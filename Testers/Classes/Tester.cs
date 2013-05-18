namespace Testers
{
    /// <summary>
    /// A marker class
    /// </summary>
    public class Tester
    {
        public TesterConverter GetClassConverter(string converterName)
        {
            return converters.ContainsKey(converterName) ? converters[converterName] as TesterConverter : new BadConverter();
        }
        protected void AddClassConverter(string converterName, TesterConverter converter)
        {
            converters.Add(converterName, converter);
        }
        protected System.Collections.Hashtable converters = new System.Collections.Hashtable();
    }
}
