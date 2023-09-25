CREATE DATABASE Netflix;
USE Netflix;



Create table Utenti
(
id int primary key identity(1,1),
nome_utente varchar(50),
passw varchar(255),
ruolo varchar(50)
);

Create table DettagliUtente
(
id int primary key IDENTITY(1,1),
idUtenti int,
Nome varchar(50),
Cognome varchar(50),
DataNascita Date,
Indirizzo Varchar(50),
NumeroTelefono varchar(20),
FOREIGN KEY (idUtenti) REFERENCES Utenti(id)
);

create table Film
(
id int primary key identity(1,1),
titolo varchar(50),
genere varchar(50),
uscita int,
descrizione text,
regista varchar(50),
locandina text
);
create table PreferitiFilm
(
id int primary key identity(1,1),
idUtente int,
idFilm int,
Foreign key (idUtente) references Utenti(id),
Foreign key (idFilm) references Film(id)
);
create table DettagliFilm
(
id int primary key identity(1,1),
descrizione text,
URLVideo text,
attoreProtagonista varchar(50),
idFilm Int,
FOREIGN KEY (idFilm) REFERENCES film(id)
);


create table SerieTv
(
id int primary key identity(1,1),
titolo varchar(50),
genere varchar(50),
uscita int,
descrizione text,
regista varchar(50),
locandina text
);

create table DettagliSerieTV
(
id INT Primary key IDENTITY(1,1),
idSerieTv int,
URLEpisodio text,
URLTrailer text,
NumeroStagioni int,
NumeroEpisodi int,
foreign key (idSerieTv) references SerieTv(id)
)
create table PreferitiSerieTv
(
id int primary key identity(1,1),
idUtente int,
idSerieTv int,
Foreign key (idUtente) references Utenti(id),
Foreign key (idSerieTv) references SerieTV(id)
);



-- Inserisci dati nella tabella Utenti
INSERT INTO Utenti (nome_utente, passw, ruolo)
VALUES
('user1', HASHBYTES('Sha2_512','hashed_password_1'), 'admin'),
('user2', HASHBYTES('Sha2_512','hashed_password_2'), 'user'),
('user3', HASHBYTES('Sha2_512','hashed_password_3'), 'user');

-- Inserisci dati nella tabella DettagliUtente
INSERT INTO DettagliUtente (idUtenti, Nome, Cognome, DataNascita, Indirizzo, NumeroTelefono)
VALUES
(1, 'John', 'Doe', '1990-01-15', '123 Main St', '555-123-4567'),
(2, 'Jane', 'Smith', '1985-03-20', '456 Elm St', '555-987-6543'),
(3, 'Bob', 'Johnson', '1995-07-10', '789 Oak St', '555-111-2233');

-- Inserisci dati nella tabella Film
INSERT INTO Film (titolo, genere, uscita, descrizione, regista, locandina)
VALUES
('Film 1', 'Azione', 2022, 'Descrizione del Film 1', 'Regista 1', 'locandina1.jpg'),
('Film 2', 'Commedia', 2021, 'Descrizione del Film 2', 'Regista 2', 'locandina2.jpg'),
('Film 3', 'Drammatico', 2023, 'Descrizione del Film 3', 'Regista 3', 'locandina3.jpg');

-- Inserisci dati nella tabella PreferitiFilm
INSERT INTO PreferitiFilm (idUtente, idFilm)
VALUES
(1, 1),
(1, 2),
(2, 2),
(3, 3);

-- Inserisci dati nella tabella DettagliFilm
INSERT INTO DettagliFilm (descrizione, urlVideo, attoreProtagonista, idFilm)
VALUES
('Dettagli per Film 1', 'https://www.example.com/video1', 'Attore 1', 1),
('Dettagli per Film 2', 'https://www.example.com/video2', 'Attore 2', 2),
('Dettagli per Film 3', 'https://www.example.com/video3', 'Attore 3', 3);

-- Inserisci dati nella tabella SerieTv
INSERT INTO SerieTv (titolo, genere, uscita, descrizione, regista, locandina)
VALUES
('Serie TV 1', 'Drammatico', 2022, 'Descrizione della Serie TV 1', 'Regista A', 'locandina_serie1.jpg'),
('Serie TV 2', 'Commedia', 2020, 'Descrizione della Serie TV 2', 'Regista B', 'locandina_serie2.jpg'),
('Serie TV 3', 'Sci-Fi', 2023, 'Descrizione della Serie TV 3', 'Regista C', 'locandina_serie3.jpg');

-- Inserisci dati nella tabella DettagliSerieTV
INSERT INTO DettagliSerieTV (idSerieTv, URLEpisodio, URLTrailer, NumeroStagioni, NumeroEpisodi)
VALUES
(1, 'https://www.example.com/episodio1', 'https://www.example.com/trailer1', 3, 24),
(2, 'https://www.example.com/episodio2', 'https://www.example.com/trailer2', 4, 30),
(3, 'https://www.example.com/episodio3', 'https://www.example.com/trailer3', 2, 16);

-- Inserisci dati nella tabella PreferitiSerieTv
INSERT INTO PreferitiSerieTv (idUtente, idSerieTv)
VALUES
(1, 1),
(1, 2),
(2, 2),
(3, 3);




select * from Utenti
select * from DettagliSerieTV
select * from DettagliUtente
select * from PreferitiFilm
select * from PreferitiSerieTv
select * from Film
select * from SerieTv






drop table Utenti
drop table DettagliSerieTV
drop table DettagliUtente
drop table SerieTv
drop table PreferitiFilm
drop table PreferitiSerieTv
drop table Film
drop table DettagliFilm

