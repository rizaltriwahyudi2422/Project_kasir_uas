/*
 Navicat Premium Data Transfer

 Source Server         : latihan
 Source Server Type    : MariaDB
 Source Server Version : 100704
 Source Host           : localhost:3306
 Source Schema         : db_kasir

 Target Server Type    : MariaDB
 Target Server Version : 100704
 File Encoding         : 65001

 Date: 06/09/2022 11:27:03
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for t_barang
-- ----------------------------
DROP TABLE IF EXISTS `t_barang`;
CREATE TABLE `t_barang`  (
  `id_barang` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `nama_barang` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `harga_satuan` int(10) NULL DEFAULT NULL,
  `stok` int(4) NULL DEFAULT NULL,
  `harga_jual` int(10) NULL DEFAULT NULL,
  PRIMARY KEY (`id_barang`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_barang
-- ----------------------------
INSERT INTO `t_barang` VALUES ('KB01', 'Yakult', 1000, 77, 1500);
INSERT INTO `t_barang` VALUES ('KB02', 'oreo', 2000, 80, 2000);
INSERT INTO `t_barang` VALUES ('KB03', 'energen', 1000, 50, 1500);

-- ----------------------------
-- Table structure for t_beli
-- ----------------------------
DROP TABLE IF EXISTS `t_beli`;
CREATE TABLE `t_beli`  (
  `id_faktur` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `tanggal` date NULL DEFAULT NULL,
  `id_suplier` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `total_item` int(11) NULL DEFAULT NULL,
  `total_bayar` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_faktur`) USING BTREE,
  INDEX `id_suplier`(`id_suplier`) USING BTREE,
  CONSTRAINT `id_suplier` FOREIGN KEY (`id_suplier`) REFERENCES `t_suplier` (`id_suplier`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_beli
-- ----------------------------
INSERT INTO `t_beli` VALUES ('B001', '2022-09-03', 'S0001', 10, 10000);
INSERT INTO `t_beli` VALUES ('B040', '2022-09-03', 'S0001', 77, 104000);
INSERT INTO `t_beli` VALUES ('E001', '2022-09-02', 'S0001', 105, 195000);
INSERT INTO `t_beli` VALUES ('K001', '2022-09-02', 'S0001', 10, 10000);
INSERT INTO `t_beli` VALUES ('K002', '2022-09-02', 'S0001', 5, 5000);
INSERT INTO `t_beli` VALUES ('K003', '2022-09-02', 'S0001', 9, 9000);
INSERT INTO `t_beli` VALUES ('KB001', '2022-09-03', 'S0001', 10, 10000);
INSERT INTO `t_beli` VALUES ('KL001', '2022-09-03', 'S0001', 23, 31000);
INSERT INTO `t_beli` VALUES ('L001', '2022-09-02', 'S0001', 4, 4000);
INSERT INTO `t_beli` VALUES ('MN01', '2022-09-03', 'S0001', 9, 9000);
INSERT INTO `t_beli` VALUES ('N001', '2022-09-03', 'S0001', 10, 10000);
INSERT INTO `t_beli` VALUES ('P001', '2022-09-03', 'S0001', 5, 5000);
INSERT INTO `t_beli` VALUES ('U001', '2022-09-03', 'S0001', 10, 20000);

-- ----------------------------
-- Table structure for t_detail_beli
-- ----------------------------
DROP TABLE IF EXISTS `t_detail_beli`;
CREATE TABLE `t_detail_beli`  (
  `id_faktur` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `id_barang` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `jumlah` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  INDEX `id_faktur_beli`(`id_faktur`) USING BTREE,
  INDEX `id_barang_beli`(`id_barang`) USING BTREE,
  CONSTRAINT `id_barang_beli` FOREIGN KEY (`id_barang`) REFERENCES `t_barang` (`id_barang`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `id_faktur_beli` FOREIGN KEY (`id_faktur`) REFERENCES `t_beli` (`id_faktur`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_detail_beli
-- ----------------------------
INSERT INTO `t_detail_beli` VALUES ('K001', 'KB01', '10');
INSERT INTO `t_detail_beli` VALUES ('K002', 'KB01', '25');
INSERT INTO `t_detail_beli` VALUES ('K003', 'KB01', '9');
INSERT INTO `t_detail_beli` VALUES ('L001', 'KB01', '4');
INSERT INTO `t_detail_beli` VALUES ('E001', 'KB03', '15');
INSERT INTO `t_detail_beli` VALUES ('E001', 'KB02', '90');
INSERT INTO `t_detail_beli` VALUES ('KB001', 'KB01', '10');
INSERT INTO `t_detail_beli` VALUES ('B001', 'KB01', '10');
INSERT INTO `t_detail_beli` VALUES ('P001', 'KB01', '5');
INSERT INTO `t_detail_beli` VALUES ('N001', 'KB01', '10');
INSERT INTO `t_detail_beli` VALUES ('U001', 'KB02', '10');
INSERT INTO `t_detail_beli` VALUES ('KL001', 'KB01', '9');
INSERT INTO `t_detail_beli` VALUES ('KL001', 'KB02', '8');
INSERT INTO `t_detail_beli` VALUES ('KL001', 'KB03', '6');
INSERT INTO `t_detail_beli` VALUES ('MN01', 'KB01', '9');
INSERT INTO `t_detail_beli` VALUES ('B040', 'KB02', '27');
INSERT INTO `t_detail_beli` VALUES ('B040', 'KB03', '50');

-- ----------------------------
-- Table structure for t_detail_jual
-- ----------------------------
DROP TABLE IF EXISTS `t_detail_jual`;
CREATE TABLE `t_detail_jual`  (
  `id_faktur_jual` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `id_barang` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `jumlah` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  INDEX `id_faktur_jual`(`id_faktur_jual`) USING BTREE,
  INDEX `id_barang_jual`(`id_barang`) USING BTREE,
  CONSTRAINT `id_faktur_jual` FOREIGN KEY (`id_faktur_jual`) REFERENCES `t_jual` (`id_faktur_jual`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `id_barang_jual` FOREIGN KEY (`id_barang`) REFERENCES `t_barang` (`id_barang`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_detail_jual
-- ----------------------------
INSERT INTO `t_detail_jual` VALUES ('J001', 'KB01', '10');
INSERT INTO `t_detail_jual` VALUES ('KP001', 'KB01', '10');
INSERT INTO `t_detail_jual` VALUES ('JU01', 'KB03', '20');
INSERT INTO `t_detail_jual` VALUES ('ZU01', 'KB02', '5');
INSERT INTO `t_detail_jual` VALUES ('XU05', 'KB02', '30');
INSERT INTO `t_detail_jual` VALUES ('XU07', 'KB02', '30');
INSERT INTO `t_detail_jual` VALUES ('V008', 'KB02', '20');
INSERT INTO `t_detail_jual` VALUES ('YU4L', 'KB03', '1');

-- ----------------------------
-- Table structure for t_jual
-- ----------------------------
DROP TABLE IF EXISTS `t_jual`;
CREATE TABLE `t_jual`  (
  `id_faktur_jual` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `tanggal` date NULL DEFAULT NULL,
  `id_kasir` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `total_item` int(11) NULL DEFAULT NULL,
  `total_bayar` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_faktur_jual`) USING BTREE,
  INDEX `id_kasir`(`id_kasir`) USING BTREE,
  CONSTRAINT `id_kasir` FOREIGN KEY (`id_kasir`) REFERENCES `t_kasir` (`id_kasir`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_jual
-- ----------------------------
INSERT INTO `t_jual` VALUES ('J001', '2022-09-02', '2', 10, 15000);
INSERT INTO `t_jual` VALUES ('JU01', '2022-09-03', '2', 20, 30000);
INSERT INTO `t_jual` VALUES ('K001', '2022-09-02', '2', 10, 15000);
INSERT INTO `t_jual` VALUES ('KP001', '2022-09-03', '2', 10, 15000);
INSERT INTO `t_jual` VALUES ('V008', '2022-09-03', '2', 20, 40000);
INSERT INTO `t_jual` VALUES ('XU05', '2022-09-03', '1', 30, 60000);
INSERT INTO `t_jual` VALUES ('XU07', '2022-09-03', '1', 30, 60000);
INSERT INTO `t_jual` VALUES ('YU4L', '2022-09-03', '1', 1, 1500);
INSERT INTO `t_jual` VALUES ('ZU01', '2022-09-03', '2', 5, 10000);

-- ----------------------------
-- Table structure for t_kasir
-- ----------------------------
DROP TABLE IF EXISTS `t_kasir`;
CREATE TABLE `t_kasir`  (
  `id_kasir` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `nama_kasir` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `password_kasir` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `level_kasir` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_kasir`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_kasir
-- ----------------------------
INSERT INTO `t_kasir` VALUES ('1', 'admin', '1', 'admin');
INSERT INTO `t_kasir` VALUES ('2', 'Joni', 'joni123!', 'kasir');
INSERT INTO `t_kasir` VALUES ('3', 'Ableh', '2', 'kasir');

-- ----------------------------
-- Table structure for t_pelanggan
-- ----------------------------
DROP TABLE IF EXISTS `t_pelanggan`;
CREATE TABLE `t_pelanggan`  (
  `id_pelanggan` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `nama_pelanggan` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `alamat` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `telp` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_pelanggan`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_pelanggan
-- ----------------------------

-- ----------------------------
-- Table structure for t_suplier
-- ----------------------------
DROP TABLE IF EXISTS `t_suplier`;
CREATE TABLE `t_suplier`  (
  `id_suplier` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `nama_suplier` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `alamat` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `telp` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_suplier`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_suplier
-- ----------------------------
INSERT INTO `t_suplier` VALUES ('S0001', 'Yadi Sembako', 'jl dakota', '08980099888');

-- ----------------------------
-- View structure for viewbeli
-- ----------------------------
DROP VIEW IF EXISTS `viewbeli`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `viewbeli` AS select `t_barang`.`id_barang` AS `id_barang`,`t_detail_beli`.`id_faktur` AS `id_faktur`,`t_barang`.`nama_barang` AS `nama_barang`,`t_barang`.`harga_satuan` AS `harga_satuan`,`t_detail_beli`.`jumlah` AS `jumlah`,`t_beli`.`total_bayar` AS `total_bayar`,`t_suplier`.`nama_suplier` AS `nama_suplier`,`t_beli`.`tanggal` AS `tanggal` from (((`t_detail_beli` join `t_barang`) join `t_suplier`) join `t_beli`) where `t_beli`.`id_faktur` = `t_detail_beli`.`id_faktur` and `t_detail_beli`.`id_barang` = `t_barang`.`id_barang`;

-- ----------------------------
-- View structure for viewjual
-- ----------------------------
DROP VIEW IF EXISTS `viewjual`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `viewjual` AS select `t_kasir`.`id_kasir` AS `id_kasir`,`t_kasir`.`nama_kasir` AS `nama_kasir`,`t_jual`.`id_faktur_jual` AS `id_faktur_jual`,`t_detail_jual`.`id_barang` AS `id_barang`,`t_barang`.`nama_barang` AS `nama_barang`,`t_jual`.`tanggal` AS `tanggal`,`t_jual`.`total_item` AS `total_item`,`t_barang`.`harga_jual` AS `harga_jual`,`t_jual`.`total_bayar` AS `total_bayar` from (((`t_jual` join `t_detail_jual`) join `t_kasir`) join `t_barang`) where `t_jual`.`id_faktur_jual` = `t_detail_jual`.`id_faktur_jual` and `t_detail_jual`.`id_barang` = `t_barang`.`id_barang` and `t_kasir`.`id_kasir` = `t_jual`.`id_kasir`;

SET FOREIGN_KEY_CHECKS = 1;
