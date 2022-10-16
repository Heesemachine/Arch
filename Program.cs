using _2DGame;

// Level objects
GameObject[] objs = {
    new Decoration(false, "Tree", 0, 0),
    new Decoration(false, "Tree", 1, 0),
    new Decoration(false, "Tree", 2, 0),
    new Decoration(false, "Tree", 3, 0),
    new Decoration(false, "Tree", 0, 1),
    new Decoration(false, "Tree", 0, 2),
    new Decoration(false, "Tree", 0, 3),
    new Decoration(false, "Tree", 1, 1),
    new Decoration(false, "Tree", 2, 1),
    new Decoration(false, "Tree", 1, 2),

    new Decoration(false, "Rock", 5, 4),
    new Decoration(false, "Rock", 5, 5),
    new Decoration(false, "Rock", 8, 9),
    new Decoration(false, "Rock", 3, 8),
    new Decoration(false, "Rock", 1, 8),

    new NPC(false, "Bobby", 1, 7, 1),
    new NPC(false, "Marry", 10, 4, 2),
    new NPC(false, "Anthony", 5, 4, 5),
    new NPC(false, "Leonore", 8, 8, 1)
};

// Building level
Level lvl = new Level(false, 10, 10, objs);

Console.WriteLine("Level map ({0}x{1}):", lvl.GetWidth(), lvl.GetHeight());
Console.WriteLine(lvl.ToString());

// Objects interactions test
NPC Mermaid = new NPC(true, "Mermaid", 0, 0, 1);
NPC Seaweed = new NPC(true, "Seaweed", 1, 5, 3);
NPC Wolf = new NPC(false, "Wolf", 5, 3, 1);
Decoration Tree = new Decoration(false, "Fox", 5, 3);

Console.WriteLine("Objects interactions:");

Mermaid.Interract(Wolf);
Mermaid.Interract(Tree);
Mermaid.Interract(Seaweed);
Wolf.Interract(Seaweed);
Wolf.Interract(Tree);

Console.ReadKey();