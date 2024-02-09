-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 09. Feb 2024 um 12:13
-- Server-Version: 10.4.18-MariaDB
-- PHP-Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `kleidershop`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellinformation`
--

CREATE TABLE `bestellinformation` (
  `BestellID` int(11) NOT NULL,
  `ProduktID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellung`
--

CREATE TABLE `bestellung` (
  `BestellID` int(11) NOT NULL,
  `Datum` date DEFAULT NULL,
  `Gesamtsumme` decimal(10,2) DEFAULT NULL,
  `Zahlungsmethode` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `produkt`
--

CREATE TABLE `produkt` (
  `ProduktID` int(11) NOT NULL,
  `Produktname` varchar(255) DEFAULT NULL,
  `Artikelnummer` varchar(50) DEFAULT NULL,
  `Beschreibung` text DEFAULT NULL,
  `Preis` decimal(10,2) DEFAULT NULL,
  `Kategorie` varchar(50) DEFAULT NULL,
  `Verfügbarkeit` tinyint(1) DEFAULT NULL,
  `Lagermenge` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `produkt`
--

INSERT INTO `produkt` (`ProduktID`, `Produktname`, `Artikelnummer`, `Beschreibung`, `Preis`, `Kategorie`, `Verfügbarkeit`, `Lagermenge`) VALUES
(1, 'Beispielprodukt', '12345', 'Dies ist ein Beispielprodukt.', '19.99', 'Beispielkategorie', 1, 100),
(2, 'Beispielprodukt2', '54321', 'Dies ist ein weiteres Beispielprodukt.', '29.99', 'Beispielkategorie2', 1, 150),
(3, 'Beispielprodukt3', '98765', 'Ein drittes Beispielprodukt für Testzwecke.', '39.99', 'Beispielkategorie3', 1, 200),
(4, 'Beispielprodukt4', '13579', 'Noch ein Beispielprodukt für die Datenbank.', '49.99', 'Beispielkategorie4', 1, 250),
(5, 'Beispielprodukt5', '24680', 'Ein weiteres Beispielprodukt für die Datenbank.', '59.99', 'Beispielkategorie5', 1, 300),
(6, 'Beispielprodukt6', '13579', 'Ein sechstes Beispielprodukt für Testzwecke.', '69.99', 'Beispielkategorie6', 1, 350),
(7, 'Beispielprodukt7', '98765', 'Ein siebtes Beispielprodukt für die Datenbank.', '79.99', 'Beispielkategorie7', 1, 400),
(8, 'Beispielprodukt8', '54321', 'Ein achtes Beispielprodukt für Testzwecke.', '89.99', 'Beispielkategorie8', 1, 450),
(9, 'Beispielprodukt9', '10101', 'Ein neuntes Beispielprodukt für die Datenbank.', '99.99', 'Beispielkategorie9', 1, 500);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `bestellinformation`
--
ALTER TABLE `bestellinformation`
  ADD PRIMARY KEY (`BestellID`,`ProduktID`),
  ADD KEY `ProduktID` (`ProduktID`);

--
-- Indizes für die Tabelle `bestellung`
--
ALTER TABLE `bestellung`
  ADD PRIMARY KEY (`BestellID`);

--
-- Indizes für die Tabelle `produkt`
--
ALTER TABLE `produkt`
  ADD PRIMARY KEY (`ProduktID`);

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `bestellinformation`
--
ALTER TABLE `bestellinformation`
  ADD CONSTRAINT `bestellinformation_ibfk_1` FOREIGN KEY (`BestellID`) REFERENCES `bestellung` (`BestellID`),
  ADD CONSTRAINT `bestellinformation_ibfk_2` FOREIGN KEY (`ProduktID`) REFERENCES `produkt` (`ProduktID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
