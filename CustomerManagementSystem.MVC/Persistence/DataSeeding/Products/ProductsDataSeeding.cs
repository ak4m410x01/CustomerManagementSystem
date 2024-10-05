using CustomerManagementSystem.MVC.Application.Interfaces.UnitOfWorks;
using CustomerManagementSystem.MVC.Domain.Entities;

namespace CustomerManagementSystem.MVC.Persistence.DataSeeding.Products
{
    public static class ProductsDataSeeding
    {
        public static async Task InitializeProductsAsync(this IUnitOfWork unitOfWork)
        {
            var products = new List<Product>()
{
    new Product()
    {
        Name = "Sultanas",
        Price = 6.42m
    },
    new Product()
    {
        Name = "Spinach - Packaged",
        Price = 7.35m
    },
    new Product()
    {
        Name = "Rice Wine - Aji Mirin",
        Price = 1.41m
    },
    new Product()
    {
        Name = "Bread - English Muffin",
        Price = 4.79m
    },
    new Product()
    {
        Name = "Sobe - Green Tea",
        Price = 7.58m
    },
    new Product()
    {
        Name = "Seedlings - Mix, Organic",
        Price = 6.10m
    },
    new Product()
    {
        Name = "Soup - French Onion, Dry",
        Price = 7.93m
    },
    new Product()
    {
        Name = "Arctic Char - Fillets",
        Price = 3.14m
    },
    new Product()
    {
        Name = "Versatainer Nc - 888",
        Price = 6.74m
    },
    new Product()
    {
        Name = "Olives - Morracan Dired",
        Price = 0.13m
    },
    new Product()
    {
        Name = "Seabream Whole Farmed",
        Price = 6.09m
    },
    new Product()
    {
        Name = "Nut - Peanut, Roasted",
        Price = 2.86m
    },
    new Product()
    {
        Name = "Soup - Knorr, Classic Can. Chili",
        Price = 3.80m
    },
    new Product()
    {
        Name = "Icecream Bar - Del Monte",
        Price = 3.96m
    },
    new Product()
    {
        Name = "Gingerale - Schweppes, 355 Ml",
        Price = 6.67m
    },
    new Product()
    {
        Name = "Soup - Campbells, Creamy",
        Price = 4.72m
    },
    new Product()
    {
        Name = "Cumin - Ground",
        Price = 1.94m
    },
    new Product()
    {
        Name = "Cherries - Bing, Canned",
        Price = 0.20m
    },
    new Product()
    {
        Name = "Oyster - In Shell",
        Price = 9.71m
    },
    new Product()
    {
        Name = "Strawberries",
        Price = 0.40m
    },
    new Product()
    {
        Name = "Cookies - Assorted",
        Price = 0.87m
    },
    new Product()
    {
        Name = "Blouse / Shirt / Sweater",
        Price = 5.53m
    },
    new Product()
    {
        Name = "Peach - Halves",
        Price = 1.52m
    },
    new Product()
    {
        Name = "Relish",
        Price = 8.51m
    },
    new Product()
    {
        Name = "Juice - Apple Cider",
        Price = 3.95m
    },
    new Product()
    {
        Name = "The Pop Shoppe - Grape",
        Price = 8.28m
    },
    new Product()
    {
        Name = "Gelatine Powder",
        Price = 4.27m
    },
    new Product()
    {
        Name = "Cheese - Mozzarella",
        Price = 2.33m
    },
    new Product()
    {
        Name = "Wine - Magnotta, Merlot Sr Vqa",
        Price = 1.29m
    },
    new Product()
    {
        Name = "Wine - Rosso Del Veronese Igt",
        Price = 0.91m
    },
    new Product()
    {
        Name = "Corn Kernels - Frozen",
        Price = 8.40m
    },
    new Product()
    {
        Name = "Lamb - Rack",
        Price = 7.56m
    },
    new Product()
    {
        Name = "Quinoa",
        Price = 9.23m
    },
    new Product()
    {
        Name = "Pork - Loin, Center Cut",
        Price = 3.05m
    },
    new Product()
    {
        Name = "Amaretto",
        Price = 3.54m
    },
    new Product()
    {
        Name = "Wine - Duboeuf Beaujolais",
        Price = 8.99m
    },
    new Product()
    {
        Name = "Port - 74 Brights",
        Price = 7.22m
    },
    new Product()
    {
        Name = "Sugar - Invert",
        Price = 2.28m
    },
    new Product()
    {
        Name = "Cheese - Blue",
        Price = 4.32m
    },
    new Product()
    {
        Name = "Sugar - Monocystal / Rock",
        Price = 9.42m
    },
    new Product()
    {
        Name = "Swiss Chard - Red",
        Price = 8.75m
    },
    new Product()
    {
        Name = "Radish - Black, Winter, Organic",
        Price = 0.47m
    },
    new Product()
    {
        Name = "Nantucket - 518ml",
        Price = 8.55m
    },
    new Product()
    {
        Name = "Chicken Giblets",
        Price = 4.70m
    },
    new Product()
    {
        Name = "Bread - Malt",
        Price = 7.24m
    },
    new Product()
    {
        Name = "Wasabi Powder",
        Price = 0.71m
    },
    new Product()
    {
        Name = "Evaporated Milk - Skim",
        Price = 0.13m
    },
    new Product()
    {
        Name = "Samosa - Veg",
        Price = 0.13m
    },
    new Product()
    {
        Name = "Spaghetti Squash",
        Price = 4.31m
    },
    new Product()
    {
        Name = "Tea - Grapefruit Green Tea",
        Price = 4.74m
    },
    new Product()
    {
        Name = "Muffin - Bran Ind Wrpd",
        Price = 6.24m
    },
    new Product()
    {
        Name = "Soupcontfoam16oz 116con",
        Price = 9.47m
    },
    new Product()
    {
        Name = "Basil - Seedlings Cookstown",
        Price = 1.80m
    },
    new Product()
    {
        Name = "Pineapple - Golden",
        Price = 0.67m
    },
    new Product()
    {
        Name = "Truffle Cups - White Paper",
        Price = 0.29m
    },
    new Product()
    {
        Name = "Parsley Italian - Fresh",
        Price = 7.00m
    },
    new Product()
    {
        Name = "Tomatoes Tear Drop Yellow",
        Price = 2.12m
    },
    new Product()
    {
        Name = "Chocolate - Sugar Free Semi Choc",
        Price = 7.96m
    },
    new Product()
    {
        Name = "Wine - Ruffino Chianti Classico",
        Price = 7.87m
    },
    new Product()
    {
        Name = "Muffin Mix - Corn Harvest",
        Price = 1.91m
    },
    new Product()
    {
        Name = "Savory",
        Price = 4.49m
    },
    new Product()
    {
        Name = "Wine - Barbera Alba Doc 2001",
        Price = 4.45m
    },
    new Product()
    {
        Name = "V8 - Berry Blend",
        Price = 3.44m
    },
    new Product()
    {
        Name = "Chicken - Ground",
        Price = 8.90m
    },
    new Product()
    {
        Name = "Lotus Root",
        Price = 1.65m
    },
    new Product()
    {
        Name = "Coffee Beans - Chocolate",
        Price = 0.39m
    },
    new Product()
    {
        Name = "Veal - Tenderloin, Untrimmed",
        Price = 4.91m
    },
    new Product()
    {
        Name = "Wine - Gewurztraminer Pierre",
        Price = 6.90m
    },
    new Product()
    {
        Name = "Sauce - Soy Low Sodium - 3.87l",
        Price = 5.69m
    },
    new Product()
    {
        Name = "Eggplant Italian",
        Price = 0.67m
    },
    new Product()
    {
        Name = "Onions - Red Pearl",
        Price = 1.58m
    },
    new Product()
    {
        Name = "Cookies - Englishbay Wht",
        Price = 0.17m
    },
    new Product()
    {
        Name = "Bread - Rye",
        Price = 9.34m
    },
    new Product()
    {
        Name = "Veal - Sweetbread",
        Price = 1.25m
    },
    new Product()
    {
        Name = "Star Fruit",
        Price = 1.60m
    },
    new Product()
    {
        Name = "Tart - Butter Plain Squares",
        Price = 2.32m
    },
    new Product()
    {
        Name = "Pork Casing",
        Price = 1.39m
    },
    new Product()
    {
        Name = "Apples - Spartan",
        Price = 5.48m
    },
    new Product()
    {
        Name = "The Pop Shoppe Pinapple",
        Price = 0.68m
    },
    new Product()
    {
        Name = "Sauce Bbq Smokey",
        Price = 1.20m
    },
    new Product()
    {
        Name = "Bread - Focaccia Quarter",
        Price = 8.53m
    },
    new Product()
    {
        Name = "Muffin - Banana Nut Individual",
        Price = 9.21m
    },
    new Product()
    {
        Name = "Wine - Cabernet Sauvignon",
        Price = 8.48m
    },
    new Product()
    {
        Name = "Sugar - Brown",
        Price = 4.42m
    },
    new Product()
    {
        Name = "Nori Sea Weed - Gold Label",
        Price = 2.18m
    },
    new Product()
    {
        Name = "Wine - Rosso Toscano Igt",
        Price = 2.82m
    },
    new Product()
    {
        Name = "Shrimp - 16/20, Iqf, Shell On",
        Price = 9.83m
    },
    new Product()
    {
        Name = "Fenngreek Seed",
        Price = 1.19m
    },
    new Product()
    {
        Name = "Mahi Mahi",
        Price = 5.52m
    },
    new Product()
    {
        Name = "Nantucket Cranberry Juice",
        Price = 9.00m
    },
    new Product()
    {
        Name = "Lambcasing",
        Price = 0.01m
    },
    new Product()
    {
        Name = "Juice - Grapefruit, 341 Ml",
        Price = 1.57m
    },
    new Product()
    {
        Name = "Creme De Banane - Marie",
        Price = 4.14m
    },
    new Product()
    {
        Name = "Pastry - Plain Baked Croissant",
        Price = 1.28m
    },
    new Product()
    {
        Name = "Danishes - Mini Cheese",
        Price = 2.65m
    },
    new Product()
    {
        Name = "Pomegranates",
        Price = 2.69m
    },
    new Product()
    {
        Name = "Cheese - Cheddar, Medium",
        Price = 5.06m
    },
    new Product()
    {
        Name = "Fond - Neutral",
        Price = 9.57m
    },
    new Product()
    {
        Name = "Sprite, Diet - 355ml",
        Price = 7.92m
    },
    new Product()
    {
        Name = "Pheasants - Whole",
        Price = 6.27m
    },
    new Product()
    {
        Name = "Juice - Cranberry, 341 Ml",
        Price = 3.66m
    },
    new Product()
    {
        Name = "Butter Sweet",
        Price = 2.54m
    },
    new Product()
    {
        Name = "Bread - Roll, Canadian Dinner",
        Price = 4.31m
    },
    new Product()
    {
        Name = "Ham - Cooked Italian",
        Price = 8.62m
    },
    new Product()
    {
        Name = "Tart - Lemon",
        Price = 1.45m
    },
    new Product()
    {
        Name = "Turkey Tenderloin Frozen",
        Price = 7.63m
    },
    new Product()
    {
        Name = "Cocoa Feuilletine",
        Price = 8.63m
    },
    new Product()
    {
        Name = "Appetizer - Mushroom Tart",
        Price = 1.31m
    },
    new Product()
    {
        Name = "Stock - Beef, White",
        Price = 4.73m
    },
    new Product()
    {
        Name = "Salsify, Organic",
        Price = 1.60m
    },
    new Product()
    {
        Name = "Brandy Apricot",
        Price = 9.39m
    },
    new Product()
    {
        Name = "Tamarind Paste",
        Price = 6.69m
    },
    new Product()
    {
        Name = "Fish - Soup Base, Bouillon",
        Price = 1.84m
    },
    new Product()
    {
        Name = "Snapple - Iced Tea Peach",
        Price = 6.50m
    },
    new Product()
    {
        Name = "Beef - Striploin",
        Price = 6.18m
    },
    new Product()
    {
        Name = "Mushroom - Enoki, Dry",
        Price = 1.10m
    },
    new Product()
    {
        Name = "Sparkling Wine - Rose, Freixenet",
        Price = 1.64m
    },
    new Product()
    {
        Name = "Cheese - Roquefort Pappillon",
        Price = 6.17m
    },
    new Product()
    {
        Name = "Chocolate - Pistoles, Lactee, Milk",
        Price = 6.09m
    },
    new Product()
    {
        Name = "Pineapple - Regular",
        Price = 2.29m
    },
    new Product()
    {
        Name = "Chevere Logs",
        Price = 7.21m
    },
    new Product()
    {
        Name = "Glass Clear 8 Oz",
        Price = 1.47m
    },
    new Product()
    {
        Name = "Jello - Assorted",
        Price = 6.39m
    },
    new Product()
    {
        Name = "Persimmons",
        Price = 5.09m
    },
    new Product()
    {
        Name = "Pepper - Cayenne",
        Price = 3.17m
    },
    new Product()
    {
        Name = "Cheese - Cheddarsliced",
        Price = 7.11m
    },
    new Product()
    {
        Name = "Pate - Cognac",
        Price = 2.02m
    },
    new Product()
    {
        Name = "Energy - Boo - Koo",
        Price = 9.94m
    },
    new Product()
    {
        Name = "Carrots - Purple, Organic",
        Price = 0.87m
    },
    new Product()
    {
        Name = "Versatainer Nc - 888",
        Price = 8.14m
    },
    new Product()
    {
        Name = "Doilies - 12, Paper",
        Price = 9.21m
    },
    new Product()
    {
        Name = "Mahi Mahi",
        Price = 7.78m
    },
    new Product()
    {
        Name = "Appetizer - Mini Egg Roll, Shrimp",
        Price = 7.75m
    },
    new Product()
    {
        Name = "Ostrich - Prime Cut",
        Price = 4.43m
    },
    new Product()
    {
        Name = "Tilapia - Fillets",
        Price = 9.57m
    },
    new Product()
    {
        Name = "Thyme - Lemon, Fresh",
        Price = 6.90m
    },
    new Product()
    {
        Name = "Mushroom - Enoki, Fresh",
        Price = 0.58m
    },
    new Product()
    {
        Name = "Beer - Blue Light",
        Price = 1.63m
    },
    new Product()
    {
        Name = "Lamb - Sausage Casings",
        Price = 2.87m
    },
    new Product()
    {
        Name = "Soup - Campbells Broccoli",
        Price = 3.01m
    },
    new Product()
    {
        Name = "Sauce - Cranberry",
        Price = 6.75m
    },
    new Product()
    {
        Name = "Eggwhite Frozen",
        Price = 3.96m
    },
    new Product()
    {
        Name = "Sugar - Fine",
        Price = 8.41m
    },
    new Product()
    {
        Name = "Steampan - Foil",
        Price = 3.33m
    },
    new Product()
    {
        Name = "Nestea - Ice Tea, Diet",
        Price = 5.70m
    },
    new Product()
    {
        Name = "Container - Clear 16 Oz",
        Price = 0.77m
    },
    new Product()
    {
        Name = "Pepper - Paprika, Hungarian",
        Price = 4.03m
    },
    new Product()
    {
        Name = "Tray - 12in Rnd Blk",
        Price = 3.49m
    },
    new Product()
    {
        Name = "Eggplant Italian",
        Price = 4.24m
    },
    new Product()
    {
        Name = "Chinese Foods - Chicken",
        Price = 9.56m
    },
    new Product()
    {
        Name = "White Fish - Filets",
        Price = 1.88m
    },
    new Product()
    {
        Name = "Bread - English Muffin",
        Price = 4.80m
    },
    new Product()
    {
        Name = "Soup - French Onion",
        Price = 0.58m
    },
    new Product()
    {
        Name = "Lettuce - Green Leaf",
        Price = 6.38m
    },
    new Product()
    {
        Name = "Cheese - St. Paulin",
        Price = 0.12m
    },
    new Product()
    {
        Name = "Pepper - Chili Powder",
        Price = 9.44m
    },
    new Product()
    {
        Name = "Beer - Fruli",
        Price = 6.28m
    },
    new Product()
    {
        Name = "Lemon Tarts",
        Price = 5.27m
    },
    new Product()
    {
        Name = "Sage Ground Wiberg",
        Price = 5.60m
    },
    new Product()
    {
        Name = "Soup Campbells Mexicali Tortilla",
        Price = 8.21m
    },
    new Product()
    {
        Name = "Vanilla Beans",
        Price = 3.72m
    },
    new Product()
    {
        Name = "Pork - Smoked Kassler",
        Price = 2.46m
    },
    new Product()
    {
        Name = "Tomatoes - Heirloom",
        Price = 9.79m
    },
    new Product()
    {
        Name = "Wine - Cahors Ac 2000, Clos",
        Price = 2.88m
    },
    new Product()
    {
        Name = "Chicken - Soup Base",
        Price = 3.07m
    },
    new Product()
    {
        Name = "Lettuce - Boston Bib - Organic",
        Price = 9.32m
    },
    new Product()
    {
        Name = "Canadian Emmenthal",
        Price = 5.12m
    },
    new Product()
    {
        Name = "Vol Au Vents",
        Price = 7.38m
    },
    new Product()
    {
        Name = "Noodles - Cellophane, Thin",
        Price = 7.90m
    },
    new Product()
    {
        Name = "Ocean Spray - Kiwi Strawberry",
        Price = 7.21m
    },
    new Product()
    {
        Name = "Towel - Roll White",
        Price = 6.98m
    },
    new Product()
    {
        Name = "Beans - Kidney, Canned",
        Price = 4.92m
    },
    new Product()
    {
        Name = "Cake - Sheet Strawberry",
        Price = 8.84m
    },
    new Product()
    {
        Name = "Garbage Bags - Black",
        Price = 7.76m
    },
    new Product()
    {
        Name = "Pepper Squash",
        Price = 4.88m
    },
    new Product()
    {
        Name = "Propel Sport Drink",
        Price = 1.63m
    },
    new Product()
    {
        Name = "Fireball Whisky",
        Price = 4.45m
    },
    new Product()
    {
        Name = "Rice - 7 Grain Blend",
        Price = 1.35m
    },
    new Product()
    {
        Name = "Bread - Frozen Basket Variety",
        Price = 6.76m
    },
    new Product()
    {
        Name = "Chevril",
        Price = 6.49m
    },
    new Product()
    {
        Name = "Broom And Brush Rack Black",
        Price = 9.34m
    },
    new Product()
    {
        Name = "Monkfish Fresh - Skin Off",
        Price = 8.29m
    },
    new Product()
    {
        Name = "Tuna - Sushi Grade",
        Price = 1.77m
    },
    new Product()
    {
        Name = "Wine - White, Colubia Cresh",
        Price = 4.09m
    },
    new Product()
    {
        Name = "Crab - Blue, Frozen",
        Price = 9.01m
    },
    new Product()
    {
        Name = "Mushroom - Lg - Cello",
        Price = 5.15m
    },
    new Product()
    {
        Name = "Lid - 3oz Med Rec",
        Price = 6.93m
    },
    new Product()
    {
        Name = "Pail For Lid 1537",
        Price = 0.36m
    },
    new Product()
    {
        Name = "Bread - Raisin",
        Price = 6.31m
    },
    new Product()
    {
        Name = "Vodka - Lemon, Absolut",
        Price = 4.22m
    },
    new Product()
    {
        Name = "Pepper - Julienne, Frozen",
        Price = 1.74m
    },
    new Product()
    {
        Name = "Wine - Merlot Vina Carmen",
        Price = 3.21m
    },
    new Product()
    {
        Name = "Grapes - Green",
        Price = 1.54m
    },
    new Product()
    {
        Name = "Turkey Leg With Drum And Thigh",
        Price = 3.55m
    },
    new Product()
    {
        Name = "Wine - Red, Gamay Noir",
        Price = 6.16m
    },
    new Product()
    {
        Name = "Sausage - Andouille",
        Price = 1.07m
    },
    new Product()
    {
        Name = "Gelatine Leaves - Bulk",
        Price = 5.24m
    },
    new Product()
    {
        Name = "Juice - Apple, 341 Ml",
        Price = 3.54m
    },
    new Product()
    {
        Name = "Thyme - Dried",
        Price = 1.65m
    },
    new Product()
    {
        Name = "Bag - Regular Kraft 20 Lb",
        Price = 8.26m
    },
    new Product()
    {
        Name = "Cheese - Augre Des Champs",
        Price = 0.49m
    },
    new Product()
    {
        Name = "Lettuce - Romaine, Heart",
        Price = 4.72m
    },
    new Product()
    {
        Name = "Cheese - Blue",
        Price = 9.78m
    },
    new Product()
    {
        Name = "Broom - Angled",
        Price = 3.02m
    },
    new Product()
    {
        Name = "Shrimp - 16/20, Iqf, Shell On",
        Price = 8.72m
    },
    new Product()
    {
        Name = "Nectarines",
        Price = 7.74m
    },
    new Product()
    {
        Name = "Graham Cracker Mix",
        Price = 9.09m
    },
    new Product()
    {
        Name = "Wine - Alicanca Vinho Verde",
        Price = 1.44m
    },
    new Product()
    {
        Name = "Tuna - Loin",
        Price = 7.33m
    },
    new Product()
    {
        Name = "Pork - Loin, Center Cut",
        Price = 4.05m
    },
    new Product()
    {
        Name = "Tabasco Sauce, 2 Oz",
        Price = 8.32m
    },
    new Product()
    {
        Name = "Crackers - Melba Toast",
        Price = 0.20m
    },
    new Product()
    {
        Name = "Quiche Assorted",
        Price = 6.41m
    },
    new Product()
    {
        Name = "Beef - Outside, Round",
        Price = 1.42m
    },
    new Product()
    {
        Name = "Wine - Chardonnay Mondavi",
        Price = 8.74m
    },
    new Product()
    {
        Name = "Flower - Dish Garden",
        Price = 3.89m
    },
    new Product()
    {
        Name = "Cake - French Pear Tart",
        Price = 5.11m
    },
    new Product()
    {
        Name = "Dill - Primerba, Paste",
        Price = 6.58m
    },
    new Product()
    {
        Name = "Kiwi Gold Zespri",
        Price = 3.14m
    },
    new Product()
    {
        Name = "Juice - Clam, 46 Oz",
        Price = 2.51m
    },
    new Product()
    {
        Name = "Brandy - Orange, Mc Guiness",
        Price = 0.43m
    },
    new Product()
    {
        Name = "Wine - Puligny Montrachet A.",
        Price = 0.37m
    },
    new Product()
    {
        Name = "Sauce - Marinara",
        Price = 0.12m
    },
    new Product()
    {
        Name = "Tomatoes - Hot House",
        Price = 10.00m
    },
    new Product()
    {
        Name = "Syrup - Monin - Passion Fruit",
        Price = 2.23m
    },
    new Product()
    {
        Name = "Muffin Mix - Blueberry",
        Price = 8.88m
    },
    new Product()
    {
        Name = "Cookie Dough - Double",
        Price = 3.93m
    },
    new Product()
    {
        Name = "Bar Mix - Pina Colada, 355 Ml",
        Price = 1.04m
    },
    new Product()
    {
        Name = "Tomatoes Tear Drop",
        Price = 0.89m
    },
    new Product()
    {
        Name = "Wine - Ruffino Chianti Classico",
        Price = 5.71m
    },
    new Product()
    {
        Name = "Wine - Prosecco Valdobienne",
        Price = 3.35m
    },
    new Product()
    {
        Name = "Brandy - Orange, Mc Guiness",
        Price = 3.04m
    },
    new Product()
    {
        Name = "Pineapple - Golden",
        Price = 6.81m
    },
    new Product()
    {
        Name = "Ice Cream - Life Savers",
        Price = 1.38m
    },
    new Product()
    {
        Name = "Mushroom - Shitake, Fresh",
        Price = 7.28m
    },
    new Product()
    {
        Name = "Carrots - Jumbo",
        Price = 2.99m
    },
    new Product()
    {
        Name = "Calypso - Lemonade",
        Price = 5.97m
    },
    new Product()
    {
        Name = "Browning Caramel Glace",
        Price = 0.33m
    },
    new Product()
    {
        Name = "Table Cloth 54x54 White",
        Price = 2.73m
    },
    new Product()
    {
        Name = "Bread - 10 Grain",
        Price = 9.56m
    },
    new Product()
    {
        Name = "Ecolab - Ster Bac",
        Price = 4.88m
    },
    new Product()
    {
        Name = "Wine - Piper Heidsieck Brut",
        Price = 6.96m
    },
    new Product()
    {
        Name = "Bread - Corn Muffaletta",
        Price = 7.97m
    },
    new Product()
    {
        Name = "Muffin Batt - Choc Chk",
        Price = 4.08m
    },
    new Product()
    {
        Name = "Fond - Neutral",
        Price = 2.28m
    },
    new Product()
    {
        Name = "Coffee - Colombian, Portioned",
        Price = 7.87m
    },
    new Product()
    {
        Name = "Beer - Mcauslan Apricot",
        Price = 9.24m
    },
    new Product()
    {
        Name = "Chicken - Tenderloin",
        Price = 7.81m
    },
    new Product()
    {
        Name = "Marjoram - Fresh",
        Price = 1.20m
    },
    new Product()
    {
        Name = "Limes",
        Price = 4.30m
    },
    new Product()
    {
        Name = "Milk - 2% 250 Ml",
        Price = 4.96m
    },
    new Product()
    {
        Name = "Pastry - Chocolate Chip Muffin",
        Price = 5.11m
    },
    new Product()
    {
        Name = "Kellogs All Bran Bars",
        Price = 0.65m
    },
    new Product()
    {
        Name = "Dragon Fruit",
        Price = 3.73m
    },
    new Product()
    {
        Name = "Venison - Racks Frenched",
        Price = 6.18m
    },
    new Product()
    {
        Name = "Soup - Campbells, Butternut",
        Price = 4.95m
    },
    new Product()
    {
        Name = "Sauce - Thousand Island",
        Price = 8.28m
    },
    new Product()
    {
        Name = "Jack Daniels",
        Price = 5.73m
    },
    new Product()
    {
        Name = "Jam - Blackberry, 20 Ml Jar",
        Price = 0.91m
    },
    new Product()
    {
        Name = "Lentils - Green Le Puy",
        Price = 0.97m
    },
    new Product()
    {
        Name = "Island Oasis - Magarita Mix",
        Price = 0.28m
    },
    new Product()
    {
        Name = "Water - San Pellegrino",
        Price = 9.19m
    },
    new Product()
    {
        Name = "Venison - Liver",
        Price = 2.45m
    },
    new Product()
    {
        Name = "Remy Red",
        Price = 0.33m
    },
    new Product()
    {
        Name = "Bread - 10 Grain Parisian",
        Price = 2.48m
    },
    new Product()
    {
        Name = "Bread - 10 Grain Parisian",
        Price = 8.19m
    },
    new Product()
    {
        Name = "Beer - Sleemans Honey Brown",
        Price = 5.42m
    },
    new Product()
    {
        Name = "Chinese Foods - Plain Fried Rice",
        Price = 3.01m
    },
    new Product()
    {
        Name = "Longos - Penne With Pesto",
        Price = 2.16m
    },
    new Product()
    {
        Name = "Bread - White Epi Baguette",
        Price = 3.55m
    },
    new Product()
    {
        Name = "Tart Shells - Savory, 4",
        Price = 1.18m
    },
    new Product()
    {
        Name = "Nantucket - 518ml",
        Price = 7.53m
    },
    new Product()
    {
        Name = "Garlic Powder",
        Price = 3.96m
    },
    new Product()
    {
        Name = "Chicken - Tenderloin",
        Price = 4.82m
    },
    new Product()
    {
        Name = "Hagen Daza - Dk Choocolate",
        Price = 2.45m
    },
    new Product()
    {
        Name = "V8 - Tropical Blend",
        Price = 1.98m
    },
    new Product()
    {
        Name = "Wine - Prosecco Valdobienne",
        Price = 5.29m
    },
    new Product()
    {
        Name = "The Pop Shoppe Pinapple",
        Price = 0.88m
    },
    new Product()
    {
        Name = "Wine - Peller Estates Late",
        Price = 4.05m
    },
    new Product()
    {
        Name = "Parasol Pick Stir Stick",
        Price = 3.46m
    },
    new Product()
    {
        Name = "Versatainer Nc - 8288",
        Price = 0.40m
    },
    new Product()
    {
        Name = "Chicken - Livers",
        Price = 3.27m
    },
    new Product()
    {
        Name = "Soup - Campbells, Spinach Crm",
        Price = 6.50m
    },
    new Product()
    {
        Name = "Soup - French Onion, Dry",
        Price = 1.07m
    },
    new Product()
    {
        Name = "Wine - White, Gewurtzraminer",
        Price = 1.84m
    },
    new Product()
    {
        Name = "Squid - U - 10 Thailand",
        Price = 7.78m
    },
    new Product()
    {
        Name = "Cod - Fillets",
        Price = 9.81m
    },
    new Product()
    {
        Name = "Sunflower Seed Raw",
        Price = 9.01m
    },
    new Product()
    {
        Name = "Cheese - Brie, Cups 125g",
        Price = 4.95m
    },
    new Product()
    {
        Name = "Napkin - Dinner, White",
        Price = 6.67m
    },
    new Product()
    {
        Name = "Water Chestnut - Canned",
        Price = 1.66m
    },
    new Product()
    {
        Name = "Pear - Prickly",
        Price = 7.72m
    },
    new Product()
    {
        Name = "Table Cloth 53x53 White",
        Price = 4.74m
    },
    new Product()
    {
        Name = "Bread - English Muffin",
        Price = 3.29m
    },
    new Product()
    {
        Name = "Beans - Black Bean, Preserved",
        Price = 0.33m
    },
    new Product()
    {
        Name = "Silicone Paper 16.5x24",
        Price = 0.89m
    },
    new Product()
    {
        Name = "Red Cod Fillets - 225g",
        Price = 1.14m
    },
    new Product()
    {
        Name = "Octopus - Baby, Cleaned",
        Price = 7.73m
    },
    new Product()
    {
        Name = "Isomalt",
        Price = 0.08m
    },
    new Product()
    {
        Name = "Sugar - Invert",
        Price = 6.72m
    },
    new Product()
    {
        Name = "Soupcontfoam16oz 116con",
        Price = 2.70m
    },
    new Product()
    {
        Name = "Skirt - 24 Foot",
        Price = 3.64m
    },
    new Product()
    {
        Name = "Steampan - Foil",
        Price = 2.95m
    },
    new Product()
    {
        Name = "Turkey - Breast, Double",
        Price = 7.70m
    },
    new Product()
    {
        Name = "Langers - Ruby Red Grapfruit",
        Price = 3.28m
    },
    new Product()
    {
        Name = "Nut - Walnut, Pieces",
        Price = 5.85m
    },
    new Product()
    {
        Name = "Venison - Denver Leg Boneless",
        Price = 5.66m
    },
    new Product()
    {
        Name = "Peas Snow",
        Price = 7.15m
    },
    new Product()
    {
        Name = "Thermometer Digital",
        Price = 0.80m
    },
    new Product()
    {
        Name = "Wine - Chenin Blanc K.w.v.",
        Price = 0.92m
    },
    new Product()
    {
        Name = "Cookie Choc",
        Price = 2.65m
    },
    new Product()
    {
        Name = "Bread - White Mini Epi",
        Price = 3.09m
    },
    new Product()
    {
        Name = "Beef - Tenderloin",
        Price = 8.12m
    },
    new Product()
    {
        Name = "Squash - Butternut",
        Price = 3.28m
    },
    new Product()
    {
        Name = "Lettuce - Iceberg",
        Price = 4.76m
    },
    new Product()
    {
        Name = "Bar Nature Valley",
        Price = 1.07m
    },
    new Product()
    {
        Name = "Pasta - Cannelloni, Sheets, Fresh",
        Price = 0.09m
    },
    new Product()
    {
        Name = "Huck Towels White",
        Price = 0.50m
    },
    new Product()
    {
        Name = "Brownies - Two Bite, Chocolate",
        Price = 6.84m
    },
    new Product()
    {
        Name = "Dill Weed - Dry",
        Price = 1.72m
    },
    new Product()
    {
        Name = "Tuna - Loin",
        Price = 9.70m
    },
    new Product()
    {
        Name = "Beef - Bones, Marrow",
        Price = 7.66m
    },
    new Product()
    {
        Name = "Sauce Bbq Smokey",
        Price = 9.55m
    },
    new Product()
    {
        Name = "Lid - 16 Oz And 32 Oz",
        Price = 9.01m
    },
    new Product()
    {
        Name = "Cornflakes",
        Price = 4.34m
    },
    new Product()
    {
        Name = "Pasta - Elbows, Macaroni, Dry",
        Price = 3.90m
    },
    new Product()
    {
        Name = "Beef - Rib Roast, Capless",
        Price = 1.89m
    },
    new Product()
    {
        Name = "Irish Cream - Butterscotch",
        Price = 8.80m
    },
    new Product()
    {
        Name = "Lettuce - Arugula",
        Price = 9.99m
    },
    new Product()
    {
        Name = "Water - Mineral, Natural",
        Price = 8.66m
    },
    new Product()
    {
        Name = "Beer - Alexander Kieths, Pale Ale",
        Price = 8.14m
    },
    new Product()
    {
        Name = "Island Oasis - Banana Daiquiri",
        Price = 7.73m
    },
    new Product()
    {
        Name = "Swiss Chard",
        Price = 0.05m
    },
    new Product()
    {
        Name = "Danishes - Mini Cheese",
        Price = 0.11m
    },
    new Product()
    {
        Name = "Pail With Metal Handle 16l White",
        Price = 9.21m
    },
    new Product()
    {
        Name = "Beef - Cow Feet Split",
        Price = 3.53m
    },
    new Product()
    {
        Name = "Amaretto",
        Price = 7.93m
    },
    new Product()
    {
        Name = "Fuji Apples",
        Price = 1.59m
    },
    new Product()
    {
        Name = "Yeast Dry - Fermipan",
        Price = 1.24m
    },
    new Product()
    {
        Name = "Dawn Professionl Pot And Pan",
        Price = 8.67m
    },
    new Product()
    {
        Name = "Soup - French Onion",
        Price = 9.12m
    },
    new Product()
    {
        Name = "Hot Choc Vending",
        Price = 1.23m
    },
    new Product()
    {
        Name = "Cookies - Fortune",
        Price = 5.66m
    },
    new Product()
    {
        Name = "Water - Mineral, Carbonated",
        Price = 7.25m
    },
    new Product()
    {
        Name = "Sauce - Roasted Red Pepper",
        Price = 1.89m
    },
    new Product()
    {
        Name = "Juice - Orange",
        Price = 9.30m
    },
    new Product()
    {
        Name = "Wine - Cave Springs Dry Riesling",
        Price = 8.04m
    },
    new Product()
    {
        Name = "Tart Shells - Sweet, 4",
        Price = 9.13m
    },
    new Product()
    {
        Name = "Fudge - Chocolate Fudge",
        Price = 1.87m
    },
    new Product()
    {
        Name = "Wine - Baron De Rothschild",
        Price = 1.26m
    },
    new Product()
    {
        Name = "Durian Fruit",
        Price = 0.61m
    },
    new Product()
    {
        Name = "Mint - Fresh",
        Price = 6.75m
    },
    new Product()
    {
        Name = "Cheese - Grana Padano",
        Price = 5.33m
    },
    new Product()
    {
        Name = "Anisette - Mcguiness",
        Price = 9.40m
    },
    new Product()
    {
        Name = "Salmon - Canned",
        Price = 2.76m
    },
    new Product()
    {
        Name = "Icecream - Dibs",
        Price = 5.28m
    },
    new Product()
    {
        Name = "Wine - Two Oceans Cabernet",
        Price = 0.62m
    },
    new Product()
    {
        Name = "Beef Ground Medium",
        Price = 3.11m
    },
    new Product()
    {
        Name = "Truffle Cups - White Paper",
        Price = 3.84m
    },
    new Product()
    {
        Name = "Tea - Lemon Scented",
        Price = 4.50m
    },
    new Product()
    {
        Name = "Island Oasis - Ice Cream Mix",
        Price = 6.01m
    },
    new Product()
    {
        Name = "Lettuce - Boston Bib - Organic",
        Price = 9.12m
    },
    new Product()
    {
        Name = "Flower - Commercial Bronze",
        Price = 2.62m
    },
    new Product()
    {
        Name = "Bread - White Mini Epi",
        Price = 9.61m
    },
    new Product()
    {
        Name = "Flower - Daisies",
        Price = 8.10m
    },
    new Product()
    {
        Name = "Vermouth - White, Cinzano",
        Price = 0.82m
    },
    new Product()
    {
        Name = "Sprouts - Brussel",
        Price = 0.99m
    },
    new Product()
    {
        Name = "Capon - Breast, Wing On",
        Price = 1.36m
    },
    new Product()
    {
        Name = "Table Cloth 62x120 Colour",
        Price = 0.36m
    },
    new Product()
    {
        Name = "Beans - Turtle, Black, Dry",
        Price = 0.12m
    },
    new Product()
    {
        Name = "Yucca",
        Price = 8.84m
    },
    new Product()
    {
        Name = "Beef - Top Sirloin",
        Price = 7.90m
    },
    new Product()
    {
        Name = "Steamers White",
        Price = 3.43m
    },
    new Product()
    {
        Name = "Vacuum Bags 12x16",
        Price = 0.27m
    },
    new Product()
    {
        Name = "Rambutan",
        Price = 0.06m
    },
    new Product()
    {
        Name = "Pasta - Penne, Lisce, Dry",
        Price = 5.68m
    },
    new Product()
    {
        Name = "Cheese - Bakers Cream Cheese",
        Price = 3.02m
    },
    new Product()
    {
        Name = "Potatoes - Idaho 100 Count",
        Price = 1.90m
    },
    new Product()
    {
        Name = "Napkin - Cocktail,beige 2 - Ply",
        Price = 3.69m
    },
    new Product()
    {
        Name = "Lettuce - Lolla Rosa",
        Price = 6.63m
    },
    new Product()
    {
        Name = "Pickle - Dill",
        Price = 5.69m
    },
    new Product()
    {
        Name = "Beef - Shank",
        Price = 9.44m
    },
    new Product()
    {
        Name = "Squid - Tubes / Tenticles 10/20",
        Price = 6.63m
    },
    new Product()
    {
        Name = "Basil - Fresh",
        Price = 9.37m
    },
    new Product()
    {
        Name = "Guava",
        Price = 6.34m
    },
    new Product()
    {
        Name = "Blackberries",
        Price = 7.85m
    },
    new Product()
    {
        Name = "Zucchini - Mini, Green",
        Price = 9.10m
    },
    new Product()
    {
        Name = "Trout - Rainbow, Frozen",
        Price = 8.11m
    },
    new Product()
    {
        Name = "Spoon - Soup, Plastic",
        Price = 5.57m
    },
    new Product()
    {
        Name = "Rice Paper",
        Price = 3.65m
    },
    new Product()
    {
        Name = "Creamers - 10%",
        Price = 3.24m
    },
    new Product()
    {
        Name = "Macaroons - Two Bite Choc",
        Price = 0.96m
    },
    new Product()
    {
        Name = "Calypso - Black Cherry Lemonade",
        Price = 0.47m
    },
    new Product()
    {
        Name = "Pate - Peppercorn",
        Price = 5.21m
    },
    new Product()
    {
        Name = "Ice Cream - Super Sandwich",
        Price = 4.43m
    },
    new Product()
    {
        Name = "Vinegar - White Wine",
        Price = 8.92m
    },
    new Product()
    {
        Name = "Chocolate - Feathers",
        Price = 4.57m
    },
    new Product()
    {
        Name = "Bread Base - Goodhearth",
        Price = 1.81m
    },
    new Product()
    {
        Name = "Shrimp - Baby, Warm Water",
        Price = 1.25m
    },
    new Product()
    {
        Name = "Food Colouring - Red",
        Price = 0.24m
    },
    new Product()
    {
        Name = "Wine - Pinot Noir Latour",
        Price = 2.40m
    },
    new Product()
    {
        Name = "Nantucket Cranberry Juice",
        Price = 7.59m
    },
    new Product()
    {
        Name = "Flower - Dish Garden",
        Price = 5.91m
    },
    new Product()
    {
        Name = "Longos - Chicken Curried",
        Price = 6.12m
    },
    new Product()
    {
        Name = "Wine - Periguita Fonseca",
        Price = 3.02m
    },
    new Product()
    {
        Name = "Pork Loin Cutlets",
        Price = 8.92m
    },
    new Product()
    {
        Name = "Smirnoff Green Apple Twist",
        Price = 2.98m
    },
    new Product()
    {
        Name = "Dry Ice",
        Price = 4.19m
    },
    new Product()
    {
        Name = "Wine - Pinot Noir Stoneleigh",
        Price = 3.36m
    },
    new Product()
    {
        Name = "Bacardi Raspberry",
        Price = 8.43m
    },
    new Product()
    {
        Name = "Bread - Sour Sticks With Onion",
        Price = 2.70m
    },
    new Product()
    {
        Name = "Wine - Clavet Saint Emilion",
        Price = 3.19m
    },
    new Product()
    {
        Name = "Soup - Knorr, Classic Can. Chili",
        Price = 1.86m
    },
    new Product()
    {
        Name = "Soup - Clam Chowder, Dry Mix",
        Price = 6.20m
    },
    new Product()
    {
        Name = "Eggplant Oriental",
        Price = 8.83m
    },
    new Product()
    {
        Name = "Salt And Pepper Mix - Black",
        Price = 9.27m
    },
    new Product()
    {
        Name = "Ketchup - Tomato",
        Price = 6.36m
    },
    new Product()
    {
        Name = "Chicken - Base, Ultimate",
        Price = 5.66m
    },
    new Product()
    {
        Name = "Puff Pastry - Sheets",
        Price = 1.59m
    },
    new Product()
    {
        Name = "Mushroom - Trumpet, Dry",
        Price = 8.87m
    },
    new Product()
    {
        Name = "Marsala - Sperone, Fine, D.o.c.",
        Price = 0.15m
    },
    new Product()
    {
        Name = "Rum - White, Gg White",
        Price = 0.00m
    },
    new Product()
    {
        Name = "Pasta - Canelloni, Single Serve",
        Price = 5.74m
    },
    new Product()
    {
        Name = "Wooden Mop Handle",
        Price = 2.28m
    },
    new Product()
    {
        Name = "Beef Striploin Aaa",
        Price = 0.53m
    },
    new Product()
    {
        Name = "Chicken - Soup Base",
        Price = 6.78m
    },
    new Product()
    {
        Name = "Wine - Niagara Peninsula Vqa",
        Price = 4.78m
    },
    new Product()
    {
        Name = "Oil - Pumpkinseed",
        Price = 2.26m
    },
    new Product()
    {
        Name = "Wine - Hardys Bankside Shiraz",
        Price = 1.72m
    },
    new Product()
    {
        Name = "Cup - 4oz Translucent",
        Price = 2.40m
    },
    new Product()
    {
        Name = "Salmon - Sockeye Raw",
        Price = 6.71m
    },
    new Product()
    {
        Name = "Bouq All Italian - Primerba",
        Price = 3.55m
    },
    new Product()
    {
        Name = "Soup Bowl Clear 8oz92008",
        Price = 2.66m
    },
    new Product()
    {
        Name = "Vinegar - Cider",
        Price = 4.06m
    },
    new Product()
    {
        Name = "Beef - Ox Tongue",
        Price = 4.81m
    },
    new Product()
    {
        Name = "Wine - White, Riesling, Semi - Dry",
        Price = 4.24m
    },
    new Product()
    {
        Name = "Chicken - Leg, Fresh",
        Price = 7.52m
    },
    new Product()
    {
        Name = "Bread - Ciabatta Buns",
        Price = 2.32m
    },
    new Product()
    {
        Name = "Napkin White",
        Price = 9.13m
    },
    new Product()
    {
        Name = "Swordfish Loin Portions",
        Price = 6.95m
    },
    new Product()
    {
        Name = "Fruit Mix - Light",
        Price = 7.60m
    },
    new Product()
    {
        Name = "Chilli Paste, Sambal Oelek",
        Price = 4.40m
    },
    new Product()
    {
        Name = "Pasta - Lasagna, Dry",
        Price = 1.20m
    },
    new Product()
    {
        Name = "Ocean Spray - Kiwi Strawberry",
        Price = 0.76m
    },
    new Product()
    {
        Name = "Oil - Olive Bertolli",
        Price = 6.95m
    },
    new Product()
    {
        Name = "Arrowroot",
        Price = 0.58m
    },
    new Product()
    {
        Name = "Juice - Propel Sport",
        Price = 1.37m
    },
    new Product()
    {
        Name = "Wine - Periguita Fonseca",
        Price = 7.61m
    },
    new Product()
    {
        Name = "Wine - Gato Negro Cabernet",
        Price = 1.38m
    },
    new Product()
    {
        Name = "Ginger - Crystalized",
        Price = 0.88m
    },
    new Product()
    {
        Name = "Soup Campbells Mexicali Tortilla",
        Price = 5.63m
    },
    new Product()
    {
        Name = "Pepper - Chillies, Crushed",
        Price = 0.20m
    },
    new Product()
    {
        Name = "Sauce - Bernaise, Mix",
        Price = 4.96m
    },
    new Product()
    {
        Name = "Coriander - Ground",
        Price = 9.63m
    },
    new Product()
    {
        Name = "Tomato Paste",
        Price = 3.64m
    },
    new Product()
    {
        Name = "Foam Espresso Cup Plain White",
        Price = 2.78m
    },
    new Product()
    {
        Name = "Mushroom - Morel Frozen",
        Price = 7.81m
    },
    new Product()
    {
        Name = "Broom And Broom Rack White",
        Price = 2.29m
    },
    new Product()
    {
        Name = "Beef - Rib Roast, Cap On",
        Price = 8.49m
    },
    new Product()
    {
        Name = "Clam - Cherrystone",
        Price = 0.86m
    },
    new Product()
    {
        Name = "Wine - Semi Dry Riesling Vineland",
        Price = 7.12m
    },
    new Product()
    {
        Name = "Muffin Mix - Raisin Bran",
        Price = 3.08m
    },
    new Product()
    {
        Name = "Wine - Taylors Reserve",
        Price = 1.06m
    },
    new Product()
    {
        Name = "Orange - Canned, Mandarin",
        Price = 1.88m
    },
    new Product()
    {
        Name = "Hipnotiq Liquor",
        Price = 0.70m
    },
    new Product()
    {
        Name = "Flour - Bran, Red",
        Price = 6.12m
    },
    new Product()
    {
        Name = "Trout - Rainbow, Fresh",
        Price = 4.51m
    },
    new Product()
    {
        Name = "Sauce - Caesar Dressing",
        Price = 2.36m
    },
    new Product()
    {
        Name = "Oats Large Flake",
        Price = 7.37m
    },
    new Product()
    {
        Name = "Sauce - Fish 25 Ozf Bottle",
        Price = 4.31m
    },
    new Product()
    {
        Name = "Cocoa Powder - Natural",
        Price = 6.39m
    },
    new Product()
    {
        Name = "Bread - Dark Rye, Loaf",
        Price = 1.00m
    },
    new Product()
    {
        Name = "Chicken - White Meat With Tender",
        Price = 5.37m
    },
    new Product()
    {
        Name = "Ocean Spray - Ruby Red",
        Price = 4.23m
    },
    new Product()
    {
        Name = "Juice - V8, Tomato",
        Price = 9.56m
    },
    new Product()
    {
        Name = "Cherries - Frozen",
        Price = 1.97m
    },
    new Product()
    {
        Name = "Tray - Foam, Square 4 - S",
        Price = 0.66m
    },
    new Product()
    {
        Name = "Squash - Pepper",
        Price = 5.74m
    },
    new Product()
    {
        Name = "Cup - 6oz, Foam",
        Price = 4.93m
    },
    new Product()
    {
        Name = "Dc - Sakura Fu",
        Price = 1.49m
    },
    new Product()
    {
        Name = "Lid Coffeecup 12oz D9542b",
        Price = 3.59m
    },
    new Product()
    {
        Name = "Pasta - Fettuccine, Egg, Fresh",
        Price = 9.44m
    },
    new Product()
    {
        Name = "Lettuce - Romaine",
        Price = 9.46m
    },
    new Product()
    {
        Name = "Turkey Leg With Drum And Thigh",
        Price = 4.38m
    },
    new Product()
    {
        Name = "Wine - White, French Cross",
        Price = 2.39m
    },
    new Product()
    {
        Name = "Lobster - Base",
        Price = 2.03m
    },
    new Product()
    {
        Name = "Cheese - Comtomme",
        Price = 4.39m
    },
    new Product()
    {
        Name = "Cornstarch",
        Price = 5.61m
    },
    new Product()
    {
        Name = "Coriander - Seed",
        Price = 9.45m
    },
    new Product()
    {
        Name = "Nantuket Peach Orange",
        Price = 6.85m
    },
    new Product()
    {
        Name = "Longos - Grilled Salmon With Bbq",
        Price = 5.43m
    },
    new Product()
    {
        Name = "Tuna - Canned, Flaked, Light",
        Price = 0.36m
    },
    new Product()
    {
        Name = "Puree - Passion Fruit",
        Price = 8.01m
    },
    new Product()
    {
        Name = "Stock - Chicken, White",
        Price = 6.29m
    },
    new Product()
    {
        Name = "Oil - Canola",
        Price = 0.12m
    },
    new Product()
    {
        Name = "Cheese - Swiss",
        Price = 6.82m
    },
    new Product()
    {
        Name = "Crackers - Soda / Saltins",
        Price = 4.31m
    },
    new Product()
    {
        Name = "Wood Chips - Regular",
        Price = 3.46m
    },
    new Product()
    {
        Name = "Island Oasis - Wildberry",
        Price = 0.15m
    },
    new Product()
    {
        Name = "Thyme - Dried",
        Price = 0.74m
    },
    new Product()
    {
        Name = "Pie Shells 10",
        Price = 2.18m
    },
    new Product()
    {
        Name = "Wine - White, Riesling, Henry Of",
        Price = 8.17m
    },
    new Product()
    {
        Name = "Lychee",
        Price = 2.85m
    },
    new Product()
    {
        Name = "Bread - Italian Roll With Herbs",
        Price = 7.71m
    },
    new Product()
    {
        Name = "Baking Soda",
        Price = 2.99m
    },
    new Product()
    {
        Name = "Capers - Ox Eye Daisy",
        Price = 0.47m
    },
    new Product()
    {
        Name = "Cookie Dough - Chocolate Chip",
        Price = 0.67m
    },
    new Product()
    {
        Name = "Tomatoes - Orange",
        Price = 4.54m
    },
    new Product()
    {
        Name = "Galliano",
        Price = 9.66m
    },
    new Product()
    {
        Name = "Bread - Multigrain Oval",
        Price = 1.92m
    },
    new Product()
    {
        Name = "Beef - Tenderloin Tails",
        Price = 5.02m
    },
    new Product()
    {
        Name = "Nut - Pumpkin Seeds",
        Price = 5.93m
    },
    new Product()
    {
        Name = "Dr. Pepper - 355ml",
        Price = 1.14m
    },
    new Product()
    {
        Name = "Durian Fruit",
        Price = 9.60m
    },
    new Product()
    {
        Name = "Calypso - Pineapple Passion",
        Price = 1.12m
    },
    new Product()
    {
        Name = "Graham Cracker Mix",
        Price = 2.40m
    },
    new Product()
    {
        Name = "Soup Campbells Beef With Veg",
        Price = 0.40m
    },
    new Product()
    {
        Name = "Red Snapper - Fresh, Whole",
        Price = 8.12m
    },
    new Product()
    {
        Name = "Dates",
        Price = 0.55m
    },
    new Product()
    {
        Name = "Wine - Chateauneuf Du Pape",
        Price = 6.74m
    },
    new Product()
    {
        Name = "Crush - Cream Soda",
        Price = 1.53m
    },
    new Product()
    {
        Name = "Isomalt",
        Price = 4.56m
    },
    new Product()
    {
        Name = "Mousse - Mango",
        Price = 4.04m
    },
    new Product()
    {
        Name = "Squid - Breaded",
        Price = 6.01m
    },
    new Product()
    {
        Name = "Island Oasis - Strawberry",
        Price = 8.51m
    },
    new Product()
    {
        Name = "Carbonated Water - Wildberry",
        Price = 7.88m
    },
    new Product()
    {
        Name = "Monkfish - Fresh",
        Price = 3.44m
    },
    new Product()
    {
        Name = "Pastry - Mini French Pastries",
        Price = 2.43m
    },
    new Product()
    {
        Name = "Papayas",
        Price = 4.19m
    },
    new Product()
    {
        Name = "Marzipan 50/50",
        Price = 9.23m
    },
    new Product()
    {
        Name = "Wine - White, Chardonnay",
        Price = 5.09m
    },
    new Product()
    {
        Name = "Eel Fresh",
        Price = 9.34m
    },
    new Product()
    {
        Name = "Oil - Food, Lacquer Spray",
        Price = 1.29m
    },
    new Product()
    {
        Name = "Chicken - Whole Roasting",
        Price = 0.78m
    },
    new Product()
    {
        Name = "Chicken - White Meat, No Tender",
        Price = 4.43m
    },
    new Product()
    {
        Name = "Beer - Labatt Blue",
        Price = 8.95m
    },
    new Product()
    {
        Name = "Bagel - Whole White Sesame",
        Price = 5.82m
    },
    new Product()
    {
        Name = "Broom And Brush Rack Black",
        Price = 6.05m
    },
    new Product()
    {
        Name = "Cream - 10%",
        Price = 3.21m
    },
    new Product()
    {
        Name = "Pears - Anjou",
        Price = 3.37m
    },
    new Product()
    {
        Name = "Rice - Aborio",
        Price = 9.51m
    },
    new Product()
    {
        Name = "Oil - Pumpkinseed",
        Price = 2.31m
    },
    new Product()
    {
        Name = "Chickhen - Chicken Phyllo",
        Price = 4.72m
    },
    new Product()
    {
        Name = "Pop - Club Soda Can",
        Price = 9.11m
    },
    new Product()
    {
        Name = "Beans - Black Bean, Dry",
        Price = 1.12m
    },
    new Product()
    {
        Name = "Veal - Inside, Choice",
        Price = 3.02m
    },
    new Product()
    {
        Name = "Juice - Orange, 341 Ml",
        Price = 6.53m
    },
    new Product()
    {
        Name = "Cheese - St. Paulin",
        Price = 3.74m
    },
    new Product()
    {
        Name = "Crackers - Graham",
        Price = 9.69m
    },
    new Product()
    {
        Name = "Honey - Lavender",
        Price = 2.26m
    },
    new Product()
    {
        Name = "Boogies",
        Price = 3.73m
    },
    new Product()
    {
        Name = "Pasta - Lasagne, Fresh",
        Price = 3.58m
    },
    new Product()
    {
        Name = "Wine - Shiraz South Eastern",
        Price = 2.54m
    },
    new Product()
    {
        Name = "Chinese Foods - Thick Noodles",
        Price = 8.89m
    },
    new Product()
    {
        Name = "Steampan - Lid For Half Size",
        Price = 4.06m
    },
    new Product()
    {
        Name = "Foil - Round Foil",
        Price = 6.24m
    },
    new Product()
    {
        Name = "Yoplait Drink",
        Price = 5.09m
    },
    new Product()
    {
        Name = "Muffin Batt - Carrot Spice",
        Price = 6.36m
    },
    new Product()
    {
        Name = "Chinese Lemon Pork",
        Price = 8.63m
    },
    new Product()
    {
        Name = "Water, Tap",
        Price = 6.99m
    },
    new Product()
    {
        Name = "Quiche Assorted",
        Price = 7.73m
    },
    new Product()
    {
        Name = "Wine - Sogrape Mateus Rose",
        Price = 6.43m
    },
    new Product()
    {
        Name = "Remy Red",
        Price = 0.62m
    },
    new Product()
    {
        Name = "Oil - Shortening - All - Purpose",
        Price = 5.38m
    },
    new Product()
    {
        Name = "Sugar Thermometer",
        Price = 1.20m
    },
    new Product()
    {
        Name = "Chocolate - Sugar Free Semi Choc",
        Price = 4.54m
    },
    new Product()
    {
        Name = "Glaze - Clear",
        Price = 0.86m
    },
    new Product()
    {
        Name = "Potatoes - Yukon Gold, 80 Ct",
        Price = 8.37m
    },
    new Product()
    {
        Name = "Cheese - Ermite Bleu",
        Price = 2.42m
    },
    new Product()
    {
        Name = "Pork Loin Cutlets",
        Price = 1.68m
    },
    new Product()
    {
        Name = "Pate - Liver",
        Price = 5.40m
    },
    new Product()
    {
        Name = "Sherbet - Raspberry",
        Price = 6.61m
    },
    new Product()
    {
        Name = "Bandage - Finger Cots",
        Price = 4.95m
    },
    new Product()
    {
        Name = "Cake - Cheese Cake 9 Inch",
        Price = 0.00m
    },
    new Product()
    {
        Name = "Bread - Bistro Sour",
        Price = 7.93m
    },
    new Product()
    {
        Name = "Chilli Paste, Hot Sambal Oelek",
        Price = 8.47m
    },
    new Product()
    {
        Name = "Appetizer - Southwestern",
        Price = 7.17m
    },
    new Product()
    {
        Name = "Kale - Red",
        Price = 0.07m
    },
    new Product()
    {
        Name = "Nut - Pumpkin Seeds",
        Price = 2.74m
    },
    new Product()
    {
        Name = "Chick Peas - Dried",
        Price = 3.29m
    },
    new Product()
    {
        Name = "Snapple Lemon Tea",
        Price = 8.49m
    },
    new Product()
    {
        Name = "Fennel",
        Price = 3.85m
    },
    new Product()
    {
        Name = "Appetizer - Shrimp Puff",
        Price = 2.92m
    },
    new Product()
    {
        Name = "Chips - Doritos",
        Price = 8.19m
    },
    new Product()
    {
        Name = "Soup - French Can Pea",
        Price = 8.12m
    },
    new Product()
    {
        Name = "Cheese - Sheep Milk",
        Price = 0.14m
    },
    new Product()
    {
        Name = "Langers - Ruby Red Grapfruit",
        Price = 7.14m
    },
    new Product()
    {
        Name = "Vacuum Bags 12x16",
        Price = 4.42m
    },
    new Product()
    {
        Name = "Sprouts Dikon",
        Price = 8.35m
    },
    new Product()
    {
        Name = "Pasta - Shells, Medium, Dry",
        Price = 3.72m
    },
    new Product()
    {
        Name = "Quail - Whole, Bone - In",
        Price = 3.30m
    },
    new Product()
    {
        Name = "Carbonated Water - Strawberry",
        Price = 2.66m
    },
    new Product()
    {
        Name = "Beets - Pickled",
        Price = 0.17m
    },
    new Product()
    {
        Name = "Vinegar - Cider",
        Price = 9.46m
    },
    new Product()
    {
        Name = "Appetizer - Sausage Rolls",
        Price = 6.25m
    },
    new Product()
    {
        Name = "V8 - Berry Blend",
        Price = 3.22m
    },
    new Product()
    {
        Name = "Pepper - Yellow Bell",
        Price = 5.80m
    },
    new Product()
    {
        Name = "Cod - Salted, Boneless",
        Price = 3.27m
    },
    new Product()
    {
        Name = "Ice Cream - Life Savers",
        Price = 1.55m
    },
    new Product()
    {
        Name = "Basil - Seedlings Cookstown",
        Price = 8.68m
    },
    new Product()
    {
        Name = "Pear - Prickly",
        Price = 5.95m
    },
    new Product()
    {
        Name = "Chocolate Bar - Coffee Crisp",
        Price = 0.35m
    },
    new Product()
    {
        Name = "Chicken Breast Wing On",
        Price = 4.64m
    },
    new Product()
    {
        Name = "Noodles - Steamed Chow Mein",
        Price = 4.39m
    },
    new Product()
    {
        Name = "Bread Fig And Almond",
        Price = 4.04m
    },
    new Product()
    {
        Name = "Oats Large Flake",
        Price = 5.08m
    },
    new Product()
    {
        Name = "Lamb - Whole Head Off,nz",
        Price = 3.61m
    },
    new Product()
    {
        Name = "Cake Sheet Combo Party Pack",
        Price = 9.44m
    },
    new Product()
    {
        Name = "Nut - Pecan, Pieces",
        Price = 2.25m
    },
    new Product()
    {
        Name = "Ginger - Crystalized",
        Price = 4.95m
    },
    new Product()
    {
        Name = "Onions - Cooking",
        Price = 4.67m
    },
    new Product()
    {
        Name = "Cucumber - Pickling Ontario",
        Price = 9.97m
    },
    new Product()
    {
        Name = "Absolut Citron",
        Price = 9.94m
    },
    new Product()
    {
        Name = "Chip - Potato Dill Pickle",
        Price = 4.09m
    },
    new Product()
    {
        Name = "Cheese - Brie,danish",
        Price = 4.15m
    },
    new Product()
    {
        Name = "Scotch - Queen Anne",
        Price = 8.03m
    },
    new Product()
    {
        Name = "Rice - 7 Grain Blend",
        Price = 2.25m
    },
    new Product()
    {
        Name = "Tofu - Firm",
        Price = 3.71m
    },
    new Product()
    {
        Name = "Oil - Grapeseed Oil",
        Price = 6.60m
    },
    new Product()
    {
        Name = "Lobster - Live",
        Price = 9.38m
    },
    new Product()
    {
        Name = "Wine - Pinot Grigio Collavini",
        Price = 6.05m
    },
    new Product()
    {
        Name = "Pesto - Primerba, Paste",
        Price = 2.04m
    },
    new Product()
    {
        Name = "Mushroom - Enoki, Dry",
        Price = 2.82m
    },
    new Product()
    {
        Name = "Cookie Choc",
        Price = 5.41m
    },
    new Product()
    {
        Name = "Table Cloth 62x114 White",
        Price = 1.87m
    },
    new Product()
    {
        Name = "Gatorade - Orange",
        Price = 4.71m
    },
    new Product()
    {
        Name = "Table Cloth 54x54 Colour",
        Price = 4.63m
    },
    new Product()
    {
        Name = "Oil - Peanut",
        Price = 4.22m
    },
    new Product()
    {
        Name = "Wine - Tribal Sauvignon",
        Price = 4.95m
    },
    new Product()
    {
        Name = "Island Oasis - Raspberry",
        Price = 2.53m
    },
    new Product()
    {
        Name = "Beer - Labatt Blue",
        Price = 3.77m
    },
    new Product()
    {
        Name = "Food Colouring - Blue",
        Price = 4.46m
    },
    new Product()
    {
        Name = "Beef - Inside Round",
        Price = 3.87m
    },
    new Product()
    {
        Name = "Honey - Comb",
        Price = 6.03m
    },
    new Product()
    {
        Name = "Bread - Multigrain Oval",
        Price = 9.80m
    },
    new Product()
    {
        Name = "Persimmons",
        Price = 6.74m
    },
    new Product()
    {
        Name = "Cake - Cake Sheet Macaroon",
        Price = 6.23m
    },
    new Product()
    {
        Name = "Beer - Tetleys",
        Price = 1.09m
    },
    new Product()
    {
        Name = "Crawfish",
        Price = 4.18m
    },
    new Product()
    {
        Name = "Soup - Campbells, Minestrone",
        Price = 9.58m
    },
    new Product()
    {
        Name = "Kippers - Smoked",
        Price = 8.95m
    },
    new Product()
    {
        Name = "Carbonated Water - Raspberry",
        Price = 4.14m
    },
    new Product()
    {
        Name = "Veal - Inside, Choice",
        Price = 6.49m
    },
    new Product()
    {
        Name = "Arizona - Green Tea",
        Price = 5.17m
    },
    new Product()
    {
        Name = "Tuna - Fresh",
        Price = 4.94m
    },
    new Product()
    {
        Name = "Pasta - Orecchiette",
        Price = 4.36m
    },
    new Product()
    {
        Name = "Lidsoupcont Rp12dn",
        Price = 7.35m
    },
    new Product()
    {
        Name = "Chocolate - Milk",
        Price = 4.45m
    },
    new Product()
    {
        Name = "Cheese - Woolwich Goat, Log",
        Price = 2.30m
    },
    new Product()
    {
        Name = "Chicken Breast Wing On",
        Price = 3.72m
    },
    new Product()
    {
        Name = "Rosemary - Fresh",
        Price = 4.81m
    },
    new Product()
    {
        Name = "Tomatoes - Vine Ripe, Yellow",
        Price = 2.30m
    },
    new Product()
    {
        Name = "Ginger - Pickled",
        Price = 9.70m
    },
    new Product()
    {
        Name = "Fuji Apples",
        Price = 8.47m
    },
    new Product()
    {
        Name = "Truffle - Peelings",
        Price = 3.47m
    },
    new Product()
    {
        Name = "Soup - Chicken And Wild Rice",
        Price = 0.96m
    },
    new Product()
    {
        Name = "Melon - Honey Dew",
        Price = 2.61m
    },
    new Product()
    {
        Name = "Tart Shells - Sweet, 3",
        Price = 5.93m
    },
    new Product()
    {
        Name = "Soup - Knorr, Chicken Noodle",
        Price = 5.37m
    },
    new Product()
    {
        Name = "Honey - Comb",
        Price = 0.10m
    },
    new Product()
    {
        Name = "Calvados - Boulard",
        Price = 0.23m
    },
    new Product()
    {
        Name = "Juice - Cranberry 284ml",
        Price = 9.02m
    },
    new Product()
    {
        Name = "Glycerine",
        Price = 4.56m
    },
    new Product()
    {
        Name = "Cheese - Provolone",
        Price = 4.81m
    },
    new Product()
    {
        Name = "Water - Tonic",
        Price = 7.77m
    },
    new Product()
    {
        Name = "Skirt - 29 Foot",
        Price = 3.21m
    },
    new Product()
    {
        Name = "Chocolate - Semi Sweet, Calets",
        Price = 8.02m
    },
    new Product()
    {
        Name = "Loaf Pan - 2 Lb, Foil",
        Price = 4.72m
    },
    new Product()
    {
        Name = "White Baguette",
        Price = 1.44m
    },
    new Product()
    {
        Name = "Beets - Golden",
        Price = 4.08m
    },
    new Product()
    {
        Name = "Wine - Red, Pinot Noir, Chateau",
        Price = 6.98m
    },
    new Product()
    {
        Name = "Cinnamon Buns Sticky",
        Price = 7.70m
    },
    new Product()
    {
        Name = "Bread Ww Cluster",
        Price = 7.44m
    },
    new Product()
    {
        Name = "Island Oasis - Mango Daiquiri",
        Price = 0.98m
    },
    new Product()
    {
        Name = "Ice Cream Bar - Hagen Daz",
        Price = 4.58m
    },
    new Product()
    {
        Name = "Bread - Assorted Rolls",
        Price = 0.79m
    },
    new Product()
    {
        Name = "Tomato - Tricolor Cherry",
        Price = 3.32m
    },
    new Product()
    {
        Name = "Cup - Translucent 7 Oz Clear",
        Price = 6.59m
    },
    new Product()
    {
        Name = "Onions - Red",
        Price = 3.00m
    },
    new Product()
    {
        Name = "Cheese - Comte",
        Price = 1.34m
    },
    new Product()
    {
        Name = "Dawn Professionl Pot And Pan",
        Price = 4.25m
    },
    new Product()
    {
        Name = "Wine - White, Pinot Grigio",
        Price = 7.57m
    },
    new Product()
    {
        Name = "Canadian Emmenthal",
        Price = 4.07m
    },
    new Product()
    {
        Name = "Butter - Salted",
        Price = 0.83m
    },
    new Product()
    {
        Name = "Bagel - Whole White Sesame",
        Price = 8.85m
    },
    new Product()
    {
        Name = "Bread - Hot Dog Buns",
        Price = 5.18m
    },
    new Product()
    {
        Name = "Pork Casing",
        Price = 5.71m
    },
    new Product()
    {
        Name = "Bread Fig And Almond",
        Price = 0.95m
    },
    new Product()
    {
        Name = "Garlic",
        Price = 0.88m
    },
    new Product()
    {
        Name = "Kirsch - Schloss",
        Price = 3.45m
    },
    new Product()
    {
        Name = "Bread - Pumpernickel",
        Price = 5.57m
    },
    new Product()
    {
        Name = "Pecan Raisin - Tarts",
        Price = 1.41m
    },
    new Product()
    {
        Name = "Cheese - Grie Des Champ",
        Price = 8.60m
    },
    new Product()
    {
        Name = "Cheese - Cheddar With Claret",
        Price = 5.55m
    },
    new Product()
    {
        Name = "Tart Shells - Sweet, 2",
        Price = 0.90m
    },
    new Product()
    {
        Name = "Bread - Onion Focaccia",
        Price = 5.44m
    },
    new Product()
    {
        Name = "Muffin Batt - Ban Dream Zero",
        Price = 2.75m
    },
    new Product()
    {
        Name = "Clams - Bay",
        Price = 5.00m
    },
    new Product()
    {
        Name = "Tray - 16in Rnd Blk",
        Price = 0.42m
    },
    new Product()
    {
        Name = "Island Oasis - Lemonade",
        Price = 8.34m
    },
    new Product()
    {
        Name = "Goulash Seasoning",
        Price = 8.33m
    },
    new Product()
    {
        Name = "Jack Daniels",
        Price = 1.88m
    },
    new Product()
    {
        Name = "Nestea - Iced Tea",
        Price = 7.82m
    },
    new Product()
    {
        Name = "Wine - White, Schroder And Schyl",
        Price = 2.43m
    },
    new Product()
    {
        Name = "Shrimp - Baby, Warm Water",
        Price = 6.46m
    },
    new Product()
    {
        Name = "Spice - Onion Powder Granulated",
        Price = 0.57m
    },
    new Product()
    {
        Name = "Strawberries - California",
        Price = 5.14m
    },
    new Product()
    {
        Name = "Tilapia - Fillets",
        Price = 6.30m
    },
    new Product()
    {
        Name = "Pectin",
        Price = 7.28m
    },
    new Product()
    {
        Name = "Salmon Steak - Cohoe 6 Oz",
        Price = 5.55m
    },
    new Product()
    {
        Name = "Jam - Raspberry",
        Price = 7.60m
    },
    new Product()
    {
        Name = "Toothpick Frilled",
        Price = 7.31m
    },
    new Product()
    {
        Name = "Yogurt - Raspberry, 175 Gr",
        Price = 1.53m
    },
    new Product()
    {
        Name = "Brocolinni - Gaylan, Chinese",
        Price = 9.61m
    },
    new Product()
    {
        Name = "Spice - Chili Powder Mexican",
        Price = 2.85m
    },
    new Product()
    {
        Name = "Crab - Dungeness, Whole",
        Price = 2.63m
    },
    new Product()
    {
        Name = "Beef - Bones, Marrow",
        Price = 3.72m
    },
    new Product()
    {
        Name = "Wine - Coteaux Du Tricastin Ac",
        Price = 2.72m
    },
    new Product()
    {
        Name = "Broom And Broom Rack White",
        Price = 9.18m
    },
    new Product()
    {
        Name = "Ham - Cooked Italian",
        Price = 0.92m
    },
    new Product()
    {
        Name = "Broom And Broom Rack White",
        Price = 6.18m
    },
    new Product()
    {
        Name = "Squid - U 5",
        Price = 2.88m
    },
    new Product()
    {
        Name = "Sea Urchin",
        Price = 8.92m
    },
    new Product()
    {
        Name = "Veal - Kidney",
        Price = 7.22m
    },
    new Product()
    {
        Name = "Praline Paste",
        Price = 4.93m
    },
    new Product()
    {
        Name = "Buffalo - Short Rib Fresh",
        Price = 9.21m
    },
    new Product()
    {
        Name = "Coriander - Seed",
        Price = 0.45m
    },
    new Product()
    {
        Name = "Pepsi - Diet, 355 Ml",
        Price = 2.30m
    },
    new Product()
    {
        Name = "Cleaner - Bleach",
        Price = 9.65m
    },
    new Product()
    {
        Name = "Sultanas",
        Price = 7.43m
    },
    new Product()
    {
        Name = "Beer - Molson Excel",
        Price = 6.88m
    },
    new Product()
    {
        Name = "Chips - Doritos",
        Price = 7.63m
    },
    new Product()
    {
        Name = "Dill Weed - Dry",
        Price = 5.31m
    },
    new Product()
    {
        Name = "Cake - Pancake",
        Price = 1.31m
    },
    new Product()
    {
        Name = "Longos - Chicken Caeser Salad",
        Price = 4.24m
    },
    new Product()
    {
        Name = "Spice - Paprika",
        Price = 5.66m
    },
    new Product()
    {
        Name = "Port - 74 Brights",
        Price = 3.68m
    },
    new Product()
    {
        Name = "Wine - Magnotta - Cab Franc",
        Price = 7.48m
    },
    new Product()
    {
        Name = "Trout - Smoked",
        Price = 0.76m
    },
    new Product()
    {
        Name = "Cherries - Fresh",
        Price = 3.68m
    },
    new Product()
    {
        Name = "Appetizer - Crab And Brie",
        Price = 7.27m
    },
    new Product()
    {
        Name = "Pastry - French Mini Assorted",
        Price = 5.24m
    },
    new Product()
    {
        Name = "Sherry - Dry",
        Price = 1.24m
    },
    new Product()
    {
        Name = "Squash - Butternut",
        Price = 1.21m
    },
    new Product()
    {
        Name = "Dawn Professionl Pot And Pan",
        Price = 5.17m
    },
    new Product()
    {
        Name = "Cheese - Provolone",
        Price = 0.87m
    },
    new Product()
    {
        Name = "Chocolate Liqueur - Godet White",
        Price = 0.76m
    },
    new Product()
    {
        Name = "Cloves - Ground",
        Price = 0.74m
    },
    new Product()
    {
        Name = "Glaze - Apricot",
        Price = 4.74m
    },
    new Product()
    {
        Name = "Foam Dinner Plate",
        Price = 0.70m
    },
    new Product()
    {
        Name = "Pasta - Canelloni, Single Serve",
        Price = 3.86m
    },
    new Product()
    {
        Name = "Veal - Eye Of Round",
        Price = 7.84m
    },
    new Product()
    {
        Name = "Nantucket - Pomegranate Pear",
        Price = 7.45m
    },
    new Product()
    {
        Name = "Wine - Jackson Triggs Okonagan",
        Price = 8.31m
    },
    new Product()
    {
        Name = "Pasta - Linguini, Dry",
        Price = 3.03m
    },
    new Product()
    {
        Name = "Pants Custom Dry Clean",
        Price = 6.92m
    },
    new Product()
    {
        Name = "Oil - Cooking Spray",
        Price = 4.43m
    },
    new Product()
    {
        Name = "Crab - Dungeness, Whole, live",
        Price = 8.97m
    },
    new Product()
    {
        Name = "Watercress",
        Price = 5.05m
    },
    new Product()
    {
        Name = "Soup - Base Broth Chix",
        Price = 0.03m
    },
    new Product()
    {
        Name = "Mix - Cappucino Cocktail",
        Price = 4.61m
    },
    new Product()
    {
        Name = "Liquid Aminios Acid - Braggs",
        Price = 1.29m
    },
    new Product()
    {
        Name = "Syrup - Golden, Lyles",
        Price = 5.96m
    },
    new Product()
    {
        Name = "Wine - Chardonnay Mondavi",
        Price = 1.77m
    },
    new Product()
    {
        Name = "Turnip - Mini",
        Price = 5.18m
    },
    new Product()
    {
        Name = "Oven Mitts 17 Inch",
        Price = 5.47m
    },
    new Product()
    {
        Name = "Relish",
        Price = 5.64m
    },
    new Product()
    {
        Name = "Huck Towels White",
        Price = 2.32m
    },
    new Product()
    {
        Name = "Pepper - Orange",
        Price = 5.60m
    },
    new Product()
    {
        Name = "Bread - White Epi Baguette",
        Price = 6.50m
    },
    new Product()
    {
        Name = "Chips Potato All Dressed - 43g",
        Price = 1.73m
    },
    new Product()
    {
        Name = "Dried Cranberries",
        Price = 6.53m
    },
    new Product()
    {
        Name = "Pail - 15l White, With Handle",
        Price = 4.02m
    },
    new Product()
    {
        Name = "Juice - Orange 1.89l",
        Price = 3.02m
    },
    new Product()
    {
        Name = "Bread - Pullman, Sliced",
        Price = 3.52m
    },
    new Product()
    {
        Name = "Pork - Bacon, Double Smoked",
        Price = 9.50m
    },
    new Product()
    {
        Name = "Wine - Vovray Sec Domaine Huet",
        Price = 7.84m
    },
    new Product()
    {
        Name = "Table Cloth 91x91 Colour",
        Price = 8.84m
    },
    new Product()
    {
        Name = "Soup - Base Broth Beef",
        Price = 4.87m
    },
    new Product()
    {
        Name = "Yogurt - Cherry, 175 Gr",
        Price = 7.84m
    },
    new Product()
    {
        Name = "Veal - Kidney",
        Price = 8.64m
    },
    new Product()
    {
        Name = "Bok Choy - Baby",
        Price = 4.37m
    },
    new Product()
    {
        Name = "Salt - Table",
        Price = 0.33m
    },
    new Product()
    {
        Name = "Bread - French Stick",
        Price = 5.39m
    },
    new Product()
    {
        Name = "Wine - Chianti Classica Docg",
        Price = 6.41m
    },
    new Product()
    {
        Name = "Lemonade - Kiwi, 591 Ml",
        Price = 7.59m
    },
    new Product()
    {
        Name = "Wine - White, Riesling, Henry Of",
        Price = 6.27m
    },
    new Product()
    {
        Name = "Trout - Smoked",
        Price = 9.48m
    },
    new Product()
    {
        Name = "Tarragon - Primerba, Paste",
        Price = 3.26m
    },
    new Product()
    {
        Name = "Foam Espresso Cup Plain White",
        Price = 5.27m
    },
    new Product()
    {
        Name = "Liqueur - Melon",
        Price = 4.47m
    },
    new Product()
    {
        Name = "Chocolate - White",
        Price = 1.57m
    },
    new Product()
    {
        Name = "Carbonated Water - Strawberry",
        Price = 0.17m
    },
    new Product()
    {
        Name = "Onion - Dried",
        Price = 5.74m
    },
    new Product()
    {
        Name = "Vodka - Lemon, Absolut",
        Price = 3.15m
    },
    new Product()
    {
        Name = "Oneshot Automatic Soap System",
        Price = 3.77m
    },
    new Product()
    {
        Name = "Wine - Magnotta, Merlot Sr Vqa",
        Price = 3.86m
    },
    new Product()
    {
        Name = "Oysters - Smoked",
        Price = 2.21m
    },
    new Product()
    {
        Name = "Sping Loaded Cup Dispenser",
        Price = 5.71m
    },
    new Product()
    {
        Name = "Table Cloth 54x72 Colour",
        Price = 1.99m
    },
    new Product()
    {
        Name = "Langers - Ruby Red Grapfruit",
        Price = 9.93m
    },
    new Product()
    {
        Name = "Chevere Logs",
        Price = 7.66m
    },
    new Product()
    {
        Name = "Bread - Corn Muffaleta Onion",
        Price = 8.15m
    },
    new Product()
    {
        Name = "Onions - Pearl",
        Price = 5.64m
    },
    new Product()
    {
        Name = "Wood Chips - Regular",
        Price = 4.17m
    },
    new Product()
    {
        Name = "Bread - Hamburger Buns",
        Price = 0.55m
    },
    new Product()
    {
        Name = "Crab Meat Claw Pasteurise",
        Price = 1.18m
    },
    new Product()
    {
        Name = "Pancetta",
        Price = 2.84m
    },
    new Product()
    {
        Name = "Cheese - Brie, Triple Creme",
        Price = 3.25m
    },
    new Product()
    {
        Name = "Mortadella",
        Price = 3.10m
    },
    new Product()
    {
        Name = "Yeast Dry - Fleischman",
        Price = 5.23m
    },
    new Product()
    {
        Name = "Truffle - Whole Black Peeled",
        Price = 8.15m
    },
    new Product()
    {
        Name = "Coffee - Decafenated",
        Price = 3.40m
    },
    new Product()
    {
        Name = "Curry Paste - Madras",
        Price = 7.54m
    },
    new Product()
    {
        Name = "Garbage Bags - Clear",
        Price = 9.39m
    },
    new Product()
    {
        Name = "Onions - Red Pearl",
        Price = 6.83m
    },
    new Product()
    {
        Name = "Beer - Moosehead",
        Price = 0.98m
    },
    new Product()
    {
        Name = "Pears - Bartlett",
        Price = 3.95m
    },
    new Product()
    {
        Name = "Nutmeg - Ground",
        Price = 6.65m
    },
    new Product()
    {
        Name = "Longos - Chicken Caeser Salad",
        Price = 4.61m
    },
    new Product()
    {
        Name = "Cleaner - Comet",
        Price = 6.57m
    },
    new Product()
    {
        Name = "Pork - Bones",
        Price = 8.99m
    },
    new Product()
    {
        Name = "Beans - Butter Lrg Lima",
        Price = 8.82m
    },
    new Product()
    {
        Name = "Bananas",
        Price = 8.19m
    },
    new Product()
    {
        Name = "Versatainer Nc - 888",
        Price = 8.09m
    },
    new Product()
    {
        Name = "Cheese - Boursin, Garlic / Herbs",
        Price = 3.49m
    },
    new Product()
    {
        Name = "Cinnamon Buns Sticky",
        Price = 0.12m
    },
    new Product()
    {
        Name = "Glycerine",
        Price = 1.05m
    },
    new Product()
    {
        Name = "Mace Ground",
        Price = 1.56m
    },
    new Product()
    {
        Name = "Bread - Ciabatta Buns",
        Price = 7.14m
    },
    new Product()
    {
        Name = "Puree - Strawberry",
        Price = 9.34m
    },
    new Product()
    {
        Name = "Cake Slab",
        Price = 3.69m
    },
    new Product()
    {
        Name = "Salmon - Whole, 4 - 6 Pounds",
        Price = 1.47m
    },
    new Product()
    {
        Name = "Coffee Beans - Chocolate",
        Price = 3.91m
    },
    new Product()
    {
        Name = "Pineapple - Canned, Rings",
        Price = 5.25m
    },
    new Product()
    {
        Name = "Longos - Greek Salad",
        Price = 9.94m
    },
    new Product()
    {
        Name = "Wine - Rubyport",
        Price = 5.03m
    },
    new Product()
    {
        Name = "Mahi Mahi",
        Price = 7.77m
    },
    new Product()
    {
        Name = "Pork - Back, Short Cut, Boneless",
        Price = 8.46m
    },
    new Product()
    {
        Name = "Potatoes - Peeled",
        Price = 0.32m
    },
    new Product()
    {
        Name = "Oil - Truffle, White",
        Price = 5.47m
    },
    new Product()
    {
        Name = "Table Cloth 62x114 Colour",
        Price = 3.52m
    },
    new Product()
    {
        Name = "Snails - Large Canned",
        Price = 1.73m
    },
    new Product()
    {
        Name = "Mustard Prepared",
        Price = 8.10m
    },
    new Product()
    {
        Name = "Fish - Bones",
        Price = 3.15m
    },
    new Product()
    {
        Name = "Chocolate Bar - Coffee Crisp",
        Price = 5.49m
    },
    new Product()
    {
        Name = "Squash - Butternut",
        Price = 6.03m
    },
    new Product()
    {
        Name = "Egg Patty Fried",
        Price = 4.97m
    },
    new Product()
    {
        Name = "Soup - Cream Of Potato / Leek",
        Price = 8.63m
    },
    new Product()
    {
        Name = "Guinea Fowl",
        Price = 6.63m
    },
    new Product()
    {
        Name = "Goulash Seasoning",
        Price = 4.07m
    },
    new Product()
    {
        Name = "Soup - Campbells Asian Noodle",
        Price = 2.91m
    },
    new Product()
    {
        Name = "Chick Peas - Canned",
        Price = 0.09m
    },
    new Product()
    {
        Name = "Ginger - Ground",
        Price = 8.28m
    },
    new Product()
    {
        Name = "Five Alive Citrus",
        Price = 1.81m
    },
    new Product()
    {
        Name = "Beef Wellington",
        Price = 1.19m
    },
    new Product()
    {
        Name = "Tarts Assorted",
        Price = 7.52m
    },
    new Product()
    {
        Name = "Calaloo",
        Price = 8.07m
    },
    new Product()
    {
        Name = "Tarragon - Fresh",
        Price = 4.48m
    },
    new Product()
    {
        Name = "Basil - Primerba, Paste",
        Price = 4.27m
    },
    new Product()
    {
        Name = "Sea Urchin",
        Price = 1.76m
    },
    new Product()
    {
        Name = "Tuna - Fresh",
        Price = 7.85m
    },
    new Product()
    {
        Name = "Beef - Eye Of Round",
        Price = 8.50m
    },
    new Product()
    {
        Name = "Tea - Apple Green Tea",
        Price = 7.22m
    },
    new Product()
    {
        Name = "Wine - Red, Harrow Estates, Cab",
        Price = 1.04m
    },
    new Product()
    {
        Name = "Creme De Cacao White",
        Price = 2.22m
    },
    new Product()
    {
        Name = "Truffle Shells - Semi - Sweet",
        Price = 9.95m
    },
    new Product()
    {
        Name = "Energy Drink - Franks Pineapple",
        Price = 2.70m
    },
    new Product()
    {
        Name = "Pomello",
        Price = 0.56m
    },
    new Product()
    {
        Name = "Longos - Lasagna Beef",
        Price = 5.02m
    },
    new Product()
    {
        Name = "Onions - Red Pearl",
        Price = 0.83m
    },
    new Product()
    {
        Name = "Bread - Olive",
        Price = 2.58m
    },
    new Product()
    {
        Name = "Orange Roughy 4/6 Oz",
        Price = 6.73m
    },
    new Product()
    {
        Name = "Beer - Paulaner Hefeweisse",
        Price = 1.50m
    },
    new Product()
    {
        Name = "Lotus Rootlets - Canned",
        Price = 4.39m
    },
    new Product()
    {
        Name = "Wine - Tribal Sauvignon",
        Price = 6.72m
    },
    new Product()
    {
        Name = "Cup - 6oz, Foam",
        Price = 0.74m
    },
    new Product()
    {
        Name = "Pepper - Yellow Bell",
        Price = 3.68m
    },
    new Product()
    {
        Name = "Wine - Masi Valpolocell",
        Price = 7.18m
    },
    new Product()
    {
        Name = "Milk 2% 500 Ml",
        Price = 2.10m
    },
    new Product()
    {
        Name = "Wine - White Cab Sauv.on",
        Price = 7.19m
    },
    new Product()
    {
        Name = "Beer - Alexander Kieths, Pale Ale",
        Price = 7.67m
    },
    new Product()
    {
        Name = "Oxtail - Cut",
        Price = 7.19m
    },
    new Product()
    {
        Name = "Straw - Regular",
        Price = 7.91m
    },
    new Product()
    {
        Name = "Dried Cranberries",
        Price = 8.25m
    },
    new Product()
    {
        Name = "Sauce - Thousand Island",
        Price = 0.64m
    },
    new Product()
    {
        Name = "Oil - Truffle, White",
        Price = 0.29m
    },
    new Product()
    {
        Name = "Beans - Fava, Canned",
        Price = 9.81m
    },
    new Product()
    {
        Name = "Scallops - 20/30",
        Price = 5.80m
    },
    new Product()
    {
        Name = "Brandy - Orange, Mc Guiness",
        Price = 5.14m
    },
    new Product()
    {
        Name = "Beer - Sleemans Honey Brown",
        Price = 8.20m
    },
    new Product()
    {
        Name = "Ranchero - Primerba, Paste",
        Price = 6.80m
    },
    new Product()
    {
        Name = "Chicken - Wieners",
        Price = 2.09m
    },
    new Product()
    {
        Name = "Rabbit - Legs",
        Price = 3.68m
    },
    new Product()
    {
        Name = "Crackers - Melba Toast",
        Price = 0.22m
    },
    new Product()
    {
        Name = "Shiratamako - Rice Flour",
        Price = 6.55m
    },
    new Product()
    {
        Name = "Everfresh Products",
        Price = 9.53m
    },
    new Product()
    {
        Name = "Ranchero - Primerba, Paste",
        Price = 0.76m
    },
    new Product()
    {
        Name = "Beer - Rickards Red",
        Price = 5.07m
    },
    new Product()
    {
        Name = "Wine - Magnotta - Pinot Gris Sr",
        Price = 3.75m
    },
    new Product()
    {
        Name = "Island Oasis - Sweet And Sour Mix",
        Price = 4.05m
    },
    new Product()
    {
        Name = "Hickory Smoke, Liquid",
        Price = 1.27m
    },
    new Product()
    {
        Name = "Fish - Base, Bouillion",
        Price = 3.24m
    },
    new Product()
    {
        Name = "Cheese - Le Cheve Noir",
        Price = 4.67m
    },
    new Product()
    {
        Name = "Tarragon - Fresh",
        Price = 8.76m
    },
    new Product()
    {
        Name = "Chilli Paste, Sambal Oelek",
        Price = 7.04m
    },
    new Product()
    {
        Name = "Sobe - Green Tea",
        Price = 1.38m
    },
    new Product()
    {
        Name = "Fudge - Chocolate Fudge",
        Price = 1.22m
    },
    new Product()
    {
        Name = "Sping Loaded Cup Dispenser",
        Price = 4.03m
    },
    new Product()
    {
        Name = "Wine - Red, Lurton Merlot De",
        Price = 6.35m
    },
    new Product()
    {
        Name = "Parsnip",
        Price = 6.84m
    },
    new Product()
    {
        Name = "Veal - Chops, Split, Frenched",
        Price = 7.26m
    },
    new Product()
    {
        Name = "Long Island Ice Tea",
        Price = 6.87m
    },
    new Product()
    {
        Name = "Duck - Fat",
        Price = 0.41m
    },
    new Product()
    {
        Name = "Food Colouring - Red",
        Price = 8.09m
    },
    new Product()
    {
        Name = "Cinnamon - Ground",
        Price = 3.46m
    },
    new Product()
    {
        Name = "Cheese - Taleggio D.o.p.",
        Price = 9.55m
    },
    new Product()
    {
        Name = "Nantucket - Pomegranate Pear",
        Price = 5.30m
    },
    new Product()
    {
        Name = "Ice Cream Bar - Hagen Daz",
        Price = 6.89m
    },
    new Product()
    {
        Name = "Tea - Honey Green Tea",
        Price = 0.22m
    },
    new Product()
    {
        Name = "Maintenance Removal Charge",
        Price = 5.37m
    },
    new Product()
    {
        Name = "Flavouring - Raspberry",
        Price = 2.45m
    },
    new Product()
    {
        Name = "Gingerale - Diet - Schweppes",
        Price = 2.74m
    },
    new Product()
    {
        Name = "Pepper - White, Whole",
        Price = 5.95m
    },
    new Product()
    {
        Name = "Snails - Large Canned",
        Price = 3.01m
    },
    new Product()
    {
        Name = "Mustard - Individual Pkg",
        Price = 2.83m
    },
    new Product()
    {
        Name = "Dill Weed - Fresh",
        Price = 7.82m
    },
    new Product()
    {
        Name = "Beef Wellington",
        Price = 1.68m
    },
    new Product()
    {
        Name = "Spring Roll Wrappers",
        Price = 4.40m
    },
    new Product()
    {
        Name = "Chervil - Fresh",
        Price = 8.62m
    },
    new Product()
    {
        Name = "Coffee - Dark Roast",
        Price = 4.20m
    },
    new Product()
    {
        Name = "Onions - Pearl",
        Price = 8.12m
    },
    new Product()
    {
        Name = "Grapes - Red",
        Price = 0.61m
    },
    new Product()
    {
        Name = "Wine - Sake",
        Price = 6.66m
    },
    new Product()
    {
        Name = "Bread Crumbs - Panko",
        Price = 9.09m
    },
    new Product()
    {
        Name = "Salt - Celery",
        Price = 6.40m
    },
    new Product()
    {
        Name = "Cod - Fillets",
        Price = 7.86m
    },
    new Product()
    {
        Name = "Coke - Classic, 355 Ml",
        Price = 6.68m
    },
    new Product()
    {
        Name = "Cheese - Fontina",
        Price = 7.80m
    },
    new Product()
    {
        Name = "Roe - Lump Fish, Red",
        Price = 8.23m
    },
    new Product()
    {
        Name = "Wine - Casablanca Valley",
        Price = 5.92m
    },
    new Product()
    {
        Name = "Kellogs All Bran Bars",
        Price = 6.44m
    },
    new Product()
    {
        Name = "Lentils - Red, Dry",
        Price = 7.75m
    },
    new Product()
    {
        Name = "Sobe - Cranberry Grapefruit",
        Price = 4.95m
    },
    new Product()
    {
        Name = "Durian Fruit",
        Price = 4.76m
    },
    new Product()
    {
        Name = "Tea Peppermint",
        Price = 7.86m
    },
    new Product()
    {
        Name = "Chickhen - Chicken Phyllo",
        Price = 4.45m
    },
    new Product()
    {
        Name = "Croissants Thaw And Serve",
        Price = 8.03m
    },
    new Product()
    {
        Name = "Numi - Assorted Teas",
        Price = 5.72m
    },
    new Product()
    {
        Name = "Wine - Prosecco Valdobiaddene",
        Price = 1.10m
    },
    new Product()
    {
        Name = "Burger Veggie",
        Price = 0.48m
    },
    new Product()
    {
        Name = "Tabasco Sauce, 2 Oz",
        Price = 2.87m
    },
    new Product()
    {
        Name = "Ice Cream - Super Sandwich",
        Price = 4.78m
    },
    new Product()
    {
        Name = "Cheese - Parmigiano Reggiano",
        Price = 4.37m
    },
    new Product()
    {
        Name = "Cabbage - Savoy",
        Price = 5.59m
    },
    new Product()
    {
        Name = "Coffee - French Vanilla Frothy",
        Price = 7.91m
    },
    new Product()
    {
        Name = "7up Diet, 355 Ml",
        Price = 0.75m
    },
    new Product()
    {
        Name = "Lentils - Red, Dry",
        Price = 1.50m
    },
    new Product()
    {
        Name = "Pepper - Pablano",
        Price = 4.45m
    },
    new Product()
    {
        Name = "Beer - Labatt Blue",
        Price = 2.86m
    },
    new Product()
    {
        Name = "Sproutsmustard Cress",
        Price = 7.54m
    },
    new Product()
    {
        Name = "Bread - Multigrain, Loaf",
        Price = 6.02m
    },
    new Product()
    {
        Name = "Beef Flat Iron Steak",
        Price = 4.38m
    },
    new Product()
    {
        Name = "Flower - Daisies",
        Price = 6.74m
    },
    new Product()
    {
        Name = "Carbonated Water - Peach",
        Price = 9.79m
    },
    new Product()
    {
        Name = "Veal - Kidney",
        Price = 2.46m
    },
    new Product()
    {
        Name = "Sobe - Tropical Energy",
        Price = 7.13m
    },
    new Product()
    {
        Name = "Cheese - Shred Cheddar / Mozza",
        Price = 8.43m
    },
    new Product()
    {
        Name = "Marzipan 50/50",
        Price = 2.61m
    },
    new Product()
    {
        Name = "Bag Stand",
        Price = 9.87m
    },
    new Product()
    {
        Name = "Salmon - Atlantic, No Skin",
        Price = 8.67m
    },
    new Product()
    {
        Name = "Lamb - Leg, Bone In",
        Price = 7.49m
    },
    new Product()
    {
        Name = "Paper - Brown Paper Mini Cups",
        Price = 1.22m
    },
    new Product()
    {
        Name = "Beef - Tongue, Fresh",
        Price = 9.63m
    },
    new Product()
    {
        Name = "Spinach - Packaged",
        Price = 0.09m
    },
    new Product()
    {
        Name = "Rice - Basmati",
        Price = 7.30m
    },
    new Product()
    {
        Name = "The Pop Shoppe - Root Beer",
        Price = 9.60m
    },
    new Product()
    {
        Name = "Chicken - Soup Base",
        Price = 7.96m
    },
    new Product()
    {
        Name = "Salmon - Atlantic, Skin On",
        Price = 6.29m
    },
    new Product()
    {
        Name = "Sambuca - Opal Nera",
        Price = 8.53m
    },
    new Product()
    {
        Name = "Dr. Pepper - 355ml",
        Price = 1.04m
    },
    new Product()
    {
        Name = "Foil Cont Round",
        Price = 7.34m
    },
    new Product()
    {
        Name = "Sauce - Hoisin",
        Price = 8.26m
    },
    new Product()
    {
        Name = "Syrup - Monin, Swiss Choclate",
        Price = 8.40m
    },
    new Product()
    {
        Name = "Shrimp - 100 / 200 Cold Water",
        Price = 8.11m
    },
    new Product()
    {
        Name = "Cup Translucent 9 Oz",
        Price = 0.77m
    },
    new Product()
    {
        Name = "Soup Campbells Turkey Veg.",
        Price = 6.17m
    },
    new Product()
    {
        Name = "Pasta - Spaghetti, Dry",
        Price = 9.81m
    },
    new Product()
    {
        Name = "Tomatoes - Roma",
        Price = 8.66m
    },
    new Product()
    {
        Name = "Capers - Pickled",
        Price = 8.01m
    },
    new Product()
    {
        Name = "Longos - Lasagna Veg",
        Price = 6.66m
    },
    new Product()
    {
        Name = "Lid - 0090 Clear",
        Price = 1.00m
    },
    new Product()
    {
        Name = "Wine - Cave Springs Dry Riesling",
        Price = 7.42m
    },
    new Product()
    {
        Name = "Coke - Classic, 355 Ml",
        Price = 3.93m
    },
    new Product()
    {
        Name = "Wine - Red, Mouton Cadet",
        Price = 9.78m
    },
    new Product()
    {
        Name = "Bar Energy Chocchip",
        Price = 0.49m
    },
    new Product()
    {
        Name = "Asparagus - Mexican",
        Price = 8.39m
    },
    new Product()
    {
        Name = "Bread - Pumpernickel",
        Price = 5.26m
    },
    new Product()
    {
        Name = "Wine - Magnotta - Cab Sauv",
        Price = 0.66m
    },
    new Product()
    {
        Name = "Crab - Meat Combo",
        Price = 3.91m
    }
};

            await unitOfWork.Repository<Product>().AddRangeAsync(products);
        }
    }
}