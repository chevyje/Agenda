
# Uitleg

Dit is een applicatie waarin een locaal opgeslagen database in acces word gebruikt. 
Deze applicatie is speciaal gemaakt voor massagetherapie-drunen. 
In deze applicatie worden afspraken overzichtelijk weergegeven en krijg je een snel overzicht welke klant wanneer komt. 
Ook zorgt deze applicatie er voor dat er rescrities geplaatst kunnen worden op bebaalde personen en of acties van aantal afspraken
En zit er een fuctie in waarin cadeau bonnen worden bij gehouden zodat hier geen fraude mee gepleegd kan worden.

# How to call a collum in oledb
   Retrieve columns by index or name
    string column1 = reader[0].ToString();
    string column2 = reader["ColumnName"].ToString();

# Cadeaubon nummer format
   voorbeeld: 120052425
	(12) staat voor de maand van het jaar
	(005) is een autoincrement nummer
	(24) Het jaartal
	(25) de dag

   Deze format is gekozen zodat het lastig te achterhalen is welk nummer het volgende cadeaubon krijgt zodat hier geen fraude mee gepleegd kan worden.

# Klant adres format
   straatnaam, postcode, woonplaats
    voorbeeld: Bloemenlaan 23, 1234 AB, Amsterdam

   Zodra dit wordt gesplit krijg je de volgende index
    0 - straatnaam
    1 - postcode
    2 - woonplaats

# Types to open forms
   if used like the way below the user cant leave the form without closing it.
    Form_NieuweAfspraak form = new Form_NieuweAfspraak();
    form.ShowDialog();
   
   if used like this the form wil be as normal
    Form_NieuweAfspraak form = new Form_NieuweAfspraak();
    form.Show();

# Some handy shortcuts
   Collapses all code.
    Ctrl + M, Ctrl + O
   
   Expands all code
    Ctrl + M, Ctrl + L.

# Base path of the app
   AppContext.BaseDirectory

# Author
	Jurre Blankers
