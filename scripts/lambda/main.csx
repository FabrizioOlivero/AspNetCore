
Func<DateTime, bool> canDrive = dob => {
    return dob.AddYears(18) <= DateTime.Today;
};

DateTime dob = new DateTime(2002, 12, 25);

bool result = canDrive(dob);
Console.WriteLine(result);

Action<DateTime> printDate = date => Console.WriteLine(date);
DateTime date = DateTime.Today;
printDate(date);

Func<string, string, string> concactFirstAndLastName = (nome, cognome) => 
nome + cognome;

string nomeCompleto = concactFirstAndLastName("Fabrizio", "Olivero");
Console.WriteLine(nomeCompleto);

Func<int, int, int, int> getMaximum = (num1, num2, num3) =>
{
    int result;

    result = (num1>num2 ? num1:num2);
    result = (num3>result ? num3:result);

    return result;
};
int numeroMax = getMaximum(7,11,3);
Console.WriteLine(numeroMax);

Action<DateTime, DateTime> printLowerDate = (dt1, dt2) =>
{
    DateTime dtResult;

    dtResult = (dt1<dt2? dt1:dt2);
    Console.WriteLine(dtResult);
};

DateTime dt1 = new DateTime(2000, 12, 10);
DateTime dt2 = new DateTime(1950, 12, 10);

printLowerDate(dt1, dt2);