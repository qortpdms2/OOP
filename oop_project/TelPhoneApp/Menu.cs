namespace TelPhoneApp {
    public class Menu {
        public string Name { get; set;}
        public Menu(string n = "") {
            Name = n;
        }
        public override string ToString() {
            return $"Name: {Name}";
        }
    }
}
