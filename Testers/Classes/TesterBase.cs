namespace Testers
{
    /// <summary>
    /// This is the base class and the least amount of information of a Tester
    /// </summary>
    public class TesterBase
    {
        public TesterBase()
        {

        }

        public int TesterId
        {
            get { return _testerId; }
            set { _testerId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Privileges PrivilegeLevel
        {
            get { return _privilegeLevel; }
            set { _privilegeLevel = value; }
        }

        protected int _testerId;
        protected string _name;
        protected Privileges _privilegeLevel;

    }
}
