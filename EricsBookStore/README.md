Book Store Total Time Spent - 17 hours and 8 mins

11/1/2021 - 2 hours

11:18 am: Created github repo for EricsBookStore and changed indentity.

11:24 am: Commented out https for school.

11:39 am: Added new bootstrap file and saved the backup bootstrap file, changed nav classes and footer class names to add styles and replaced site.css with new site.css.

11:46 am: changed a few styles for footer and the login/register buttons.

12:22 pm: Added a dropdown to my homepage named Content Management.

12:49 pm: Added core class files and added the package files for nuget.

8:59 pm: corrected all the errors and deleted class1.cs files, edited the using statement in startup.cs and corrected the errors in homecontroller with new errorviewmodel.

11/2/2021 - 25 mins

3:49 pm: added areas for Customer and added SD class and project references and when I ran my program it errored: InvalidOperationException: The constraint reference 'Customer' could not be resolved to a type. Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'.

4:09 pm: Error fixed.... typo! ughh!!!

4:14pm: added Admin areas and added the proper view files to it.

11/10/2021 - 1 hour and 18 mins

9:21 am: changed database name in appsettings.json and added migration, 20211110142010_AddDefaultIdentityMigration.cs

10:12 am: Added Category.cs and added removed then re added AddCategoryToDb migrations then updated the database once the duplication error was resolved.

10:39 am: Added the IRepository and Repository.cs files

11/11/2021 - 3 hours

9:16 pm: Added ICategoryRepository.cs and CategoryRepository.cs.

10:28 pm : Added UnitOfWork, IUnitOfWork, ISP_Call, SP_Call and edited startup.cs and fixed some errors and dapper.

1:50 am: Added Category in admin areas also added it into the dropdown menu.

2:37 am: added category.js

11/17/2021 - 1 hour and 20 mins

9:30 am Cloned my assignment into school computer.

10:49 AM: Added Upsert.cshtml and createandbacktolistbutton and same thing for edit button for create new category in Admin. Also Fixed this error from a typo : Severity Code Description Project File Line Suppression State Warning CS0472 The result of the expression is always 'true' since a value of type 'int' is never equal to 'null' of type 'int?' EricsBookStore C:\Users\W0774957\source\repos\EricsBookStore\EricsBookStore\Areas\Admin\Views\Category\Upsert.cshtml

10:50 Am: Saved and closed down for end of class..

11/22/2021 - 1 hour

3:46 pm: added script and title for upsert.

4:38 pm: Added Delete and fixed errors with Upsert.

11/23/2021 - 5 hours

10:35 pm: Added covertype to unitofwork and repository.

10:40 pm : fixed typo.

11:29 pm : Added covertype to the database -- 20211124042752_addCoverTypeToDb.cs and fixed error..

12:28 am: Added CoverType controller, covertype Index and Upsert views and added product.cs Class.

12:59 am: Updated product.cs class and created new migration for 20211124055834_addValidationToProduct.cs

1:36 am: Added product into unitofwork and iunitofwork and IproductRepo and productrepo

2:21 am: Added ProductVM class, added coverType.js file to fix coverType.. added ProductController.cs

2:52 am: Edited ProductController with updated productVM and added product.js and added product into layout for dropdown.

3:00 am: fixed title for category and upsert when editing column.

3:42 am: tried changing font color for database...... No luck more on this later.. shut down for the night.

11/24/2021

10:46 am: Added table-dark to my tables for database finally readable!!

12/1/2021 1 Hour 40 mins

9:00 am: started lab..

9:33 am: added product upsert view... but error..: Severity Code Description Project File Line Suppression State Error CS1503 Argument 2: cannot convert from 'System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem>' to 'System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>' EricsBookStore C:\Users\W0774957\source\repos\EricsBookStore\EricsBookStore\Areas\Admin\Views\Product\Upsert.cshtml 70 Active

9:53 am: FIXED!!! Huge error fix in ProductVM.cs and ProductController.cs and added Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -Version 5.0.8 to EricsBooks.Models.csproj to fix error thanks to... https://stackoverflow.com/questions/58817271/cannot-implicitly-convert-type-listsystem-web-mvc-selectlistitem-to-ienumera?answertab=active#comment103912529_58817271

10:02 am: uncommented out ProductController.cs and added new folder called images products cannot use "/".

10:03 am: added in updated readme in the project.

10:08 am: added img folder and class.cs just to upload img to github.

10:10 am: deleted class.cs and it deleted my img folder!!!!

10:13 am: added an img as a placeholder! grr! fixed.

10:29 am: end of class

10:41 am: updated Readme..

12/6/2021 1 hour 13 mins

11:00 am: Started class.

11:40 am: Fixed error where Category showed for both category and covertype lists.

11:51 am: updated productcontroller.

11:55 am: Getting error: SqlException: The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Products_CoverType_CategoryId". The conflict occurred in database "EricsBookStore", table "dbo.CoverType", column 'Id'. The statement has been terminated. Cannot resolve.

12:13 pm: tried fixing the sqlexception error.. Getting closer still no luck though.

12/8/2021 12 mins

5:32 pm: Fixed up HomeController.cs

5:44 pm: Fixed Ajax Error... Still having same error as before with product table and foreign key...

12/9/2021

7:41 pm: fixed color being too light to see category and covertype in product.