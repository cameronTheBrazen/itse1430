-- Removes a product from the database.
-- PARAMETERS
--    @id | INT | ID of the product
-- RETURNS
--    None
CREATE PROCEDURE [dbo].[RemoveProduct]
    @id INT
AS BEGIN
    SET NOCOUNT ON;

    DELETE FROM Products
    WHERE Id = @id
END
