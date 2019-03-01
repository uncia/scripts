/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80013
 Source Host           : 127.0.0.1
 Source Database       : demo

 Target Server Type    : MySQL
 Target Server Version : 80013
 File Encoding         : utf-8

 Date: 03/01/2019 23:49:06 PM
*/

SET NAMES utf8;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
--  Table structure for `fofa_spider`
-- ----------------------------
DROP TABLE IF EXISTS `fofa_spider`;
CREATE TABLE `fofa_spider` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `host` varchar(255) NOT NULL,
  `ip` varchar(255) NOT NULL,
  `port` varchar(255) DEFAULT NULL,
  `protocol` varchar(255) NOT NULL,
  `country_name` varchar(255) DEFAULT NULL,
  `region_name` varchar(255) DEFAULT NULL,
  `city_name` varchar(255) DEFAULT NULL,
  `fofa_sql` text NOT NULL,
  `create_date` datetime NOT NULL,
  `update_date` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

SET FOREIGN_KEY_CHECKS = 1;
