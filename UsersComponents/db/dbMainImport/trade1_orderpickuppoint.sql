CREATE DATABASE  IF NOT EXISTS `trade1` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `trade1`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: trade1
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `orderpickuppoint`
--

DROP TABLE IF EXISTS `orderpickuppoint`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderpickuppoint` (
  `idOrderPickupPoint` int NOT NULL,
  `addres` varchar(45) NOT NULL,
  PRIMARY KEY (`idOrderPickupPoint`),
  UNIQUE KEY `addres_UNIQUE` (`addres`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderpickuppoint`
--

LOCK TABLES `orderpickuppoint` WRITE;
/*!40000 ALTER TABLE `orderpickuppoint` DISABLE KEYS */;
INSERT INTO `orderpickuppoint` VALUES (29,'125061, г. Талнах, ул. Подгорная, 8'),(6,'125703, г. Талнах, ул. Партизанская, 49'),(5,'125837, г. Талнах, ул. Шоссейная, 40'),(36,'190949, г. Талнах, ул. Мичурина, 26'),(1,'344288, г. Талнах, ул. Чехова, 1'),(16,'394060, г.Талнах, ул. Фрунзе, 43'),(3,'394242, г. Талнах, ул. Коммунистическая, 43'),(13,'394782, г. Талнах, ул. Чехова, 3'),(20,'400562, г. Талнах, ул. Зеленая, 32'),(27,'410172, г. Талнах, ул. Северная, 13'),(22,'410542, г. Талнах, ул. Светлая, 46'),(17,'410661, г. Талнах, ул. Школьная, 50'),(28,'420151, г. Талнах, ул. Вишневая, 32'),(32,'426030, г. Талнах, ул. Маяковского, 44'),(24,'443890, г. Талнах, ул. Коммунистическая, 1'),(33,'450375, г. Талнах ул. Клубная, 44'),(15,'450558, г. Талнах, ул. Набережная, 30'),(12,'450983, г.Талнах, ул. Комсомольская, 26'),(9,'454311, г.Талнах, ул. Новая, 19'),(14,'603002, г. Талнах, ул. Дзержинского, 28'),(11,'603036, г. Талнах, ул. Садовая, 4'),(25,'603379, г. Талнах, ул. Спортивная, 46'),(26,'603721, г. Талнах, ул. Гоголя, 41'),(2,'614164, г.Талнах,  ул. Степная, 30'),(21,'614510, г. Талнах, ул. Маяковского, 47'),(8,'614611, г. Талнах, ул. Молодежная, 50'),(31,'614753, г. Талнах, ул. Полевая, 35'),(23,'620839, г. Талнах, ул. Цветочная, 8'),(7,'625283, г. Талнах, ул. Победы, 46'),(34,'625560, г. Талнах, ул. Некрасова, 12'),(18,'625590, г. Талнах, ул. Коммунистическая, 20'),(19,'625683, г. Талнах, ул. 8 Марта'),(35,'630201, г. Талнах, ул. Комсомольская, 17'),(30,'630370, г. Талнах, ул. Шоссейная, 24'),(10,'660007, г.Талнах, ул. Октябрьская, 19'),(4,'660540, г. Талнах, ул. Солнечная, 25');
/*!40000 ALTER TABLE `orderpickuppoint` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-20  8:18:19
