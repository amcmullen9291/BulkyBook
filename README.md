# BulkyBook

CRUD functionality with Entity Framework annotations.
DB connected to SQL Server using Microsoft SQL Server Management Studio with Azure Data Studio

Created with Visual Code 2022. Edited in Visual code and VScode.

Steps creating a table:
Create model / entity, add model to ApplicationDbContent file, add-migration command in GUI, update-database command

steps to retreived table data:
create and instance of the ApplicationDbContext, create a constructor to have access to a local instance of the Class variable?, create a second var in the Action your working with
 (He likes Enumberables but a var would be fine if you use the .ToList() method)
ie: IEnumerable<ClassName> nameyouchoose = _db.Categories.ToList();
then, from the controller return that variable to the view!

... in the view, iterate over the given variable like normal. don't forget to import the Enumerable so you can do a foreach loop with it. and remeber to use the '@' symbol

    @*Note: put you comments in between these TWO characters *@
