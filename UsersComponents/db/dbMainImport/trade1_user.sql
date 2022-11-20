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
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `UserSurname` varchar(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `UserPatronymic` varchar(100) NOT NULL,
  `UserLogin` text NOT NULL,
  `UserPassword` text NOT NULL,
  `UserRole` int NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `UserRole` (`UserRole`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`UserRole`) REFERENCES `role` (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Ефремов','Сергей','Пантелеймонович','loginDEppn2018','6}i+FD',1),(2,'Родионова','Тамара','Валентиновна','loginDElqb2018','RNynil',1),(3,'Миронова','Галина','Улебовна','loginDEydn2018','34I}X9',2),(4,'Сидоров','Роман','Иринеевич','loginDEijg2018','4QlKJW',2),(5,'Ситников','Парфений','Всеволодович','loginDEdpy2018','MJ0W|f',2),(6,'Никонов','Роман','Геласьевич','loginDEwdm2018','&PynqU',2),(7,'Щербаков','Владимир','Матвеевич','loginDEdup2018','JM+2{s',1),(8,'Кулаков','Мартын','Михаилович','loginDEhbm2018','9aObu4',2),(9,'Сазонова','Оксана','Лаврентьевна','loginDExvq2018','hX0wJz',3),(10,'Архипов','Варлам','Мэлорович','loginDErks2018','LQNSjo',2),(11,'Устинова','Ираида','Мэлоровна','loginDErvb2018','ceAf&R',3),(12,'Лукин','Георгий','Альбертович','loginDEulo2018','#ИМЯ?',3),(13,'Кононов','Эдуард','Валентинович','loginDEgfw2018','3c2Ic1',1),(14,'Орехова','Клавдия','Альбертовна','loginDEmxb2018','ZPXcRS',2),(15,'Яковлев','Яков','Эдуардович','loginDEgeq2018','&&Eim0',2),(16,'Воронов','Мэлс','Семёнович','loginDEkhj2018','Pbc0t{',1),(17,'Вишнякова','Ия','Данииловна','loginDEliu2018','32FyTl',1),(18,'Третьяков','Фёдор','Вадимович','loginDEsmf2018','{{O2QG',1),(19,'Макаров','Максим','Ильяович','loginDEutd2018','GbcJvC',2),(20,'Шубина','Маргарита','Анатольевна','loginDEpgh2018','YV2lvh',2),(21,'Блинова','Ангелина','Владленовна','loginDEvop2018','pBP8rO',2),(22,'Воробьёв','Владлен','Фролович','loginDEwjo2018','EQaD|d',1),(23,'Сорокина','Прасковья','Фёдоровна','loginDEbur2018','aZKGeI',2),(24,'Давыдов','Яков','Антонович','loginDEszw2018','EGU{YE',1),(25,'Рыбакова','Евдокия','Анатольевна','loginDExsu2018','*2RMsp',1),(26,'Маслов','Геннадий','Фролович','loginDEztn2018','nJBZpU',1),(27,'Цветкова','Элеонора','Аристарховна','loginDEtmn2018','UObB}N',1),(28,'Евдокимов','Ростислав','Александрович','loginDEhep2018','SwRicr',1),(29,'Никонова','Венера','Станиславовна','loginDEevr2018','zO5l}l',1),(30,'Громов','Егор','Антонович','loginDEnpa2018','M*QLjf',1),(31,'Суворова','Валерия','Борисовна','loginDEgyt2018','Pav+GP',3),(32,'Мишина','Елизавета','Романовна','loginDEbrr2018','Z7L|+i',1),(33,'Зимина','Ольга','Аркадьевна','loginDEyoo2018','UG1BjP',3),(34,'Игнатьев','Игнатий','Антонинович','loginDEaob2018','3fy+3I',3),(35,'Пахомова','Зинаида','Витальевна','loginDEwtz2018','&GxSST',1),(36,'Устинов','Владимир','Федосеевич','loginDEctf2018','sjt*3N',3),(37,'Кулаков','Мэлор','Вячеславович','loginDEipm2018','MAZl6|',2),(38,'Сазонов','Авксентий','Брониславович','loginDEjoi2018','o}C4jv',1),(39,'Бурова','Наина','Брониславовна','loginDEwap2018','4hny7k',2),(40,'Фадеев','Демьян','Федосеевич','loginDEaxm2018','BEc3xq',1),(41,'Бобылёва','Дарья','Якуновна','loginDEsmq2018','ATVmM7',1),(42,'Виноградов','Созон','Арсеньевич','loginDEeur2018','n4V{wP',1),(43,'Гордеев','Владлен','Ефимович','loginDEvke2018','WQLXSl',1),(44,'Иванова','Зинаида','Валерьевна','loginDEvod2018','0EW93v',2),(45,'Гусев','Руслан','Дамирович','loginDEjaw2018','h6z&Ky',1),(46,'Маслов','Дмитрий','Иванович','loginDEpdp2018','8NvRfC',2),(47,'Антонова','Ульяна','Семёновна','loginDEjpp2018','oMOQq3',1),(48,'Орехова','Людмила','Владимировна','loginDEkiy2018','BQzsts',2),(49,'Авдеева','Жанна','Куприяновна','loginDEhmn2018','a|Iz|7',2),(50,'Кузнецов','Фрол','Варламович','loginDEfmn2018','cw3|03',1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
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
