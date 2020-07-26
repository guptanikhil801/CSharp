create procedure spCustomerDetails
(
@Email varchar(50)
)
as
begin try
select FirstName, LastName, PhoneNumber, Address, City, PinCode from Customers
where Email=@Email
End try
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber,
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH