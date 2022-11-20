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
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductArticleNumber` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `ProductName` text NOT NULL,
  `ProductDescription` text NOT NULL,
  `ProductCategory` text NOT NULL,
  `ProductPhoto` text NOT NULL,
  `ProductManufacturer` text NOT NULL,
  `ProductCost` decimal(19,2) NOT NULL,
  `ProductDiscountAmount` tinyint DEFAULT NULL,
  `ProductQuantityInStock` int NOT NULL,
  `ProductStatus` text,
  `ProductProvider` text NOT NULL,
  `ProductMaxDiscount` tinyint DEFAULT NULL,
  `ProductUnit` text NOT NULL,
  PRIMARY KEY (`ProductArticleNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES ('F745K4','Столовые приборы для салата','Столовые приборы для салата Orskov Lava, 2шт','наборы','D735T5.jpg','Mayer & Boch',2000.00,3,5,NULL,'LeroiMerlin',50,'пач.'),('F839R6','Ложка чайная','Ложка чайная DORIA Eternum','Ложки','','Doria',400.00,2,6,NULL,'Максидом',15,'шт.'),('G387Y6','Ложка столовая','Ложка столовая DORIA L=195/60 мм Eternum','Ложки','G387Y6.jpg','Doria',441.00,4,23,NULL,'Максидом',5,'шт.'),('H384H3','Набор столовых приборов','Набор столовых приборов для торта Palette 7 предметов серебристый','наборы','H384H3.jpg','Apollo',600.00,11,9,NULL,'Максидом',15,'шт.'),('H495H6','Набор стейковых ножей','Набор стейковых ножей 4 пр. в деревянной коробке','ножи','','Mayer & Boch',7000.00,2,15,NULL,'LeroiMerlin',15,'шт.'),('I022Mn','Ложка-поварёшка','Самая лучшая ложечка на свете!','Ложки','D735T5.jpg','Дайдо-ложечка',15.90,14,100,NULL,'Лужайкин',90,'уп.'),('K437E6','Набор вилок','Набор вилок столовых APOLLO \"Aurora\"\" 3шт.\"','наборы','K437E6.jpg','Apollo',530.00,3,16,NULL,'Максидом',5,'шт.'),('L593H5','набор ножей','Набор ножей Mayer & Boch, 4 шт','наборы','','Mayer & Boch',1300.00,5,14,NULL,'Максидом',25,'шт.'),('N493G6','Набор для серверовки','Набор для сервировки сыра Select','наборы','','Smart Home',2550.00,4,6,NULL,'LeroiMerlin',15,'шт.'),('R836H6','Набор  столовых ножей','Attribute Набор столовых ножей Baguette 2 предмета серебристый','ножи','R836H6.jpg','Attribute',250.00,3,16,NULL,'LeroiMerlin',5,'шт.'),('S394J5','Набор чайных ложек','Attribute Набор чайных ложек Chaplet 3 предмета серебристый','наборы','','Attribute',170.00,3,4,NULL,'LeroiMerlin',5,'шт.'),('S395B5','Нож для стейка','Нож для стейка 11,5 см серебристый/черный','ножи','','Apollo',600.00,4,15,NULL,'LeroiMerlin',10,'шт.'),('T793T4','Набор ложек','Набор столовых ложек Baguette 3 предмета серебристый','Ложки','T793T4.jpg','Attribute',250.00,3,16,NULL,'LeroiMerlin',10,'шт.'),('V026J4','набор ножей','абор ножей для стейка и пиццы Swiss classic 2 шт. желтый','наборы','','Apollo',700.00,3,9,NULL,'Максидом',15,'шт.'),('V403G6','Ложка чайная','Ложка чайная DORIA Eternum','Ложки','','Doria',600.00,5,24,NULL,'Максидом',15,'шт.'),('V727Y6','Набор десертных ложек','Набор десертных ложек на подставке Размер: 7*7*15 см','Ложки','','Mayer & Boch',3000.00,4,8,NULL,'LeroiMerlin',10,'шт.'),('W295Y5','Сервировочный набор для торта','Набор сервировочный для торта \"Розанна\"\"\"','наборы','','Attribute',1100.00,2,16,NULL,'Максидом',15,'шт.'),('W405G6','Набор столовых приборов','Набор сервировочных столовых вилок Цветы','наборы','','Attribute',1300.00,3,4,NULL,'LeroiMerlin',25,'шт.'),('А112Т4','Набор вилок','Набор столовых вилок Davinci, 20 см 6 шт.','Вилки','А112Т4.jpg','Davinci',1600.00,2,6,NULL,'Максидом',30,'шт.');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-20  8:18:20
