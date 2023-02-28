
/*
This is not code.
It's about some logic notes that I didn't have time to apply.

LOGIC NOTES: 

-Employee: HireDateStart > HireDateEnd

- Transaction: 

       1.transaction.TotalValue > 50
        2.NetValue and DiscountValue: arithmetic operations in methods
        3. totalValue = NetValue - DiscountValue -> method TotalValueCalculation
        4. if (TransactionLines.Count() > 1)
            {
    if (TransactionLines.Any(x => x.DiscountValue > 0))
    { return true; } 
            -> limit of 1 fuel / transaction
        5.if (ItemType.Fuel && netValue > 20->checkfordiscount
        6.if (check for discount = true) -10 % At transactionline
        7. new form that ask if customer has cardnumer(And insern card number if yes) else show.dialog at customers form to create new
     - ledger:added all accounting data of transactions, salaries of employees and renting cost of 5000.

*/



