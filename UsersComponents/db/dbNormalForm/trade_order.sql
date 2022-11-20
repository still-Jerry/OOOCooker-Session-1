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
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `OrderStatus` int NOT NULL,
  `OrderDeliveryDate` datetime NOT NULL,
  `OrderPickupPoint` int NOT NULL,
  `kode` int NOT NULL,
  `user` int NOT NULL,
  `OrderDate` datetime NOT NULL,
  `Products` int NOT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `Order Status` (`OrderStatus`),
  KEY `OrderPickupPoint_idx` (`OrderPickupPoint`),
  KEY `user_idx` (`user`),
  KEY `Products_idx` (`Products`),
  CONSTRAINT `OrderPickupPoint` FOREIGN KEY (`OrderPickupPoint`) REFERENCES `orderpickuppoint` (`id`),
  CONSTRAINT `OrderStatus` FOREIGN KEY (`OrderStatus`) REFERENCES `orderstatus` (`id`),
  CONSTRAINT `Products` FOREIGN KEY (`Products`) REFERENCES `orderproduct` (`OrderID`),
  CONSTRAINT `user` FOREIGN KEY (`user`) REFERENCES `user` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,1,'2022-05-09 00:00:00',1,211,1,'2022-05-03 00:00:00',21),(2,2,'2022-05-10 00:00:00',3,212,2,'2022-05-04 00:00:00',22),(3,1,'2022-05-11 00:00:00',5,213,3,'2022-05-05 00:00:00',23),(4,1,'2022-05-12 00:00:00',6,214,4,'2022-05-06 00:00:00',24),(5,2,'2022-05-13 00:00:00',7,215,4,'2022-05-07 00:00:00',25),(6,1,'2022-05-14 00:00:00',10,216,4,'2022-05-08 00:00:00',26),(7,1,'2022-05-15 00:00:00',11,217,5,'2022-05-09 00:00:00',27),(8,1,'2022-05-16 00:00:00',20,218,1,'2022-05-10 00:00:00',28),(9,2,'2022-05-17 00:00:00',30,219,2,'2022-05-11 00:00:00',29),(10,1,'2022-05-18 00:00:00',33,220,3,'2022-05-12 00:00:00',30);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-20  8:18:50
