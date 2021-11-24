# EricsBookStore
Book Store

11/1/2021 

11:18 am:
Created github repo for EricsBookStore and changed indentity.

11:24 am: 
Commented out https for school.

11:39 am:
Added new bootstrap file and saved the backup bootstrap file, 
changed nav classes and footer class names to add styles and replaced site.css with new site.css.

11:46 am:
changed a few styles for footer and the login/register buttons.

12:22 pm:
Added a dropdown to my homepage named Content Management.

12:49 pm:
Added core class files and added the package files for nuget.

8:59 pm: 
corrected all the errors and deleted class1.cs files, edited the using statement in startup.cs and corrected the errors in homecontroller with new errorviewmodel.

11/2/2021

3:49 pm: added areas for Customer and added SD class and project references and when I ran my program it errored: InvalidOperationException: The constraint reference 'Customer' could not be resolved to a type. Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'.

4:09 pm: Error fixed.... typo! ughh!!!

4:14pm: added Admin areas and added the proper view files to it.

11/10/2021 

9:21 am: changed database name in appsettings.json and added migration, 20211110142010_AddDefaultIdentityMigration.cs

10:12 am: Added Category.cs and added removed then re added AddCategoryToDb migrations then updated the database once the duplication error was resolved.

10:39 am: Added the IRepository and Repository.cs files 

11/11/2021

9:16 pm: Added ICategoryRepository.cs and CategoryRepository.cs.

10:28 pm : Added UnitOfWork, IUnitOfWork, ISP_Call, SP_Call and edited startup.cs and fixed some errors and dapper.

1:50 am: Added Category in admin areas also added it into the dropdown menu.

2:37 am: added category.js

11/17/2021

9:30 am Cloned my assignment into school computer.

10:49 AM: Added Upsert.cshtml and createandbacktolistbutton and same thing for edit button for create new category in Admin. Also Fixed this error from a typo : Severity Code Description Project File Line Suppression State
Warning CS0472 The result of the expression is always 'true' since a value of type 'int' is never equal to 'null' of type 'int?' EricsBookStore C:\Users\W0774957\source\repos\EricsBookStore\EricsBookStore\Areas\Admin\Views\Category\Upsert.cshtml 

10:50 Am: Saved and closed down for end of class..

11/22/2021

3:46 pm: added script and title for upsert.

4:38 pm: Added Delete and fixed errors with Upsert.

11/23/2021

10:35 pm: Added covertype to unitofwork and repository.

10:40 pm : fixed typo.

11:29 pm : Added covertype to the database -- 20211124042752_addCoverTypeToDb.cs and fixed error..

12:28 am: Added CoverType controller, covertype Index and Upsert views and added product.cs Class.

12:59 am: Updated product.cs class and created new migration for 20211124055834_addValidationToProduct.cs

1:36 am: Added product into unitofwork and iunitofwork and IproductRepo and productrepo

2:21 am: Added ProductVM class, added coverType.js file to fix coverType.. added ProductController.cs

2:52 am: Edited ProductController with updated productVM and added product.js and added product into layout for dropdown.
