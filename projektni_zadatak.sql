-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: localhost    Database: projektni_zadatak
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `artikal`
--

DROP TABLE IF EXISTS `artikal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `artikal` (
  `artikal_id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv_artikla` varchar(100) DEFAULT NULL,
  `vrsta_artikla` varchar(50) DEFAULT NULL,
  `cijena` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`artikal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artikal`
--

LOCK TABLES `artikal` WRITE;
/*!40000 ALTER TABLE `artikal` DISABLE KEYS */;
INSERT INTO `artikal` VALUES (1,'Laptop','tehnika',1200.00),(2,'Monitor','tehnika',300.00),(3,'Tastatura','tehnika',45.00),(4,'Miš','tehnika',20.00),(5,'Slušalice','tehnika',40.00),(6,'USB HUB','tehnika',15.00),(7,'Web kamera','tehnika',80.00),(8,'Eksterni disk','tehnika',120.00),(9,'RAM memorija','tehnika',90.00),(10,'Procesor','tehnika',350.00),(11,'Grafička kartica','tehnika',600.00),(12,'Napajanje','tehnika',100.00),(13,'Kućište','tehnika',70.00),(14,'Hladnjak','tehnika',50.00),(15,'Printer','tehnika',200.00),(16,'Punjač','tehnika',40.00);
/*!40000 ALTER TABLE `artikal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kupac`
--

DROP TABLE IF EXISTS `kupac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kupac` (
  `kupac_id` int(11) NOT NULL AUTO_INCREMENT,
  `ime` varchar(50) DEFAULT NULL,
  `prezime` varchar(50) DEFAULT NULL,
  `grad` varchar(50) DEFAULT NULL,
  `adresa` varchar(100) DEFAULT NULL,
  `telefon` varchar(20) DEFAULT NULL,
  `user` varchar(50) DEFAULT NULL,
  `pass` varchar(255) DEFAULT NULL,
  `tip_korisnika` int(11) DEFAULT 0,
  PRIMARY KEY (`kupac_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kupac`
--

LOCK TABLES `kupac` WRITE;
/*!40000 ALTER TABLE `kupac` DISABLE KEYS */;
INSERT INTO `kupac` VALUES (1,'Danis','Demirović','Sarajevo','Aleja Lipa 5','061123456','danis','766957c4deefde9b08b0b2c9ced8f21c',1),(2,'Adnan','Bešić','Sarajevo','Alipašina 12','061111111','adnan.besic','aa3870525fd37551c80b22a5b7293892',0),(3,'Belma','Hadžić','Mostar','Radićeva 5','062222222','belma.hadzic','5bedbc45e8e8dcad7467de8f798e5ae8',0),(4,'Denis','Kovačević','Tuzla','Slatina bb','063333333','denis.kovacevic','719f67e6e85b355b7cd048f82c2a9a09',0),(5,'Emina','Selimović','Zenica','Bosanska 8','064444444','emina.selimovic','a969dab4226a2f2432782a4ddb318ffa',0),(6,'Faruk','Šabanović','Banja Luka','Kralja Petra 3','065555555','faruk.sabanovic','c0998678733c286a46d04d1c385720bc',0),(7,'Hana','Karamehmedović','Bihać','Bosanska 15','066666666','hana.karam','3b7972d6e14381a8f234aaf14c813d2e',0),(8,'Jasmin','Turković','Bijeljina','Karađorđeva 7','067777777','jasmin.turkovic','c677901e8baa1f96025f0938a4cd0423',0),(9,'Lejla','Halilović','Brčko','Hasanova 9','068888888','lejla.halilovic','4aa7d14fb716955a52b6cc4ddabb0615',0),(10,'Mirza','Osmanović','Prijedor','Sanska 22','069999999','mirza.osmanovic','c6c4cabe9fa81bb02e3825151703288b',0),(11,'Nerma','Dautović','Doboj','Vidovdanska 4','060000000','nerma.dautovic','7467718ac550b725a55a75ef2575f193',0),(12,'Lamija','Mujčić','Sarajevo','Azize Šaćirbegović','061 758 947','lamija','dbf4195c15833cf29a18f3079067950e',0);
/*!40000 ALTER TABLE `kupac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `narudzbenica`
--

DROP TABLE IF EXISTS `narudzbenica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `narudzbenica` (
  `narudzbenica_id` int(11) NOT NULL AUTO_INCREMENT,
  `kupac_id` int(11) DEFAULT NULL,
  `datum_narudzbe` date DEFAULT NULL,
  PRIMARY KEY (`narudzbenica_id`),
  KEY `kupac_id` (`kupac_id`),
  CONSTRAINT `narudzbenica_ibfk_1` FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `narudzbenica`
--

LOCK TABLES `narudzbenica` WRITE;
/*!40000 ALTER TABLE `narudzbenica` DISABLE KEYS */;
INSERT INTO `narudzbenica` VALUES (1,1,'2026-04-01'),(2,2,'2026-04-02'),(3,3,'2026-04-05'),(4,4,'2026-04-10'),(5,5,'2026-04-15'),(6,1,'2026-04-20');
/*!40000 ALTER TABLE `narudzbenica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `skladiste`
--

DROP TABLE IF EXISTS `skladiste`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `skladiste` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `artikal_id` int(11) DEFAULT NULL,
  `kolicina_stanje` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `skladiste_ibfk_1` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `skladiste`
--

LOCK TABLES `skladiste` WRITE;
/*!40000 ALTER TABLE `skladiste` DISABLE KEYS */;
INSERT INTO `skladiste` VALUES (1,1,12),(2,2,8),(3,3,15),(4,4,20),(5,5,12),(6,6,25),(7,7,5),(8,8,7),(9,9,30),(10,10,4),(11,11,3),(12,12,10),(13,13,6),(14,14,8),(15,15,5),(16,16,1);
/*!40000 ALTER TABLE `skladiste` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stavka_narudzbenice`
--

DROP TABLE IF EXISTS `stavka_narudzbenice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int(11) NOT NULL AUTO_INCREMENT,
  `narudzbenica_id` int(11) DEFAULT NULL,
  `artikal_id` int(11) DEFAULT NULL,
  `kolicina` int(11) DEFAULT NULL,
  PRIMARY KEY (`stavka_id`),
  KEY `narudzbenica_id` (`narudzbenica_id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_1` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_2` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stavka_narudzbenice`
--

LOCK TABLES `stavka_narudzbenice` WRITE;
/*!40000 ALTER TABLE `stavka_narudzbenice` DISABLE KEYS */;
INSERT INTO `stavka_narudzbenice` VALUES (46,1,1,2),(47,1,2,1),(48,2,3,1),(49,2,4,2),(50,3,5,1),(51,3,6,3),(52,4,7,1),(53,4,8,1),(54,5,9,2),(55,5,10,1),(56,6,11,1),(57,6,12,2);
/*!40000 ALTER TABLE `stavka_narudzbenice` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-04-29 22:45:05
