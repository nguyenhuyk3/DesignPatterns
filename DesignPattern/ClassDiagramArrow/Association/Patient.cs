namespace DesignPattern.ClassDiagramArrow.Association
{
    public class Patient
    {
        public string Name { get; set; }
        public string Disease { get; set; }

        public Patient(string name, string disease)
        {
            Name = name;
            Disease = disease;
        }
    }
}
