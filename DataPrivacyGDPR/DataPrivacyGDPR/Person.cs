namespace DataPrivacyGDPR
{

    // Skapar en class som innehåller data om en person, den döper vi till Person. Done
    public class Person
    {
        // Använder enum som vi har skappat upp för att lagra data om personens kön "Gender"
        public Gender Gender { get; set; }

        // Använder struct som vi har skappat upp för att hålla data om personens hårdetaljer      
        public Hair Hair { get; set; }

        // Skapar en property av lämplig datatyp "DateTime" för att lagra data om personens födelsedag (år, månad, dag).
        public DateTime BirthDate { get; set; }

        // Skapar en property "string" för att lagra data om personens ögonfärg.
        public string EyesColor { get; set; }

        // Använder konstruktor som initierar en ny person med värden för kön, hår, födelsedatum och ögonfärg.
        public Person(Gender gender, Hair hair, DateTime birthDate, string eyesColor)
        {
            Gender = gender;
            Hair = hair;
            BirthDate = birthDate;
            EyesColor = eyesColor;
        }

        // Override av ToString()-metoden för att returnera en beskrivning av personen.
        // Metoden returnerar en sträng som innehåller kön, hårbeskrivning, födelsedatum och ögonfärg.
        public override string ToString()

        {
            return $"Kön: {Gender}, Hår: {Hair.HairLength}, {Hair.HairColor}, Födelsedatum: {BirthDate.ToShortDateString()}, Ögonfärg: {EyesColor}";
        }
    }
}
