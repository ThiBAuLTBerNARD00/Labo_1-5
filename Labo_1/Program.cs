// See https://aka.ms/new-console-template for more information
using Comparer;
using MaLibrairieForme;
Console.WriteLine("Coordonnee ");


Coordonnees c1 = new();
Coordonnees c2 = new (2, 2);
Coordonnees c3 = new (c2);

Console.WriteLine("c1 => constructeur par default:");
Console.WriteLine(c1);
Console.WriteLine("c2 => Constructeur d'initialisation (2, 2)");
Console.WriteLine(c2);
Console.WriteLine("c3 => Constructeur de copie (c2)");
Console.WriteLine(c3);


Console.WriteLine("Carre ");

Carre ca = new ();
Carre ca1= new (2, 7, 12);
Carre ca2 = new(c2, 5);
Carre ca3 = new(ca2 );


Console.WriteLine("ca => Constructeur par default");
ca.Affiche();
Console.WriteLine("ca1 => Constructeur d'initialisation (2, 7, 12)");

ca1.Affiche();
Console.WriteLine("ca2 => Constructeur d'initialisation (c2, 5) ");
ca2.Affiche();
Console.WriteLine("ca3 => Constructeur de copie (ca2)");
ca3.Affiche();

Console.WriteLine("Le rectangle mtn \n");

Rectangle r=new (c2,1,2);
Rectangle r1=new ();
Rectangle r2=new Rectangle(3,4,7,8);
Rectangle r3=new Rectangle(r);
Console.WriteLine("rectangle1 - Constructeur par défaut :");
r1.Affiche();
Console.WriteLine("rectangle2 - Constructeur d'initialisation (3,4,7,8) :");
r2.Affiche();
Console.WriteLine("rectangle3 - Constructeur d'initialisation (c2, 1, 2) :");
r.Affiche();
Console.WriteLine("rectangle4 - Constructeur de copie (rectangle3) :");
r3.Affiche();


Console.WriteLine(" Le cercle mtn \n");
Cercle ce =new ();
Cercle ce1=new (2, 7, 12);
Cercle ce2= new (c2,8);
Cercle ce3 = new(ce2);

Console.WriteLine("cercle 1");
ce.Affiche();
Console.WriteLine("cercle 2");
ce1.Affiche();
Console.WriteLine("cercle 3");
ce2.Affiche();
Console.WriteLine("cercle 4");
ce3.Affiche();



List<Forme> formes =new() ;

formes.Add(ca);
formes.Add(ca1);
formes.Add(ca2);

//cercle
formes.Add(ce);
formes.Add(ce1);
formes.Add(ce2);

//rectangle
formes.Add(r);
formes.Add(r1);
formes.Add(r2);

Console.WriteLine(" affichage des objets");

foreach (Forme forme in formes)
{
    forme.Affiche();
}

Console.WriteLine("---------------------");
Console.WriteLine("Affichage des objets avec ISommets ");
foreach (Forme forme in formes)
{
    if(forme is ISommets)
    {
        forme.Affiche();
    }
}
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Affichage des objets n'implémentant pas l’interface ISommets :");

foreach (Forme f in formes)
{
    if (f is not ISommets)
    {
        f.Affiche();
    }
}

Console.WriteLine("##############################################################");

List<Carre> carres = new();

carres.Add(new Carre { cor = new Coordonnees { x = 3, y = 9 }, L = 4 });
carres.Add(new Carre { cor = new Coordonnees { x = 6, y = 2 }, L = 2 });
carres.Add(new Carre { cor = new Coordonnees {x = 1, y = 8 }, L = 7 });
carres.Add(new Carre { cor = new Coordonnees {x = 5, y = 5 }, L = 3 });
carres.Add(new Carre { cor = new Coordonnees {x = 2, y = 3 }, L = 5 });

Console.WriteLine("Liste générique de 5 carrés :");

foreach (Carre c in carres)
{
    c.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Liste triée par taille croissante :");

carres.Sort();

foreach (Carre c in carres)
{
    c.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Liste triée par abscisse croissante :");

FormeAbscisseComparer fcomp = new();
carres.Sort(fcomp);

foreach (Carre c in carres)
{
    c.Affiche();
}
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Carré de référence :");

Carre reference = new(5, 3, 4);
reference.Affiche();

Console.WriteLine("Carrés qui ont la même taille que le carré de référence :");

foreach (Carre c in carres.FindAll(x => x.L == reference.L))
{
    c.Affiche();
}
Console.WriteLine("##############################################################");
Console.WriteLine("Formes :");

List<Forme> formesp = new();

formesp.Add(new Carre { cor = new Coordonnees {x = 5, y = 2 }, L = 6 });
formesp.Add(new Cercle { cor = new Coordonnees {x = 7, y = 9 }, R = 4 });
formesp.Add(new Rectangle { cor = new Coordonnees {x = 3, y = 5 }, L = 5, l = 3 });

foreach (Forme f in formesp)
{
    f.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Coordonnees coordp = new(9, 7);
Console.WriteLine("Formes qui contiennent le point " + coordp + " :");

foreach (Forme f in formesp.FindAll(x => x.CoordonneeEstDans(coordp)))
{
    f.Affiche();
}
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Liste triée par surface croissante :");

FormeSurfaceComparer scomp = new();
formesp.Sort(scomp);

foreach (Forme f in formesp)
{
    f.Affiche();
    Console.WriteLine("Surf : " + MathUtil.MathUtil.CalculerSurface(f));
}
