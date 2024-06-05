using Adapter2;

class Program
{
    static void Main(string[] args)
    {
        // Inicjalizacja nowej biblioteki rejestrowania
        var nowaBiblioteka = new NowaBibliotekaRejestrowania();

        // Użycie adaptera
        IStaraBibliotekaRejestrowania adapter = new Adapter(nowaBiblioteka);
        adapter.Log("Log message");

        // Można nadal używać starej biblioteki rejestrowania bez zmian w kodzie
        var staraBiblioteka = new StaraBibliotekaRejestrowania();
        staraBiblioteka.Log("Log message");
    }
}