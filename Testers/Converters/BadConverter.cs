namespace Testers
{
    public class BadConverter : TesterConverter
    {
        public override string GetAddStatement()
        {
            throw new System.NotImplementedException("Unknown Converter Type");
        }

        public override string GetUpdateStatement()
        {
            throw new System.NotImplementedException("Unknown Converter Type");
        }

        public override string GetDeleteStatement()
        {
            throw new System.NotImplementedException("Unknown Converter Type");
        }

        public override void Extract()
        {
            throw new System.NotImplementedException("Unknown Converter Type");
        }
    }
}
