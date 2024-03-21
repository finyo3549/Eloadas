using NUnit.Framework;

[TestFixture]
public class EloadasTesztek
{
    [Test]
    public void ElsoSzabadHelyFoglalas()
    {
        // Arrange
        Eloadas eloadas = new Eloadas(3, 3);

        // Act
        bool sikeresFoglalas = eloadas.Lefoglal();

        // Assert
        Assert.IsTrue(sikeresFoglalas);
    }

    [Test]
    public void Telthaz()
    {
        Eloadas eloadas = new Eloadas(1, 1);
        eloadas.Lefoglal();

        bool sikeresFoglalas = eloadas.Lefoglal();

        
        Assert.IsFalse(sikeresFoglalas);
    }

    [Test]
    public void SzabadHelyek_UresEloadas_EloadasMerete()
    {
        Eloadas eloadas = new Eloadas(2, 2);

        int szabadHelyek = eloadas.SzabadHelyek;

        Assert.AreEqual(4, szabadHelyek);
    }

    [Test]
    public void Teli_UresEloadas_NemTeli()
    {
        Eloadas eloadas = new Eloadas(2, 2);

        bool teli = eloadas.Teli;

        Assert.IsFalse(teli);
    }

    [Test]
    public void Foglalte()
    {
        Eloadas eloadas = new Eloadas(2, 2);

        bool foglalt = eloadas.Foglalt(1, 1);

        Assert.IsFalse(foglalt);
    }

    [Test]
    public void FoglaltHely()
    {
        Eloadas eloadas = new Eloadas(2, 2);
        eloadas.Lefoglal();
        bool foglalt = eloadas.Foglalt(1, 1);
        Assert.IsTrue(foglalt);
    }

    [Test]
    public void Foglalt_InvalidParameterek()
    {
        // Arrange
        Eloadas eloadas = new Eloadas(2, 2);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => eloadas.Foglalt(0, 1));
        Assert.Throws<ArgumentException>(() => eloadas.Foglalt(1, 0));
        Assert.Throws<ArgumentException>(() => eloadas.Foglalt(3, 1));
        Assert.Throws<ArgumentException>(() => eloadas.Foglalt(1, 3));
    }
}
