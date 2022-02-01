namespace SimplePasswordManager
{
    class Unit
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string URI { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }

        public static string Key;

        private static Unit _instance;
        public static Unit GetInstanse()
        {
            if (_instance == null)
            {
                _instance = new Unit();
            }
            return _instance;
        }
    }
}