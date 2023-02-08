using FirstProject;

var menu = new Menu();

DateTime date = DateTime.UtcNow;

string name = Helpers.GetName();

menu.ShowMenu(name, date);