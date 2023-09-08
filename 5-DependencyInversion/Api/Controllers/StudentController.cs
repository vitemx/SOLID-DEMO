using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    IStudentRepository _studentRepository;
    ILogbook _logbook;

    public StudentController(IStudentRepository studentRepository, ILogbook logbook)
    {
        _logbook = logbook;
        _studentRepository = studentRepository;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        _logbook.Add($"returning student's list");
        return _studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        _studentRepository.Add(student);
        _logbook.Add($"The Student {student.Fullname} have been added");
    }
}
