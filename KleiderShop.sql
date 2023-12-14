-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 14. Dez 2023 um 12:42
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
CREATE DATABASE IF NOT EXISTS `kleidershop` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `kleidershop`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellinformation`
--

DROP TABLE IF EXISTS `bestellinformation`;
CREATE TABLE `bestellinformation` (
  `BestellID` int(11) NOT NULL,
  `ProduktID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `bestellung`
--

DROP TABLE IF EXISTS `bestellung`;
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

DROP TABLE IF EXISTS `produkt`;
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
