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

 Date: 29/08/2022 23:35:29
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for t_barang
-- ----------------------------
DROP TABLE IF EXISTS `t_barang`;
CREATE TABLE `t_barang`  (
  `id_barang` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `nama_barang` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `harga_satuan` int(10) NULL DEFAULT NULL,
  `stok` int(4) NULL DEFAULT NULL,
  `nama_suplier` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_barang`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_barang
-- ----------------------------
INSERT INTO `t_barang` VALUES ('', '', NULL, NULL, '');

-- ----------------------------
-- Table structure for t_beli
-- ----------------------------
DROP TABLE IF EXISTS `t_beli`;
CREATE TABLE `t_beli`  (
  `id_faktur` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
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

-- ----------------------------
-- Table structure for t_detail_beli
-- ----------------------------
DROP TABLE IF EXISTS `t_detail_beli`;
CREATE TABLE `t_detail_beli`  (
  `id_faktur` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `id_barang` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `jumlah` int(20) NULL DEFAULT NULL,
  INDEX `id_faktur`(`id_faktur`) USING BTREE,
  INDEX `id_barang`(`id_barang`) USING BTREE,
  CONSTRAINT `id_barang` FOREIGN KEY (`id_barang`) REFERENCES `t_barang` (`id_barang`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `id_faktur` FOREIGN KEY (`id_faktur`) REFERENCES `t_beli` (`id_faktur`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_detail_beli
-- ----------------------------

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

-- ----------------------------
-- Table structure for t_jual
-- ----------------------------
DROP TABLE IF EXISTS `t_jual`;
CREATE TABLE `t_jual`  (
  `id_faktur_jual` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `tanggal` date NULL DEFAULT NULL,
  `id_pelanggan` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `total_item` int(11) NULL DEFAULT NULL,
  `total_bayar` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id_faktur_jual`) USING BTREE,
  INDEX `id_pelanggan`(`id_pelanggan`) USING BTREE,
  CONSTRAINT `id_pelanggan` FOREIGN KEY (`id_pelanggan`) REFERENCES `t_pelanggan` (`id_pelanggan`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_jual
-- ----------------------------

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
INSERT INTO `t_kasir` VALUES ('1', 'admin', 'test123!', 'admin');
INSERT INTO `t_kasir` VALUES ('2', 'Joni', 'joni123!', 'kasir');

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
  `id_barang` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `nama_suplier` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `alamat` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `telp` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_suplier`) USING BTREE,
  INDEX `id_barang_suplier`(`id_barang`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_suplier
-- ----------------------------
INSERT INTO `t_suplier` VALUES ('3243', 'kb002', 'gcfgf', 'wewr', 'hvhjv');
INSERT INTO `t_suplier` VALUES ('KS001', 'KB001', 'adw', 'dwada', '21312412');

SET FOREIGN_KEY_CHECKS = 1;
