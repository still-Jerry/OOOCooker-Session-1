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
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductArticleNumber` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `ProductName` text NOT NULL,
  `ProductDescription` text NOT NULL,
  `ProductCategory` int NOT NULL,
  `ProductPhoto` text NOT NULL,
  `ProductManufacturer` int NOT NULL,
  `ProductCost` decimal(19,4) NOT NULL,
  `ProductDiscountAmount_copy1` tinyint NOT NULL,
  `ProductMaxDiscountAmount` tinyint NOT NULL,
  `ProductQuantityInStock` int NOT NULL,
  `ProductStatus` int NOT NULL,
  `unit` varchar(10) NOT NULL,
  `ProductProvider` int NOT NULL,
  PRIMARY KEY (`ProductArticleNumber`),
  KEY `Product Provider_idx` (`ProductProvider`),
  KEY `Product Status_idx` (`ProductStatus`),
  KEY `Product Manufactured_idx` (`ProductManufacturer`),
  KEY `Product Category_idx` (`ProductCategory`),
  CONSTRAINT `Product Category` FOREIGN KEY (`ProductCategory`) REFERENCES `productcategory` (`id`),
  CONSTRAINT `Product Manufactured` FOREIGN KEY (`ProductManufacturer`) REFERENCES `productmanufacturer` (`id`),
  CONSTRAINT `Product Provider` FOREIGN KEY (`ProductProvider`) REFERENCES `productprovider` (`id`),
  CONSTRAINT `Product Status` FOREIGN KEY (`ProductStatus`) REFERENCES `productstatus` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (' M562Y7','Мультиметр','Мультиметр JTC 1227A автомобильный',5,'',8,14200.0000,3,5,12,1,'шт.',2),('A782R4','Аккумулятор','Аккумулятор автомобильный BIG FIGHTER 55р',3,'A782R4.jpg',3,4500.0000,2,30,24,1,'шт.',2),('B702T6','Домкрат','Домкрат ALCA 436000',6,'',12,2700.0000,2,10,3,1,'шт.',1),('D374E4','Съемник подшипников','Съемник AIRLINE AT-GP2-05',2,'D374E4.jpeg',2,1400.0000,3,20,2,1,'шт.',1),('D799T6','Съемник подшипников','Съемник для подшипников JTC 9000',2,'',8,1800.0000,2,25,6,1,'шт.',1),('E679R3','Автошампунь','Автошампунь GRASS 800026 Active Foam Truck',6,'',9,4000.0000,4,15,14,1,'шт.',1),('E932T8','Полироль','Полироль GRASS 125101 Black Brilliance',6,'',9,2100.0000,3,25,23,1,'шт.',1),('F026R4','Антифриз','Антифриз сине-зеленый MOBIL ANTIFREEZE EXTRA',6,'',13,530.0000,2,15,13,1,'шт.',1),('F938T5','Антифриз','Антифриз красный TCL LLC01212',6,'',7,1200.0000,4,15,34,1,'шт.',1),('H572T6','Парктроник','Парктроник AIRLINE APS-8L-02',3,'',2,2900.0000,5,15,12,1,'шт.',1),('K702L6','Ключ','Ключ JONNESWAY W233032 (30 / 32 мм)',4,'',5,1600.0000,3,15,9,1,'шт.',1),('K830R4','Колпак для колеса','Колпак для колеса AIRLINE Супер Астра R16 серебристый 2шт',3,'K830R4.jpg',2,915.0000,3,20,14,1,'уп.',2),('K849L6','Набор ключей','Набор ключей накидных STV 00-00010990 6шт.',4,'K849L6.jpeg',4,780.0000,2,15,23,1,'уп.',1),('L802Y5','Лопата','Лопата саперная AIRLINE AB-S-03',5,'',2,870.0000,4,5,23,1,'шт.',1),('O393R4','Отвертка','Отвертка JONNESWAY D04P2100',4,'O393R4.jpeg',5,460.0000,3,15,14,1,'шт.',1),('P023T2','Провода прикуривания','Провода прикуривания в сумке SMART CABLE 700 4,5м',3,'',10,3400.0000,2,20,6,1,'шт.',2),('P307T5','Провода прикуривания','Провода прикуривания в сумке EXPERT 400А 2,5м',3,'',14,700.0000,4,10,2,1,'шт.',2),('P439R4','Пассатижи','Пассатижи HAMMER Flex 601-050 160 мм (6 дюймов)',5,'',15,310.0000,3,5,34,1,'шт.',2),('S021R4','Адаптер для щеток','Адаптер для щеток стеклоочистителя ALCA Top Lock A/C блистер 2 шт',3,'',12,200.0000,2,3,13,1,'уп.',2),('S037R9','Щетка','Щётка AIRLINE AB-H-03',5,'S037R9.jpeg',2,740.0000,2,25,26,1,'шт.',1),('S625T5','Щетка','щетка стеклоочистителя ALCA Start 16\"/40см каркасная\"',3,'',12,249.0000,3,20,12,1,'шт.',2),('S826R4','Щетка','Щетка стеклоочистителя ALCA Super flat 19\"/48см бескаркасная\"',3,'',12,530.0000,4,2,28,1,'шт.',2),('S983R4','Щетка','Щетка с/о BOSCH ECO 65C 650мм каркасная',3,'S983R4.jpg',6,500.0000,4,15,8,1,'шт.',2),('T589T6','Термометр','Термометр ALCA 577000',5,'',12,1400.0000,2,10,3,1,'шт.',1),('V892T6','Свеча зажигания','Свеча зажигания CHAMPION IGP F7RTC',3,'',11,130.0000,3,5,21,1,'шт.',2),('Z326T9','Зарядное устройство','Устройство зарядное EXPERT ЗУ-300 6/12В 3,8А',1,'',14,2400.0000,3,15,14,1,'шт.',2),('Z374R3','Зарядное устройство','Зарядное устройство AIRLINE ACH-15A-08',1,'Z374R3.jpeg',2,4600.0000,2,25,14,1,'шт.',1),('Z469T7','Устройство пуско-зарядное','Устройство пуско-зарядное AIRLINE 12В 8000мАч 350А',1,'Z469T7.jpg',2,4000.0000,2,25,4,1,'шт.',2),('Z472R4','Зарядное устройство','Зарядное устройство KOLNER KBCН 4',1,'Z472R4.jpeg',1,1250.0000,4,30,0,0,'шт.',1),('Z782T5','Зажим','Зажим AIRLINE SA-400-P',1,'',2,290.0000,5,25,6,1,'уп.',1);
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

-- Dump completed on 2022-11-20  8:18:54
