CREATE PROCEDURE [dbo].[get_work_item_by_id]
    @ID int
AS
    SELECT * FROM [dbo].work_items as w
    WHERE w.[ID] = @ID
