namespace Testers
{
    public abstract class TesterConverter
    {
        public abstract string GetAddStatement();
        public abstract string GetUpdateStatement();
        public abstract string GetDeleteStatement();
        public abstract void Extract(/*TODO object<T> data*/);
    }
}
