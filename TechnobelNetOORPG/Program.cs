using TechnobelNetOORPG.Models;

Warrior HulkHougan = new Warrior("Houlk", 120, 34);

Mage Gandoulf = new Mage("Gandoulf", 100, 20);

Hunter Degoulas = new Hunter("Degoulas", 20, 50);

Warrior Bouroumir = new Warrior("Bourourmir", 120, 34);

Warrior Thanous = new Warrior("Thanous", 2000, 34);


HulkHougan.AddAttacker(Gandoulf);
HulkHougan.AddAttacker(Degoulas);
HulkHougan.AddAttacker(Bouroumir);

HulkHougan.GroupAttack(Thanous);