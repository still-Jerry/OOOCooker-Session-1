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
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Якушев','Евсей','Лукьевич','loginDEdcx2018','TYlFkM',1),(2,'Фёдоров','Святослав','Григорьевич','loginDEnsa2018','LdqH+T',1),(3,'Борисов','Герман','Дамирович','loginDErxm2018','8EavEy',1),(4,'Ситников','Серапион','Фролович','loginDEaic2018','X2adoa',2),(5,'Третьяков','Валерьян','Иринеевич','loginDEwul2018','uK&3Zr',2),(6,'Комиссарова','Мария','Владимировна','loginDEjgl2018','++04Tb',1),(7,'Меркушева','Раиса','Владленовна','loginDEgtk2018','pNWXhi',1),(8,'Калашникова','Венера','Якуновна','loginDEvrd2018','S7N9hz',1),(9,'Комиссаров','Семён','Павлович','loginDExky2018','Kt9EAS',3),(10,'Денисов','Митрофан','Егорович','loginDExnj2018','IJDdP0',2),(11,'Матвиенко','Дамир','Богданович','loginDEnbu2018','86uDLd',1),(12,'Кириллов','Константин','Алексеевич','loginDEiik2018','gKt2zV',1),(13,'Медведьев','Фёдор','Мэлсович','loginDEwyi2018','9eskgK',1),(14,'Карпов','Евгений','Лукьевич','loginDEpfr2018','mW1Q36',1),(15,'Маркова','Евдокия','Артёмовна','loginDEjct2018','3WpoK9',1),(16,'Красильников','Тихон','Богданович','loginDEsmg2018','ApH1By',1),(17,'Титов','Семён','Иринеевич','loginDEexu2018','Nt44pG',2),(18,'Кудряшов','Борис','Иринеевич','loginDEztr2018','MYCgB7',2),(19,'Гаврилова','Нинель','Денисовна','loginDEwrc2018','SktJa|',2),(20,'Быков','Дмитрий','Валерьянович','loginDEzjs2018','|x{s+X',2),(21,'Фомичёв','Денис','Федосеевич','loginDEeka2018','mLZvLv',2),(22,'Белова','Марфа','Матвеевна','loginDEepr2018','BG6tpN',3),(23,'Романова','Марина','Лаврентьевна','loginDEsnq2018','hrD}}g',3),(24,'Беспалов','Демьян','Витальевич','loginDEvqn2018','LPa|e3',1),(25,'Архипова','Венера','Демьяновна','loginDEery2018','*I0Rdi',1),(26,'Носков','Парфений','Георгьевич','loginDElqv2018','Hqfw17',1),(27,'Зыков','Иван','Варламович','loginDEtuz2018','Yln7JW',2),(28,'Рожков','Протасий','Альвианович','loginDEisy2018','5k5dHN',2),(29,'Большакова','Нинель','Протасьевна','loginDEqiv2018','h+N2uW',3),(30,'Наумова','Лидия','Донатовна','loginDEmfu2018','{ZpDBn',1),(31,'Панова','Ольга','Олеговна','loginDEgbd2018','+86Nf*',2),(32,'Комаров','Аркадий','Иванович','loginDEkdg2018','R0tt07',3),(33,'Федосеева','Тамара','Михаиловна','loginDEjrs2018','MVg{yd',3),(34,'Пестов','Роман','Михаилович','loginDEmvd2018','wyLDa{',1),(35,'Блинов','Артём','Ильяович','loginDEctc2018','B&dlx+',2),(36,'Владимирова','Полина','Иринеевна','loginDEavf2018','oDTttg',1),(37,'Силин','Игнатий','Яковович','loginDEako2018','tD8J5+',3),(38,'Кононов','Геннадий','Созонович','loginDEzrg2018','WXIgGi',2),(39,'Дьячков','Фрол','Арсеньевич','loginDEdwq2018','WkTaBP',2),(40,'Горбачёв','Арсений','Григорьевич','loginDEszg2018','NWkAVP',1),(41,'Виноградов','Яков','Онисимович','loginDEmeh2018','HQ+m4W',1),(42,'Лаврентьева','Валентина','Васильевна','loginDEpwm2018','be7AT0',1),(43,'Брагин','Лукьян','Мартынович','loginDEnaq2018','I8c5EB',1),(44,'Трофимов','Кондрат','Игоревич','loginDEtuk2018','6aDAzV',2),(45,'Степанова','Глафира','Авксентьевна','loginDEhsb2018','n|I6A0',1),(46,'Федосеев','Пётр','Григорьевич','loginDEaoi2018','Dl58m|',2),(47,'Поляков','Николай','Антонович','loginDErmk2018','D3GuIv',2),(48,'Медведев','Владимир','Онисимович','loginDEfnd2018','74D9|d',2);
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

-- Dump completed on 2022-11-20  8:18:54
