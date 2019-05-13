CREATE DATABASE  IF NOT EXISTS `desaytest` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `desaytest`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: desaytest
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `propiedad`
--

DROP TABLE IF EXISTS `propiedad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `propiedad` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(255) NOT NULL,
  `ubicacion` varchar(255) NOT NULL,
  `cantHabitaciones` int(11) NOT NULL,
  `admin que cargo propiedad` varchar(10) NOT NULL,
  `fecha de carga` datetime NOT NULL,
  `admin que dio de baja propiedad` varchar(10) DEFAULT NULL,
  `fecha de baja` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `adminpropcargada_idx` (`admin que cargo propiedad`),
  KEY `adminpropdebaja_idx` (`admin que dio de baja propiedad`),
  CONSTRAINT `adminpropcargada` FOREIGN KEY (`admin que cargo propiedad`) REFERENCES `admins` (`token`),
  CONSTRAINT `adminpropdebaja` FOREIGN KEY (`admin que dio de baja propiedad`) REFERENCES `admins` (`token`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `propiedad`
--

LOCK TABLES `propiedad` WRITE;
/*!40000 ALTER TABLE `propiedad` DISABLE KEYS */;
/*!40000 ALTER TABLE `propiedad` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-13 19:02:56
