# SnackMachine

The project simulates the operation of a vending machine for snacks and drinks. The purchase process consists of choosing a product, paying, choosing whether you are interested in a bag, and also - the option of gift wrapping. A finished product or a cup of hot or cold drink can be purchased in the machine according to the customer's request. The machine buttons will be enabled according to the order status in the machine (for example, after payment, you cannot change the selection).

In addition, the machine inventory is managed automatically: when the inventory of a particular product is approaching its end, the supplier will be updated about it. For example, if there are 5 units or less left of the product, the supplier needs to know about it.

At the end of each day, a report of the actions performed in the machine on that day will be saved, the report will be saved in a text file but in the future it will be possible to save in other formats. The appropriate infrastructure must be prepared for this in accordance with the open-closed principle.

Implemented in: Winform


The report of the actions performed in the machine on that day will be saved in the file "report.txt" in the project library. The file can be opened in a file management program or in a spreadsheet program.

### Infrastructure:

The project uses the following infrastructures:

.NET Framework
Windows Forms

### Open-closed principle:

The project implements the open-closed principle, which means that new functionality can be added to the project without changing the existing code. For example, if you want to add an option to save the action report in other formats, you can do so by adding new code to the ReportManager class. The existing code in this class does not need to be changed.


