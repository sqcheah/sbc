namespace ShuttleBusCentral
{
    class ComboBoxItem
    {
        public string Name;
        public string Value;
        public ComboBoxItem(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        // override ToString() function
        public override string ToString()
        {
            return this.Name;
        }
    }
}
