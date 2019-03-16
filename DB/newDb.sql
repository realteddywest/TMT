create database TMT_Database;

use TMT_Database;

create table EvilnessFactors (
Id int identity primary key,
Name varchar(30)
);

create table Countries (
Id int identity primary key,
Name varchar(30) unique
);

create table Towns (
Id int identity primary key,
Name varchar(30) unique,
CountryCode int,
constraint fk_towns_countries
foreign key (CountryCode)
references Countries (Id)
);

create table Criminals (
Id int identity primary key,
Name varchar(50),
Nickname varchar(50),
TownId int,
constraint fk_criminals_countries
foreign key (TownId)
references Towns (Id),
Crime varchar(100),
Sentence varchar(100),
Status varchar(50),
EvilnessFactorId int,
constraint fk_criminals_evilnessfactor
foreign key (EvilnessFactorId)
references EvilnessFactors (id)
);

create table Agents (
Id int identity primary key,
Name varchar(30),
Nickname varchar(50),
Age int,
TownId int,
constraint fk_agents_towns
foreign key (TownId)
references Towns(Id)
);

create table AgentsCriminals(
AgentId int,
constraint fk_agentscriminals_agents
foreign key (AgentId)
references Agents(Id),
CriminalId int,
constraint fk_agentscriminals_criminals
foreign key (CriminalId)
references Criminals(Id),
constraint pk_AgentsCriminals 
primary key(AgentId, CriminalId)
);


insert into Countries(name) values
('USA'),
('Colombia'),
('Mexico'),
('Bulgaria'),
('Great Britain'),
('Germany'),
('Switzerland'),
('Canada'),
('Australia'),
('New Zealand'),
('Austria'),
('Italy'),
('France'),
('Finland'),
('Spain'),
('Egypt'),
('Russia'),
('China'),
('Japan'),
('Peru');


insert into Towns (Name, CountryCode) values
('Los Angeles', 1),
('Burlington', 1),
('San Francisco', 1),
('New York', 1),
('Rionegro', 2),
('Velingrad', 4),
('Honolulu', 1),
('Santa Monica', 1),
('London', 5),
('Edinburgh', 5),
('Chicago', 1),
('Berlin', 6),
('Munich', 6),
('Zurich', 7),
('West Aliis', 1),
('Bern', 7),
('Ottawa', 8),
('Toronto', 8),
('Sydney', 9),
('Badiraguato', 3),
('Wellington', 10),
('Vienna', 11),
('Milano', 12),
('National City', 1),
('Paris', 13);

insert into EvilnessFactors (Name) values
('Super Good'),
('Good'),
('Bad'), 
('Evil'),
('Super Evil');

insert into Criminals (Name, Nickname, TownId, Crime, Sentence, Status, EvilnessFactorId) values
('Ted Bundy', 'Lady Killer', 2, '30 killings, kidnappings, rapes', 'Execution', 'Dead - executed', 5),
('Pablo Escobar', 'El Doctor', 5, 'Cocaine distribution, murders', '5 years imprisonment', 'Dead - shot', 5),
('Maria Malcheva', 'Mimi', 6, 'Larceny of 180 fluffy unicorns from a toy store', 
'1 month with no phone and restricted access to chocolate', 'Alive', 3),
('Andrew Cunanan', 'N/A', 24, 'Murder of 5 people, including Gianni Versace', 'N/A', 'Dead - suicide', 5),
('Alish Alishov', 'Mr. Hacker', 6, 'Being too good at teaching', 'Higher wage', 'Alive', 1),
('Victor Perkins', 'Vector', 1, 'Stealing the Great Pyramid of Giza', 
'Propelled out of the Earth and left marooned on the Moon', 'Alive', 3),
('Ernesto Fonseca Carrillo', 'Don Neto', 20, 'Drug distribution, money laundering, extortion, torture, murders', 
'40 years of imprisonment', 'Alive', 5),
('Hristo Spasov', 'N/A', 6, 'Murder', 'Yet to be known', 'Alive', 5),
('Jeffrey Dahmer', 'The Milwaukee Cannibal', 15, '17 murders, dismembering of bodies', 
'15 life terms of imprisonment - 957 years total', 'Dead - killed by an inmate', 5),
('John Wayne Gacy', 'N/A', 11, '33 murders, rapes', 'Death sentence', 'Dead - executed by lethal injection', 5),
('Stefan Papanov', 'Mr. Papanov', 6, 'Being too happy', 'Higher wage', 'Alive', 5),
('Nikolai Kitov', 'King Kong', 6, 'Alcoholism', 'N/A', 'Alive', 2);


insert into Agents (Name, Nickname, Age, TownId) values
('Temenuzhka Gadzheva', 'Nuzhkotemka', 18, 4),                       
('Teodora Taslakova', 'Teddy West', 17, 3),
('Daniel Craig', 'Agent 007', 51, 1),
('Viliyana Savova', 'Vili', 17, 4),
('Alison Keller', 'Alison', 22, 7),
('Jesus Ortega', 'Soos',  31, 3),
('Mira Dasheva', 'Ms. FBI', 17,13),
('Fernando Diaz', 'Nando', 46, 1),
('Dwayne Johnson', 'The Rock', 46, 1),
('Omar Burleson', 'Omar', 51, 17),
('Tom Austen', 'Tom', 30, 18),
('Georgi Nikolov', 'Super Gosho', 34, 12);


