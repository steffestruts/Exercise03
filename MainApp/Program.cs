using MainApp.Dialogs;
using MainApp.Services;

var menuService = new MenuService();
var menuDialog = new MenuDialog(menuService);

menuDialog.MenuOptionsDialog();

