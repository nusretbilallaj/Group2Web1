namespace Group2Web1.Models
{
    public class Studenti
    {
        public Studenti(string emri,string mbiemri,int mosha)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            Mosha = mosha;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public int Mosha { get; set; }

        public string SayHello()
        {
            return $"Tungjatjeta {Emri} {Mbiemri}";
        }

    }
}
