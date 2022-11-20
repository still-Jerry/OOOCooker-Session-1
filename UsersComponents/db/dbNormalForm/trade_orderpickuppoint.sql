CREATE DATABASE  IF NOT EXISTS `trade` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `trade`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: trade
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
  `id` int NOT NULL,
  `Address` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderpickuppoint`
--

LOCK TABLES `orderpickuppoint` WRITE;
/*!40000 ALTER TABLE `orderpickuppoint` DISABLE KEYS */;
INSERT INTO `orderpickuppoint` VALUES (1,'344288 г. Вологда ул. Чехова 1'),(2,'614164 г.Вологда  ул. Степная 30'),(3,'394242 г. Вологда ул. Коммунистическая 43'),(4,'660540 г. Вологда ул. Солнечная 25'),(5,'125837 г. Вологда ул. Шоссейная 40'),(6,'125703 г. Вологда ул. Партизанская 49'),(7,'625283 г. Вологда ул. Победы 46'),(8,'614611 г. Вологда ул. Молодежная 50'),(9,'454311 г.Вологда ул. Новая 19'),(10,'660007 г.Вологда ул. Октябрьская 19'),(11,'603036 г. Вологда ул. Садовая 4'),(12,'450983 г.Вологда ул. Комсомольская 26'),(13,'394782 г. Вологда ул. Чехова 3'),(14,'603002 г. Вологда ул. Дзержинского 28'),(15,'450558 г. Вологда ул. Набережная 30'),(16,'394060 г.Вологда ул. Фрунзе 43'),(17,'410661 г. Вологда ул. Школьная 50'),(18,'625590 г. Вологда ул. Коммунистическая 20'),(19,'625683 г. Вологда ул. 8 Марта'),(20,'400562 г. Вологда ул. Зеленая 32'),(21,'614510 г. Вологда ул. Маяковского 47'),(22,'410542 г. Вологда ул. Светлая 46'),(23,'620839 г. Вологда ул. Цветочная 8'),(24,'443890 г. Вологда ул. Коммунистическая 1'),(25,'603379 г. Вологда ул. Спортивная 46'),(26,'603721 г. Вологда ул. Гоголя 41'),(27,'410172 г. Вологда ул. Северная 13'),(28,'420151 г. Вологда ул. Вишневая 32'),(29,'125061 г. Вологда ул. Подгорная 8'),(30,'630370 г. Вологда ул. Шоссейная 24'),(31,'614753 г. Вологда ул. Полевая 35'),(32,'426030 г. Вологда ул. Маяковского 44'),(33,'450375 г. Вологда ул. Клубная 44'),(34,'625560 г. Вологда ул. Некрасова 12'),(35,'630201 г. Вологда ул. Комсомольская 17'),(36,'190949 г. Вологда ул. Мичурина 26');
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

-- Dump completed on 2022-11-20  8:18:53
