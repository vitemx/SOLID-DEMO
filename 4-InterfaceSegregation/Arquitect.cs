namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
        {
            
        }
        void IWorkTeamActivities.Comunicate()
        {
            throw new NotImplementedException();
        }

        void IDesignActivities.Design()
        {
            throw new NotImplementedException();
        }

        void IDevelopActivities.Develop()
        {
            throw new NotImplementedException();
        }

        void IWorkTeamActivities.Plan()
        {
            throw new NotImplementedException();
        }

        void ITestActivities.Test()
        {
            throw new NotImplementedException();
        }
    }
}