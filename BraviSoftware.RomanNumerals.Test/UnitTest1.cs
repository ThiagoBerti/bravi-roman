using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BraviSoftware.RomanNumerals;

namespace BraviSoftware.RomanNumerals.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert_1_Returns_I()
        {
            Assert.AreEqual("I", Converter.Convert(1));
        }
        [TestMethod]
        public void Convert_2_Returns_II()
        {
            Assert.AreEqual("II", Converter.Convert(2));
        }
        [TestMethod]
        public void Convert_3_Returns_III()
        {
            Assert.AreEqual("III", Converter.Convert(3));
        }
        [TestMethod]
        public void Convert_4_Returns_IV()
        {
            Assert.AreEqual("IV", Converter.Convert(4));
        }
        [TestMethod]
        public void Convert_5_Returns_V()
        {
            Assert.AreEqual("V", Converter.Convert(5));
        }
        [TestMethod]
        public void Convert_6_Returns_VI()
        {
            Assert.AreEqual("VI", Converter.Convert(6));
        }
        [TestMethod]
        public void Convert_7_Returns_VII()
        {
            Assert.AreEqual("VII", Converter.Convert(7));
        }
        [TestMethod]
        public void Convert_8_Returns_VIII()
        {
            Assert.AreEqual("VIII", Converter.Convert(8));
        }
        [TestMethod]
        public void Convert_9_Returns_IX()
        {
            Assert.AreEqual("IX", Converter.Convert(9));
        }
        [TestMethod]
        public void Convert_10_Returns_X()
        {
            Assert.AreEqual("X", Converter.Convert(10));
        }
        [TestMethod]
        public void Convert_11_Returns_XI()
        {
            Assert.AreEqual("XI", Converter.Convert(11));
        }
        [TestMethod]
        public void Convert_12_Returns_XII()
        {
            Assert.AreEqual("XII", Converter.Convert(12));
        }
        [TestMethod]
        public void Convert_13_Returns_XIII()
        {
            Assert.AreEqual("XIII", Converter.Convert(13));
        }
        [TestMethod]
        public void Convert_14_Returns_XIV()
        {
            Assert.AreEqual("XIV", Converter.Convert(14));
        }
        [TestMethod]
        public void Convert_15_Returns_XV()
        {
            Assert.AreEqual("XV", Converter.Convert(15));
        }
        [TestMethod]
        public void Convert_16_Returns_XVI()
        {
            Assert.AreEqual("XVI", Converter.Convert(16));
        }
        [TestMethod]
        public void Convert_17_Returns_XVII()
        {
            Assert.AreEqual("XVII", Converter.Convert(17));
        }
        [TestMethod]
        public void Convert_18_Returns_XVIII()
        {
            Assert.AreEqual("XVIII", Converter.Convert(18));
        }
        [TestMethod]
        public void Convert_19_Returns_XIX()
        {
            Assert.AreEqual("XIX", Converter.Convert(19));
        }
        [TestMethod]
        public void Convert_20_Returns_XX()
        {
            Assert.AreEqual("XX", Converter.Convert(20));
        }
        [TestMethod]
        public void Convert_21_Returns_XXI()
        {
            Assert.AreEqual("XXI", Converter.Convert(21));
        }
        [TestMethod]
        public void Convert_22_Returns_XXII()
        {
            Assert.AreEqual("XXII", Converter.Convert(22));
        }
        [TestMethod]
        public void Convert_23_Returns_XXIII()
        {
            Assert.AreEqual("XXIII", Converter.Convert(23));
        }
        [TestMethod]
        public void Convert_24_Returns_XXIV()
        {
            Assert.AreEqual("XXIV", Converter.Convert(24));
        }
        [TestMethod]
        public void Convert_25_Returns_XXV()
        {
            Assert.AreEqual("XXV", Converter.Convert(25));
        }
        [TestMethod]
        public void Convert_26_Returns_XXVI()
        {
            Assert.AreEqual("XXVI", Converter.Convert(26));
        }
        [TestMethod]
        public void Convert_27_Returns_XXVII()
        {
            Assert.AreEqual("XXVII", Converter.Convert(27));
        }
        [TestMethod]
        public void Convert_28_Returns_XXVIII()
        {
            Assert.AreEqual("XXVIII", Converter.Convert(28));
        }
        [TestMethod]
        public void Convert_29_Returns_XXIX()
        {
            Assert.AreEqual("XXIX", Converter.Convert(29));
        }
        [TestMethod]
        public void Convert_30_Returns_XXX()
        {
            Assert.AreEqual("XXX", Converter.Convert(30));
        }
        [TestMethod]
        public void Convert_31_Returns_XXXI()
        {
            Assert.AreEqual("XXXI", Converter.Convert(31));
        }
        [TestMethod]
        public void Convert_32_Returns_XXXII()
        {
            Assert.AreEqual("XXXII", Converter.Convert(32));
        }
        [TestMethod]
        public void Convert_33_Returns_XXXIII()
        {
            Assert.AreEqual("XXXIII", Converter.Convert(33));
        }
        [TestMethod]
        public void Convert_34_Returns_XXXIV()
        {
            Assert.AreEqual("XXXIV", Converter.Convert(34));
        }
        [TestMethod]
        public void Convert_35_Returns_XXXV()
        {
            Assert.AreEqual("XXXV", Converter.Convert(35));
        }
        [TestMethod]
        public void Convert_36_Returns_XXXVI()
        {
            Assert.AreEqual("XXXVI", Converter.Convert(36));
        }
        [TestMethod]
        public void Convert_37_Returns_XXXVII()
        {
            Assert.AreEqual("XXXVII", Converter.Convert(37));
        }
        [TestMethod]
        public void Convert_38_Returns_XXXVIII()
        {
            Assert.AreEqual("XXXVIII", Converter.Convert(38));
        }
        [TestMethod]
        public void Convert_39_Returns_XXXIX()
        {
            Assert.AreEqual("XXXIX", Converter.Convert(39));
        }
        [TestMethod]
        public void Convert_40_Returns_XL()
        {
            Assert.AreEqual("XL", Converter.Convert(40));
        }
        [TestMethod]
        public void Convert_41_Returns_XLI()
        {
            Assert.AreEqual("XLI", Converter.Convert(41));
        }
        [TestMethod]
        public void Convert_42_Returns_XLII()
        {
            Assert.AreEqual("XLII", Converter.Convert(42));
        }
        [TestMethod]
        public void Convert_43_Returns_XLIII()
        {
            Assert.AreEqual("XLIII", Converter.Convert(43));
        }
        [TestMethod]
        public void Convert_44_Returns_XLIV()
        {
            Assert.AreEqual("XLIV", Converter.Convert(44));
        }
        [TestMethod]
        public void Convert_45_Returns_XLV()
        {
            Assert.AreEqual("XLV", Converter.Convert(45));
        }
        [TestMethod]
        public void Convert_46_Returns_XLVI()
        {
            Assert.AreEqual("XLVI", Converter.Convert(46));
        }
        [TestMethod]
        public void Convert_47_Returns_XLVII()
        {
            Assert.AreEqual("XLVII", Converter.Convert(47));
        }
        [TestMethod]
        public void Convert_48_Returns_XLVIII()
        {
            Assert.AreEqual("XLVIII", Converter.Convert(48));
        }
        [TestMethod]
        public void Convert_49_Returns_XLIX()
        {
            Assert.AreEqual("XLIX", Converter.Convert(49));
        }
        [TestMethod]
        public void Convert_50_Returns_L()
        {
            Assert.AreEqual("L", Converter.Convert(50));
        }
        [TestMethod]
        public void Convert_51_Returns_LI()
        {
            Assert.AreEqual("LI", Converter.Convert(51));
        }
        [TestMethod]
        public void Convert_52_Returns_LII()
        {
            Assert.AreEqual("LII", Converter.Convert(52));
        }
        [TestMethod]
        public void Convert_53_Returns_LIII()
        {
            Assert.AreEqual("LIII", Converter.Convert(53));
        }
        [TestMethod]
        public void Convert_54_Returns_LIV()
        {
            Assert.AreEqual("LIV", Converter.Convert(54));
        }
        [TestMethod]
        public void Convert_55_Returns_LV()
        {
            Assert.AreEqual("LV", Converter.Convert(55));
        }
        [TestMethod]
        public void Convert_56_Returns_LVI()
        {
            Assert.AreEqual("LVI", Converter.Convert(56));
        }
        [TestMethod]
        public void Convert_57_Returns_LVII()
        {
            Assert.AreEqual("LVII", Converter.Convert(57));
        }
        [TestMethod]
        public void Convert_58_Returns_LVIII()
        {
            Assert.AreEqual("LVIII", Converter.Convert(58));
        }
        [TestMethod]
        public void Convert_59_Returns_LIX()
        {
            Assert.AreEqual("LIX", Converter.Convert(59));
        }
        [TestMethod]
        public void Convert_60_Returns_LX()
        {
            Assert.AreEqual("LX", Converter.Convert(60));
        }
        [TestMethod]
        public void Convert_61_Returns_LXI()
        {
            Assert.AreEqual("LXI", Converter.Convert(61));
        }
        [TestMethod]
        public void Convert_62_Returns_LXII()
        {
            Assert.AreEqual("LXII", Converter.Convert(62));
        }
        [TestMethod]
        public void Convert_63_Returns_LXIII()
        {
            Assert.AreEqual("LXIII", Converter.Convert(63));
        }
        [TestMethod]
        public void Convert_64_Returns_LXIV()
        {
            Assert.AreEqual("LXIV", Converter.Convert(64));
        }
        [TestMethod]
        public void Convert_65_Returns_LXV()
        {
            Assert.AreEqual("LXV", Converter.Convert(65));
        }
        [TestMethod]
        public void Convert_66_Returns_LXVI()
        {
            Assert.AreEqual("LXVI", Converter.Convert(66));
        }
        [TestMethod]
        public void Convert_67_Returns_LXVII()
        {
            Assert.AreEqual("LXVII", Converter.Convert(67));
        }
        [TestMethod]
        public void Convert_68_Returns_LXVIII()
        {
            Assert.AreEqual("LXVIII", Converter.Convert(68));
        }
        [TestMethod]
        public void Convert_69_Returns_LXIX()
        {
            Assert.AreEqual("LXIX", Converter.Convert(69));
        }
        [TestMethod]
        public void Convert_70_Returns_LXX()
        {
            Assert.AreEqual("LXX", Converter.Convert(70));
        }
        [TestMethod]
        public void Convert_71_Returns_LXXI()
        {
            Assert.AreEqual("LXXI", Converter.Convert(71));
        }
        [TestMethod]
        public void Convert_72_Returns_LXXII()
        {
            Assert.AreEqual("LXXII", Converter.Convert(72));
        }
        [TestMethod]
        public void Convert_73_Returns_LXXIII()
        {
            Assert.AreEqual("LXXIII", Converter.Convert(73));
        }
        [TestMethod]
        public void Convert_74_Returns_LXXIV()
        {
            Assert.AreEqual("LXXIV", Converter.Convert(74));
        }
        [TestMethod]
        public void Convert_75_Returns_LXXV()
        {
            Assert.AreEqual("LXXV", Converter.Convert(75));
        }
        [TestMethod]
        public void Convert_76_Returns_LXXVI()
        {
            Assert.AreEqual("LXXVI", Converter.Convert(76));
        }
        [TestMethod]
        public void Convert_77_Returns_LXXVII()
        {
            Assert.AreEqual("LXXVII", Converter.Convert(77));
        }
        [TestMethod]
        public void Convert_78_Returns_LXXVIII()
        {
            Assert.AreEqual("LXXVIII", Converter.Convert(78));
        }
        [TestMethod]
        public void Convert_79_Returns_LXXIX()
        {
            Assert.AreEqual("LXXIX", Converter.Convert(79));
        }
        [TestMethod]
        public void Convert_80_Returns_LXXX()
        {
            Assert.AreEqual("LXXX", Converter.Convert(80));
        }
        [TestMethod]
        public void Convert_81_Returns_LXXXI()
        {
            Assert.AreEqual("LXXXI", Converter.Convert(81));
        }
        [TestMethod]
        public void Convert_82_Returns_LXXXII()
        {
            Assert.AreEqual("LXXXII", Converter.Convert(82));
        }
        [TestMethod]
        public void Convert_83_Returns_LXXXIII()
        {
            Assert.AreEqual("LXXXIII", Converter.Convert(83));
        }
        [TestMethod]
        public void Convert_84_Returns_LXXXIV()
        {
            Assert.AreEqual("LXXXIV", Converter.Convert(84));
        }
        [TestMethod]
        public void Convert_85_Returns_LXXXV()
        {
            Assert.AreEqual("LXXXV", Converter.Convert(85));
        }
        [TestMethod]
        public void Convert_86_Returns_LXXXVI()
        {
            Assert.AreEqual("LXXXVI", Converter.Convert(86));
        }
        [TestMethod]
        public void Convert_87_Returns_LXXXVII()
        {
            Assert.AreEqual("LXXXVII", Converter.Convert(87));
        }
        [TestMethod]
        public void Convert_88_Returns_LXXXVIII()
        {
            Assert.AreEqual("LXXXVIII", Converter.Convert(88));
        }
        [TestMethod]
        public void Convert_89_Returns_LXXXIX()
        {
            Assert.AreEqual("LXXXIX", Converter.Convert(89));
        }
        [TestMethod]
        public void Convert_90_Returns_XC()
        {
            Assert.AreEqual("XC", Converter.Convert(90));
        }
        [TestMethod]
        public void Convert_91_Returns_XCI()
        {
            Assert.AreEqual("XCI", Converter.Convert(91));
        }
        [TestMethod]
        public void Convert_92_Returns_XCII()
        {
            Assert.AreEqual("XCII", Converter.Convert(92));
        }
        [TestMethod]
        public void Convert_93_Returns_XCIII()
        {
            Assert.AreEqual("XCIII", Converter.Convert(93));
        }
        [TestMethod]
        public void Convert_94_Returns_XCIV()
        {
            Assert.AreEqual("XCIV", Converter.Convert(94));
        }
        [TestMethod]
        public void Convert_95_Returns_XCV()
        {
            Assert.AreEqual("XCV", Converter.Convert(95));
        }
        [TestMethod]
        public void Convert_96_Returns_XCVI()
        {
            Assert.AreEqual("XCVI", Converter.Convert(96));
        }
        [TestMethod]
        public void Convert_97_Returns_XCVII()
        {
            Assert.AreEqual("XCVII", Converter.Convert(97));
        }
        [TestMethod]
        public void Convert_98_Returns_XCVIII()
        {
            Assert.AreEqual("XCVIII", Converter.Convert(98));
        }
        [TestMethod]
        public void Convert_99_Returns_XCIX()
        {
            Assert.AreEqual("XCIX", Converter.Convert(99));
        }
        [TestMethod]
        public void Convert_100_Returns_C()
        {
            Assert.AreEqual("C", Converter.Convert(100));
        }
        [TestMethod]
        public void Convert_101_Returns_CI()
        {
            Assert.AreEqual("CI", Converter.Convert(101));
        }
        [TestMethod]
        public void Convert_102_Returns_CII()
        {
            Assert.AreEqual("CII", Converter.Convert(102));
        }
        [TestMethod]
        public void Convert_103_Returns_CIII()
        {
            Assert.AreEqual("CIII", Converter.Convert(103));
        }
        [TestMethod]
        public void Convert_104_Returns_CIV()
        {
            Assert.AreEqual("CIV", Converter.Convert(104));
        }
        [TestMethod]
        public void Convert_105_Returns_CV()
        {
            Assert.AreEqual("CV", Converter.Convert(105));
        }
        [TestMethod]
        public void Convert_106_Returns_CVI()
        {
            Assert.AreEqual("CVI", Converter.Convert(106));
        }
        [TestMethod]
        public void Convert_107_Returns_CVII()
        {
            Assert.AreEqual("CVII", Converter.Convert(107));
        }
        [TestMethod]
        public void Convert_108_Returns_CVIII()
        {
            Assert.AreEqual("CVIII", Converter.Convert(108));
        }
        [TestMethod]
        public void Convert_109_Returns_CIX()
        {
            Assert.AreEqual("CIX", Converter.Convert(109));
        }
        [TestMethod]
        public void Convert_110_Returns_CX()
        {
            Assert.AreEqual("CX", Converter.Convert(110));
        }
        [TestMethod]
        public void Convert_111_Returns_CXI()
        {
            Assert.AreEqual("CXI", Converter.Convert(111));
        }
        [TestMethod]
        public void Convert_112_Returns_CXII()
        {
            Assert.AreEqual("CXII", Converter.Convert(112));
        }
        [TestMethod]
        public void Convert_113_Returns_CXIII()
        {
            Assert.AreEqual("CXIII", Converter.Convert(113));
        }
        [TestMethod]
        public void Convert_114_Returns_CXIV()
        {
            Assert.AreEqual("CXIV", Converter.Convert(114));
        }
        [TestMethod]
        public void Convert_115_Returns_CXV()
        {
            Assert.AreEqual("CXV", Converter.Convert(115));
        }
        [TestMethod]
        public void Convert_116_Returns_CXVI()
        {
            Assert.AreEqual("CXVI", Converter.Convert(116));
        }
        [TestMethod]
        public void Convert_117_Returns_CXVII()
        {
            Assert.AreEqual("CXVII", Converter.Convert(117));
        }
        [TestMethod]
        public void Convert_118_Returns_CXVIII()
        {
            Assert.AreEqual("CXVIII", Converter.Convert(118));
        }
        [TestMethod]
        public void Convert_119_Returns_CXIX()
        {
            Assert.AreEqual("CXIX", Converter.Convert(119));
        }
        [TestMethod]
        public void Convert_120_Returns_CXX()
        {
            Assert.AreEqual("CXX", Converter.Convert(120));
        }
        [TestMethod]
        public void Convert_121_Returns_CXXI()
        {
            Assert.AreEqual("CXXI", Converter.Convert(121));
        }
        [TestMethod]
        public void Convert_122_Returns_CXXII()
        {
            Assert.AreEqual("CXXII", Converter.Convert(122));
        }
        [TestMethod]
        public void Convert_123_Returns_CXXIII()
        {
            Assert.AreEqual("CXXIII", Converter.Convert(123));
        }
        [TestMethod]
        public void Convert_124_Returns_CXXIV()
        {
            Assert.AreEqual("CXXIV", Converter.Convert(124));
        }
        [TestMethod]
        public void Convert_125_Returns_CXXV()
        {
            Assert.AreEqual("CXXV", Converter.Convert(125));
        }
        [TestMethod]
        public void Convert_126_Returns_CXXVI()
        {
            Assert.AreEqual("CXXVI", Converter.Convert(126));
        }
        [TestMethod]
        public void Convert_127_Returns_CXXVII()
        {
            Assert.AreEqual("CXXVII", Converter.Convert(127));
        }
        [TestMethod]
        public void Convert_128_Returns_CXXVIII()
        {
            Assert.AreEqual("CXXVIII", Converter.Convert(128));
        }
        [TestMethod]
        public void Convert_129_Returns_CXXIX()
        {
            Assert.AreEqual("CXXIX", Converter.Convert(129));
        }
        [TestMethod]
        public void Convert_130_Returns_CXXX()
        {
            Assert.AreEqual("CXXX", Converter.Convert(130));
        }
        [TestMethod]
        public void Convert_131_Returns_CXXXI()
        {
            Assert.AreEqual("CXXXI", Converter.Convert(131));
        }
        [TestMethod]
        public void Convert_132_Returns_CXXXII()
        {
            Assert.AreEqual("CXXXII", Converter.Convert(132));
        }
        [TestMethod]
        public void Convert_133_Returns_CXXXIII()
        {
            Assert.AreEqual("CXXXIII", Converter.Convert(133));
        }
        [TestMethod]
        public void Convert_134_Returns_CXXXIV()
        {
            Assert.AreEqual("CXXXIV", Converter.Convert(134));
        }
        [TestMethod]
        public void Convert_135_Returns_CXXXV()
        {
            Assert.AreEqual("CXXXV", Converter.Convert(135));
        }
        [TestMethod]
        public void Convert_136_Returns_CXXXVI()
        {
            Assert.AreEqual("CXXXVI", Converter.Convert(136));
        }
        [TestMethod]
        public void Convert_137_Returns_CXXXVII()
        {
            Assert.AreEqual("CXXXVII", Converter.Convert(137));
        }
        [TestMethod]
        public void Convert_138_Returns_CXXXVIII()
        {
            Assert.AreEqual("CXXXVIII", Converter.Convert(138));
        }
        [TestMethod]
        public void Convert_139_Returns_CXXXIX()
        {
            Assert.AreEqual("CXXXIX", Converter.Convert(139));
        }
        [TestMethod]
        public void Convert_140_Returns_CXL()
        {
            Assert.AreEqual("CXL", Converter.Convert(140));
        }
        [TestMethod]
        public void Convert_141_Returns_CXLI()
        {
            Assert.AreEqual("CXLI", Converter.Convert(141));
        }
        [TestMethod]
        public void Convert_142_Returns_CXLII()
        {
            Assert.AreEqual("CXLII", Converter.Convert(142));
        }
        [TestMethod]
        public void Convert_143_Returns_CXLIII()
        {
            Assert.AreEqual("CXLIII", Converter.Convert(143));
        }
        [TestMethod]
        public void Convert_144_Returns_CXLIV()
        {
            Assert.AreEqual("CXLIV", Converter.Convert(144));
        }
        [TestMethod]
        public void Convert_145_Returns_CXLV()
        {
            Assert.AreEqual("CXLV", Converter.Convert(145));
        }
        [TestMethod]
        public void Convert_146_Returns_CXLVI()
        {
            Assert.AreEqual("CXLVI", Converter.Convert(146));
        }
        [TestMethod]
        public void Convert_147_Returns_CXLVII()
        {
            Assert.AreEqual("CXLVII", Converter.Convert(147));
        }
        [TestMethod]
        public void Convert_148_Returns_CXLVIII()
        {
            Assert.AreEqual("CXLVIII", Converter.Convert(148));
        }
        [TestMethod]
        public void Convert_149_Returns_CXLIX()
        {
            Assert.AreEqual("CXLIX", Converter.Convert(149));
        }
        [TestMethod]
        public void Convert_150_Returns_CL()
        {
            Assert.AreEqual("CL", Converter.Convert(150));
        }
        [TestMethod]
        public void Convert_151_Returns_CLI()
        {
            Assert.AreEqual("CLI", Converter.Convert(151));
        }
        [TestMethod]
        public void Convert_152_Returns_CLII()
        {
            Assert.AreEqual("CLII", Converter.Convert(152));
        }
        [TestMethod]
        public void Convert_153_Returns_CLIII()
        {
            Assert.AreEqual("CLIII", Converter.Convert(153));
        }
        [TestMethod]
        public void Convert_154_Returns_CLIV()
        {
            Assert.AreEqual("CLIV", Converter.Convert(154));
        }
        [TestMethod]
        public void Convert_155_Returns_CLV()
        {
            Assert.AreEqual("CLV", Converter.Convert(155));
        }
        [TestMethod]
        public void Convert_156_Returns_CLVI()
        {
            Assert.AreEqual("CLVI", Converter.Convert(156));
        }
        [TestMethod]
        public void Convert_157_Returns_CLVII()
        {
            Assert.AreEqual("CLVII", Converter.Convert(157));
        }
        [TestMethod]
        public void Convert_158_Returns_CLVIII()
        {
            Assert.AreEqual("CLVIII", Converter.Convert(158));
        }
        [TestMethod]
        public void Convert_159_Returns_CLIX()
        {
            Assert.AreEqual("CLIX", Converter.Convert(159));
        }
        [TestMethod]
        public void Convert_160_Returns_CLX()
        {
            Assert.AreEqual("CLX", Converter.Convert(160));
        }
        [TestMethod]
        public void Convert_161_Returns_CLXI()
        {
            Assert.AreEqual("CLXI", Converter.Convert(161));
        }
        [TestMethod]
        public void Convert_162_Returns_CLXII()
        {
            Assert.AreEqual("CLXII", Converter.Convert(162));
        }
        [TestMethod]
        public void Convert_163_Returns_CLXIII()
        {
            Assert.AreEqual("CLXIII", Converter.Convert(163));
        }
        [TestMethod]
        public void Convert_164_Returns_CLXIV()
        {
            Assert.AreEqual("CLXIV", Converter.Convert(164));
        }
        [TestMethod]
        public void Convert_165_Returns_CLXV()
        {
            Assert.AreEqual("CLXV", Converter.Convert(165));
        }
        [TestMethod]
        public void Convert_166_Returns_CLXVI()
        {
            Assert.AreEqual("CLXVI", Converter.Convert(166));
        }
        [TestMethod]
        public void Convert_167_Returns_CLXVII()
        {
            Assert.AreEqual("CLXVII", Converter.Convert(167));
        }
        [TestMethod]
        public void Convert_168_Returns_CLXVIII()
        {
            Assert.AreEqual("CLXVIII", Converter.Convert(168));
        }
        [TestMethod]
        public void Convert_169_Returns_CLXIX()
        {
            Assert.AreEqual("CLXIX", Converter.Convert(169));
        }
        [TestMethod]
        public void Convert_170_Returns_CLXX()
        {
            Assert.AreEqual("CLXX", Converter.Convert(170));
        }
        [TestMethod]
        public void Convert_171_Returns_CLXXI()
        {
            Assert.AreEqual("CLXXI", Converter.Convert(171));
        }
        [TestMethod]
        public void Convert_172_Returns_CLXXII()
        {
            Assert.AreEqual("CLXXII", Converter.Convert(172));
        }
        [TestMethod]
        public void Convert_173_Returns_CLXXIII()
        {
            Assert.AreEqual("CLXXIII", Converter.Convert(173));
        }
        [TestMethod]
        public void Convert_174_Returns_CLXXIV()
        {
            Assert.AreEqual("CLXXIV", Converter.Convert(174));
        }
        [TestMethod]
        public void Convert_175_Returns_CLXXV()
        {
            Assert.AreEqual("CLXXV", Converter.Convert(175));
        }
        [TestMethod]
        public void Convert_176_Returns_CLXXVI()
        {
            Assert.AreEqual("CLXXVI", Converter.Convert(176));
        }
        [TestMethod]
        public void Convert_177_Returns_CLXXVII()
        {
            Assert.AreEqual("CLXXVII", Converter.Convert(177));
        }
        [TestMethod]
        public void Convert_178_Returns_CLXXVIII()
        {
            Assert.AreEqual("CLXXVIII", Converter.Convert(178));
        }
        [TestMethod]
        public void Convert_179_Returns_CLXXIX()
        {
            Assert.AreEqual("CLXXIX", Converter.Convert(179));
        }
        [TestMethod]
        public void Convert_180_Returns_CLXXX()
        {
            Assert.AreEqual("CLXXX", Converter.Convert(180));
        }
        [TestMethod]
        public void Convert_181_Returns_CLXXXI()
        {
            Assert.AreEqual("CLXXXI", Converter.Convert(181));
        }
        [TestMethod]
        public void Convert_182_Returns_CLXXXII()
        {
            Assert.AreEqual("CLXXXII", Converter.Convert(182));
        }
        [TestMethod]
        public void Convert_183_Returns_CLXXXIII()
        {
            Assert.AreEqual("CLXXXIII", Converter.Convert(183));
        }
        [TestMethod]
        public void Convert_184_Returns_CLXXXIV()
        {
            Assert.AreEqual("CLXXXIV", Converter.Convert(184));
        }
        [TestMethod]
        public void Convert_185_Returns_CLXXXV()
        {
            Assert.AreEqual("CLXXXV", Converter.Convert(185));
        }
        [TestMethod]
        public void Convert_186_Returns_CLXXXVI()
        {
            Assert.AreEqual("CLXXXVI", Converter.Convert(186));
        }
        [TestMethod]
        public void Convert_187_Returns_CLXXXVII()
        {
            Assert.AreEqual("CLXXXVII", Converter.Convert(187));
        }
        [TestMethod]
        public void Convert_188_Returns_CLXXXVIII()
        {
            Assert.AreEqual("CLXXXVIII", Converter.Convert(188));
        }
        [TestMethod]
        public void Convert_189_Returns_CLXXXIX()
        {
            Assert.AreEqual("CLXXXIX", Converter.Convert(189));
        }
        [TestMethod]
        public void Convert_190_Returns_CXC()
        {
            Assert.AreEqual("CXC", Converter.Convert(190));
        }
        [TestMethod]
        public void Convert_191_Returns_CXCI()
        {
            Assert.AreEqual("CXCI", Converter.Convert(191));
        }
        [TestMethod]
        public void Convert_192_Returns_CXCII()
        {
            Assert.AreEqual("CXCII", Converter.Convert(192));
        }
        [TestMethod]
        public void Convert_193_Returns_CXCIII()
        {
            Assert.AreEqual("CXCIII", Converter.Convert(193));
        }
        [TestMethod]
        public void Convert_194_Returns_CXCIV()
        {
            Assert.AreEqual("CXCIV", Converter.Convert(194));
        }
        [TestMethod]
        public void Convert_195_Returns_CXCV()
        {
            Assert.AreEqual("CXCV", Converter.Convert(195));
        }
        [TestMethod]
        public void Convert_196_Returns_CXCVI()
        {
            Assert.AreEqual("CXCVI", Converter.Convert(196));
        }
        [TestMethod]
        public void Convert_197_Returns_CXCVII()
        {
            Assert.AreEqual("CXCVII", Converter.Convert(197));
        }
        [TestMethod]
        public void Convert_198_Returns_CXCVIII()
        {
            Assert.AreEqual("CXCVIII", Converter.Convert(198));
        }
        [TestMethod]
        public void Convert_199_Returns_CXCIX()
        {
            Assert.AreEqual("CXCIX", Converter.Convert(199));
        }
        [TestMethod]
        public void Convert_200_Returns_CC()
        {
            Assert.AreEqual("CC", Converter.Convert(200));
        }
        [TestMethod]
        public void Convert_201_Returns_CCI()
        {
            Assert.AreEqual("CCI", Converter.Convert(201));
        }
        [TestMethod]
        public void Convert_202_Returns_CCII()
        {
            Assert.AreEqual("CCII", Converter.Convert(202));
        }
        [TestMethod]
        public void Convert_203_Returns_CCIII()
        {
            Assert.AreEqual("CCIII", Converter.Convert(203));
        }
        [TestMethod]
        public void Convert_204_Returns_CCIV()
        {
            Assert.AreEqual("CCIV", Converter.Convert(204));
        }
        [TestMethod]
        public void Convert_205_Returns_CCV()
        {
            Assert.AreEqual("CCV", Converter.Convert(205));
        }
        [TestMethod]
        public void Convert_206_Returns_CCVI()
        {
            Assert.AreEqual("CCVI", Converter.Convert(206));
        }
        [TestMethod]
        public void Convert_207_Returns_CCVII()
        {
            Assert.AreEqual("CCVII", Converter.Convert(207));
        }
        [TestMethod]
        public void Convert_208_Returns_CCVIII()
        {
            Assert.AreEqual("CCVIII", Converter.Convert(208));
        }
        [TestMethod]
        public void Convert_209_Returns_CCIX()
        {
            Assert.AreEqual("CCIX", Converter.Convert(209));
        }
        [TestMethod]
        public void Convert_210_Returns_CCX()
        {
            Assert.AreEqual("CCX", Converter.Convert(210));
        }
        [TestMethod]
        public void Convert_211_Returns_CCXI()
        {
            Assert.AreEqual("CCXI", Converter.Convert(211));
        }
        [TestMethod]
        public void Convert_212_Returns_CCXII()
        {
            Assert.AreEqual("CCXII", Converter.Convert(212));
        }
        [TestMethod]
        public void Convert_213_Returns_CCXIII()
        {
            Assert.AreEqual("CCXIII", Converter.Convert(213));
        }
        [TestMethod]
        public void Convert_214_Returns_CCXIV()
        {
            Assert.AreEqual("CCXIV", Converter.Convert(214));
        }
        [TestMethod]
        public void Convert_215_Returns_CCXV()
        {
            Assert.AreEqual("CCXV", Converter.Convert(215));
        }
        [TestMethod]
        public void Convert_216_Returns_CCXVI()
        {
            Assert.AreEqual("CCXVI", Converter.Convert(216));
        }
        [TestMethod]
        public void Convert_217_Returns_CCXVII()
        {
            Assert.AreEqual("CCXVII", Converter.Convert(217));
        }
        [TestMethod]
        public void Convert_218_Returns_CCXVIII()
        {
            Assert.AreEqual("CCXVIII", Converter.Convert(218));
        }
        [TestMethod]
        public void Convert_219_Returns_CCXIX()
        {
            Assert.AreEqual("CCXIX", Converter.Convert(219));
        }
        [TestMethod]
        public void Convert_220_Returns_CCXX()
        {
            Assert.AreEqual("CCXX", Converter.Convert(220));
        }
        [TestMethod]
        public void Convert_221_Returns_CCXXI()
        {
            Assert.AreEqual("CCXXI", Converter.Convert(221));
        }
        [TestMethod]
        public void Convert_222_Returns_CCXXII()
        {
            Assert.AreEqual("CCXXII", Converter.Convert(222));
        }
        [TestMethod]
        public void Convert_223_Returns_CCXXIII()
        {
            Assert.AreEqual("CCXXIII", Converter.Convert(223));
        }
        [TestMethod]
        public void Convert_224_Returns_CCXXIV()
        {
            Assert.AreEqual("CCXXIV", Converter.Convert(224));
        }
        [TestMethod]
        public void Convert_225_Returns_CCXXV()
        {
            Assert.AreEqual("CCXXV", Converter.Convert(225));
        }
        [TestMethod]
        public void Convert_226_Returns_CCXXVI()
        {
            Assert.AreEqual("CCXXVI", Converter.Convert(226));
        }
        [TestMethod]
        public void Convert_227_Returns_CCXXVII()
        {
            Assert.AreEqual("CCXXVII", Converter.Convert(227));
        }
        [TestMethod]
        public void Convert_228_Returns_CCXXVIII()
        {
            Assert.AreEqual("CCXXVIII", Converter.Convert(228));
        }
        [TestMethod]
        public void Convert_229_Returns_CCXXIX()
        {
            Assert.AreEqual("CCXXIX", Converter.Convert(229));
        }
        [TestMethod]
        public void Convert_230_Returns_CCXXX()
        {
            Assert.AreEqual("CCXXX", Converter.Convert(230));
        }
        [TestMethod]
        public void Convert_231_Returns_CCXXXI()
        {
            Assert.AreEqual("CCXXXI", Converter.Convert(231));
        }
        [TestMethod]
        public void Convert_232_Returns_CCXXXII()
        {
            Assert.AreEqual("CCXXXII", Converter.Convert(232));
        }
        [TestMethod]
        public void Convert_233_Returns_CCXXXIII()
        {
            Assert.AreEqual("CCXXXIII", Converter.Convert(233));
        }
        [TestMethod]
        public void Convert_234_Returns_CCXXXIV()
        {
            Assert.AreEqual("CCXXXIV", Converter.Convert(234));
        }
        [TestMethod]
        public void Convert_235_Returns_CCXXXV()
        {
            Assert.AreEqual("CCXXXV", Converter.Convert(235));
        }
        [TestMethod]
        public void Convert_236_Returns_CCXXXVI()
        {
            Assert.AreEqual("CCXXXVI", Converter.Convert(236));
        }
        [TestMethod]
        public void Convert_237_Returns_CCXXXVII()
        {
            Assert.AreEqual("CCXXXVII", Converter.Convert(237));
        }
        [TestMethod]
        public void Convert_238_Returns_CCXXXVIII()
        {
            Assert.AreEqual("CCXXXVIII", Converter.Convert(238));
        }
        [TestMethod]
        public void Convert_239_Returns_CCXXXIX()
        {
            Assert.AreEqual("CCXXXIX", Converter.Convert(239));
        }
        [TestMethod]
        public void Convert_240_Returns_CCXL()
        {
            Assert.AreEqual("CCXL", Converter.Convert(240));
        }
        [TestMethod]
        public void Convert_241_Returns_CCXLI()
        {
            Assert.AreEqual("CCXLI", Converter.Convert(241));
        }
        [TestMethod]
        public void Convert_242_Returns_CCXLII()
        {
            Assert.AreEqual("CCXLII", Converter.Convert(242));
        }
        [TestMethod]
        public void Convert_243_Returns_CCXLIII()
        {
            Assert.AreEqual("CCXLIII", Converter.Convert(243));
        }
        [TestMethod]
        public void Convert_244_Returns_CCXLIV()
        {
            Assert.AreEqual("CCXLIV", Converter.Convert(244));
        }
        [TestMethod]
        public void Convert_245_Returns_CCXLV()
        {
            Assert.AreEqual("CCXLV", Converter.Convert(245));
        }
        [TestMethod]
        public void Convert_246_Returns_CCXLVI()
        {
            Assert.AreEqual("CCXLVI", Converter.Convert(246));
        }
        [TestMethod]
        public void Convert_247_Returns_CCXLVII()
        {
            Assert.AreEqual("CCXLVII", Converter.Convert(247));
        }
        [TestMethod]
        public void Convert_248_Returns_CCXLVIII()
        {
            Assert.AreEqual("CCXLVIII", Converter.Convert(248));
        }
        [TestMethod]
        public void Convert_249_Returns_CCXLIX()
        {
            Assert.AreEqual("CCXLIX", Converter.Convert(249));
        }
        [TestMethod]
        public void Convert_250_Returns_CCL()
        {
            Assert.AreEqual("CCL", Converter.Convert(250));
        }
        [TestMethod]
        public void Convert_251_Returns_CCLI()
        {
            Assert.AreEqual("CCLI", Converter.Convert(251));
        }
        [TestMethod]
        public void Convert_252_Returns_CCLII()
        {
            Assert.AreEqual("CCLII", Converter.Convert(252));
        }
        [TestMethod]
        public void Convert_253_Returns_CCLIII()
        {
            Assert.AreEqual("CCLIII", Converter.Convert(253));
        }
        [TestMethod]
        public void Convert_254_Returns_CCLIV()
        {
            Assert.AreEqual("CCLIV", Converter.Convert(254));
        }
        [TestMethod]
        public void Convert_255_Returns_CCLV()
        {
            Assert.AreEqual("CCLV", Converter.Convert(255));
        }
        [TestMethod]
        public void Convert_256_Returns_CCLVI()
        {
            Assert.AreEqual("CCLVI", Converter.Convert(256));
        }
        [TestMethod]
        public void Convert_257_Returns_CCLVII()
        {
            Assert.AreEqual("CCLVII", Converter.Convert(257));
        }
        [TestMethod]
        public void Convert_258_Returns_CCLVIII()
        {
            Assert.AreEqual("CCLVIII", Converter.Convert(258));
        }
        [TestMethod]
        public void Convert_259_Returns_CCLIX()
        {
            Assert.AreEqual("CCLIX", Converter.Convert(259));
        }
        [TestMethod]
        public void Convert_260_Returns_CCLX()
        {
            Assert.AreEqual("CCLX", Converter.Convert(260));
        }
        [TestMethod]
        public void Convert_261_Returns_CCLXI()
        {
            Assert.AreEqual("CCLXI", Converter.Convert(261));
        }
        [TestMethod]
        public void Convert_262_Returns_CCLXII()
        {
            Assert.AreEqual("CCLXII", Converter.Convert(262));
        }
        [TestMethod]
        public void Convert_263_Returns_CCLXIII()
        {
            Assert.AreEqual("CCLXIII", Converter.Convert(263));
        }
        [TestMethod]
        public void Convert_264_Returns_CCLXIV()
        {
            Assert.AreEqual("CCLXIV", Converter.Convert(264));
        }
        [TestMethod]
        public void Convert_265_Returns_CCLXV()
        {
            Assert.AreEqual("CCLXV", Converter.Convert(265));
        }
        [TestMethod]
        public void Convert_266_Returns_CCLXVI()
        {
            Assert.AreEqual("CCLXVI", Converter.Convert(266));
        }
        [TestMethod]
        public void Convert_267_Returns_CCLXVII()
        {
            Assert.AreEqual("CCLXVII", Converter.Convert(267));
        }
        [TestMethod]
        public void Convert_268_Returns_CCLXVIII()
        {
            Assert.AreEqual("CCLXVIII", Converter.Convert(268));
        }
        [TestMethod]
        public void Convert_269_Returns_CCLXIX()
        {
            Assert.AreEqual("CCLXIX", Converter.Convert(269));
        }
        [TestMethod]
        public void Convert_270_Returns_CCLXX()
        {
            Assert.AreEqual("CCLXX", Converter.Convert(270));
        }
        [TestMethod]
        public void Convert_271_Returns_CCLXXI()
        {
            Assert.AreEqual("CCLXXI", Converter.Convert(271));
        }
        [TestMethod]
        public void Convert_272_Returns_CCLXXII()
        {
            Assert.AreEqual("CCLXXII", Converter.Convert(272));
        }
        [TestMethod]
        public void Convert_273_Returns_CCLXXIII()
        {
            Assert.AreEqual("CCLXXIII", Converter.Convert(273));
        }
        [TestMethod]
        public void Convert_274_Returns_CCLXXIV()
        {
            Assert.AreEqual("CCLXXIV", Converter.Convert(274));
        }
        [TestMethod]
        public void Convert_275_Returns_CCLXXV()
        {
            Assert.AreEqual("CCLXXV", Converter.Convert(275));
        }
        [TestMethod]
        public void Convert_276_Returns_CCLXXVI()
        {
            Assert.AreEqual("CCLXXVI", Converter.Convert(276));
        }
        [TestMethod]
        public void Convert_277_Returns_CCLXXVII()
        {
            Assert.AreEqual("CCLXXVII", Converter.Convert(277));
        }
        [TestMethod]
        public void Convert_278_Returns_CCLXXVIII()
        {
            Assert.AreEqual("CCLXXVIII", Converter.Convert(278));
        }
        [TestMethod]
        public void Convert_279_Returns_CCLXXIX()
        {
            Assert.AreEqual("CCLXXIX", Converter.Convert(279));
        }
        [TestMethod]
        public void Convert_280_Returns_CCLXXX()
        {
            Assert.AreEqual("CCLXXX", Converter.Convert(280));
        }
        [TestMethod]
        public void Convert_281_Returns_CCLXXXI()
        {
            Assert.AreEqual("CCLXXXI", Converter.Convert(281));
        }
        [TestMethod]
        public void Convert_282_Returns_CCLXXXII()
        {
            Assert.AreEqual("CCLXXXII", Converter.Convert(282));
        }
        [TestMethod]
        public void Convert_283_Returns_CCLXXXIII()
        {
            Assert.AreEqual("CCLXXXIII", Converter.Convert(283));
        }
        [TestMethod]
        public void Convert_284_Returns_CCLXXXIV()
        {
            Assert.AreEqual("CCLXXXIV", Converter.Convert(284));
        }
        [TestMethod]
        public void Convert_285_Returns_CCLXXXV()
        {
            Assert.AreEqual("CCLXXXV", Converter.Convert(285));
        }
        [TestMethod]
        public void Convert_286_Returns_CCLXXXVI()
        {
            Assert.AreEqual("CCLXXXVI", Converter.Convert(286));
        }
        [TestMethod]
        public void Convert_287_Returns_CCLXXXVII()
        {
            Assert.AreEqual("CCLXXXVII", Converter.Convert(287));
        }
        [TestMethod]
        public void Convert_288_Returns_CCLXXXVIII()
        {
            Assert.AreEqual("CCLXXXVIII", Converter.Convert(288));
        }
        [TestMethod]
        public void Convert_289_Returns_CCLXXXIX()
        {
            Assert.AreEqual("CCLXXXIX", Converter.Convert(289));
        }
        [TestMethod]
        public void Convert_290_Returns_CCXC()
        {
            Assert.AreEqual("CCXC", Converter.Convert(290));
        }
        [TestMethod]
        public void Convert_291_Returns_CCXCI()
        {
            Assert.AreEqual("CCXCI", Converter.Convert(291));
        }
        [TestMethod]
        public void Convert_292_Returns_CCXCII()
        {
            Assert.AreEqual("CCXCII", Converter.Convert(292));
        }
        [TestMethod]
        public void Convert_293_Returns_CCXCIII()
        {
            Assert.AreEqual("CCXCIII", Converter.Convert(293));
        }
        [TestMethod]
        public void Convert_294_Returns_CCXCIV()
        {
            Assert.AreEqual("CCXCIV", Converter.Convert(294));
        }
        [TestMethod]
        public void Convert_295_Returns_CCXCV()
        {
            Assert.AreEqual("CCXCV", Converter.Convert(295));
        }
        [TestMethod]
        public void Convert_296_Returns_CCXCVI()
        {
            Assert.AreEqual("CCXCVI", Converter.Convert(296));
        }
        [TestMethod]
        public void Convert_297_Returns_CCXCVII()
        {
            Assert.AreEqual("CCXCVII", Converter.Convert(297));
        }
        [TestMethod]
        public void Convert_298_Returns_CCXCVIII()
        {
            Assert.AreEqual("CCXCVIII", Converter.Convert(298));
        }
        [TestMethod]
        public void Convert_299_Returns_CCXCIX()
        {
            Assert.AreEqual("CCXCIX", Converter.Convert(299));
        }
        [TestMethod]
        public void Convert_300_Returns_CCC()
        {
            Assert.AreEqual("CCC", Converter.Convert(300));
        }
        [TestMethod]
        public void Convert_301_Returns_CCCI()
        {
            Assert.AreEqual("CCCI", Converter.Convert(301));
        }
        [TestMethod]
        public void Convert_302_Returns_CCCII()
        {
            Assert.AreEqual("CCCII", Converter.Convert(302));
        }
        [TestMethod]
        public void Convert_303_Returns_CCCIII()
        {
            Assert.AreEqual("CCCIII", Converter.Convert(303));
        }
        [TestMethod]
        public void Convert_304_Returns_CCCIV()
        {
            Assert.AreEqual("CCCIV", Converter.Convert(304));
        }
        [TestMethod]
        public void Convert_305_Returns_CCCV()
        {
            Assert.AreEqual("CCCV", Converter.Convert(305));
        }
        [TestMethod]
        public void Convert_306_Returns_CCCVI()
        {
            Assert.AreEqual("CCCVI", Converter.Convert(306));
        }
        [TestMethod]
        public void Convert_307_Returns_CCCVII()
        {
            Assert.AreEqual("CCCVII", Converter.Convert(307));
        }
        [TestMethod]
        public void Convert_308_Returns_CCCVIII()
        {
            Assert.AreEqual("CCCVIII", Converter.Convert(308));
        }
        [TestMethod]
        public void Convert_309_Returns_CCCIX()
        {
            Assert.AreEqual("CCCIX", Converter.Convert(309));
        }
        [TestMethod]
        public void Convert_310_Returns_CCCX()
        {
            Assert.AreEqual("CCCX", Converter.Convert(310));
        }
        [TestMethod]
        public void Convert_311_Returns_CCCXI()
        {
            Assert.AreEqual("CCCXI", Converter.Convert(311));
        }
        [TestMethod]
        public void Convert_312_Returns_CCCXII()
        {
            Assert.AreEqual("CCCXII", Converter.Convert(312));
        }
        [TestMethod]
        public void Convert_313_Returns_CCCXIII()
        {
            Assert.AreEqual("CCCXIII", Converter.Convert(313));
        }
        [TestMethod]
        public void Convert_314_Returns_CCCXIV()
        {
            Assert.AreEqual("CCCXIV", Converter.Convert(314));
        }
        [TestMethod]
        public void Convert_315_Returns_CCCXV()
        {
            Assert.AreEqual("CCCXV", Converter.Convert(315));
        }
        [TestMethod]
        public void Convert_316_Returns_CCCXVI()
        {
            Assert.AreEqual("CCCXVI", Converter.Convert(316));
        }
        [TestMethod]
        public void Convert_317_Returns_CCCXVII()
        {
            Assert.AreEqual("CCCXVII", Converter.Convert(317));
        }
        [TestMethod]
        public void Convert_318_Returns_CCCXVIII()
        {
            Assert.AreEqual("CCCXVIII", Converter.Convert(318));
        }
        [TestMethod]
        public void Convert_319_Returns_CCCXIX()
        {
            Assert.AreEqual("CCCXIX", Converter.Convert(319));
        }
        [TestMethod]
        public void Convert_320_Returns_CCCXX()
        {
            Assert.AreEqual("CCCXX", Converter.Convert(320));
        }
        [TestMethod]
        public void Convert_321_Returns_CCCXXI()
        {
            Assert.AreEqual("CCCXXI", Converter.Convert(321));
        }
        [TestMethod]
        public void Convert_322_Returns_CCCXXII()
        {
            Assert.AreEqual("CCCXXII", Converter.Convert(322));
        }
        [TestMethod]
        public void Convert_323_Returns_CCCXXIII()
        {
            Assert.AreEqual("CCCXXIII", Converter.Convert(323));
        }
        [TestMethod]
        public void Convert_324_Returns_CCCXXIV()
        {
            Assert.AreEqual("CCCXXIV", Converter.Convert(324));
        }
        [TestMethod]
        public void Convert_325_Returns_CCCXXV()
        {
            Assert.AreEqual("CCCXXV", Converter.Convert(325));
        }
        [TestMethod]
        public void Convert_326_Returns_CCCXXVI()
        {
            Assert.AreEqual("CCCXXVI", Converter.Convert(326));
        }
        [TestMethod]
        public void Convert_327_Returns_CCCXXVII()
        {
            Assert.AreEqual("CCCXXVII", Converter.Convert(327));
        }
        [TestMethod]
        public void Convert_328_Returns_CCCXXVIII()
        {
            Assert.AreEqual("CCCXXVIII", Converter.Convert(328));
        }
        [TestMethod]
        public void Convert_329_Returns_CCCXXIX()
        {
            Assert.AreEqual("CCCXXIX", Converter.Convert(329));
        }
        [TestMethod]
        public void Convert_330_Returns_CCCXXX()
        {
            Assert.AreEqual("CCCXXX", Converter.Convert(330));
        }
        [TestMethod]
        public void Convert_331_Returns_CCCXXXI()
        {
            Assert.AreEqual("CCCXXXI", Converter.Convert(331));
        }
        [TestMethod]
        public void Convert_332_Returns_CCCXXXII()
        {
            Assert.AreEqual("CCCXXXII", Converter.Convert(332));
        }
        [TestMethod]
        public void Convert_333_Returns_CCCXXXIII()
        {
            Assert.AreEqual("CCCXXXIII", Converter.Convert(333));
        }
        [TestMethod]
        public void Convert_334_Returns_CCCXXXIV()
        {
            Assert.AreEqual("CCCXXXIV", Converter.Convert(334));
        }
        [TestMethod]
        public void Convert_335_Returns_CCCXXXV()
        {
            Assert.AreEqual("CCCXXXV", Converter.Convert(335));
        }
        [TestMethod]
        public void Convert_336_Returns_CCCXXXVI()
        {
            Assert.AreEqual("CCCXXXVI", Converter.Convert(336));
        }
        [TestMethod]
        public void Convert_337_Returns_CCCXXXVII()
        {
            Assert.AreEqual("CCCXXXVII", Converter.Convert(337));
        }
        [TestMethod]
        public void Convert_338_Returns_CCCXXXVIII()
        {
            Assert.AreEqual("CCCXXXVIII", Converter.Convert(338));
        }
        [TestMethod]
        public void Convert_339_Returns_CCCXXXIX()
        {
            Assert.AreEqual("CCCXXXIX", Converter.Convert(339));
        }
        [TestMethod]
        public void Convert_340_Returns_CCCXL()
        {
            Assert.AreEqual("CCCXL", Converter.Convert(340));
        }
        [TestMethod]
        public void Convert_341_Returns_CCCXLI()
        {
            Assert.AreEqual("CCCXLI", Converter.Convert(341));
        }
        [TestMethod]
        public void Convert_342_Returns_CCCXLII()
        {
            Assert.AreEqual("CCCXLII", Converter.Convert(342));
        }
        [TestMethod]
        public void Convert_343_Returns_CCCXLIII()
        {
            Assert.AreEqual("CCCXLIII", Converter.Convert(343));
        }
        [TestMethod]
        public void Convert_344_Returns_CCCXLIV()
        {
            Assert.AreEqual("CCCXLIV", Converter.Convert(344));
        }
        [TestMethod]
        public void Convert_345_Returns_CCCXLV()
        {
            Assert.AreEqual("CCCXLV", Converter.Convert(345));
        }
        [TestMethod]
        public void Convert_346_Returns_CCCXLVI()
        {
            Assert.AreEqual("CCCXLVI", Converter.Convert(346));
        }
        [TestMethod]
        public void Convert_347_Returns_CCCXLVII()
        {
            Assert.AreEqual("CCCXLVII", Converter.Convert(347));
        }
        [TestMethod]
        public void Convert_348_Returns_CCCXLVIII()
        {
            Assert.AreEqual("CCCXLVIII", Converter.Convert(348));
        }
        [TestMethod]
        public void Convert_349_Returns_CCCXLIX()
        {
            Assert.AreEqual("CCCXLIX", Converter.Convert(349));
        }
        [TestMethod]
        public void Convert_350_Returns_CCCL()
        {
            Assert.AreEqual("CCCL", Converter.Convert(350));
        }
        [TestMethod]
        public void Convert_351_Returns_CCCLI()
        {
            Assert.AreEqual("CCCLI", Converter.Convert(351));
        }
        [TestMethod]
        public void Convert_352_Returns_CCCLII()
        {
            Assert.AreEqual("CCCLII", Converter.Convert(352));
        }
        [TestMethod]
        public void Convert_353_Returns_CCCLIII()
        {
            Assert.AreEqual("CCCLIII", Converter.Convert(353));
        }
        [TestMethod]
        public void Convert_354_Returns_CCCLIV()
        {
            Assert.AreEqual("CCCLIV", Converter.Convert(354));
        }
        [TestMethod]
        public void Convert_355_Returns_CCCLV()
        {
            Assert.AreEqual("CCCLV", Converter.Convert(355));
        }
        [TestMethod]
        public void Convert_356_Returns_CCCLVI()
        {
            Assert.AreEqual("CCCLVI", Converter.Convert(356));
        }
        [TestMethod]
        public void Convert_357_Returns_CCCLVII()
        {
            Assert.AreEqual("CCCLVII", Converter.Convert(357));
        }
        [TestMethod]
        public void Convert_358_Returns_CCCLVIII()
        {
            Assert.AreEqual("CCCLVIII", Converter.Convert(358));
        }
        [TestMethod]
        public void Convert_359_Returns_CCCLIX()
        {
            Assert.AreEqual("CCCLIX", Converter.Convert(359));
        }
        [TestMethod]
        public void Convert_360_Returns_CCCLX()
        {
            Assert.AreEqual("CCCLX", Converter.Convert(360));
        }
        [TestMethod]
        public void Convert_361_Returns_CCCLXI()
        {
            Assert.AreEqual("CCCLXI", Converter.Convert(361));
        }
        [TestMethod]
        public void Convert_362_Returns_CCCLXII()
        {
            Assert.AreEqual("CCCLXII", Converter.Convert(362));
        }
        [TestMethod]
        public void Convert_363_Returns_CCCLXIII()
        {
            Assert.AreEqual("CCCLXIII", Converter.Convert(363));
        }
        [TestMethod]
        public void Convert_364_Returns_CCCLXIV()
        {
            Assert.AreEqual("CCCLXIV", Converter.Convert(364));
        }
        [TestMethod]
        public void Convert_365_Returns_CCCLXV()
        {
            Assert.AreEqual("CCCLXV", Converter.Convert(365));
        }
        [TestMethod]
        public void Convert_366_Returns_CCCLXVI()
        {
            Assert.AreEqual("CCCLXVI", Converter.Convert(366));
        }
        [TestMethod]
        public void Convert_367_Returns_CCCLXVII()
        {
            Assert.AreEqual("CCCLXVII", Converter.Convert(367));
        }
        [TestMethod]
        public void Convert_368_Returns_CCCLXVIII()
        {
            Assert.AreEqual("CCCLXVIII", Converter.Convert(368));
        }
        [TestMethod]
        public void Convert_369_Returns_CCCLXIX()
        {
            Assert.AreEqual("CCCLXIX", Converter.Convert(369));
        }
        [TestMethod]
        public void Convert_370_Returns_CCCLXX()
        {
            Assert.AreEqual("CCCLXX", Converter.Convert(370));
        }
        [TestMethod]
        public void Convert_371_Returns_CCCLXXI()
        {
            Assert.AreEqual("CCCLXXI", Converter.Convert(371));
        }
        [TestMethod]
        public void Convert_372_Returns_CCCLXXII()
        {
            Assert.AreEqual("CCCLXXII", Converter.Convert(372));
        }
        [TestMethod]
        public void Convert_373_Returns_CCCLXXIII()
        {
            Assert.AreEqual("CCCLXXIII", Converter.Convert(373));
        }
        [TestMethod]
        public void Convert_374_Returns_CCCLXXIV()
        {
            Assert.AreEqual("CCCLXXIV", Converter.Convert(374));
        }
        [TestMethod]
        public void Convert_375_Returns_CCCLXXV()
        {
            Assert.AreEqual("CCCLXXV", Converter.Convert(375));
        }
        [TestMethod]
        public void Convert_376_Returns_CCCLXXVI()
        {
            Assert.AreEqual("CCCLXXVI", Converter.Convert(376));
        }
        [TestMethod]
        public void Convert_377_Returns_CCCLXXVII()
        {
            Assert.AreEqual("CCCLXXVII", Converter.Convert(377));
        }
        [TestMethod]
        public void Convert_378_Returns_CCCLXXVIII()
        {
            Assert.AreEqual("CCCLXXVIII", Converter.Convert(378));
        }
        [TestMethod]
        public void Convert_379_Returns_CCCLXXIX()
        {
            Assert.AreEqual("CCCLXXIX", Converter.Convert(379));
        }
        [TestMethod]
        public void Convert_380_Returns_CCCLXXX()
        {
            Assert.AreEqual("CCCLXXX", Converter.Convert(380));
        }
        [TestMethod]
        public void Convert_381_Returns_CCCLXXXI()
        {
            Assert.AreEqual("CCCLXXXI", Converter.Convert(381));
        }
        [TestMethod]
        public void Convert_382_Returns_CCCLXXXII()
        {
            Assert.AreEqual("CCCLXXXII", Converter.Convert(382));
        }
        [TestMethod]
        public void Convert_383_Returns_CCCLXXXIII()
        {
            Assert.AreEqual("CCCLXXXIII", Converter.Convert(383));
        }
        [TestMethod]
        public void Convert_384_Returns_CCCLXXXIV()
        {
            Assert.AreEqual("CCCLXXXIV", Converter.Convert(384));
        }
        [TestMethod]
        public void Convert_385_Returns_CCCLXXXV()
        {
            Assert.AreEqual("CCCLXXXV", Converter.Convert(385));
        }
        [TestMethod]
        public void Convert_386_Returns_CCCLXXXVI()
        {
            Assert.AreEqual("CCCLXXXVI", Converter.Convert(386));
        }
        [TestMethod]
        public void Convert_387_Returns_CCCLXXXVII()
        {
            Assert.AreEqual("CCCLXXXVII", Converter.Convert(387));
        }
        [TestMethod]
        public void Convert_388_Returns_CCCLXXXVIII()
        {
            Assert.AreEqual("CCCLXXXVIII", Converter.Convert(388));
        }
        [TestMethod]
        public void Convert_389_Returns_CCCLXXXIX()
        {
            Assert.AreEqual("CCCLXXXIX", Converter.Convert(389));
        }
        [TestMethod]
        public void Convert_390_Returns_CCCXC()
        {
            Assert.AreEqual("CCCXC", Converter.Convert(390));
        }
        [TestMethod]
        public void Convert_391_Returns_CCCXCI()
        {
            Assert.AreEqual("CCCXCI", Converter.Convert(391));
        }
        [TestMethod]
        public void Convert_392_Returns_CCCXCII()
        {
            Assert.AreEqual("CCCXCII", Converter.Convert(392));
        }
        [TestMethod]
        public void Convert_393_Returns_CCCXCIII()
        {
            Assert.AreEqual("CCCXCIII", Converter.Convert(393));
        }
        [TestMethod]
        public void Convert_394_Returns_CCCXCIV()
        {
            Assert.AreEqual("CCCXCIV", Converter.Convert(394));
        }
        [TestMethod]
        public void Convert_395_Returns_CCCXCV()
        {
            Assert.AreEqual("CCCXCV", Converter.Convert(395));
        }
        [TestMethod]
        public void Convert_396_Returns_CCCXCVI()
        {
            Assert.AreEqual("CCCXCVI", Converter.Convert(396));
        }
        [TestMethod]
        public void Convert_397_Returns_CCCXCVII()
        {
            Assert.AreEqual("CCCXCVII", Converter.Convert(397));
        }
        [TestMethod]
        public void Convert_398_Returns_CCCXCVIII()
        {
            Assert.AreEqual("CCCXCVIII", Converter.Convert(398));
        }
        [TestMethod]
        public void Convert_399_Returns_CCCXCIX()
        {
            Assert.AreEqual("CCCXCIX", Converter.Convert(399));
        }
        [TestMethod]
        public void Convert_400_Returns_CD()
        {
            Assert.AreEqual("CD", Converter.Convert(400));
        }
        [TestMethod]
        public void Convert_401_Returns_CDI()
        {
            Assert.AreEqual("CDI", Converter.Convert(401));
        }
        [TestMethod]
        public void Convert_402_Returns_CDII()
        {
            Assert.AreEqual("CDII", Converter.Convert(402));
        }
        [TestMethod]
        public void Convert_403_Returns_CDIII()
        {
            Assert.AreEqual("CDIII", Converter.Convert(403));
        }
        [TestMethod]
        public void Convert_404_Returns_CDIV()
        {
            Assert.AreEqual("CDIV", Converter.Convert(404));
        }
        [TestMethod]
        public void Convert_405_Returns_CDV()
        {
            Assert.AreEqual("CDV", Converter.Convert(405));
        }
        [TestMethod]
        public void Convert_406_Returns_CDVI()
        {
            Assert.AreEqual("CDVI", Converter.Convert(406));
        }
        [TestMethod]
        public void Convert_407_Returns_CDVII()
        {
            Assert.AreEqual("CDVII", Converter.Convert(407));
        }
        [TestMethod]
        public void Convert_408_Returns_CDVIII()
        {
            Assert.AreEqual("CDVIII", Converter.Convert(408));
        }
        [TestMethod]
        public void Convert_409_Returns_CDIX()
        {
            Assert.AreEqual("CDIX", Converter.Convert(409));
        }
        [TestMethod]
        public void Convert_410_Returns_CDX()
        {
            Assert.AreEqual("CDX", Converter.Convert(410));
        }
        [TestMethod]
        public void Convert_411_Returns_CDXI()
        {
            Assert.AreEqual("CDXI", Converter.Convert(411));
        }
        [TestMethod]
        public void Convert_412_Returns_CDXII()
        {
            Assert.AreEqual("CDXII", Converter.Convert(412));
        }
        [TestMethod]
        public void Convert_413_Returns_CDXIII()
        {
            Assert.AreEqual("CDXIII", Converter.Convert(413));
        }
        [TestMethod]
        public void Convert_414_Returns_CDXIV()
        {
            Assert.AreEqual("CDXIV", Converter.Convert(414));
        }
        [TestMethod]
        public void Convert_415_Returns_CDXV()
        {
            Assert.AreEqual("CDXV", Converter.Convert(415));
        }
        [TestMethod]
        public void Convert_416_Returns_CDXVI()
        {
            Assert.AreEqual("CDXVI", Converter.Convert(416));
        }
        [TestMethod]
        public void Convert_417_Returns_CDXVII()
        {
            Assert.AreEqual("CDXVII", Converter.Convert(417));
        }
        [TestMethod]
        public void Convert_418_Returns_CDXVIII()
        {
            Assert.AreEqual("CDXVIII", Converter.Convert(418));
        }
        [TestMethod]
        public void Convert_419_Returns_CDXIX()
        {
            Assert.AreEqual("CDXIX", Converter.Convert(419));
        }
        [TestMethod]
        public void Convert_420_Returns_CDXX()
        {
            Assert.AreEqual("CDXX", Converter.Convert(420));
        }
        [TestMethod]
        public void Convert_421_Returns_CDXXI()
        {
            Assert.AreEqual("CDXXI", Converter.Convert(421));
        }
        [TestMethod]
        public void Convert_422_Returns_CDXXII()
        {
            Assert.AreEqual("CDXXII", Converter.Convert(422));
        }
        [TestMethod]
        public void Convert_423_Returns_CDXXIII()
        {
            Assert.AreEqual("CDXXIII", Converter.Convert(423));
        }
        [TestMethod]
        public void Convert_424_Returns_CDXXIV()
        {
            Assert.AreEqual("CDXXIV", Converter.Convert(424));
        }
        [TestMethod]
        public void Convert_425_Returns_CDXXV()
        {
            Assert.AreEqual("CDXXV", Converter.Convert(425));
        }
        [TestMethod]
        public void Convert_426_Returns_CDXXVI()
        {
            Assert.AreEqual("CDXXVI", Converter.Convert(426));
        }
        [TestMethod]
        public void Convert_427_Returns_CDXXVII()
        {
            Assert.AreEqual("CDXXVII", Converter.Convert(427));
        }
        [TestMethod]
        public void Convert_428_Returns_CDXXVIII()
        {
            Assert.AreEqual("CDXXVIII", Converter.Convert(428));
        }
        [TestMethod]
        public void Convert_429_Returns_CDXXIX()
        {
            Assert.AreEqual("CDXXIX", Converter.Convert(429));
        }
        [TestMethod]
        public void Convert_430_Returns_CDXXX()
        {
            Assert.AreEqual("CDXXX", Converter.Convert(430));
        }
        [TestMethod]
        public void Convert_431_Returns_CDXXXI()
        {
            Assert.AreEqual("CDXXXI", Converter.Convert(431));
        }
        [TestMethod]
        public void Convert_432_Returns_CDXXXII()
        {
            Assert.AreEqual("CDXXXII", Converter.Convert(432));
        }
        [TestMethod]
        public void Convert_433_Returns_CDXXXIII()
        {
            Assert.AreEqual("CDXXXIII", Converter.Convert(433));
        }
        [TestMethod]
        public void Convert_434_Returns_CDXXXIV()
        {
            Assert.AreEqual("CDXXXIV", Converter.Convert(434));
        }
        [TestMethod]
        public void Convert_435_Returns_CDXXXV()
        {
            Assert.AreEqual("CDXXXV", Converter.Convert(435));
        }
        [TestMethod]
        public void Convert_436_Returns_CDXXXVI()
        {
            Assert.AreEqual("CDXXXVI", Converter.Convert(436));
        }
        [TestMethod]
        public void Convert_437_Returns_CDXXXVII()
        {
            Assert.AreEqual("CDXXXVII", Converter.Convert(437));
        }
        [TestMethod]
        public void Convert_438_Returns_CDXXXVIII()
        {
            Assert.AreEqual("CDXXXVIII", Converter.Convert(438));
        }
        [TestMethod]
        public void Convert_439_Returns_CDXXXIX()
        {
            Assert.AreEqual("CDXXXIX", Converter.Convert(439));
        }
        [TestMethod]
        public void Convert_440_Returns_CDXL()
        {
            Assert.AreEqual("CDXL", Converter.Convert(440));
        }
        [TestMethod]
        public void Convert_441_Returns_CDXLI()
        {
            Assert.AreEqual("CDXLI", Converter.Convert(441));
        }
        [TestMethod]
        public void Convert_442_Returns_CDXLII()
        {
            Assert.AreEqual("CDXLII", Converter.Convert(442));
        }
        [TestMethod]
        public void Convert_443_Returns_CDXLIII()
        {
            Assert.AreEqual("CDXLIII", Converter.Convert(443));
        }
        [TestMethod]
        public void Convert_444_Returns_CDXLIV()
        {
            Assert.AreEqual("CDXLIV", Converter.Convert(444));
        }
        [TestMethod]
        public void Convert_445_Returns_CDXLV()
        {
            Assert.AreEqual("CDXLV", Converter.Convert(445));
        }
        [TestMethod]
        public void Convert_446_Returns_CDXLVI()
        {
            Assert.AreEqual("CDXLVI", Converter.Convert(446));
        }
        [TestMethod]
        public void Convert_447_Returns_CDXLVII()
        {
            Assert.AreEqual("CDXLVII", Converter.Convert(447));
        }
        [TestMethod]
        public void Convert_448_Returns_CDXLVIII()
        {
            Assert.AreEqual("CDXLVIII", Converter.Convert(448));
        }
        [TestMethod]
        public void Convert_449_Returns_CDXLIX()
        {
            Assert.AreEqual("CDXLIX", Converter.Convert(449));
        }
        [TestMethod]
        public void Convert_450_Returns_CDL()
        {
            Assert.AreEqual("CDL", Converter.Convert(450));
        }
        [TestMethod]
        public void Convert_451_Returns_CDLI()
        {
            Assert.AreEqual("CDLI", Converter.Convert(451));
        }
        [TestMethod]
        public void Convert_452_Returns_CDLII()
        {
            Assert.AreEqual("CDLII", Converter.Convert(452));
        }
        [TestMethod]
        public void Convert_453_Returns_CDLIII()
        {
            Assert.AreEqual("CDLIII", Converter.Convert(453));
        }
        [TestMethod]
        public void Convert_454_Returns_CDLIV()
        {
            Assert.AreEqual("CDLIV", Converter.Convert(454));
        }
        [TestMethod]
        public void Convert_455_Returns_CDLV()
        {
            Assert.AreEqual("CDLV", Converter.Convert(455));
        }
        [TestMethod]
        public void Convert_456_Returns_CDLVI()
        {
            Assert.AreEqual("CDLVI", Converter.Convert(456));
        }
        [TestMethod]
        public void Convert_457_Returns_CDLVII()
        {
            Assert.AreEqual("CDLVII", Converter.Convert(457));
        }
        [TestMethod]
        public void Convert_458_Returns_CDLVIII()
        {
            Assert.AreEqual("CDLVIII", Converter.Convert(458));
        }
        [TestMethod]
        public void Convert_459_Returns_CDLIX()
        {
            Assert.AreEqual("CDLIX", Converter.Convert(459));
        }
        [TestMethod]
        public void Convert_460_Returns_CDLX()
        {
            Assert.AreEqual("CDLX", Converter.Convert(460));
        }
        [TestMethod]
        public void Convert_461_Returns_CDLXI()
        {
            Assert.AreEqual("CDLXI", Converter.Convert(461));
        }
        [TestMethod]
        public void Convert_462_Returns_CDLXII()
        {
            Assert.AreEqual("CDLXII", Converter.Convert(462));
        }
        [TestMethod]
        public void Convert_463_Returns_CDLXIII()
        {
            Assert.AreEqual("CDLXIII", Converter.Convert(463));
        }
        [TestMethod]
        public void Convert_464_Returns_CDLXIV()
        {
            Assert.AreEqual("CDLXIV", Converter.Convert(464));
        }
        [TestMethod]
        public void Convert_465_Returns_CDLXV()
        {
            Assert.AreEqual("CDLXV", Converter.Convert(465));
        }
        [TestMethod]
        public void Convert_466_Returns_CDLXVI()
        {
            Assert.AreEqual("CDLXVI", Converter.Convert(466));
        }
        [TestMethod]
        public void Convert_467_Returns_CDLXVII()
        {
            Assert.AreEqual("CDLXVII", Converter.Convert(467));
        }
        [TestMethod]
        public void Convert_468_Returns_CDLXVIII()
        {
            Assert.AreEqual("CDLXVIII", Converter.Convert(468));
        }
        [TestMethod]
        public void Convert_469_Returns_CDLXIX()
        {
            Assert.AreEqual("CDLXIX", Converter.Convert(469));
        }
        [TestMethod]
        public void Convert_470_Returns_CDLXX()
        {
            Assert.AreEqual("CDLXX", Converter.Convert(470));
        }
        [TestMethod]
        public void Convert_471_Returns_CDLXXI()
        {
            Assert.AreEqual("CDLXXI", Converter.Convert(471));
        }
        [TestMethod]
        public void Convert_472_Returns_CDLXXII()
        {
            Assert.AreEqual("CDLXXII", Converter.Convert(472));
        }
        [TestMethod]
        public void Convert_473_Returns_CDLXXIII()
        {
            Assert.AreEqual("CDLXXIII", Converter.Convert(473));
        }
        [TestMethod]
        public void Convert_474_Returns_CDLXXIV()
        {
            Assert.AreEqual("CDLXXIV", Converter.Convert(474));
        }
        [TestMethod]
        public void Convert_475_Returns_CDLXXV()
        {
            Assert.AreEqual("CDLXXV", Converter.Convert(475));
        }
        [TestMethod]
        public void Convert_476_Returns_CDLXXVI()
        {
            Assert.AreEqual("CDLXXVI", Converter.Convert(476));
        }
        [TestMethod]
        public void Convert_477_Returns_CDLXXVII()
        {
            Assert.AreEqual("CDLXXVII", Converter.Convert(477));
        }
        [TestMethod]
        public void Convert_478_Returns_CDLXXVIII()
        {
            Assert.AreEqual("CDLXXVIII", Converter.Convert(478));
        }
        [TestMethod]
        public void Convert_479_Returns_CDLXXIX()
        {
            Assert.AreEqual("CDLXXIX", Converter.Convert(479));
        }
        [TestMethod]
        public void Convert_480_Returns_CDLXXX()
        {
            Assert.AreEqual("CDLXXX", Converter.Convert(480));
        }
        [TestMethod]
        public void Convert_481_Returns_CDLXXXI()
        {
            Assert.AreEqual("CDLXXXI", Converter.Convert(481));
        }
        [TestMethod]
        public void Convert_482_Returns_CDLXXXII()
        {
            Assert.AreEqual("CDLXXXII", Converter.Convert(482));
        }
        [TestMethod]
        public void Convert_483_Returns_CDLXXXIII()
        {
            Assert.AreEqual("CDLXXXIII", Converter.Convert(483));
        }
        [TestMethod]
        public void Convert_484_Returns_CDLXXXIV()
        {
            Assert.AreEqual("CDLXXXIV", Converter.Convert(484));
        }
        [TestMethod]
        public void Convert_485_Returns_CDLXXXV()
        {
            Assert.AreEqual("CDLXXXV", Converter.Convert(485));
        }
        [TestMethod]
        public void Convert_486_Returns_CDLXXXVI()
        {
            Assert.AreEqual("CDLXXXVI", Converter.Convert(486));
        }
        [TestMethod]
        public void Convert_487_Returns_CDLXXXVII()
        {
            Assert.AreEqual("CDLXXXVII", Converter.Convert(487));
        }
        [TestMethod]
        public void Convert_488_Returns_CDLXXXVIII()
        {
            Assert.AreEqual("CDLXXXVIII", Converter.Convert(488));
        }
        [TestMethod]
        public void Convert_489_Returns_CDLXXXIX()
        {
            Assert.AreEqual("CDLXXXIX", Converter.Convert(489));
        }
        [TestMethod]
        public void Convert_490_Returns_CDXC()
        {
            Assert.AreEqual("CDXC", Converter.Convert(490));
        }
        [TestMethod]
        public void Convert_491_Returns_CDXCI()
        {
            Assert.AreEqual("CDXCI", Converter.Convert(491));
        }
        [TestMethod]
        public void Convert_492_Returns_CDXCII()
        {
            Assert.AreEqual("CDXCII", Converter.Convert(492));
        }
        [TestMethod]
        public void Convert_493_Returns_CDXCIII()
        {
            Assert.AreEqual("CDXCIII", Converter.Convert(493));
        }
        [TestMethod]
        public void Convert_494_Returns_CDXCIV()
        {
            Assert.AreEqual("CDXCIV", Converter.Convert(494));
        }
        [TestMethod]
        public void Convert_495_Returns_CDXCV()
        {
            Assert.AreEqual("CDXCV", Converter.Convert(495));
        }
        [TestMethod]
        public void Convert_496_Returns_CDXCVI()
        {
            Assert.AreEqual("CDXCVI", Converter.Convert(496));
        }
        [TestMethod]
        public void Convert_497_Returns_CDXCVII()
        {
            Assert.AreEqual("CDXCVII", Converter.Convert(497));
        }
        [TestMethod]
        public void Convert_498_Returns_CDXCVIII()
        {
            Assert.AreEqual("CDXCVIII", Converter.Convert(498));
        }
        [TestMethod]
        public void Convert_499_Returns_CDXCIX()
        {
            Assert.AreEqual("CDXCIX", Converter.Convert(499));
        }
        [TestMethod]
        public void Convert_500_Returns_D()
        {
            Assert.AreEqual("D", Converter.Convert(500));
        }
        [TestMethod]
        public void Convert_501_Returns_DI()
        {
            Assert.AreEqual("DI", Converter.Convert(501));
        }
        [TestMethod]
        public void Convert_502_Returns_DII()
        {
            Assert.AreEqual("DII", Converter.Convert(502));
        }
        [TestMethod]
        public void Convert_503_Returns_DIII()
        {
            Assert.AreEqual("DIII", Converter.Convert(503));
        }
        [TestMethod]
        public void Convert_504_Returns_DIV()
        {
            Assert.AreEqual("DIV", Converter.Convert(504));
        }
        [TestMethod]
        public void Convert_505_Returns_DV()
        {
            Assert.AreEqual("DV", Converter.Convert(505));
        }
        [TestMethod]
        public void Convert_506_Returns_DVI()
        {
            Assert.AreEqual("DVI", Converter.Convert(506));
        }
        [TestMethod]
        public void Convert_507_Returns_DVII()
        {
            Assert.AreEqual("DVII", Converter.Convert(507));
        }
        [TestMethod]
        public void Convert_508_Returns_DVIII()
        {
            Assert.AreEqual("DVIII", Converter.Convert(508));
        }
        [TestMethod]
        public void Convert_509_Returns_DIX()
        {
            Assert.AreEqual("DIX", Converter.Convert(509));
        }
        [TestMethod]
        public void Convert_510_Returns_DX()
        {
            Assert.AreEqual("DX", Converter.Convert(510));
        }
        [TestMethod]
        public void Convert_511_Returns_DXI()
        {
            Assert.AreEqual("DXI", Converter.Convert(511));
        }
        [TestMethod]
        public void Convert_512_Returns_DXII()
        {
            Assert.AreEqual("DXII", Converter.Convert(512));
        }
        [TestMethod]
        public void Convert_513_Returns_DXIII()
        {
            Assert.AreEqual("DXIII", Converter.Convert(513));
        }
        [TestMethod]
        public void Convert_514_Returns_DXIV()
        {
            Assert.AreEqual("DXIV", Converter.Convert(514));
        }
        [TestMethod]
        public void Convert_515_Returns_DXV()
        {
            Assert.AreEqual("DXV", Converter.Convert(515));
        }
        [TestMethod]
        public void Convert_516_Returns_DXVI()
        {
            Assert.AreEqual("DXVI", Converter.Convert(516));
        }
        [TestMethod]
        public void Convert_517_Returns_DXVII()
        {
            Assert.AreEqual("DXVII", Converter.Convert(517));
        }
        [TestMethod]
        public void Convert_518_Returns_DXVIII()
        {
            Assert.AreEqual("DXVIII", Converter.Convert(518));
        }
        [TestMethod]
        public void Convert_519_Returns_DXIX()
        {
            Assert.AreEqual("DXIX", Converter.Convert(519));
        }
        [TestMethod]
        public void Convert_520_Returns_DXX()
        {
            Assert.AreEqual("DXX", Converter.Convert(520));
        }
        [TestMethod]
        public void Convert_521_Returns_DXXI()
        {
            Assert.AreEqual("DXXI", Converter.Convert(521));
        }
        [TestMethod]
        public void Convert_522_Returns_DXXII()
        {
            Assert.AreEqual("DXXII", Converter.Convert(522));
        }
        [TestMethod]
        public void Convert_523_Returns_DXXIII()
        {
            Assert.AreEqual("DXXIII", Converter.Convert(523));
        }
        [TestMethod]
        public void Convert_524_Returns_DXXIV()
        {
            Assert.AreEqual("DXXIV", Converter.Convert(524));
        }
        [TestMethod]
        public void Convert_525_Returns_DXXV()
        {
            Assert.AreEqual("DXXV", Converter.Convert(525));
        }
        [TestMethod]
        public void Convert_526_Returns_DXXVI()
        {
            Assert.AreEqual("DXXVI", Converter.Convert(526));
        }
        [TestMethod]
        public void Convert_527_Returns_DXXVII()
        {
            Assert.AreEqual("DXXVII", Converter.Convert(527));
        }
        [TestMethod]
        public void Convert_528_Returns_DXXVIII()
        {
            Assert.AreEqual("DXXVIII", Converter.Convert(528));
        }
        [TestMethod]
        public void Convert_529_Returns_DXXIX()
        {
            Assert.AreEqual("DXXIX", Converter.Convert(529));
        }
        [TestMethod]
        public void Convert_530_Returns_DXXX()
        {
            Assert.AreEqual("DXXX", Converter.Convert(530));
        }
        [TestMethod]
        public void Convert_531_Returns_DXXXI()
        {
            Assert.AreEqual("DXXXI", Converter.Convert(531));
        }
        [TestMethod]
        public void Convert_532_Returns_DXXXII()
        {
            Assert.AreEqual("DXXXII", Converter.Convert(532));
        }
        [TestMethod]
        public void Convert_533_Returns_DXXXIII()
        {
            Assert.AreEqual("DXXXIII", Converter.Convert(533));
        }
        [TestMethod]
        public void Convert_534_Returns_DXXXIV()
        {
            Assert.AreEqual("DXXXIV", Converter.Convert(534));
        }
        [TestMethod]
        public void Convert_535_Returns_DXXXV()
        {
            Assert.AreEqual("DXXXV", Converter.Convert(535));
        }
        [TestMethod]
        public void Convert_536_Returns_DXXXVI()
        {
            Assert.AreEqual("DXXXVI", Converter.Convert(536));
        }
        [TestMethod]
        public void Convert_537_Returns_DXXXVII()
        {
            Assert.AreEqual("DXXXVII", Converter.Convert(537));
        }
        [TestMethod]
        public void Convert_538_Returns_DXXXVIII()
        {
            Assert.AreEqual("DXXXVIII", Converter.Convert(538));
        }
        [TestMethod]
        public void Convert_539_Returns_DXXXIX()
        {
            Assert.AreEqual("DXXXIX", Converter.Convert(539));
        }
        [TestMethod]
        public void Convert_540_Returns_DXL()
        {
            Assert.AreEqual("DXL", Converter.Convert(540));
        }
        [TestMethod]
        public void Convert_541_Returns_DXLI()
        {
            Assert.AreEqual("DXLI", Converter.Convert(541));
        }
        [TestMethod]
        public void Convert_542_Returns_DXLII()
        {
            Assert.AreEqual("DXLII", Converter.Convert(542));
        }
        [TestMethod]
        public void Convert_543_Returns_DXLIII()
        {
            Assert.AreEqual("DXLIII", Converter.Convert(543));
        }
        [TestMethod]
        public void Convert_544_Returns_DXLIV()
        {
            Assert.AreEqual("DXLIV", Converter.Convert(544));
        }
        [TestMethod]
        public void Convert_545_Returns_DXLV()
        {
            Assert.AreEqual("DXLV", Converter.Convert(545));
        }
        [TestMethod]
        public void Convert_546_Returns_DXLVI()
        {
            Assert.AreEqual("DXLVI", Converter.Convert(546));
        }
        [TestMethod]
        public void Convert_547_Returns_DXLVII()
        {
            Assert.AreEqual("DXLVII", Converter.Convert(547));
        }
        [TestMethod]
        public void Convert_548_Returns_DXLVIII()
        {
            Assert.AreEqual("DXLVIII", Converter.Convert(548));
        }
        [TestMethod]
        public void Convert_549_Returns_DXLIX()
        {
            Assert.AreEqual("DXLIX", Converter.Convert(549));
        }
        [TestMethod]
        public void Convert_550_Returns_DL()
        {
            Assert.AreEqual("DL", Converter.Convert(550));
        }
        [TestMethod]
        public void Convert_551_Returns_DLI()
        {
            Assert.AreEqual("DLI", Converter.Convert(551));
        }
        [TestMethod]
        public void Convert_552_Returns_DLII()
        {
            Assert.AreEqual("DLII", Converter.Convert(552));
        }
        [TestMethod]
        public void Convert_553_Returns_DLIII()
        {
            Assert.AreEqual("DLIII", Converter.Convert(553));
        }
        [TestMethod]
        public void Convert_554_Returns_DLIV()
        {
            Assert.AreEqual("DLIV", Converter.Convert(554));
        }
        [TestMethod]
        public void Convert_555_Returns_DLV()
        {
            Assert.AreEqual("DLV", Converter.Convert(555));
        }
        [TestMethod]
        public void Convert_556_Returns_DLVI()
        {
            Assert.AreEqual("DLVI", Converter.Convert(556));
        }
        [TestMethod]
        public void Convert_557_Returns_DLVII()
        {
            Assert.AreEqual("DLVII", Converter.Convert(557));
        }
        [TestMethod]
        public void Convert_558_Returns_DLVIII()
        {
            Assert.AreEqual("DLVIII", Converter.Convert(558));
        }
        [TestMethod]
        public void Convert_559_Returns_DLIX()
        {
            Assert.AreEqual("DLIX", Converter.Convert(559));
        }
        [TestMethod]
        public void Convert_560_Returns_DLX()
        {
            Assert.AreEqual("DLX", Converter.Convert(560));
        }
        [TestMethod]
        public void Convert_561_Returns_DLXI()
        {
            Assert.AreEqual("DLXI", Converter.Convert(561));
        }
        [TestMethod]
        public void Convert_562_Returns_DLXII()
        {
            Assert.AreEqual("DLXII", Converter.Convert(562));
        }
        [TestMethod]
        public void Convert_563_Returns_DLXIII()
        {
            Assert.AreEqual("DLXIII", Converter.Convert(563));
        }
        [TestMethod]
        public void Convert_564_Returns_DLXIV()
        {
            Assert.AreEqual("DLXIV", Converter.Convert(564));
        }
        [TestMethod]
        public void Convert_565_Returns_DLXV()
        {
            Assert.AreEqual("DLXV", Converter.Convert(565));
        }
        [TestMethod]
        public void Convert_566_Returns_DLXVI()
        {
            Assert.AreEqual("DLXVI", Converter.Convert(566));
        }
        [TestMethod]
        public void Convert_567_Returns_DLXVII()
        {
            Assert.AreEqual("DLXVII", Converter.Convert(567));
        }
        [TestMethod]
        public void Convert_568_Returns_DLXVIII()
        {
            Assert.AreEqual("DLXVIII", Converter.Convert(568));
        }
        [TestMethod]
        public void Convert_569_Returns_DLXIX()
        {
            Assert.AreEqual("DLXIX", Converter.Convert(569));
        }
        [TestMethod]
        public void Convert_570_Returns_DLXX()
        {
            Assert.AreEqual("DLXX", Converter.Convert(570));
        }
        [TestMethod]
        public void Convert_571_Returns_DLXXI()
        {
            Assert.AreEqual("DLXXI", Converter.Convert(571));
        }
        [TestMethod]
        public void Convert_572_Returns_DLXXII()
        {
            Assert.AreEqual("DLXXII", Converter.Convert(572));
        }
        [TestMethod]
        public void Convert_573_Returns_DLXXIII()
        {
            Assert.AreEqual("DLXXIII", Converter.Convert(573));
        }
        [TestMethod]
        public void Convert_574_Returns_DLXXIV()
        {
            Assert.AreEqual("DLXXIV", Converter.Convert(574));
        }
        [TestMethod]
        public void Convert_575_Returns_DLXXV()
        {
            Assert.AreEqual("DLXXV", Converter.Convert(575));
        }
        [TestMethod]
        public void Convert_576_Returns_DLXXVI()
        {
            Assert.AreEqual("DLXXVI", Converter.Convert(576));
        }
        [TestMethod]
        public void Convert_577_Returns_DLXXVII()
        {
            Assert.AreEqual("DLXXVII", Converter.Convert(577));
        }
        [TestMethod]
        public void Convert_578_Returns_DLXXVIII()
        {
            Assert.AreEqual("DLXXVIII", Converter.Convert(578));
        }
        [TestMethod]
        public void Convert_579_Returns_DLXXIX()
        {
            Assert.AreEqual("DLXXIX", Converter.Convert(579));
        }
        [TestMethod]
        public void Convert_580_Returns_DLXXX()
        {
            Assert.AreEqual("DLXXX", Converter.Convert(580));
        }
        [TestMethod]
        public void Convert_581_Returns_DLXXXI()
        {
            Assert.AreEqual("DLXXXI", Converter.Convert(581));
        }
        [TestMethod]
        public void Convert_582_Returns_DLXXXII()
        {
            Assert.AreEqual("DLXXXII", Converter.Convert(582));
        }
        [TestMethod]
        public void Convert_583_Returns_DLXXXIII()
        {
            Assert.AreEqual("DLXXXIII", Converter.Convert(583));
        }
        [TestMethod]
        public void Convert_584_Returns_DLXXXIV()
        {
            Assert.AreEqual("DLXXXIV", Converter.Convert(584));
        }
        [TestMethod]
        public void Convert_585_Returns_DLXXXV()
        {
            Assert.AreEqual("DLXXXV", Converter.Convert(585));
        }
        [TestMethod]
        public void Convert_586_Returns_DLXXXVI()
        {
            Assert.AreEqual("DLXXXVI", Converter.Convert(586));
        }
        [TestMethod]
        public void Convert_587_Returns_DLXXXVII()
        {
            Assert.AreEqual("DLXXXVII", Converter.Convert(587));
        }
        [TestMethod]
        public void Convert_588_Returns_DLXXXVIII()
        {
            Assert.AreEqual("DLXXXVIII", Converter.Convert(588));
        }
        [TestMethod]
        public void Convert_589_Returns_DLXXXIX()
        {
            Assert.AreEqual("DLXXXIX", Converter.Convert(589));
        }
        [TestMethod]
        public void Convert_590_Returns_DXC()
        {
            Assert.AreEqual("DXC", Converter.Convert(590));
        }
        [TestMethod]
        public void Convert_591_Returns_DXCI()
        {
            Assert.AreEqual("DXCI", Converter.Convert(591));
        }
        [TestMethod]
        public void Convert_592_Returns_DXCII()
        {
            Assert.AreEqual("DXCII", Converter.Convert(592));
        }
        [TestMethod]
        public void Convert_593_Returns_DXCIII()
        {
            Assert.AreEqual("DXCIII", Converter.Convert(593));
        }
        [TestMethod]
        public void Convert_594_Returns_DXCIV()
        {
            Assert.AreEqual("DXCIV", Converter.Convert(594));
        }
        [TestMethod]
        public void Convert_595_Returns_DXCV()
        {
            Assert.AreEqual("DXCV", Converter.Convert(595));
        }
        [TestMethod]
        public void Convert_596_Returns_DXCVI()
        {
            Assert.AreEqual("DXCVI", Converter.Convert(596));
        }
        [TestMethod]
        public void Convert_597_Returns_DXCVII()
        {
            Assert.AreEqual("DXCVII", Converter.Convert(597));
        }
        [TestMethod]
        public void Convert_598_Returns_DXCVIII()
        {
            Assert.AreEqual("DXCVIII", Converter.Convert(598));
        }
        [TestMethod]
        public void Convert_599_Returns_DXCIX()
        {
            Assert.AreEqual("DXCIX", Converter.Convert(599));
        }
        [TestMethod]
        public void Convert_600_Returns_DC()
        {
            Assert.AreEqual("DC", Converter.Convert(600));
        }
        [TestMethod]
        public void Convert_601_Returns_DCI()
        {
            Assert.AreEqual("DCI", Converter.Convert(601));
        }
        [TestMethod]
        public void Convert_602_Returns_DCII()
        {
            Assert.AreEqual("DCII", Converter.Convert(602));
        }
        [TestMethod]
        public void Convert_603_Returns_DCIII()
        {
            Assert.AreEqual("DCIII", Converter.Convert(603));
        }
        [TestMethod]
        public void Convert_604_Returns_DCIV()
        {
            Assert.AreEqual("DCIV", Converter.Convert(604));
        }
        [TestMethod]
        public void Convert_605_Returns_DCV()
        {
            Assert.AreEqual("DCV", Converter.Convert(605));
        }
        [TestMethod]
        public void Convert_606_Returns_DCVI()
        {
            Assert.AreEqual("DCVI", Converter.Convert(606));
        }
        [TestMethod]
        public void Convert_607_Returns_DCVII()
        {
            Assert.AreEqual("DCVII", Converter.Convert(607));
        }
        [TestMethod]
        public void Convert_608_Returns_DCVIII()
        {
            Assert.AreEqual("DCVIII", Converter.Convert(608));
        }
        [TestMethod]
        public void Convert_609_Returns_DCIX()
        {
            Assert.AreEqual("DCIX", Converter.Convert(609));
        }
        [TestMethod]
        public void Convert_610_Returns_DCX()
        {
            Assert.AreEqual("DCX", Converter.Convert(610));
        }
        [TestMethod]
        public void Convert_611_Returns_DCXI()
        {
            Assert.AreEqual("DCXI", Converter.Convert(611));
        }
        [TestMethod]
        public void Convert_612_Returns_DCXII()
        {
            Assert.AreEqual("DCXII", Converter.Convert(612));
        }
        [TestMethod]
        public void Convert_613_Returns_DCXIII()
        {
            Assert.AreEqual("DCXIII", Converter.Convert(613));
        }
        [TestMethod]
        public void Convert_614_Returns_DCXIV()
        {
            Assert.AreEqual("DCXIV", Converter.Convert(614));
        }
        [TestMethod]
        public void Convert_615_Returns_DCXV()
        {
            Assert.AreEqual("DCXV", Converter.Convert(615));
        }
        [TestMethod]
        public void Convert_616_Returns_DCXVI()
        {
            Assert.AreEqual("DCXVI", Converter.Convert(616));
        }
        [TestMethod]
        public void Convert_617_Returns_DCXVII()
        {
            Assert.AreEqual("DCXVII", Converter.Convert(617));
        }
        [TestMethod]
        public void Convert_618_Returns_DCXVIII()
        {
            Assert.AreEqual("DCXVIII", Converter.Convert(618));
        }
        [TestMethod]
        public void Convert_619_Returns_DCXIX()
        {
            Assert.AreEqual("DCXIX", Converter.Convert(619));
        }
        [TestMethod]
        public void Convert_620_Returns_DCXX()
        {
            Assert.AreEqual("DCXX", Converter.Convert(620));
        }
        [TestMethod]
        public void Convert_621_Returns_DCXXI()
        {
            Assert.AreEqual("DCXXI", Converter.Convert(621));
        }
        [TestMethod]
        public void Convert_622_Returns_DCXXII()
        {
            Assert.AreEqual("DCXXII", Converter.Convert(622));
        }
        [TestMethod]
        public void Convert_623_Returns_DCXXIII()
        {
            Assert.AreEqual("DCXXIII", Converter.Convert(623));
        }
        [TestMethod]
        public void Convert_624_Returns_DCXXIV()
        {
            Assert.AreEqual("DCXXIV", Converter.Convert(624));
        }
        [TestMethod]
        public void Convert_625_Returns_DCXXV()
        {
            Assert.AreEqual("DCXXV", Converter.Convert(625));
        }
        [TestMethod]
        public void Convert_626_Returns_DCXXVI()
        {
            Assert.AreEqual("DCXXVI", Converter.Convert(626));
        }
        [TestMethod]
        public void Convert_627_Returns_DCXXVII()
        {
            Assert.AreEqual("DCXXVII", Converter.Convert(627));
        }
        [TestMethod]
        public void Convert_628_Returns_DCXXVIII()
        {
            Assert.AreEqual("DCXXVIII", Converter.Convert(628));
        }
        [TestMethod]
        public void Convert_629_Returns_DCXXIX()
        {
            Assert.AreEqual("DCXXIX", Converter.Convert(629));
        }
        [TestMethod]
        public void Convert_630_Returns_DCXXX()
        {
            Assert.AreEqual("DCXXX", Converter.Convert(630));
        }
        [TestMethod]
        public void Convert_631_Returns_DCXXXI()
        {
            Assert.AreEqual("DCXXXI", Converter.Convert(631));
        }
        [TestMethod]
        public void Convert_632_Returns_DCXXXII()
        {
            Assert.AreEqual("DCXXXII", Converter.Convert(632));
        }
        [TestMethod]
        public void Convert_633_Returns_DCXXXIII()
        {
            Assert.AreEqual("DCXXXIII", Converter.Convert(633));
        }
        [TestMethod]
        public void Convert_634_Returns_DCXXXIV()
        {
            Assert.AreEqual("DCXXXIV", Converter.Convert(634));
        }
        [TestMethod]
        public void Convert_635_Returns_DCXXXV()
        {
            Assert.AreEqual("DCXXXV", Converter.Convert(635));
        }
        [TestMethod]
        public void Convert_636_Returns_DCXXXVI()
        {
            Assert.AreEqual("DCXXXVI", Converter.Convert(636));
        }
        [TestMethod]
        public void Convert_637_Returns_DCXXXVII()
        {
            Assert.AreEqual("DCXXXVII", Converter.Convert(637));
        }
        [TestMethod]
        public void Convert_638_Returns_DCXXXVIII()
        {
            Assert.AreEqual("DCXXXVIII", Converter.Convert(638));
        }
        [TestMethod]
        public void Convert_639_Returns_DCXXXIX()
        {
            Assert.AreEqual("DCXXXIX", Converter.Convert(639));
        }
        [TestMethod]
        public void Convert_640_Returns_DCXL()
        {
            Assert.AreEqual("DCXL", Converter.Convert(640));
        }
        [TestMethod]
        public void Convert_641_Returns_DCXLI()
        {
            Assert.AreEqual("DCXLI", Converter.Convert(641));
        }
        [TestMethod]
        public void Convert_642_Returns_DCXLII()
        {
            Assert.AreEqual("DCXLII", Converter.Convert(642));
        }
        [TestMethod]
        public void Convert_643_Returns_DCXLIII()
        {
            Assert.AreEqual("DCXLIII", Converter.Convert(643));
        }
        [TestMethod]
        public void Convert_644_Returns_DCXLIV()
        {
            Assert.AreEqual("DCXLIV", Converter.Convert(644));
        }
        [TestMethod]
        public void Convert_645_Returns_DCXLV()
        {
            Assert.AreEqual("DCXLV", Converter.Convert(645));
        }
        [TestMethod]
        public void Convert_646_Returns_DCXLVI()
        {
            Assert.AreEqual("DCXLVI", Converter.Convert(646));
        }
        [TestMethod]
        public void Convert_647_Returns_DCXLVII()
        {
            Assert.AreEqual("DCXLVII", Converter.Convert(647));
        }
        [TestMethod]
        public void Convert_648_Returns_DCXLVIII()
        {
            Assert.AreEqual("DCXLVIII", Converter.Convert(648));
        }
        [TestMethod]
        public void Convert_649_Returns_DCXLIX()
        {
            Assert.AreEqual("DCXLIX", Converter.Convert(649));
        }
        [TestMethod]
        public void Convert_650_Returns_DCL()
        {
            Assert.AreEqual("DCL", Converter.Convert(650));
        }
        [TestMethod]
        public void Convert_651_Returns_DCLI()
        {
            Assert.AreEqual("DCLI", Converter.Convert(651));
        }
        [TestMethod]
        public void Convert_652_Returns_DCLII()
        {
            Assert.AreEqual("DCLII", Converter.Convert(652));
        }
        [TestMethod]
        public void Convert_653_Returns_DCLIII()
        {
            Assert.AreEqual("DCLIII", Converter.Convert(653));
        }
        [TestMethod]
        public void Convert_654_Returns_DCLIV()
        {
            Assert.AreEqual("DCLIV", Converter.Convert(654));
        }
        [TestMethod]
        public void Convert_655_Returns_DCLV()
        {
            Assert.AreEqual("DCLV", Converter.Convert(655));
        }
        [TestMethod]
        public void Convert_656_Returns_DCLVI()
        {
            Assert.AreEqual("DCLVI", Converter.Convert(656));
        }
        [TestMethod]
        public void Convert_657_Returns_DCLVII()
        {
            Assert.AreEqual("DCLVII", Converter.Convert(657));
        }
        [TestMethod]
        public void Convert_658_Returns_DCLVIII()
        {
            Assert.AreEqual("DCLVIII", Converter.Convert(658));
        }
        [TestMethod]
        public void Convert_659_Returns_DCLIX()
        {
            Assert.AreEqual("DCLIX", Converter.Convert(659));
        }
        [TestMethod]
        public void Convert_660_Returns_DCLX()
        {
            Assert.AreEqual("DCLX", Converter.Convert(660));
        }
        [TestMethod]
        public void Convert_661_Returns_DCLXI()
        {
            Assert.AreEqual("DCLXI", Converter.Convert(661));
        }
        [TestMethod]
        public void Convert_662_Returns_DCLXII()
        {
            Assert.AreEqual("DCLXII", Converter.Convert(662));
        }
        [TestMethod]
        public void Convert_663_Returns_DCLXIII()
        {
            Assert.AreEqual("DCLXIII", Converter.Convert(663));
        }
        [TestMethod]
        public void Convert_664_Returns_DCLXIV()
        {
            Assert.AreEqual("DCLXIV", Converter.Convert(664));
        }
        [TestMethod]
        public void Convert_665_Returns_DCLXV()
        {
            Assert.AreEqual("DCLXV", Converter.Convert(665));
        }
        [TestMethod]
        public void Convert_666_Returns_DCLXVI()
        {
            Assert.AreEqual("DCLXVI", Converter.Convert(666));
        }
        [TestMethod]
        public void Convert_667_Returns_DCLXVII()
        {
            Assert.AreEqual("DCLXVII", Converter.Convert(667));
        }
        [TestMethod]
        public void Convert_668_Returns_DCLXVIII()
        {
            Assert.AreEqual("DCLXVIII", Converter.Convert(668));
        }
        [TestMethod]
        public void Convert_669_Returns_DCLXIX()
        {
            Assert.AreEqual("DCLXIX", Converter.Convert(669));
        }
        [TestMethod]
        public void Convert_670_Returns_DCLXX()
        {
            Assert.AreEqual("DCLXX", Converter.Convert(670));
        }
        [TestMethod]
        public void Convert_671_Returns_DCLXXI()
        {
            Assert.AreEqual("DCLXXI", Converter.Convert(671));
        }
        [TestMethod]
        public void Convert_672_Returns_DCLXXII()
        {
            Assert.AreEqual("DCLXXII", Converter.Convert(672));
        }
        [TestMethod]
        public void Convert_673_Returns_DCLXXIII()
        {
            Assert.AreEqual("DCLXXIII", Converter.Convert(673));
        }
        [TestMethod]
        public void Convert_674_Returns_DCLXXIV()
        {
            Assert.AreEqual("DCLXXIV", Converter.Convert(674));
        }
        [TestMethod]
        public void Convert_675_Returns_DCLXXV()
        {
            Assert.AreEqual("DCLXXV", Converter.Convert(675));
        }
        [TestMethod]
        public void Convert_676_Returns_DCLXXVI()
        {
            Assert.AreEqual("DCLXXVI", Converter.Convert(676));
        }
        [TestMethod]
        public void Convert_677_Returns_DCLXXVII()
        {
            Assert.AreEqual("DCLXXVII", Converter.Convert(677));
        }
        [TestMethod]
        public void Convert_678_Returns_DCLXXVIII()
        {
            Assert.AreEqual("DCLXXVIII", Converter.Convert(678));
        }
        [TestMethod]
        public void Convert_679_Returns_DCLXXIX()
        {
            Assert.AreEqual("DCLXXIX", Converter.Convert(679));
        }
        [TestMethod]
        public void Convert_680_Returns_DCLXXX()
        {
            Assert.AreEqual("DCLXXX", Converter.Convert(680));
        }
        [TestMethod]
        public void Convert_681_Returns_DCLXXXI()
        {
            Assert.AreEqual("DCLXXXI", Converter.Convert(681));
        }
        [TestMethod]
        public void Convert_682_Returns_DCLXXXII()
        {
            Assert.AreEqual("DCLXXXII", Converter.Convert(682));
        }
        [TestMethod]
        public void Convert_683_Returns_DCLXXXIII()
        {
            Assert.AreEqual("DCLXXXIII", Converter.Convert(683));
        }
        [TestMethod]
        public void Convert_684_Returns_DCLXXXIV()
        {
            Assert.AreEqual("DCLXXXIV", Converter.Convert(684));
        }
        [TestMethod]
        public void Convert_685_Returns_DCLXXXV()
        {
            Assert.AreEqual("DCLXXXV", Converter.Convert(685));
        }
        [TestMethod]
        public void Convert_686_Returns_DCLXXXVI()
        {
            Assert.AreEqual("DCLXXXVI", Converter.Convert(686));
        }
        [TestMethod]
        public void Convert_687_Returns_DCLXXXVII()
        {
            Assert.AreEqual("DCLXXXVII", Converter.Convert(687));
        }
        [TestMethod]
        public void Convert_688_Returns_DCLXXXVIII()
        {
            Assert.AreEqual("DCLXXXVIII", Converter.Convert(688));
        }
        [TestMethod]
        public void Convert_689_Returns_DCLXXXIX()
        {
            Assert.AreEqual("DCLXXXIX", Converter.Convert(689));
        }
        [TestMethod]
        public void Convert_690_Returns_DCXC()
        {
            Assert.AreEqual("DCXC", Converter.Convert(690));
        }
        [TestMethod]
        public void Convert_691_Returns_DCXCI()
        {
            Assert.AreEqual("DCXCI", Converter.Convert(691));
        }
        [TestMethod]
        public void Convert_692_Returns_DCXCII()
        {
            Assert.AreEqual("DCXCII", Converter.Convert(692));
        }
        [TestMethod]
        public void Convert_693_Returns_DCXCIII()
        {
            Assert.AreEqual("DCXCIII", Converter.Convert(693));
        }
        [TestMethod]
        public void Convert_694_Returns_DCXCIV()
        {
            Assert.AreEqual("DCXCIV", Converter.Convert(694));
        }
        [TestMethod]
        public void Convert_695_Returns_DCXCV()
        {
            Assert.AreEqual("DCXCV", Converter.Convert(695));
        }
        [TestMethod]
        public void Convert_696_Returns_DCXCVI()
        {
            Assert.AreEqual("DCXCVI", Converter.Convert(696));
        }
        [TestMethod]
        public void Convert_697_Returns_DCXCVII()
        {
            Assert.AreEqual("DCXCVII", Converter.Convert(697));
        }
        [TestMethod]
        public void Convert_698_Returns_DCXCVIII()
        {
            Assert.AreEqual("DCXCVIII", Converter.Convert(698));
        }
        [TestMethod]
        public void Convert_699_Returns_DCXCIX()
        {
            Assert.AreEqual("DCXCIX", Converter.Convert(699));
        }
        [TestMethod]
        public void Convert_700_Returns_DCC()
        {
            Assert.AreEqual("DCC", Converter.Convert(700));
        }
        [TestMethod]
        public void Convert_701_Returns_DCCI()
        {
            Assert.AreEqual("DCCI", Converter.Convert(701));
        }
        [TestMethod]
        public void Convert_702_Returns_DCCII()
        {
            Assert.AreEqual("DCCII", Converter.Convert(702));
        }
        [TestMethod]
        public void Convert_703_Returns_DCCIII()
        {
            Assert.AreEqual("DCCIII", Converter.Convert(703));
        }
        [TestMethod]
        public void Convert_704_Returns_DCCIV()
        {
            Assert.AreEqual("DCCIV", Converter.Convert(704));
        }
        [TestMethod]
        public void Convert_705_Returns_DCCV()
        {
            Assert.AreEqual("DCCV", Converter.Convert(705));
        }
        [TestMethod]
        public void Convert_706_Returns_DCCVI()
        {
            Assert.AreEqual("DCCVI", Converter.Convert(706));
        }
        [TestMethod]
        public void Convert_707_Returns_DCCVII()
        {
            Assert.AreEqual("DCCVII", Converter.Convert(707));
        }
        [TestMethod]
        public void Convert_708_Returns_DCCVIII()
        {
            Assert.AreEqual("DCCVIII", Converter.Convert(708));
        }
        [TestMethod]
        public void Convert_709_Returns_DCCIX()
        {
            Assert.AreEqual("DCCIX", Converter.Convert(709));
        }
        [TestMethod]
        public void Convert_710_Returns_DCCX()
        {
            Assert.AreEqual("DCCX", Converter.Convert(710));
        }
        [TestMethod]
        public void Convert_711_Returns_DCCXI()
        {
            Assert.AreEqual("DCCXI", Converter.Convert(711));
        }
        [TestMethod]
        public void Convert_712_Returns_DCCXII()
        {
            Assert.AreEqual("DCCXII", Converter.Convert(712));
        }
        [TestMethod]
        public void Convert_713_Returns_DCCXIII()
        {
            Assert.AreEqual("DCCXIII", Converter.Convert(713));
        }
        [TestMethod]
        public void Convert_714_Returns_DCCXIV()
        {
            Assert.AreEqual("DCCXIV", Converter.Convert(714));
        }
        [TestMethod]
        public void Convert_715_Returns_DCCXV()
        {
            Assert.AreEqual("DCCXV", Converter.Convert(715));
        }
        [TestMethod]
        public void Convert_716_Returns_DCCXVI()
        {
            Assert.AreEqual("DCCXVI", Converter.Convert(716));
        }
        [TestMethod]
        public void Convert_717_Returns_DCCXVII()
        {
            Assert.AreEqual("DCCXVII", Converter.Convert(717));
        }
        [TestMethod]
        public void Convert_718_Returns_DCCXVIII()
        {
            Assert.AreEqual("DCCXVIII", Converter.Convert(718));
        }
        [TestMethod]
        public void Convert_719_Returns_DCCXIX()
        {
            Assert.AreEqual("DCCXIX", Converter.Convert(719));
        }
        [TestMethod]
        public void Convert_720_Returns_DCCXX()
        {
            Assert.AreEqual("DCCXX", Converter.Convert(720));
        }
        [TestMethod]
        public void Convert_721_Returns_DCCXXI()
        {
            Assert.AreEqual("DCCXXI", Converter.Convert(721));
        }
        [TestMethod]
        public void Convert_722_Returns_DCCXXII()
        {
            Assert.AreEqual("DCCXXII", Converter.Convert(722));
        }
        [TestMethod]
        public void Convert_723_Returns_DCCXXIII()
        {
            Assert.AreEqual("DCCXXIII", Converter.Convert(723));
        }
        [TestMethod]
        public void Convert_724_Returns_DCCXXIV()
        {
            Assert.AreEqual("DCCXXIV", Converter.Convert(724));
        }
        [TestMethod]
        public void Convert_725_Returns_DCCXXV()
        {
            Assert.AreEqual("DCCXXV", Converter.Convert(725));
        }
        [TestMethod]
        public void Convert_726_Returns_DCCXXVI()
        {
            Assert.AreEqual("DCCXXVI", Converter.Convert(726));
        }
        [TestMethod]
        public void Convert_727_Returns_DCCXXVII()
        {
            Assert.AreEqual("DCCXXVII", Converter.Convert(727));
        }
        [TestMethod]
        public void Convert_728_Returns_DCCXXVIII()
        {
            Assert.AreEqual("DCCXXVIII", Converter.Convert(728));
        }
        [TestMethod]
        public void Convert_729_Returns_DCCXXIX()
        {
            Assert.AreEqual("DCCXXIX", Converter.Convert(729));
        }
        [TestMethod]
        public void Convert_730_Returns_DCCXXX()
        {
            Assert.AreEqual("DCCXXX", Converter.Convert(730));
        }
        [TestMethod]
        public void Convert_731_Returns_DCCXXXI()
        {
            Assert.AreEqual("DCCXXXI", Converter.Convert(731));
        }
        [TestMethod]
        public void Convert_732_Returns_DCCXXXII()
        {
            Assert.AreEqual("DCCXXXII", Converter.Convert(732));
        }
        [TestMethod]
        public void Convert_733_Returns_DCCXXXIII()
        {
            Assert.AreEqual("DCCXXXIII", Converter.Convert(733));
        }
        [TestMethod]
        public void Convert_734_Returns_DCCXXXIV()
        {
            Assert.AreEqual("DCCXXXIV", Converter.Convert(734));
        }
        [TestMethod]
        public void Convert_735_Returns_DCCXXXV()
        {
            Assert.AreEqual("DCCXXXV", Converter.Convert(735));
        }
        [TestMethod]
        public void Convert_736_Returns_DCCXXXVI()
        {
            Assert.AreEqual("DCCXXXVI", Converter.Convert(736));
        }
        [TestMethod]
        public void Convert_737_Returns_DCCXXXVII()
        {
            Assert.AreEqual("DCCXXXVII", Converter.Convert(737));
        }
        [TestMethod]
        public void Convert_738_Returns_DCCXXXVIII()
        {
            Assert.AreEqual("DCCXXXVIII", Converter.Convert(738));
        }
        [TestMethod]
        public void Convert_739_Returns_DCCXXXIX()
        {
            Assert.AreEqual("DCCXXXIX", Converter.Convert(739));
        }
        [TestMethod]
        public void Convert_740_Returns_DCCXL()
        {
            Assert.AreEqual("DCCXL", Converter.Convert(740));
        }
        [TestMethod]
        public void Convert_741_Returns_DCCXLI()
        {
            Assert.AreEqual("DCCXLI", Converter.Convert(741));
        }
        [TestMethod]
        public void Convert_742_Returns_DCCXLII()
        {
            Assert.AreEqual("DCCXLII", Converter.Convert(742));
        }
        [TestMethod]
        public void Convert_743_Returns_DCCXLIII()
        {
            Assert.AreEqual("DCCXLIII", Converter.Convert(743));
        }
        [TestMethod]
        public void Convert_744_Returns_DCCXLIV()
        {
            Assert.AreEqual("DCCXLIV", Converter.Convert(744));
        }
        [TestMethod]
        public void Convert_745_Returns_DCCXLV()
        {
            Assert.AreEqual("DCCXLV", Converter.Convert(745));
        }
        [TestMethod]
        public void Convert_746_Returns_DCCXLVI()
        {
            Assert.AreEqual("DCCXLVI", Converter.Convert(746));
        }
        [TestMethod]
        public void Convert_747_Returns_DCCXLVII()
        {
            Assert.AreEqual("DCCXLVII", Converter.Convert(747));
        }
        [TestMethod]
        public void Convert_748_Returns_DCCXLVIII()
        {
            Assert.AreEqual("DCCXLVIII", Converter.Convert(748));
        }
        [TestMethod]
        public void Convert_749_Returns_DCCXLIX()
        {
            Assert.AreEqual("DCCXLIX", Converter.Convert(749));
        }
        [TestMethod]
        public void Convert_750_Returns_DCCL()
        {
            Assert.AreEqual("DCCL", Converter.Convert(750));
        }
        [TestMethod]
        public void Convert_751_Returns_DCCLI()
        {
            Assert.AreEqual("DCCLI", Converter.Convert(751));
        }
        [TestMethod]
        public void Convert_752_Returns_DCCLII()
        {
            Assert.AreEqual("DCCLII", Converter.Convert(752));
        }
        [TestMethod]
        public void Convert_753_Returns_DCCLIII()
        {
            Assert.AreEqual("DCCLIII", Converter.Convert(753));
        }
        [TestMethod]
        public void Convert_754_Returns_DCCLIV()
        {
            Assert.AreEqual("DCCLIV", Converter.Convert(754));
        }
        [TestMethod]
        public void Convert_755_Returns_DCCLV()
        {
            Assert.AreEqual("DCCLV", Converter.Convert(755));
        }
        [TestMethod]
        public void Convert_756_Returns_DCCLVI()
        {
            Assert.AreEqual("DCCLVI", Converter.Convert(756));
        }
        [TestMethod]
        public void Convert_757_Returns_DCCLVII()
        {
            Assert.AreEqual("DCCLVII", Converter.Convert(757));
        }
        [TestMethod]
        public void Convert_758_Returns_DCCLVIII()
        {
            Assert.AreEqual("DCCLVIII", Converter.Convert(758));
        }
        [TestMethod]
        public void Convert_759_Returns_DCCLIX()
        {
            Assert.AreEqual("DCCLIX", Converter.Convert(759));
        }
        [TestMethod]
        public void Convert_760_Returns_DCCLX()
        {
            Assert.AreEqual("DCCLX", Converter.Convert(760));
        }
        [TestMethod]
        public void Convert_761_Returns_DCCLXI()
        {
            Assert.AreEqual("DCCLXI", Converter.Convert(761));
        }
        [TestMethod]
        public void Convert_762_Returns_DCCLXII()
        {
            Assert.AreEqual("DCCLXII", Converter.Convert(762));
        }
        [TestMethod]
        public void Convert_763_Returns_DCCLXIII()
        {
            Assert.AreEqual("DCCLXIII", Converter.Convert(763));
        }
        [TestMethod]
        public void Convert_764_Returns_DCCLXIV()
        {
            Assert.AreEqual("DCCLXIV", Converter.Convert(764));
        }
        [TestMethod]
        public void Convert_765_Returns_DCCLXV()
        {
            Assert.AreEqual("DCCLXV", Converter.Convert(765));
        }
        [TestMethod]
        public void Convert_766_Returns_DCCLXVI()
        {
            Assert.AreEqual("DCCLXVI", Converter.Convert(766));
        }
        [TestMethod]
        public void Convert_767_Returns_DCCLXVII()
        {
            Assert.AreEqual("DCCLXVII", Converter.Convert(767));
        }
        [TestMethod]
        public void Convert_768_Returns_DCCLXVIII()
        {
            Assert.AreEqual("DCCLXVIII", Converter.Convert(768));
        }
        [TestMethod]
        public void Convert_769_Returns_DCCLXIX()
        {
            Assert.AreEqual("DCCLXIX", Converter.Convert(769));
        }
        [TestMethod]
        public void Convert_770_Returns_DCCLXX()
        {
            Assert.AreEqual("DCCLXX", Converter.Convert(770));
        }
        [TestMethod]
        public void Convert_771_Returns_DCCLXXI()
        {
            Assert.AreEqual("DCCLXXI", Converter.Convert(771));
        }
        [TestMethod]
        public void Convert_772_Returns_DCCLXXII()
        {
            Assert.AreEqual("DCCLXXII", Converter.Convert(772));
        }
        [TestMethod]
        public void Convert_773_Returns_DCCLXXIII()
        {
            Assert.AreEqual("DCCLXXIII", Converter.Convert(773));
        }
        [TestMethod]
        public void Convert_774_Returns_DCCLXXIV()
        {
            Assert.AreEqual("DCCLXXIV", Converter.Convert(774));
        }
        [TestMethod]
        public void Convert_775_Returns_DCCLXXV()
        {
            Assert.AreEqual("DCCLXXV", Converter.Convert(775));
        }
        [TestMethod]
        public void Convert_776_Returns_DCCLXXVI()
        {
            Assert.AreEqual("DCCLXXVI", Converter.Convert(776));
        }
        [TestMethod]
        public void Convert_777_Returns_DCCLXXVII()
        {
            Assert.AreEqual("DCCLXXVII", Converter.Convert(777));
        }
        [TestMethod]
        public void Convert_778_Returns_DCCLXXVIII()
        {
            Assert.AreEqual("DCCLXXVIII", Converter.Convert(778));
        }
        [TestMethod]
        public void Convert_779_Returns_DCCLXXIX()
        {
            Assert.AreEqual("DCCLXXIX", Converter.Convert(779));
        }
        [TestMethod]
        public void Convert_780_Returns_DCCLXXX()
        {
            Assert.AreEqual("DCCLXXX", Converter.Convert(780));
        }
        [TestMethod]
        public void Convert_781_Returns_DCCLXXXI()
        {
            Assert.AreEqual("DCCLXXXI", Converter.Convert(781));
        }
        [TestMethod]
        public void Convert_782_Returns_DCCLXXXII()
        {
            Assert.AreEqual("DCCLXXXII", Converter.Convert(782));
        }
        [TestMethod]
        public void Convert_783_Returns_DCCLXXXIII()
        {
            Assert.AreEqual("DCCLXXXIII", Converter.Convert(783));
        }
        [TestMethod]
        public void Convert_784_Returns_DCCLXXXIV()
        {
            Assert.AreEqual("DCCLXXXIV", Converter.Convert(784));
        }
        [TestMethod]
        public void Convert_785_Returns_DCCLXXXV()
        {
            Assert.AreEqual("DCCLXXXV", Converter.Convert(785));
        }
        [TestMethod]
        public void Convert_786_Returns_DCCLXXXVI()
        {
            Assert.AreEqual("DCCLXXXVI", Converter.Convert(786));
        }
        [TestMethod]
        public void Convert_787_Returns_DCCLXXXVII()
        {
            Assert.AreEqual("DCCLXXXVII", Converter.Convert(787));
        }
        [TestMethod]
        public void Convert_788_Returns_DCCLXXXVIII()
        {
            Assert.AreEqual("DCCLXXXVIII", Converter.Convert(788));
        }
        [TestMethod]
        public void Convert_789_Returns_DCCLXXXIX()
        {
            Assert.AreEqual("DCCLXXXIX", Converter.Convert(789));
        }
        [TestMethod]
        public void Convert_790_Returns_DCCXC()
        {
            Assert.AreEqual("DCCXC", Converter.Convert(790));
        }
        [TestMethod]
        public void Convert_791_Returns_DCCXCI()
        {
            Assert.AreEqual("DCCXCI", Converter.Convert(791));
        }
        [TestMethod]
        public void Convert_792_Returns_DCCXCII()
        {
            Assert.AreEqual("DCCXCII", Converter.Convert(792));
        }
        [TestMethod]
        public void Convert_793_Returns_DCCXCIII()
        {
            Assert.AreEqual("DCCXCIII", Converter.Convert(793));
        }
        [TestMethod]
        public void Convert_794_Returns_DCCXCIV()
        {
            Assert.AreEqual("DCCXCIV", Converter.Convert(794));
        }
        [TestMethod]
        public void Convert_795_Returns_DCCXCV()
        {
            Assert.AreEqual("DCCXCV", Converter.Convert(795));
        }
        [TestMethod]
        public void Convert_796_Returns_DCCXCVI()
        {
            Assert.AreEqual("DCCXCVI", Converter.Convert(796));
        }
        [TestMethod]
        public void Convert_797_Returns_DCCXCVII()
        {
            Assert.AreEqual("DCCXCVII", Converter.Convert(797));
        }
        [TestMethod]
        public void Convert_798_Returns_DCCXCVIII()
        {
            Assert.AreEqual("DCCXCVIII", Converter.Convert(798));
        }
        [TestMethod]
        public void Convert_799_Returns_DCCXCIX()
        {
            Assert.AreEqual("DCCXCIX", Converter.Convert(799));
        }
        [TestMethod]
        public void Convert_800_Returns_DCCC()
        {
            Assert.AreEqual("DCCC", Converter.Convert(800));
        }
        [TestMethod]
        public void Convert_801_Returns_DCCCI()
        {
            Assert.AreEqual("DCCCI", Converter.Convert(801));
        }
        [TestMethod]
        public void Convert_802_Returns_DCCCII()
        {
            Assert.AreEqual("DCCCII", Converter.Convert(802));
        }
        [TestMethod]
        public void Convert_803_Returns_DCCCIII()
        {
            Assert.AreEqual("DCCCIII", Converter.Convert(803));
        }
        [TestMethod]
        public void Convert_804_Returns_DCCCIV()
        {
            Assert.AreEqual("DCCCIV", Converter.Convert(804));
        }
        [TestMethod]
        public void Convert_805_Returns_DCCCV()
        {
            Assert.AreEqual("DCCCV", Converter.Convert(805));
        }
        [TestMethod]
        public void Convert_806_Returns_DCCCVI()
        {
            Assert.AreEqual("DCCCVI", Converter.Convert(806));
        }
        [TestMethod]
        public void Convert_807_Returns_DCCCVII()
        {
            Assert.AreEqual("DCCCVII", Converter.Convert(807));
        }
        [TestMethod]
        public void Convert_808_Returns_DCCCVIII()
        {
            Assert.AreEqual("DCCCVIII", Converter.Convert(808));
        }
        [TestMethod]
        public void Convert_809_Returns_DCCCIX()
        {
            Assert.AreEqual("DCCCIX", Converter.Convert(809));
        }
        [TestMethod]
        public void Convert_810_Returns_DCCCX()
        {
            Assert.AreEqual("DCCCX", Converter.Convert(810));
        }
        [TestMethod]
        public void Convert_811_Returns_DCCCXI()
        {
            Assert.AreEqual("DCCCXI", Converter.Convert(811));
        }
        [TestMethod]
        public void Convert_812_Returns_DCCCXII()
        {
            Assert.AreEqual("DCCCXII", Converter.Convert(812));
        }
        [TestMethod]
        public void Convert_813_Returns_DCCCXIII()
        {
            Assert.AreEqual("DCCCXIII", Converter.Convert(813));
        }
        [TestMethod]
        public void Convert_814_Returns_DCCCXIV()
        {
            Assert.AreEqual("DCCCXIV", Converter.Convert(814));
        }
        [TestMethod]
        public void Convert_815_Returns_DCCCXV()
        {
            Assert.AreEqual("DCCCXV", Converter.Convert(815));
        }
        [TestMethod]
        public void Convert_816_Returns_DCCCXVI()
        {
            Assert.AreEqual("DCCCXVI", Converter.Convert(816));
        }
        [TestMethod]
        public void Convert_817_Returns_DCCCXVII()
        {
            Assert.AreEqual("DCCCXVII", Converter.Convert(817));
        }
        [TestMethod]
        public void Convert_818_Returns_DCCCXVIII()
        {
            Assert.AreEqual("DCCCXVIII", Converter.Convert(818));
        }
        [TestMethod]
        public void Convert_819_Returns_DCCCXIX()
        {
            Assert.AreEqual("DCCCXIX", Converter.Convert(819));
        }
        [TestMethod]
        public void Convert_820_Returns_DCCCXX()
        {
            Assert.AreEqual("DCCCXX", Converter.Convert(820));
        }
        [TestMethod]
        public void Convert_821_Returns_DCCCXXI()
        {
            Assert.AreEqual("DCCCXXI", Converter.Convert(821));
        }
        [TestMethod]
        public void Convert_822_Returns_DCCCXXII()
        {
            Assert.AreEqual("DCCCXXII", Converter.Convert(822));
        }
        [TestMethod]
        public void Convert_823_Returns_DCCCXXIII()
        {
            Assert.AreEqual("DCCCXXIII", Converter.Convert(823));
        }
        [TestMethod]
        public void Convert_824_Returns_DCCCXXIV()
        {
            Assert.AreEqual("DCCCXXIV", Converter.Convert(824));
        }
        [TestMethod]
        public void Convert_825_Returns_DCCCXXV()
        {
            Assert.AreEqual("DCCCXXV", Converter.Convert(825));
        }
        [TestMethod]
        public void Convert_826_Returns_DCCCXXVI()
        {
            Assert.AreEqual("DCCCXXVI", Converter.Convert(826));
        }
        [TestMethod]
        public void Convert_827_Returns_DCCCXXVII()
        {
            Assert.AreEqual("DCCCXXVII", Converter.Convert(827));
        }
        [TestMethod]
        public void Convert_828_Returns_DCCCXXVIII()
        {
            Assert.AreEqual("DCCCXXVIII", Converter.Convert(828));
        }
        [TestMethod]
        public void Convert_829_Returns_DCCCXXIX()
        {
            Assert.AreEqual("DCCCXXIX", Converter.Convert(829));
        }
        [TestMethod]
        public void Convert_830_Returns_DCCCXXX()
        {
            Assert.AreEqual("DCCCXXX", Converter.Convert(830));
        }
        [TestMethod]
        public void Convert_831_Returns_DCCCXXXI()
        {
            Assert.AreEqual("DCCCXXXI", Converter.Convert(831));
        }
        [TestMethod]
        public void Convert_832_Returns_DCCCXXXII()
        {
            Assert.AreEqual("DCCCXXXII", Converter.Convert(832));
        }
        [TestMethod]
        public void Convert_833_Returns_DCCCXXXIII()
        {
            Assert.AreEqual("DCCCXXXIII", Converter.Convert(833));
        }
        [TestMethod]
        public void Convert_834_Returns_DCCCXXXIV()
        {
            Assert.AreEqual("DCCCXXXIV", Converter.Convert(834));
        }
        [TestMethod]
        public void Convert_835_Returns_DCCCXXXV()
        {
            Assert.AreEqual("DCCCXXXV", Converter.Convert(835));
        }
        [TestMethod]
        public void Convert_836_Returns_DCCCXXXVI()
        {
            Assert.AreEqual("DCCCXXXVI", Converter.Convert(836));
        }
        [TestMethod]
        public void Convert_837_Returns_DCCCXXXVII()
        {
            Assert.AreEqual("DCCCXXXVII", Converter.Convert(837));
        }
        [TestMethod]
        public void Convert_838_Returns_DCCCXXXVIII()
        {
            Assert.AreEqual("DCCCXXXVIII", Converter.Convert(838));
        }
        [TestMethod]
        public void Convert_839_Returns_DCCCXXXIX()
        {
            Assert.AreEqual("DCCCXXXIX", Converter.Convert(839));
        }
        [TestMethod]
        public void Convert_840_Returns_DCCCXL()
        {
            Assert.AreEqual("DCCCXL", Converter.Convert(840));
        }
        [TestMethod]
        public void Convert_841_Returns_DCCCXLI()
        {
            Assert.AreEqual("DCCCXLI", Converter.Convert(841));
        }
        [TestMethod]
        public void Convert_842_Returns_DCCCXLII()
        {
            Assert.AreEqual("DCCCXLII", Converter.Convert(842));
        }
        [TestMethod]
        public void Convert_843_Returns_DCCCXLIII()
        {
            Assert.AreEqual("DCCCXLIII", Converter.Convert(843));
        }
        [TestMethod]
        public void Convert_844_Returns_DCCCXLIV()
        {
            Assert.AreEqual("DCCCXLIV", Converter.Convert(844));
        }
        [TestMethod]
        public void Convert_845_Returns_DCCCXLV()
        {
            Assert.AreEqual("DCCCXLV", Converter.Convert(845));
        }
        [TestMethod]
        public void Convert_846_Returns_DCCCXLVI()
        {
            Assert.AreEqual("DCCCXLVI", Converter.Convert(846));
        }
        [TestMethod]
        public void Convert_847_Returns_DCCCXLVII()
        {
            Assert.AreEqual("DCCCXLVII", Converter.Convert(847));
        }
        [TestMethod]
        public void Convert_848_Returns_DCCCXLVIII()
        {
            Assert.AreEqual("DCCCXLVIII", Converter.Convert(848));
        }
        [TestMethod]
        public void Convert_849_Returns_DCCCXLIX()
        {
            Assert.AreEqual("DCCCXLIX", Converter.Convert(849));
        }
        [TestMethod]
        public void Convert_850_Returns_DCCCL()
        {
            Assert.AreEqual("DCCCL", Converter.Convert(850));
        }
        [TestMethod]
        public void Convert_851_Returns_DCCCLI()
        {
            Assert.AreEqual("DCCCLI", Converter.Convert(851));
        }
        [TestMethod]
        public void Convert_852_Returns_DCCCLII()
        {
            Assert.AreEqual("DCCCLII", Converter.Convert(852));
        }
        [TestMethod]
        public void Convert_853_Returns_DCCCLIII()
        {
            Assert.AreEqual("DCCCLIII", Converter.Convert(853));
        }
        [TestMethod]
        public void Convert_854_Returns_DCCCLIV()
        {
            Assert.AreEqual("DCCCLIV", Converter.Convert(854));
        }
        [TestMethod]
        public void Convert_855_Returns_DCCCLV()
        {
            Assert.AreEqual("DCCCLV", Converter.Convert(855));
        }
        [TestMethod]
        public void Convert_856_Returns_DCCCLVI()
        {
            Assert.AreEqual("DCCCLVI", Converter.Convert(856));
        }
        [TestMethod]
        public void Convert_857_Returns_DCCCLVII()
        {
            Assert.AreEqual("DCCCLVII", Converter.Convert(857));
        }
        [TestMethod]
        public void Convert_858_Returns_DCCCLVIII()
        {
            Assert.AreEqual("DCCCLVIII", Converter.Convert(858));
        }
        [TestMethod]
        public void Convert_859_Returns_DCCCLIX()
        {
            Assert.AreEqual("DCCCLIX", Converter.Convert(859));
        }
        [TestMethod]
        public void Convert_860_Returns_DCCCLX()
        {
            Assert.AreEqual("DCCCLX", Converter.Convert(860));
        }
        [TestMethod]
        public void Convert_861_Returns_DCCCLXI()
        {
            Assert.AreEqual("DCCCLXI", Converter.Convert(861));
        }
        [TestMethod]
        public void Convert_862_Returns_DCCCLXII()
        {
            Assert.AreEqual("DCCCLXII", Converter.Convert(862));
        }
        [TestMethod]
        public void Convert_863_Returns_DCCCLXIII()
        {
            Assert.AreEqual("DCCCLXIII", Converter.Convert(863));
        }
        [TestMethod]
        public void Convert_864_Returns_DCCCLXIV()
        {
            Assert.AreEqual("DCCCLXIV", Converter.Convert(864));
        }
        [TestMethod]
        public void Convert_865_Returns_DCCCLXV()
        {
            Assert.AreEqual("DCCCLXV", Converter.Convert(865));
        }
        [TestMethod]
        public void Convert_866_Returns_DCCCLXVI()
        {
            Assert.AreEqual("DCCCLXVI", Converter.Convert(866));
        }
        [TestMethod]
        public void Convert_867_Returns_DCCCLXVII()
        {
            Assert.AreEqual("DCCCLXVII", Converter.Convert(867));
        }
        [TestMethod]
        public void Convert_868_Returns_DCCCLXVIII()
        {
            Assert.AreEqual("DCCCLXVIII", Converter.Convert(868));
        }
        [TestMethod]
        public void Convert_869_Returns_DCCCLXIX()
        {
            Assert.AreEqual("DCCCLXIX", Converter.Convert(869));
        }
        [TestMethod]
        public void Convert_870_Returns_DCCCLXX()
        {
            Assert.AreEqual("DCCCLXX", Converter.Convert(870));
        }
        [TestMethod]
        public void Convert_871_Returns_DCCCLXXI()
        {
            Assert.AreEqual("DCCCLXXI", Converter.Convert(871));
        }
        [TestMethod]
        public void Convert_872_Returns_DCCCLXXII()
        {
            Assert.AreEqual("DCCCLXXII", Converter.Convert(872));
        }
        [TestMethod]
        public void Convert_873_Returns_DCCCLXXIII()
        {
            Assert.AreEqual("DCCCLXXIII", Converter.Convert(873));
        }
        [TestMethod]
        public void Convert_874_Returns_DCCCLXXIV()
        {
            Assert.AreEqual("DCCCLXXIV", Converter.Convert(874));
        }
        [TestMethod]
        public void Convert_875_Returns_DCCCLXXV()
        {
            Assert.AreEqual("DCCCLXXV", Converter.Convert(875));
        }
        [TestMethod]
        public void Convert_876_Returns_DCCCLXXVI()
        {
            Assert.AreEqual("DCCCLXXVI", Converter.Convert(876));
        }
        [TestMethod]
        public void Convert_877_Returns_DCCCLXXVII()
        {
            Assert.AreEqual("DCCCLXXVII", Converter.Convert(877));
        }
        [TestMethod]
        public void Convert_878_Returns_DCCCLXXVIII()
        {
            Assert.AreEqual("DCCCLXXVIII", Converter.Convert(878));
        }
        [TestMethod]
        public void Convert_879_Returns_DCCCLXXIX()
        {
            Assert.AreEqual("DCCCLXXIX", Converter.Convert(879));
        }
        [TestMethod]
        public void Convert_880_Returns_DCCCLXXX()
        {
            Assert.AreEqual("DCCCLXXX", Converter.Convert(880));
        }
        [TestMethod]
        public void Convert_881_Returns_DCCCLXXXI()
        {
            Assert.AreEqual("DCCCLXXXI", Converter.Convert(881));
        }
        [TestMethod]
        public void Convert_882_Returns_DCCCLXXXII()
        {
            Assert.AreEqual("DCCCLXXXII", Converter.Convert(882));
        }
        [TestMethod]
        public void Convert_883_Returns_DCCCLXXXIII()
        {
            Assert.AreEqual("DCCCLXXXIII", Converter.Convert(883));
        }
        [TestMethod]
        public void Convert_884_Returns_DCCCLXXXIV()
        {
            Assert.AreEqual("DCCCLXXXIV", Converter.Convert(884));
        }
        [TestMethod]
        public void Convert_885_Returns_DCCCLXXXV()
        {
            Assert.AreEqual("DCCCLXXXV", Converter.Convert(885));
        }
        [TestMethod]
        public void Convert_886_Returns_DCCCLXXXVI()
        {
            Assert.AreEqual("DCCCLXXXVI", Converter.Convert(886));
        }
        [TestMethod]
        public void Convert_887_Returns_DCCCLXXXVII()
        {
            Assert.AreEqual("DCCCLXXXVII", Converter.Convert(887));
        }
        [TestMethod]
        public void Convert_888_Returns_DCCCLXXXVIII()
        {
            Assert.AreEqual("DCCCLXXXVIII", Converter.Convert(888));
        }
        [TestMethod]
        public void Convert_889_Returns_DCCCLXXXIX()
        {
            Assert.AreEqual("DCCCLXXXIX", Converter.Convert(889));
        }
        [TestMethod]
        public void Convert_890_Returns_DCCCXC()
        {
            Assert.AreEqual("DCCCXC", Converter.Convert(890));
        }
        [TestMethod]
        public void Convert_891_Returns_DCCCXCI()
        {
            Assert.AreEqual("DCCCXCI", Converter.Convert(891));
        }
        [TestMethod]
        public void Convert_892_Returns_DCCCXCII()
        {
            Assert.AreEqual("DCCCXCII", Converter.Convert(892));
        }
        [TestMethod]
        public void Convert_893_Returns_DCCCXCIII()
        {
            Assert.AreEqual("DCCCXCIII", Converter.Convert(893));
        }
        [TestMethod]
        public void Convert_894_Returns_DCCCXCIV()
        {
            Assert.AreEqual("DCCCXCIV", Converter.Convert(894));
        }
        [TestMethod]
        public void Convert_895_Returns_DCCCXCV()
        {
            Assert.AreEqual("DCCCXCV", Converter.Convert(895));
        }
        [TestMethod]
        public void Convert_896_Returns_DCCCXCVI()
        {
            Assert.AreEqual("DCCCXCVI", Converter.Convert(896));
        }
        [TestMethod]
        public void Convert_897_Returns_DCCCXCVII()
        {
            Assert.AreEqual("DCCCXCVII", Converter.Convert(897));
        }
        [TestMethod]
        public void Convert_898_Returns_DCCCXCVIII()
        {
            Assert.AreEqual("DCCCXCVIII", Converter.Convert(898));
        }
        [TestMethod]
        public void Convert_899_Returns_DCCCXCIX()
        {
            Assert.AreEqual("DCCCXCIX", Converter.Convert(899));
        }
        [TestMethod]
        public void Convert_900_Returns_CM()
        {
            Assert.AreEqual("CM", Converter.Convert(900));
        }
        [TestMethod]
        public void Convert_901_Returns_CMI()
        {
            Assert.AreEqual("CMI", Converter.Convert(901));
        }
        [TestMethod]
        public void Convert_902_Returns_CMII()
        {
            Assert.AreEqual("CMII", Converter.Convert(902));
        }
        [TestMethod]
        public void Convert_903_Returns_CMIII()
        {
            Assert.AreEqual("CMIII", Converter.Convert(903));
        }
        [TestMethod]
        public void Convert_904_Returns_CMIV()
        {
            Assert.AreEqual("CMIV", Converter.Convert(904));
        }
        [TestMethod]
        public void Convert_905_Returns_CMV()
        {
            Assert.AreEqual("CMV", Converter.Convert(905));
        }
        [TestMethod]
        public void Convert_906_Returns_CMVI()
        {
            Assert.AreEqual("CMVI", Converter.Convert(906));
        }
        [TestMethod]
        public void Convert_907_Returns_CMVII()
        {
            Assert.AreEqual("CMVII", Converter.Convert(907));
        }
        [TestMethod]
        public void Convert_908_Returns_CMVIII()
        {
            Assert.AreEqual("CMVIII", Converter.Convert(908));
        }
        [TestMethod]
        public void Convert_909_Returns_CMIX()
        {
            Assert.AreEqual("CMIX", Converter.Convert(909));
        }
        [TestMethod]
        public void Convert_910_Returns_CMX()
        {
            Assert.AreEqual("CMX", Converter.Convert(910));
        }
        [TestMethod]
        public void Convert_911_Returns_CMXI()
        {
            Assert.AreEqual("CMXI", Converter.Convert(911));
        }
        [TestMethod]
        public void Convert_912_Returns_CMXII()
        {
            Assert.AreEqual("CMXII", Converter.Convert(912));
        }
        [TestMethod]
        public void Convert_913_Returns_CMXIII()
        {
            Assert.AreEqual("CMXIII", Converter.Convert(913));
        }
        [TestMethod]
        public void Convert_914_Returns_CMXIV()
        {
            Assert.AreEqual("CMXIV", Converter.Convert(914));
        }
        [TestMethod]
        public void Convert_915_Returns_CMXV()
        {
            Assert.AreEqual("CMXV", Converter.Convert(915));
        }
        [TestMethod]
        public void Convert_916_Returns_CMXVI()
        {
            Assert.AreEqual("CMXVI", Converter.Convert(916));
        }
        [TestMethod]
        public void Convert_917_Returns_CMXVII()
        {
            Assert.AreEqual("CMXVII", Converter.Convert(917));
        }
        [TestMethod]
        public void Convert_918_Returns_CMXVIII()
        {
            Assert.AreEqual("CMXVIII", Converter.Convert(918));
        }
        [TestMethod]
        public void Convert_919_Returns_CMXIX()
        {
            Assert.AreEqual("CMXIX", Converter.Convert(919));
        }
        [TestMethod]
        public void Convert_920_Returns_CMXX()
        {
            Assert.AreEqual("CMXX", Converter.Convert(920));
        }
        [TestMethod]
        public void Convert_921_Returns_CMXXI()
        {
            Assert.AreEqual("CMXXI", Converter.Convert(921));
        }
        [TestMethod]
        public void Convert_922_Returns_CMXXII()
        {
            Assert.AreEqual("CMXXII", Converter.Convert(922));
        }
        [TestMethod]
        public void Convert_923_Returns_CMXXIII()
        {
            Assert.AreEqual("CMXXIII", Converter.Convert(923));
        }
        [TestMethod]
        public void Convert_924_Returns_CMXXIV()
        {
            Assert.AreEqual("CMXXIV", Converter.Convert(924));
        }
        [TestMethod]
        public void Convert_925_Returns_CMXXV()
        {
            Assert.AreEqual("CMXXV", Converter.Convert(925));
        }
        [TestMethod]
        public void Convert_926_Returns_CMXXVI()
        {
            Assert.AreEqual("CMXXVI", Converter.Convert(926));
        }
        [TestMethod]
        public void Convert_927_Returns_CMXXVII()
        {
            Assert.AreEqual("CMXXVII", Converter.Convert(927));
        }
        [TestMethod]
        public void Convert_928_Returns_CMXXVIII()
        {
            Assert.AreEqual("CMXXVIII", Converter.Convert(928));
        }
        [TestMethod]
        public void Convert_929_Returns_CMXXIX()
        {
            Assert.AreEqual("CMXXIX", Converter.Convert(929));
        }
        [TestMethod]
        public void Convert_930_Returns_CMXXX()
        {
            Assert.AreEqual("CMXXX", Converter.Convert(930));
        }
        [TestMethod]
        public void Convert_931_Returns_CMXXXI()
        {
            Assert.AreEqual("CMXXXI", Converter.Convert(931));
        }
        [TestMethod]
        public void Convert_932_Returns_CMXXXII()
        {
            Assert.AreEqual("CMXXXII", Converter.Convert(932));
        }
        [TestMethod]
        public void Convert_933_Returns_CMXXXIII()
        {
            Assert.AreEqual("CMXXXIII", Converter.Convert(933));
        }
        [TestMethod]
        public void Convert_934_Returns_CMXXXIV()
        {
            Assert.AreEqual("CMXXXIV", Converter.Convert(934));
        }
        [TestMethod]
        public void Convert_935_Returns_CMXXXV()
        {
            Assert.AreEqual("CMXXXV", Converter.Convert(935));
        }
        [TestMethod]
        public void Convert_936_Returns_CMXXXVI()
        {
            Assert.AreEqual("CMXXXVI", Converter.Convert(936));
        }
        [TestMethod]
        public void Convert_937_Returns_CMXXXVII()
        {
            Assert.AreEqual("CMXXXVII", Converter.Convert(937));
        }
        [TestMethod]
        public void Convert_938_Returns_CMXXXVIII()
        {
            Assert.AreEqual("CMXXXVIII", Converter.Convert(938));
        }
        [TestMethod]
        public void Convert_939_Returns_CMXXXIX()
        {
            Assert.AreEqual("CMXXXIX", Converter.Convert(939));
        }
        [TestMethod]
        public void Convert_940_Returns_CMXL()
        {
            Assert.AreEqual("CMXL", Converter.Convert(940));
        }
        [TestMethod]
        public void Convert_941_Returns_CMXLI()
        {
            Assert.AreEqual("CMXLI", Converter.Convert(941));
        }
        [TestMethod]
        public void Convert_942_Returns_CMXLII()
        {
            Assert.AreEqual("CMXLII", Converter.Convert(942));
        }
        [TestMethod]
        public void Convert_943_Returns_CMXLIII()
        {
            Assert.AreEqual("CMXLIII", Converter.Convert(943));
        }
        [TestMethod]
        public void Convert_944_Returns_CMXLIV()
        {
            Assert.AreEqual("CMXLIV", Converter.Convert(944));
        }
        [TestMethod]
        public void Convert_945_Returns_CMXLV()
        {
            Assert.AreEqual("CMXLV", Converter.Convert(945));
        }
        [TestMethod]
        public void Convert_946_Returns_CMXLVI()
        {
            Assert.AreEqual("CMXLVI", Converter.Convert(946));
        }
        [TestMethod]
        public void Convert_947_Returns_CMXLVII()
        {
            Assert.AreEqual("CMXLVII", Converter.Convert(947));
        }
        [TestMethod]
        public void Convert_948_Returns_CMXLVIII()
        {
            Assert.AreEqual("CMXLVIII", Converter.Convert(948));
        }
        [TestMethod]
        public void Convert_949_Returns_CMXLIX()
        {
            Assert.AreEqual("CMXLIX", Converter.Convert(949));
        }
        [TestMethod]
        public void Convert_950_Returns_CML()
        {
            Assert.AreEqual("CML", Converter.Convert(950));
        }
        [TestMethod]
        public void Convert_951_Returns_CMLI()
        {
            Assert.AreEqual("CMLI", Converter.Convert(951));
        }
        [TestMethod]
        public void Convert_952_Returns_CMLII()
        {
            Assert.AreEqual("CMLII", Converter.Convert(952));
        }
        [TestMethod]
        public void Convert_953_Returns_CMLIII()
        {
            Assert.AreEqual("CMLIII", Converter.Convert(953));
        }
        [TestMethod]
        public void Convert_954_Returns_CMLIV()
        {
            Assert.AreEqual("CMLIV", Converter.Convert(954));
        }
        [TestMethod]
        public void Convert_955_Returns_CMLV()
        {
            Assert.AreEqual("CMLV", Converter.Convert(955));
        }
        [TestMethod]
        public void Convert_956_Returns_CMLVI()
        {
            Assert.AreEqual("CMLVI", Converter.Convert(956));
        }
        [TestMethod]
        public void Convert_957_Returns_CMLVII()
        {
            Assert.AreEqual("CMLVII", Converter.Convert(957));
        }
        [TestMethod]
        public void Convert_958_Returns_CMLVIII()
        {
            Assert.AreEqual("CMLVIII", Converter.Convert(958));
        }
        [TestMethod]
        public void Convert_959_Returns_CMLIX()
        {
            Assert.AreEqual("CMLIX", Converter.Convert(959));
        }
        [TestMethod]
        public void Convert_960_Returns_CMLX()
        {
            Assert.AreEqual("CMLX", Converter.Convert(960));
        }
        [TestMethod]
        public void Convert_961_Returns_CMLXI()
        {
            Assert.AreEqual("CMLXI", Converter.Convert(961));
        }
        [TestMethod]
        public void Convert_962_Returns_CMLXII()
        {
            Assert.AreEqual("CMLXII", Converter.Convert(962));
        }
        [TestMethod]
        public void Convert_963_Returns_CMLXIII()
        {
            Assert.AreEqual("CMLXIII", Converter.Convert(963));
        }
        [TestMethod]
        public void Convert_964_Returns_CMLXIV()
        {
            Assert.AreEqual("CMLXIV", Converter.Convert(964));
        }
        [TestMethod]
        public void Convert_965_Returns_CMLXV()
        {
            Assert.AreEqual("CMLXV", Converter.Convert(965));
        }
        [TestMethod]
        public void Convert_966_Returns_CMLXVI()
        {
            Assert.AreEqual("CMLXVI", Converter.Convert(966));
        }
        [TestMethod]
        public void Convert_967_Returns_CMLXVII()
        {
            Assert.AreEqual("CMLXVII", Converter.Convert(967));
        }
        [TestMethod]
        public void Convert_968_Returns_CMLXVIII()
        {
            Assert.AreEqual("CMLXVIII", Converter.Convert(968));
        }
        [TestMethod]
        public void Convert_969_Returns_CMLXIX()
        {
            Assert.AreEqual("CMLXIX", Converter.Convert(969));
        }
        [TestMethod]
        public void Convert_970_Returns_CMLXX()
        {
            Assert.AreEqual("CMLXX", Converter.Convert(970));
        }
        [TestMethod]
        public void Convert_971_Returns_CMLXXI()
        {
            Assert.AreEqual("CMLXXI", Converter.Convert(971));
        }
        [TestMethod]
        public void Convert_972_Returns_CMLXXII()
        {
            Assert.AreEqual("CMLXXII", Converter.Convert(972));
        }
        [TestMethod]
        public void Convert_973_Returns_CMLXXIII()
        {
            Assert.AreEqual("CMLXXIII", Converter.Convert(973));
        }
        [TestMethod]
        public void Convert_974_Returns_CMLXXIV()
        {
            Assert.AreEqual("CMLXXIV", Converter.Convert(974));
        }
        [TestMethod]
        public void Convert_975_Returns_CMLXXV()
        {
            Assert.AreEqual("CMLXXV", Converter.Convert(975));
        }
        [TestMethod]
        public void Convert_976_Returns_CMLXXVI()
        {
            Assert.AreEqual("CMLXXVI", Converter.Convert(976));
        }
        [TestMethod]
        public void Convert_977_Returns_CMLXXVII()
        {
            Assert.AreEqual("CMLXXVII", Converter.Convert(977));
        }
        [TestMethod]
        public void Convert_978_Returns_CMLXXVIII()
        {
            Assert.AreEqual("CMLXXVIII", Converter.Convert(978));
        }
        [TestMethod]
        public void Convert_979_Returns_CMLXXIX()
        {
            Assert.AreEqual("CMLXXIX", Converter.Convert(979));
        }
        [TestMethod]
        public void Convert_980_Returns_CMLXXX()
        {
            Assert.AreEqual("CMLXXX", Converter.Convert(980));
        }
        [TestMethod]
        public void Convert_981_Returns_CMLXXXI()
        {
            Assert.AreEqual("CMLXXXI", Converter.Convert(981));
        }
        [TestMethod]
        public void Convert_982_Returns_CMLXXXII()
        {
            Assert.AreEqual("CMLXXXII", Converter.Convert(982));
        }
        [TestMethod]
        public void Convert_983_Returns_CMLXXXIII()
        {
            Assert.AreEqual("CMLXXXIII", Converter.Convert(983));
        }
        [TestMethod]
        public void Convert_984_Returns_CMLXXXIV()
        {
            Assert.AreEqual("CMLXXXIV", Converter.Convert(984));
        }
        [TestMethod]
        public void Convert_985_Returns_CMLXXXV()
        {
            Assert.AreEqual("CMLXXXV", Converter.Convert(985));
        }
        [TestMethod]
        public void Convert_986_Returns_CMLXXXVI()
        {
            Assert.AreEqual("CMLXXXVI", Converter.Convert(986));
        }
        [TestMethod]
        public void Convert_987_Returns_CMLXXXVII()
        {
            Assert.AreEqual("CMLXXXVII", Converter.Convert(987));
        }
        [TestMethod]
        public void Convert_988_Returns_CMLXXXVIII()
        {
            Assert.AreEqual("CMLXXXVIII", Converter.Convert(988));
        }
        [TestMethod]
        public void Convert_989_Returns_CMLXXXIX()
        {
            Assert.AreEqual("CMLXXXIX", Converter.Convert(989));
        }
        [TestMethod]
        public void Convert_990_Returns_CMXC()
        {
            Assert.AreEqual("CMXC", Converter.Convert(990));
        }
        [TestMethod]
        public void Convert_991_Returns_CMXCI()
        {
            Assert.AreEqual("CMXCI", Converter.Convert(991));
        }
        [TestMethod]
        public void Convert_992_Returns_CMXCII()
        {
            Assert.AreEqual("CMXCII", Converter.Convert(992));
        }
        [TestMethod]
        public void Convert_993_Returns_CMXCIII()
        {
            Assert.AreEqual("CMXCIII", Converter.Convert(993));
        }
        [TestMethod]
        public void Convert_994_Returns_CMXCIV()
        {
            Assert.AreEqual("CMXCIV", Converter.Convert(994));
        }
        [TestMethod]
        public void Convert_995_Returns_CMXCV()
        {
            Assert.AreEqual("CMXCV", Converter.Convert(995));
        }
        [TestMethod]
        public void Convert_996_Returns_CMXCVI()
        {
            Assert.AreEqual("CMXCVI", Converter.Convert(996));
        }
        [TestMethod]
        public void Convert_997_Returns_CMXCVII()
        {
            Assert.AreEqual("CMXCVII", Converter.Convert(997));
        }
        [TestMethod]
        public void Convert_998_Returns_CMXCVIII()
        {
            Assert.AreEqual("CMXCVIII", Converter.Convert(998));
        }
        [TestMethod]
        public void Convert_999_Returns_CMXCIX()
        {
            Assert.AreEqual("CMXCIX", Converter.Convert(999));
        }
        [TestMethod]
        public void Convert_1000_Returns_M()
        {
            Assert.AreEqual("M", Converter.Convert(1000));
        }
        [TestMethod]
        public void Convert_1001_Returns_MI()
        {
            Assert.AreEqual("MI", Converter.Convert(1001));
        }
        [TestMethod]
        public void Convert_1002_Returns_MII()
        {
            Assert.AreEqual("MII", Converter.Convert(1002));
        }
        [TestMethod]
        public void Convert_1003_Returns_MIII()
        {
            Assert.AreEqual("MIII", Converter.Convert(1003));
        }
        [TestMethod]
        public void Convert_1004_Returns_MIV()
        {
            Assert.AreEqual("MIV", Converter.Convert(1004));
        }
        [TestMethod]
        public void Convert_1005_Returns_MV()
        {
            Assert.AreEqual("MV", Converter.Convert(1005));
        }
        [TestMethod]
        public void Convert_1006_Returns_MVI()
        {
            Assert.AreEqual("MVI", Converter.Convert(1006));
        }
        [TestMethod]
        public void Convert_1007_Returns_MVII()
        {
            Assert.AreEqual("MVII", Converter.Convert(1007));
        }
        [TestMethod]
        public void Convert_1008_Returns_MVIII()
        {
            Assert.AreEqual("MVIII", Converter.Convert(1008));
        }
        [TestMethod]
        public void Convert_1009_Returns_MIX()
        {
            Assert.AreEqual("MIX", Converter.Convert(1009));
        }
        [TestMethod]
        public void Convert_1010_Returns_MX()
        {
            Assert.AreEqual("MX", Converter.Convert(1010));
        }
        [TestMethod]
        public void Convert_1011_Returns_MXI()
        {
            Assert.AreEqual("MXI", Converter.Convert(1011));
        }
        [TestMethod]
        public void Convert_1012_Returns_MXII()
        {
            Assert.AreEqual("MXII", Converter.Convert(1012));
        }
        [TestMethod]
        public void Convert_1013_Returns_MXIII()
        {
            Assert.AreEqual("MXIII", Converter.Convert(1013));
        }
        [TestMethod]
        public void Convert_1014_Returns_MXIV()
        {
            Assert.AreEqual("MXIV", Converter.Convert(1014));
        }
        [TestMethod]
        public void Convert_1015_Returns_MXV()
        {
            Assert.AreEqual("MXV", Converter.Convert(1015));
        }
        [TestMethod]
        public void Convert_1016_Returns_MXVI()
        {
            Assert.AreEqual("MXVI", Converter.Convert(1016));
        }
        [TestMethod]
        public void Convert_1017_Returns_MXVII()
        {
            Assert.AreEqual("MXVII", Converter.Convert(1017));
        }
        [TestMethod]
        public void Convert_1018_Returns_MXVIII()
        {
            Assert.AreEqual("MXVIII", Converter.Convert(1018));
        }
        [TestMethod]
        public void Convert_1019_Returns_MXIX()
        {
            Assert.AreEqual("MXIX", Converter.Convert(1019));
        }
        [TestMethod]
        public void Convert_1020_Returns_MXX()
        {
            Assert.AreEqual("MXX", Converter.Convert(1020));
        }
        [TestMethod]
        public void Convert_1021_Returns_MXXI()
        {
            Assert.AreEqual("MXXI", Converter.Convert(1021));
        }
        [TestMethod]
        public void Convert_1022_Returns_MXXII()
        {
            Assert.AreEqual("MXXII", Converter.Convert(1022));
        }
        [TestMethod]
        public void Convert_1023_Returns_MXXIII()
        {
            Assert.AreEqual("MXXIII", Converter.Convert(1023));
        }
        [TestMethod]
        public void Convert_1024_Returns_MXXIV()
        {
            Assert.AreEqual("MXXIV", Converter.Convert(1024));
        }
        [TestMethod]
        public void Convert_1025_Returns_MXXV()
        {
            Assert.AreEqual("MXXV", Converter.Convert(1025));
        }
        [TestMethod]
        public void Convert_1026_Returns_MXXVI()
        {
            Assert.AreEqual("MXXVI", Converter.Convert(1026));
        }
        [TestMethod]
        public void Convert_1027_Returns_MXXVII()
        {
            Assert.AreEqual("MXXVII", Converter.Convert(1027));
        }
        [TestMethod]
        public void Convert_1028_Returns_MXXVIII()
        {
            Assert.AreEqual("MXXVIII", Converter.Convert(1028));
        }
        [TestMethod]
        public void Convert_1029_Returns_MXXIX()
        {
            Assert.AreEqual("MXXIX", Converter.Convert(1029));
        }
        [TestMethod]
        public void Convert_1030_Returns_MXXX()
        {
            Assert.AreEqual("MXXX", Converter.Convert(1030));
        }
        [TestMethod]
        public void Convert_1031_Returns_MXXXI()
        {
            Assert.AreEqual("MXXXI", Converter.Convert(1031));
        }
        [TestMethod]
        public void Convert_1032_Returns_MXXXII()
        {
            Assert.AreEqual("MXXXII", Converter.Convert(1032));
        }
        [TestMethod]
        public void Convert_1033_Returns_MXXXIII()
        {
            Assert.AreEqual("MXXXIII", Converter.Convert(1033));
        }
        [TestMethod]
        public void Convert_1034_Returns_MXXXIV()
        {
            Assert.AreEqual("MXXXIV", Converter.Convert(1034));
        }
        [TestMethod]
        public void Convert_1035_Returns_MXXXV()
        {
            Assert.AreEqual("MXXXV", Converter.Convert(1035));
        }
        [TestMethod]
        public void Convert_1036_Returns_MXXXVI()
        {
            Assert.AreEqual("MXXXVI", Converter.Convert(1036));
        }
        [TestMethod]
        public void Convert_1037_Returns_MXXXVII()
        {
            Assert.AreEqual("MXXXVII", Converter.Convert(1037));
        }
        [TestMethod]
        public void Convert_1038_Returns_MXXXVIII()
        {
            Assert.AreEqual("MXXXVIII", Converter.Convert(1038));
        }
        [TestMethod]
        public void Convert_1039_Returns_MXXXIX()
        {
            Assert.AreEqual("MXXXIX", Converter.Convert(1039));
        }
        [TestMethod]
        public void Convert_1040_Returns_MXL()
        {
            Assert.AreEqual("MXL", Converter.Convert(1040));
        }
        [TestMethod]
        public void Convert_1041_Returns_MXLI()
        {
            Assert.AreEqual("MXLI", Converter.Convert(1041));
        }
        [TestMethod]
        public void Convert_1042_Returns_MXLII()
        {
            Assert.AreEqual("MXLII", Converter.Convert(1042));
        }
        [TestMethod]
        public void Convert_1043_Returns_MXLIII()
        {
            Assert.AreEqual("MXLIII", Converter.Convert(1043));
        }
        [TestMethod]
        public void Convert_1044_Returns_MXLIV()
        {
            Assert.AreEqual("MXLIV", Converter.Convert(1044));
        }
        [TestMethod]
        public void Convert_1045_Returns_MXLV()
        {
            Assert.AreEqual("MXLV", Converter.Convert(1045));
        }
        [TestMethod]
        public void Convert_1046_Returns_MXLVI()
        {
            Assert.AreEqual("MXLVI", Converter.Convert(1046));
        }
        [TestMethod]
        public void Convert_1047_Returns_MXLVII()
        {
            Assert.AreEqual("MXLVII", Converter.Convert(1047));
        }
        [TestMethod]
        public void Convert_1048_Returns_MXLVIII()
        {
            Assert.AreEqual("MXLVIII", Converter.Convert(1048));
        }
        [TestMethod]
        public void Convert_1049_Returns_MXLIX()
        {
            Assert.AreEqual("MXLIX", Converter.Convert(1049));
        }
        [TestMethod]
        public void Convert_1050_Returns_ML()
        {
            Assert.AreEqual("ML", Converter.Convert(1050));
        }
        [TestMethod]
        public void Convert_1051_Returns_MLI()
        {
            Assert.AreEqual("MLI", Converter.Convert(1051));
        }
        [TestMethod]
        public void Convert_1052_Returns_MLII()
        {
            Assert.AreEqual("MLII", Converter.Convert(1052));
        }
        [TestMethod]
        public void Convert_1053_Returns_MLIII()
        {
            Assert.AreEqual("MLIII", Converter.Convert(1053));
        }
        [TestMethod]
        public void Convert_1054_Returns_MLIV()
        {
            Assert.AreEqual("MLIV", Converter.Convert(1054));
        }
        [TestMethod]
        public void Convert_1055_Returns_MLV()
        {
            Assert.AreEqual("MLV", Converter.Convert(1055));
        }
        [TestMethod]
        public void Convert_1056_Returns_MLVI()
        {
            Assert.AreEqual("MLVI", Converter.Convert(1056));
        }
        [TestMethod]
        public void Convert_1057_Returns_MLVII()
        {
            Assert.AreEqual("MLVII", Converter.Convert(1057));
        }
        [TestMethod]
        public void Convert_1058_Returns_MLVIII()
        {
            Assert.AreEqual("MLVIII", Converter.Convert(1058));
        }
        [TestMethod]
        public void Convert_1059_Returns_MLIX()
        {
            Assert.AreEqual("MLIX", Converter.Convert(1059));
        }
        [TestMethod]
        public void Convert_1060_Returns_MLX()
        {
            Assert.AreEqual("MLX", Converter.Convert(1060));
        }
        [TestMethod]
        public void Convert_1061_Returns_MLXI()
        {
            Assert.AreEqual("MLXI", Converter.Convert(1061));
        }
        [TestMethod]
        public void Convert_1062_Returns_MLXII()
        {
            Assert.AreEqual("MLXII", Converter.Convert(1062));
        }
        [TestMethod]
        public void Convert_1063_Returns_MLXIII()
        {
            Assert.AreEqual("MLXIII", Converter.Convert(1063));
        }
        [TestMethod]
        public void Convert_1064_Returns_MLXIV()
        {
            Assert.AreEqual("MLXIV", Converter.Convert(1064));
        }
        [TestMethod]
        public void Convert_1065_Returns_MLXV()
        {
            Assert.AreEqual("MLXV", Converter.Convert(1065));
        }
        [TestMethod]
        public void Convert_1066_Returns_MLXVI()
        {
            Assert.AreEqual("MLXVI", Converter.Convert(1066));
        }
        [TestMethod]
        public void Convert_1067_Returns_MLXVII()
        {
            Assert.AreEqual("MLXVII", Converter.Convert(1067));
        }
        [TestMethod]
        public void Convert_1068_Returns_MLXVIII()
        {
            Assert.AreEqual("MLXVIII", Converter.Convert(1068));
        }
        [TestMethod]
        public void Convert_1069_Returns_MLXIX()
        {
            Assert.AreEqual("MLXIX", Converter.Convert(1069));
        }
        [TestMethod]
        public void Convert_1070_Returns_MLXX()
        {
            Assert.AreEqual("MLXX", Converter.Convert(1070));
        }
        [TestMethod]
        public void Convert_1071_Returns_MLXXI()
        {
            Assert.AreEqual("MLXXI", Converter.Convert(1071));
        }
        [TestMethod]
        public void Convert_1072_Returns_MLXXII()
        {
            Assert.AreEqual("MLXXII", Converter.Convert(1072));
        }
        [TestMethod]
        public void Convert_1073_Returns_MLXXIII()
        {
            Assert.AreEqual("MLXXIII", Converter.Convert(1073));
        }
        [TestMethod]
        public void Convert_1074_Returns_MLXXIV()
        {
            Assert.AreEqual("MLXXIV", Converter.Convert(1074));
        }
        [TestMethod]
        public void Convert_1075_Returns_MLXXV()
        {
            Assert.AreEqual("MLXXV", Converter.Convert(1075));
        }
        [TestMethod]
        public void Convert_1076_Returns_MLXXVI()
        {
            Assert.AreEqual("MLXXVI", Converter.Convert(1076));
        }
        [TestMethod]
        public void Convert_1077_Returns_MLXXVII()
        {
            Assert.AreEqual("MLXXVII", Converter.Convert(1077));
        }
        [TestMethod]
        public void Convert_1078_Returns_MLXXVIII()
        {
            Assert.AreEqual("MLXXVIII", Converter.Convert(1078));
        }
        [TestMethod]
        public void Convert_1079_Returns_MLXXIX()
        {
            Assert.AreEqual("MLXXIX", Converter.Convert(1079));
        }
        [TestMethod]
        public void Convert_1080_Returns_MLXXX()
        {
            Assert.AreEqual("MLXXX", Converter.Convert(1080));
        }
        [TestMethod]
        public void Convert_1081_Returns_MLXXXI()
        {
            Assert.AreEqual("MLXXXI", Converter.Convert(1081));
        }
        [TestMethod]
        public void Convert_1082_Returns_MLXXXII()
        {
            Assert.AreEqual("MLXXXII", Converter.Convert(1082));
        }
        [TestMethod]
        public void Convert_1083_Returns_MLXXXIII()
        {
            Assert.AreEqual("MLXXXIII", Converter.Convert(1083));
        }
        [TestMethod]
        public void Convert_1084_Returns_MLXXXIV()
        {
            Assert.AreEqual("MLXXXIV", Converter.Convert(1084));
        }
        [TestMethod]
        public void Convert_1085_Returns_MLXXXV()
        {
            Assert.AreEqual("MLXXXV", Converter.Convert(1085));
        }
        [TestMethod]
        public void Convert_1086_Returns_MLXXXVI()
        {
            Assert.AreEqual("MLXXXVI", Converter.Convert(1086));
        }
        [TestMethod]
        public void Convert_1087_Returns_MLXXXVII()
        {
            Assert.AreEqual("MLXXXVII", Converter.Convert(1087));
        }
        [TestMethod]
        public void Convert_1088_Returns_MLXXXVIII()
        {
            Assert.AreEqual("MLXXXVIII", Converter.Convert(1088));
        }
        [TestMethod]
        public void Convert_1089_Returns_MLXXXIX()
        {
            Assert.AreEqual("MLXXXIX", Converter.Convert(1089));
        }
        [TestMethod]
        public void Convert_1090_Returns_MXC()
        {
            Assert.AreEqual("MXC", Converter.Convert(1090));
        }
        [TestMethod]
        public void Convert_1091_Returns_MXCI()
        {
            Assert.AreEqual("MXCI", Converter.Convert(1091));
        }
        [TestMethod]
        public void Convert_1092_Returns_MXCII()
        {
            Assert.AreEqual("MXCII", Converter.Convert(1092));
        }
        [TestMethod]
        public void Convert_1093_Returns_MXCIII()
        {
            Assert.AreEqual("MXCIII", Converter.Convert(1093));
        }
        [TestMethod]
        public void Convert_1094_Returns_MXCIV()
        {
            Assert.AreEqual("MXCIV", Converter.Convert(1094));
        }
        [TestMethod]
        public void Convert_1095_Returns_MXCV()
        {
            Assert.AreEqual("MXCV", Converter.Convert(1095));
        }
        [TestMethod]
        public void Convert_1096_Returns_MXCVI()
        {
            Assert.AreEqual("MXCVI", Converter.Convert(1096));
        }
        [TestMethod]
        public void Convert_1097_Returns_MXCVII()
        {
            Assert.AreEqual("MXCVII", Converter.Convert(1097));
        }
        [TestMethod]
        public void Convert_1098_Returns_MXCVIII()
        {
            Assert.AreEqual("MXCVIII", Converter.Convert(1098));
        }
        [TestMethod]
        public void Convert_1099_Returns_MXCIX()
        {
            Assert.AreEqual("MXCIX", Converter.Convert(1099));
        }
        [TestMethod]
        public void Convert_1100_Returns_MC()
        {
            Assert.AreEqual("MC", Converter.Convert(1100));
        }
        [TestMethod]
        public void Convert_1101_Returns_MCI()
        {
            Assert.AreEqual("MCI", Converter.Convert(1101));
        }
        [TestMethod]
        public void Convert_1102_Returns_MCII()
        {
            Assert.AreEqual("MCII", Converter.Convert(1102));
        }
        [TestMethod]
        public void Convert_1103_Returns_MCIII()
        {
            Assert.AreEqual("MCIII", Converter.Convert(1103));
        }
        [TestMethod]
        public void Convert_1104_Returns_MCIV()
        {
            Assert.AreEqual("MCIV", Converter.Convert(1104));
        }
        [TestMethod]
        public void Convert_1105_Returns_MCV()
        {
            Assert.AreEqual("MCV", Converter.Convert(1105));
        }
        [TestMethod]
        public void Convert_1106_Returns_MCVI()
        {
            Assert.AreEqual("MCVI", Converter.Convert(1106));
        }
        [TestMethod]
        public void Convert_1107_Returns_MCVII()
        {
            Assert.AreEqual("MCVII", Converter.Convert(1107));
        }
        [TestMethod]
        public void Convert_1108_Returns_MCVIII()
        {
            Assert.AreEqual("MCVIII", Converter.Convert(1108));
        }
        [TestMethod]
        public void Convert_1109_Returns_MCIX()
        {
            Assert.AreEqual("MCIX", Converter.Convert(1109));
        }
        [TestMethod]
        public void Convert_1110_Returns_MCX()
        {
            Assert.AreEqual("MCX", Converter.Convert(1110));
        }
        [TestMethod]
        public void Convert_1111_Returns_MCXI()
        {
            Assert.AreEqual("MCXI", Converter.Convert(1111));
        }
        [TestMethod]
        public void Convert_1112_Returns_MCXII()
        {
            Assert.AreEqual("MCXII", Converter.Convert(1112));
        }
        [TestMethod]
        public void Convert_1113_Returns_MCXIII()
        {
            Assert.AreEqual("MCXIII", Converter.Convert(1113));
        }
        [TestMethod]
        public void Convert_1114_Returns_MCXIV()
        {
            Assert.AreEqual("MCXIV", Converter.Convert(1114));
        }
        [TestMethod]
        public void Convert_1115_Returns_MCXV()
        {
            Assert.AreEqual("MCXV", Converter.Convert(1115));
        }
        [TestMethod]
        public void Convert_1116_Returns_MCXVI()
        {
            Assert.AreEqual("MCXVI", Converter.Convert(1116));
        }
        [TestMethod]
        public void Convert_1117_Returns_MCXVII()
        {
            Assert.AreEqual("MCXVII", Converter.Convert(1117));
        }
        [TestMethod]
        public void Convert_1118_Returns_MCXVIII()
        {
            Assert.AreEqual("MCXVIII", Converter.Convert(1118));
        }
        [TestMethod]
        public void Convert_1119_Returns_MCXIX()
        {
            Assert.AreEqual("MCXIX", Converter.Convert(1119));
        }
        [TestMethod]
        public void Convert_1120_Returns_MCXX()
        {
            Assert.AreEqual("MCXX", Converter.Convert(1120));
        }
        [TestMethod]
        public void Convert_1121_Returns_MCXXI()
        {
            Assert.AreEqual("MCXXI", Converter.Convert(1121));
        }
        [TestMethod]
        public void Convert_1122_Returns_MCXXII()
        {
            Assert.AreEqual("MCXXII", Converter.Convert(1122));
        }
        [TestMethod]
        public void Convert_1123_Returns_MCXXIII()
        {
            Assert.AreEqual("MCXXIII", Converter.Convert(1123));
        }
        [TestMethod]
        public void Convert_1124_Returns_MCXXIV()
        {
            Assert.AreEqual("MCXXIV", Converter.Convert(1124));
        }
        [TestMethod]
        public void Convert_1125_Returns_MCXXV()
        {
            Assert.AreEqual("MCXXV", Converter.Convert(1125));
        }
        [TestMethod]
        public void Convert_1126_Returns_MCXXVI()
        {
            Assert.AreEqual("MCXXVI", Converter.Convert(1126));
        }
        [TestMethod]
        public void Convert_1127_Returns_MCXXVII()
        {
            Assert.AreEqual("MCXXVII", Converter.Convert(1127));
        }
        [TestMethod]
        public void Convert_1128_Returns_MCXXVIII()
        {
            Assert.AreEqual("MCXXVIII", Converter.Convert(1128));
        }
        [TestMethod]
        public void Convert_1129_Returns_MCXXIX()
        {
            Assert.AreEqual("MCXXIX", Converter.Convert(1129));
        }
        [TestMethod]
        public void Convert_1130_Returns_MCXXX()
        {
            Assert.AreEqual("MCXXX", Converter.Convert(1130));
        }
        [TestMethod]
        public void Convert_1131_Returns_MCXXXI()
        {
            Assert.AreEqual("MCXXXI", Converter.Convert(1131));
        }
        [TestMethod]
        public void Convert_1132_Returns_MCXXXII()
        {
            Assert.AreEqual("MCXXXII", Converter.Convert(1132));
        }
        [TestMethod]
        public void Convert_1133_Returns_MCXXXIII()
        {
            Assert.AreEqual("MCXXXIII", Converter.Convert(1133));
        }
        [TestMethod]
        public void Convert_1134_Returns_MCXXXIV()
        {
            Assert.AreEqual("MCXXXIV", Converter.Convert(1134));
        }
        [TestMethod]
        public void Convert_1135_Returns_MCXXXV()
        {
            Assert.AreEqual("MCXXXV", Converter.Convert(1135));
        }
        [TestMethod]
        public void Convert_1136_Returns_MCXXXVI()
        {
            Assert.AreEqual("MCXXXVI", Converter.Convert(1136));
        }
        [TestMethod]
        public void Convert_1137_Returns_MCXXXVII()
        {
            Assert.AreEqual("MCXXXVII", Converter.Convert(1137));
        }
        [TestMethod]
        public void Convert_1138_Returns_MCXXXVIII()
        {
            Assert.AreEqual("MCXXXVIII", Converter.Convert(1138));
        }
        [TestMethod]
        public void Convert_1139_Returns_MCXXXIX()
        {
            Assert.AreEqual("MCXXXIX", Converter.Convert(1139));
        }
        [TestMethod]
        public void Convert_1140_Returns_MCXL()
        {
            Assert.AreEqual("MCXL", Converter.Convert(1140));
        }
        [TestMethod]
        public void Convert_1141_Returns_MCXLI()
        {
            Assert.AreEqual("MCXLI", Converter.Convert(1141));
        }
        [TestMethod]
        public void Convert_1142_Returns_MCXLII()
        {
            Assert.AreEqual("MCXLII", Converter.Convert(1142));
        }
        [TestMethod]
        public void Convert_1143_Returns_MCXLIII()
        {
            Assert.AreEqual("MCXLIII", Converter.Convert(1143));
        }
        [TestMethod]
        public void Convert_1144_Returns_MCXLIV()
        {
            Assert.AreEqual("MCXLIV", Converter.Convert(1144));
        }
        [TestMethod]
        public void Convert_1145_Returns_MCXLV()
        {
            Assert.AreEqual("MCXLV", Converter.Convert(1145));
        }
        [TestMethod]
        public void Convert_1146_Returns_MCXLVI()
        {
            Assert.AreEqual("MCXLVI", Converter.Convert(1146));
        }
        [TestMethod]
        public void Convert_1147_Returns_MCXLVII()
        {
            Assert.AreEqual("MCXLVII", Converter.Convert(1147));
        }
        [TestMethod]
        public void Convert_1148_Returns_MCXLVIII()
        {
            Assert.AreEqual("MCXLVIII", Converter.Convert(1148));
        }
        [TestMethod]
        public void Convert_1149_Returns_MCXLIX()
        {
            Assert.AreEqual("MCXLIX", Converter.Convert(1149));
        }
        [TestMethod]
        public void Convert_1150_Returns_MCL()
        {
            Assert.AreEqual("MCL", Converter.Convert(1150));
        }
        [TestMethod]
        public void Convert_1151_Returns_MCLI()
        {
            Assert.AreEqual("MCLI", Converter.Convert(1151));
        }
        [TestMethod]
        public void Convert_1152_Returns_MCLII()
        {
            Assert.AreEqual("MCLII", Converter.Convert(1152));
        }
        [TestMethod]
        public void Convert_1153_Returns_MCLIII()
        {
            Assert.AreEqual("MCLIII", Converter.Convert(1153));
        }
        [TestMethod]
        public void Convert_1154_Returns_MCLIV()
        {
            Assert.AreEqual("MCLIV", Converter.Convert(1154));
        }
        [TestMethod]
        public void Convert_1155_Returns_MCLV()
        {
            Assert.AreEqual("MCLV", Converter.Convert(1155));
        }
        [TestMethod]
        public void Convert_1156_Returns_MCLVI()
        {
            Assert.AreEqual("MCLVI", Converter.Convert(1156));
        }
        [TestMethod]
        public void Convert_1157_Returns_MCLVII()
        {
            Assert.AreEqual("MCLVII", Converter.Convert(1157));
        }
        [TestMethod]
        public void Convert_1158_Returns_MCLVIII()
        {
            Assert.AreEqual("MCLVIII", Converter.Convert(1158));
        }
        [TestMethod]
        public void Convert_1159_Returns_MCLIX()
        {
            Assert.AreEqual("MCLIX", Converter.Convert(1159));
        }
        [TestMethod]
        public void Convert_1160_Returns_MCLX()
        {
            Assert.AreEqual("MCLX", Converter.Convert(1160));
        }
        [TestMethod]
        public void Convert_1161_Returns_MCLXI()
        {
            Assert.AreEqual("MCLXI", Converter.Convert(1161));
        }
        [TestMethod]
        public void Convert_1162_Returns_MCLXII()
        {
            Assert.AreEqual("MCLXII", Converter.Convert(1162));
        }
        [TestMethod]
        public void Convert_1163_Returns_MCLXIII()
        {
            Assert.AreEqual("MCLXIII", Converter.Convert(1163));
        }
        [TestMethod]
        public void Convert_1164_Returns_MCLXIV()
        {
            Assert.AreEqual("MCLXIV", Converter.Convert(1164));
        }
        [TestMethod]
        public void Convert_1165_Returns_MCLXV()
        {
            Assert.AreEqual("MCLXV", Converter.Convert(1165));
        }
        [TestMethod]
        public void Convert_1166_Returns_MCLXVI()
        {
            Assert.AreEqual("MCLXVI", Converter.Convert(1166));
        }
        [TestMethod]
        public void Convert_1167_Returns_MCLXVII()
        {
            Assert.AreEqual("MCLXVII", Converter.Convert(1167));
        }
        [TestMethod]
        public void Convert_1168_Returns_MCLXVIII()
        {
            Assert.AreEqual("MCLXVIII", Converter.Convert(1168));
        }
        [TestMethod]
        public void Convert_1169_Returns_MCLXIX()
        {
            Assert.AreEqual("MCLXIX", Converter.Convert(1169));
        }
        [TestMethod]
        public void Convert_1170_Returns_MCLXX()
        {
            Assert.AreEqual("MCLXX", Converter.Convert(1170));
        }
        [TestMethod]
        public void Convert_1171_Returns_MCLXXI()
        {
            Assert.AreEqual("MCLXXI", Converter.Convert(1171));
        }
        [TestMethod]
        public void Convert_1172_Returns_MCLXXII()
        {
            Assert.AreEqual("MCLXXII", Converter.Convert(1172));
        }
        [TestMethod]
        public void Convert_1173_Returns_MCLXXIII()
        {
            Assert.AreEqual("MCLXXIII", Converter.Convert(1173));
        }
        [TestMethod]
        public void Convert_1174_Returns_MCLXXIV()
        {
            Assert.AreEqual("MCLXXIV", Converter.Convert(1174));
        }
        [TestMethod]
        public void Convert_1175_Returns_MCLXXV()
        {
            Assert.AreEqual("MCLXXV", Converter.Convert(1175));
        }
        [TestMethod]
        public void Convert_1176_Returns_MCLXXVI()
        {
            Assert.AreEqual("MCLXXVI", Converter.Convert(1176));
        }
        [TestMethod]
        public void Convert_1177_Returns_MCLXXVII()
        {
            Assert.AreEqual("MCLXXVII", Converter.Convert(1177));
        }
        [TestMethod]
        public void Convert_1178_Returns_MCLXXVIII()
        {
            Assert.AreEqual("MCLXXVIII", Converter.Convert(1178));
        }
        [TestMethod]
        public void Convert_1179_Returns_MCLXXIX()
        {
            Assert.AreEqual("MCLXXIX", Converter.Convert(1179));
        }
        [TestMethod]
        public void Convert_1180_Returns_MCLXXX()
        {
            Assert.AreEqual("MCLXXX", Converter.Convert(1180));
        }
        [TestMethod]
        public void Convert_1181_Returns_MCLXXXI()
        {
            Assert.AreEqual("MCLXXXI", Converter.Convert(1181));
        }
        [TestMethod]
        public void Convert_1182_Returns_MCLXXXII()
        {
            Assert.AreEqual("MCLXXXII", Converter.Convert(1182));
        }
        [TestMethod]
        public void Convert_1183_Returns_MCLXXXIII()
        {
            Assert.AreEqual("MCLXXXIII", Converter.Convert(1183));
        }
        [TestMethod]
        public void Convert_1184_Returns_MCLXXXIV()
        {
            Assert.AreEqual("MCLXXXIV", Converter.Convert(1184));
        }
        [TestMethod]
        public void Convert_1185_Returns_MCLXXXV()
        {
            Assert.AreEqual("MCLXXXV", Converter.Convert(1185));
        }
        [TestMethod]
        public void Convert_1186_Returns_MCLXXXVI()
        {
            Assert.AreEqual("MCLXXXVI", Converter.Convert(1186));
        }
        [TestMethod]
        public void Convert_1187_Returns_MCLXXXVII()
        {
            Assert.AreEqual("MCLXXXVII", Converter.Convert(1187));
        }
        [TestMethod]
        public void Convert_1188_Returns_MCLXXXVIII()
        {
            Assert.AreEqual("MCLXXXVIII", Converter.Convert(1188));
        }
        [TestMethod]
        public void Convert_1189_Returns_MCLXXXIX()
        {
            Assert.AreEqual("MCLXXXIX", Converter.Convert(1189));
        }
        [TestMethod]
        public void Convert_1190_Returns_MCXC()
        {
            Assert.AreEqual("MCXC", Converter.Convert(1190));
        }
        [TestMethod]
        public void Convert_1191_Returns_MCXCI()
        {
            Assert.AreEqual("MCXCI", Converter.Convert(1191));
        }
        [TestMethod]
        public void Convert_1192_Returns_MCXCII()
        {
            Assert.AreEqual("MCXCII", Converter.Convert(1192));
        }
        [TestMethod]
        public void Convert_1193_Returns_MCXCIII()
        {
            Assert.AreEqual("MCXCIII", Converter.Convert(1193));
        }
        [TestMethod]
        public void Convert_1194_Returns_MCXCIV()
        {
            Assert.AreEqual("MCXCIV", Converter.Convert(1194));
        }
        [TestMethod]
        public void Convert_1195_Returns_MCXCV()
        {
            Assert.AreEqual("MCXCV", Converter.Convert(1195));
        }
        [TestMethod]
        public void Convert_1196_Returns_MCXCVI()
        {
            Assert.AreEqual("MCXCVI", Converter.Convert(1196));
        }
        [TestMethod]
        public void Convert_1197_Returns_MCXCVII()
        {
            Assert.AreEqual("MCXCVII", Converter.Convert(1197));
        }
        [TestMethod]
        public void Convert_1198_Returns_MCXCVIII()
        {
            Assert.AreEqual("MCXCVIII", Converter.Convert(1198));
        }
        [TestMethod]
        public void Convert_1199_Returns_MCXCIX()
        {
            Assert.AreEqual("MCXCIX", Converter.Convert(1199));
        }
        [TestMethod]
        public void Convert_1200_Returns_MCC()
        {
            Assert.AreEqual("MCC", Converter.Convert(1200));
        }
        [TestMethod]
        public void Convert_1201_Returns_MCCI()
        {
            Assert.AreEqual("MCCI", Converter.Convert(1201));
        }
        [TestMethod]
        public void Convert_1202_Returns_MCCII()
        {
            Assert.AreEqual("MCCII", Converter.Convert(1202));
        }
        [TestMethod]
        public void Convert_1203_Returns_MCCIII()
        {
            Assert.AreEqual("MCCIII", Converter.Convert(1203));
        }
        [TestMethod]
        public void Convert_1204_Returns_MCCIV()
        {
            Assert.AreEqual("MCCIV", Converter.Convert(1204));
        }
        [TestMethod]
        public void Convert_1205_Returns_MCCV()
        {
            Assert.AreEqual("MCCV", Converter.Convert(1205));
        }
        [TestMethod]
        public void Convert_1206_Returns_MCCVI()
        {
            Assert.AreEqual("MCCVI", Converter.Convert(1206));
        }
        [TestMethod]
        public void Convert_1207_Returns_MCCVII()
        {
            Assert.AreEqual("MCCVII", Converter.Convert(1207));
        }
        [TestMethod]
        public void Convert_1208_Returns_MCCVIII()
        {
            Assert.AreEqual("MCCVIII", Converter.Convert(1208));
        }
        [TestMethod]
        public void Convert_1209_Returns_MCCIX()
        {
            Assert.AreEqual("MCCIX", Converter.Convert(1209));
        }
        [TestMethod]
        public void Convert_1210_Returns_MCCX()
        {
            Assert.AreEqual("MCCX", Converter.Convert(1210));
        }
        [TestMethod]
        public void Convert_1211_Returns_MCCXI()
        {
            Assert.AreEqual("MCCXI", Converter.Convert(1211));
        }
        [TestMethod]
        public void Convert_1212_Returns_MCCXII()
        {
            Assert.AreEqual("MCCXII", Converter.Convert(1212));
        }
        [TestMethod]
        public void Convert_1213_Returns_MCCXIII()
        {
            Assert.AreEqual("MCCXIII", Converter.Convert(1213));
        }
        [TestMethod]
        public void Convert_1214_Returns_MCCXIV()
        {
            Assert.AreEqual("MCCXIV", Converter.Convert(1214));
        }
        [TestMethod]
        public void Convert_1215_Returns_MCCXV()
        {
            Assert.AreEqual("MCCXV", Converter.Convert(1215));
        }
        [TestMethod]
        public void Convert_1216_Returns_MCCXVI()
        {
            Assert.AreEqual("MCCXVI", Converter.Convert(1216));
        }
        [TestMethod]
        public void Convert_1217_Returns_MCCXVII()
        {
            Assert.AreEqual("MCCXVII", Converter.Convert(1217));
        }
        [TestMethod]
        public void Convert_1218_Returns_MCCXVIII()
        {
            Assert.AreEqual("MCCXVIII", Converter.Convert(1218));
        }
        [TestMethod]
        public void Convert_1219_Returns_MCCXIX()
        {
            Assert.AreEqual("MCCXIX", Converter.Convert(1219));
        }
        [TestMethod]
        public void Convert_1220_Returns_MCCXX()
        {
            Assert.AreEqual("MCCXX", Converter.Convert(1220));
        }
        [TestMethod]
        public void Convert_1221_Returns_MCCXXI()
        {
            Assert.AreEqual("MCCXXI", Converter.Convert(1221));
        }
        [TestMethod]
        public void Convert_1222_Returns_MCCXXII()
        {
            Assert.AreEqual("MCCXXII", Converter.Convert(1222));
        }
        [TestMethod]
        public void Convert_1223_Returns_MCCXXIII()
        {
            Assert.AreEqual("MCCXXIII", Converter.Convert(1223));
        }
        [TestMethod]
        public void Convert_1224_Returns_MCCXXIV()
        {
            Assert.AreEqual("MCCXXIV", Converter.Convert(1224));
        }
        [TestMethod]
        public void Convert_1225_Returns_MCCXXV()
        {
            Assert.AreEqual("MCCXXV", Converter.Convert(1225));
        }
        [TestMethod]
        public void Convert_1226_Returns_MCCXXVI()
        {
            Assert.AreEqual("MCCXXVI", Converter.Convert(1226));
        }
        [TestMethod]
        public void Convert_1227_Returns_MCCXXVII()
        {
            Assert.AreEqual("MCCXXVII", Converter.Convert(1227));
        }
        [TestMethod]
        public void Convert_1228_Returns_MCCXXVIII()
        {
            Assert.AreEqual("MCCXXVIII", Converter.Convert(1228));
        }
        [TestMethod]
        public void Convert_1229_Returns_MCCXXIX()
        {
            Assert.AreEqual("MCCXXIX", Converter.Convert(1229));
        }
        [TestMethod]
        public void Convert_1230_Returns_MCCXXX()
        {
            Assert.AreEqual("MCCXXX", Converter.Convert(1230));
        }
        [TestMethod]
        public void Convert_1231_Returns_MCCXXXI()
        {
            Assert.AreEqual("MCCXXXI", Converter.Convert(1231));
        }
        [TestMethod]
        public void Convert_1232_Returns_MCCXXXII()
        {
            Assert.AreEqual("MCCXXXII", Converter.Convert(1232));
        }
        [TestMethod]
        public void Convert_1233_Returns_MCCXXXIII()
        {
            Assert.AreEqual("MCCXXXIII", Converter.Convert(1233));
        }
        [TestMethod]
        public void Convert_1234_Returns_MCCXXXIV()
        {
            Assert.AreEqual("MCCXXXIV", Converter.Convert(1234));
        }
        [TestMethod]
        public void Convert_1235_Returns_MCCXXXV()
        {
            Assert.AreEqual("MCCXXXV", Converter.Convert(1235));
        }
        [TestMethod]
        public void Convert_1236_Returns_MCCXXXVI()
        {
            Assert.AreEqual("MCCXXXVI", Converter.Convert(1236));
        }
        [TestMethod]
        public void Convert_1237_Returns_MCCXXXVII()
        {
            Assert.AreEqual("MCCXXXVII", Converter.Convert(1237));
        }
        [TestMethod]
        public void Convert_1238_Returns_MCCXXXVIII()
        {
            Assert.AreEqual("MCCXXXVIII", Converter.Convert(1238));
        }
        [TestMethod]
        public void Convert_1239_Returns_MCCXXXIX()
        {
            Assert.AreEqual("MCCXXXIX", Converter.Convert(1239));
        }
        [TestMethod]
        public void Convert_1240_Returns_MCCXL()
        {
            Assert.AreEqual("MCCXL", Converter.Convert(1240));
        }
        [TestMethod]
        public void Convert_1241_Returns_MCCXLI()
        {
            Assert.AreEqual("MCCXLI", Converter.Convert(1241));
        }
        [TestMethod]
        public void Convert_1242_Returns_MCCXLII()
        {
            Assert.AreEqual("MCCXLII", Converter.Convert(1242));
        }
        [TestMethod]
        public void Convert_1243_Returns_MCCXLIII()
        {
            Assert.AreEqual("MCCXLIII", Converter.Convert(1243));
        }
        [TestMethod]
        public void Convert_1244_Returns_MCCXLIV()
        {
            Assert.AreEqual("MCCXLIV", Converter.Convert(1244));
        }
        [TestMethod]
        public void Convert_1245_Returns_MCCXLV()
        {
            Assert.AreEqual("MCCXLV", Converter.Convert(1245));
        }
        [TestMethod]
        public void Convert_1246_Returns_MCCXLVI()
        {
            Assert.AreEqual("MCCXLVI", Converter.Convert(1246));
        }
        [TestMethod]
        public void Convert_1247_Returns_MCCXLVII()
        {
            Assert.AreEqual("MCCXLVII", Converter.Convert(1247));
        }
        [TestMethod]
        public void Convert_1248_Returns_MCCXLVIII()
        {
            Assert.AreEqual("MCCXLVIII", Converter.Convert(1248));
        }
        [TestMethod]
        public void Convert_1249_Returns_MCCXLIX()
        {
            Assert.AreEqual("MCCXLIX", Converter.Convert(1249));
        }
        [TestMethod]
        public void Convert_1250_Returns_MCCL()
        {
            Assert.AreEqual("MCCL", Converter.Convert(1250));
        }
        [TestMethod]
        public void Convert_1251_Returns_MCCLI()
        {
            Assert.AreEqual("MCCLI", Converter.Convert(1251));
        }
        [TestMethod]
        public void Convert_1252_Returns_MCCLII()
        {
            Assert.AreEqual("MCCLII", Converter.Convert(1252));
        }
        [TestMethod]
        public void Convert_1253_Returns_MCCLIII()
        {
            Assert.AreEqual("MCCLIII", Converter.Convert(1253));
        }
        [TestMethod]
        public void Convert_1254_Returns_MCCLIV()
        {
            Assert.AreEqual("MCCLIV", Converter.Convert(1254));
        }
        [TestMethod]
        public void Convert_1255_Returns_MCCLV()
        {
            Assert.AreEqual("MCCLV", Converter.Convert(1255));
        }
        [TestMethod]
        public void Convert_1256_Returns_MCCLVI()
        {
            Assert.AreEqual("MCCLVI", Converter.Convert(1256));
        }
        [TestMethod]
        public void Convert_1257_Returns_MCCLVII()
        {
            Assert.AreEqual("MCCLVII", Converter.Convert(1257));
        }
        [TestMethod]
        public void Convert_1258_Returns_MCCLVIII()
        {
            Assert.AreEqual("MCCLVIII", Converter.Convert(1258));
        }
        [TestMethod]
        public void Convert_1259_Returns_MCCLIX()
        {
            Assert.AreEqual("MCCLIX", Converter.Convert(1259));
        }
        [TestMethod]
        public void Convert_1260_Returns_MCCLX()
        {
            Assert.AreEqual("MCCLX", Converter.Convert(1260));
        }
        [TestMethod]
        public void Convert_1261_Returns_MCCLXI()
        {
            Assert.AreEqual("MCCLXI", Converter.Convert(1261));
        }
        [TestMethod]
        public void Convert_1262_Returns_MCCLXII()
        {
            Assert.AreEqual("MCCLXII", Converter.Convert(1262));
        }
        [TestMethod]
        public void Convert_1263_Returns_MCCLXIII()
        {
            Assert.AreEqual("MCCLXIII", Converter.Convert(1263));
        }
        [TestMethod]
        public void Convert_1264_Returns_MCCLXIV()
        {
            Assert.AreEqual("MCCLXIV", Converter.Convert(1264));
        }
        [TestMethod]
        public void Convert_1265_Returns_MCCLXV()
        {
            Assert.AreEqual("MCCLXV", Converter.Convert(1265));
        }
        [TestMethod]
        public void Convert_1266_Returns_MCCLXVI()
        {
            Assert.AreEqual("MCCLXVI", Converter.Convert(1266));
        }
        [TestMethod]
        public void Convert_1267_Returns_MCCLXVII()
        {
            Assert.AreEqual("MCCLXVII", Converter.Convert(1267));
        }
        [TestMethod]
        public void Convert_1268_Returns_MCCLXVIII()
        {
            Assert.AreEqual("MCCLXVIII", Converter.Convert(1268));
        }
        [TestMethod]
        public void Convert_1269_Returns_MCCLXIX()
        {
            Assert.AreEqual("MCCLXIX", Converter.Convert(1269));
        }
        [TestMethod]
        public void Convert_1270_Returns_MCCLXX()
        {
            Assert.AreEqual("MCCLXX", Converter.Convert(1270));
        }
        [TestMethod]
        public void Convert_1271_Returns_MCCLXXI()
        {
            Assert.AreEqual("MCCLXXI", Converter.Convert(1271));
        }
        [TestMethod]
        public void Convert_1272_Returns_MCCLXXII()
        {
            Assert.AreEqual("MCCLXXII", Converter.Convert(1272));
        }
        [TestMethod]
        public void Convert_1273_Returns_MCCLXXIII()
        {
            Assert.AreEqual("MCCLXXIII", Converter.Convert(1273));
        }
        [TestMethod]
        public void Convert_1274_Returns_MCCLXXIV()
        {
            Assert.AreEqual("MCCLXXIV", Converter.Convert(1274));
        }
        [TestMethod]
        public void Convert_1275_Returns_MCCLXXV()
        {
            Assert.AreEqual("MCCLXXV", Converter.Convert(1275));
        }
        [TestMethod]
        public void Convert_1276_Returns_MCCLXXVI()
        {
            Assert.AreEqual("MCCLXXVI", Converter.Convert(1276));
        }
        [TestMethod]
        public void Convert_1277_Returns_MCCLXXVII()
        {
            Assert.AreEqual("MCCLXXVII", Converter.Convert(1277));
        }
        [TestMethod]
        public void Convert_1278_Returns_MCCLXXVIII()
        {
            Assert.AreEqual("MCCLXXVIII", Converter.Convert(1278));
        }
        [TestMethod]
        public void Convert_1279_Returns_MCCLXXIX()
        {
            Assert.AreEqual("MCCLXXIX", Converter.Convert(1279));
        }
        [TestMethod]
        public void Convert_1280_Returns_MCCLXXX()
        {
            Assert.AreEqual("MCCLXXX", Converter.Convert(1280));
        }
        [TestMethod]
        public void Convert_1281_Returns_MCCLXXXI()
        {
            Assert.AreEqual("MCCLXXXI", Converter.Convert(1281));
        }
        [TestMethod]
        public void Convert_1282_Returns_MCCLXXXII()
        {
            Assert.AreEqual("MCCLXXXII", Converter.Convert(1282));
        }
        [TestMethod]
        public void Convert_1283_Returns_MCCLXXXIII()
        {
            Assert.AreEqual("MCCLXXXIII", Converter.Convert(1283));
        }
        [TestMethod]
        public void Convert_1284_Returns_MCCLXXXIV()
        {
            Assert.AreEqual("MCCLXXXIV", Converter.Convert(1284));
        }
        [TestMethod]
        public void Convert_1285_Returns_MCCLXXXV()
        {
            Assert.AreEqual("MCCLXXXV", Converter.Convert(1285));
        }
        [TestMethod]
        public void Convert_1286_Returns_MCCLXXXVI()
        {
            Assert.AreEqual("MCCLXXXVI", Converter.Convert(1286));
        }
        [TestMethod]
        public void Convert_1287_Returns_MCCLXXXVII()
        {
            Assert.AreEqual("MCCLXXXVII", Converter.Convert(1287));
        }
        [TestMethod]
        public void Convert_1288_Returns_MCCLXXXVIII()
        {
            Assert.AreEqual("MCCLXXXVIII", Converter.Convert(1288));
        }
        [TestMethod]
        public void Convert_1289_Returns_MCCLXXXIX()
        {
            Assert.AreEqual("MCCLXXXIX", Converter.Convert(1289));
        }
        [TestMethod]
        public void Convert_1290_Returns_MCCXC()
        {
            Assert.AreEqual("MCCXC", Converter.Convert(1290));
        }
        [TestMethod]
        public void Convert_1291_Returns_MCCXCI()
        {
            Assert.AreEqual("MCCXCI", Converter.Convert(1291));
        }
        [TestMethod]
        public void Convert_1292_Returns_MCCXCII()
        {
            Assert.AreEqual("MCCXCII", Converter.Convert(1292));
        }
        [TestMethod]
        public void Convert_1293_Returns_MCCXCIII()
        {
            Assert.AreEqual("MCCXCIII", Converter.Convert(1293));
        }
        [TestMethod]
        public void Convert_1294_Returns_MCCXCIV()
        {
            Assert.AreEqual("MCCXCIV", Converter.Convert(1294));
        }
        [TestMethod]
        public void Convert_1295_Returns_MCCXCV()
        {
            Assert.AreEqual("MCCXCV", Converter.Convert(1295));
        }
        [TestMethod]
        public void Convert_1296_Returns_MCCXCVI()
        {
            Assert.AreEqual("MCCXCVI", Converter.Convert(1296));
        }
        [TestMethod]
        public void Convert_1297_Returns_MCCXCVII()
        {
            Assert.AreEqual("MCCXCVII", Converter.Convert(1297));
        }
        [TestMethod]
        public void Convert_1298_Returns_MCCXCVIII()
        {
            Assert.AreEqual("MCCXCVIII", Converter.Convert(1298));
        }
        [TestMethod]
        public void Convert_1299_Returns_MCCXCIX()
        {
            Assert.AreEqual("MCCXCIX", Converter.Convert(1299));
        }
        [TestMethod]
        public void Convert_1300_Returns_MCCC()
        {
            Assert.AreEqual("MCCC", Converter.Convert(1300));
        }
        [TestMethod]
        public void Convert_1301_Returns_MCCCI()
        {
            Assert.AreEqual("MCCCI", Converter.Convert(1301));
        }
        [TestMethod]
        public void Convert_1302_Returns_MCCCII()
        {
            Assert.AreEqual("MCCCII", Converter.Convert(1302));
        }
        [TestMethod]
        public void Convert_1303_Returns_MCCCIII()
        {
            Assert.AreEqual("MCCCIII", Converter.Convert(1303));
        }
        [TestMethod]
        public void Convert_1304_Returns_MCCCIV()
        {
            Assert.AreEqual("MCCCIV", Converter.Convert(1304));
        }
        [TestMethod]
        public void Convert_1305_Returns_MCCCV()
        {
            Assert.AreEqual("MCCCV", Converter.Convert(1305));
        }
        [TestMethod]
        public void Convert_1306_Returns_MCCCVI()
        {
            Assert.AreEqual("MCCCVI", Converter.Convert(1306));
        }
        [TestMethod]
        public void Convert_1307_Returns_MCCCVII()
        {
            Assert.AreEqual("MCCCVII", Converter.Convert(1307));
        }
        [TestMethod]
        public void Convert_1308_Returns_MCCCVIII()
        {
            Assert.AreEqual("MCCCVIII", Converter.Convert(1308));
        }
        [TestMethod]
        public void Convert_1309_Returns_MCCCIX()
        {
            Assert.AreEqual("MCCCIX", Converter.Convert(1309));
        }
        [TestMethod]
        public void Convert_1310_Returns_MCCCX()
        {
            Assert.AreEqual("MCCCX", Converter.Convert(1310));
        }
        [TestMethod]
        public void Convert_1311_Returns_MCCCXI()
        {
            Assert.AreEqual("MCCCXI", Converter.Convert(1311));
        }
        [TestMethod]
        public void Convert_1312_Returns_MCCCXII()
        {
            Assert.AreEqual("MCCCXII", Converter.Convert(1312));
        }
        [TestMethod]
        public void Convert_1313_Returns_MCCCXIII()
        {
            Assert.AreEqual("MCCCXIII", Converter.Convert(1313));
        }
        [TestMethod]
        public void Convert_1314_Returns_MCCCXIV()
        {
            Assert.AreEqual("MCCCXIV", Converter.Convert(1314));
        }
        [TestMethod]
        public void Convert_1315_Returns_MCCCXV()
        {
            Assert.AreEqual("MCCCXV", Converter.Convert(1315));
        }
        [TestMethod]
        public void Convert_1316_Returns_MCCCXVI()
        {
            Assert.AreEqual("MCCCXVI", Converter.Convert(1316));
        }
        [TestMethod]
        public void Convert_1317_Returns_MCCCXVII()
        {
            Assert.AreEqual("MCCCXVII", Converter.Convert(1317));
        }
        [TestMethod]
        public void Convert_1318_Returns_MCCCXVIII()
        {
            Assert.AreEqual("MCCCXVIII", Converter.Convert(1318));
        }
        [TestMethod]
        public void Convert_1319_Returns_MCCCXIX()
        {
            Assert.AreEqual("MCCCXIX", Converter.Convert(1319));
        }
        [TestMethod]
        public void Convert_1320_Returns_MCCCXX()
        {
            Assert.AreEqual("MCCCXX", Converter.Convert(1320));
        }
        [TestMethod]
        public void Convert_1321_Returns_MCCCXXI()
        {
            Assert.AreEqual("MCCCXXI", Converter.Convert(1321));
        }
        [TestMethod]
        public void Convert_1322_Returns_MCCCXXII()
        {
            Assert.AreEqual("MCCCXXII", Converter.Convert(1322));
        }
        [TestMethod]
        public void Convert_1323_Returns_MCCCXXIII()
        {
            Assert.AreEqual("MCCCXXIII", Converter.Convert(1323));
        }
        [TestMethod]
        public void Convert_1324_Returns_MCCCXXIV()
        {
            Assert.AreEqual("MCCCXXIV", Converter.Convert(1324));
        }
        [TestMethod]
        public void Convert_1325_Returns_MCCCXXV()
        {
            Assert.AreEqual("MCCCXXV", Converter.Convert(1325));
        }
        [TestMethod]
        public void Convert_1326_Returns_MCCCXXVI()
        {
            Assert.AreEqual("MCCCXXVI", Converter.Convert(1326));
        }
        [TestMethod]
        public void Convert_1327_Returns_MCCCXXVII()
        {
            Assert.AreEqual("MCCCXXVII", Converter.Convert(1327));
        }
        [TestMethod]
        public void Convert_1328_Returns_MCCCXXVIII()
        {
            Assert.AreEqual("MCCCXXVIII", Converter.Convert(1328));
        }
        [TestMethod]
        public void Convert_1329_Returns_MCCCXXIX()
        {
            Assert.AreEqual("MCCCXXIX", Converter.Convert(1329));
        }
        [TestMethod]
        public void Convert_1330_Returns_MCCCXXX()
        {
            Assert.AreEqual("MCCCXXX", Converter.Convert(1330));
        }
        [TestMethod]
        public void Convert_1331_Returns_MCCCXXXI()
        {
            Assert.AreEqual("MCCCXXXI", Converter.Convert(1331));
        }
        [TestMethod]
        public void Convert_1332_Returns_MCCCXXXII()
        {
            Assert.AreEqual("MCCCXXXII", Converter.Convert(1332));
        }
        [TestMethod]
        public void Convert_1333_Returns_MCCCXXXIII()
        {
            Assert.AreEqual("MCCCXXXIII", Converter.Convert(1333));
        }
        [TestMethod]
        public void Convert_1334_Returns_MCCCXXXIV()
        {
            Assert.AreEqual("MCCCXXXIV", Converter.Convert(1334));
        }
        [TestMethod]
        public void Convert_1335_Returns_MCCCXXXV()
        {
            Assert.AreEqual("MCCCXXXV", Converter.Convert(1335));
        }
        [TestMethod]
        public void Convert_1336_Returns_MCCCXXXVI()
        {
            Assert.AreEqual("MCCCXXXVI", Converter.Convert(1336));
        }
        [TestMethod]
        public void Convert_1337_Returns_MCCCXXXVII()
        {
            Assert.AreEqual("MCCCXXXVII", Converter.Convert(1337));
        }
        [TestMethod]
        public void Convert_1338_Returns_MCCCXXXVIII()
        {
            Assert.AreEqual("MCCCXXXVIII", Converter.Convert(1338));
        }
        [TestMethod]
        public void Convert_1339_Returns_MCCCXXXIX()
        {
            Assert.AreEqual("MCCCXXXIX", Converter.Convert(1339));
        }
        [TestMethod]
        public void Convert_1340_Returns_MCCCXL()
        {
            Assert.AreEqual("MCCCXL", Converter.Convert(1340));
        }
        [TestMethod]
        public void Convert_1341_Returns_MCCCXLI()
        {
            Assert.AreEqual("MCCCXLI", Converter.Convert(1341));
        }
        [TestMethod]
        public void Convert_1342_Returns_MCCCXLII()
        {
            Assert.AreEqual("MCCCXLII", Converter.Convert(1342));
        }
        [TestMethod]
        public void Convert_1343_Returns_MCCCXLIII()
        {
            Assert.AreEqual("MCCCXLIII", Converter.Convert(1343));
        }
        [TestMethod]
        public void Convert_1344_Returns_MCCCXLIV()
        {
            Assert.AreEqual("MCCCXLIV", Converter.Convert(1344));
        }
        [TestMethod]
        public void Convert_1345_Returns_MCCCXLV()
        {
            Assert.AreEqual("MCCCXLV", Converter.Convert(1345));
        }
        [TestMethod]
        public void Convert_1346_Returns_MCCCXLVI()
        {
            Assert.AreEqual("MCCCXLVI", Converter.Convert(1346));
        }
        [TestMethod]
        public void Convert_1347_Returns_MCCCXLVII()
        {
            Assert.AreEqual("MCCCXLVII", Converter.Convert(1347));
        }
        [TestMethod]
        public void Convert_1348_Returns_MCCCXLVIII()
        {
            Assert.AreEqual("MCCCXLVIII", Converter.Convert(1348));
        }
        [TestMethod]
        public void Convert_1349_Returns_MCCCXLIX()
        {
            Assert.AreEqual("MCCCXLIX", Converter.Convert(1349));
        }
        [TestMethod]
        public void Convert_1350_Returns_MCCCL()
        {
            Assert.AreEqual("MCCCL", Converter.Convert(1350));
        }
        [TestMethod]
        public void Convert_1351_Returns_MCCCLI()
        {
            Assert.AreEqual("MCCCLI", Converter.Convert(1351));
        }
        [TestMethod]
        public void Convert_1352_Returns_MCCCLII()
        {
            Assert.AreEqual("MCCCLII", Converter.Convert(1352));
        }
        [TestMethod]
        public void Convert_1353_Returns_MCCCLIII()
        {
            Assert.AreEqual("MCCCLIII", Converter.Convert(1353));
        }
        [TestMethod]
        public void Convert_1354_Returns_MCCCLIV()
        {
            Assert.AreEqual("MCCCLIV", Converter.Convert(1354));
        }
        [TestMethod]
        public void Convert_1355_Returns_MCCCLV()
        {
            Assert.AreEqual("MCCCLV", Converter.Convert(1355));
        }
        [TestMethod]
        public void Convert_1356_Returns_MCCCLVI()
        {
            Assert.AreEqual("MCCCLVI", Converter.Convert(1356));
        }
        [TestMethod]
        public void Convert_1357_Returns_MCCCLVII()
        {
            Assert.AreEqual("MCCCLVII", Converter.Convert(1357));
        }
        [TestMethod]
        public void Convert_1358_Returns_MCCCLVIII()
        {
            Assert.AreEqual("MCCCLVIII", Converter.Convert(1358));
        }
        [TestMethod]
        public void Convert_1359_Returns_MCCCLIX()
        {
            Assert.AreEqual("MCCCLIX", Converter.Convert(1359));
        }
        [TestMethod]
        public void Convert_1360_Returns_MCCCLX()
        {
            Assert.AreEqual("MCCCLX", Converter.Convert(1360));
        }
        [TestMethod]
        public void Convert_1361_Returns_MCCCLXI()
        {
            Assert.AreEqual("MCCCLXI", Converter.Convert(1361));
        }
        [TestMethod]
        public void Convert_1362_Returns_MCCCLXII()
        {
            Assert.AreEqual("MCCCLXII", Converter.Convert(1362));
        }
        [TestMethod]
        public void Convert_1363_Returns_MCCCLXIII()
        {
            Assert.AreEqual("MCCCLXIII", Converter.Convert(1363));
        }
        [TestMethod]
        public void Convert_1364_Returns_MCCCLXIV()
        {
            Assert.AreEqual("MCCCLXIV", Converter.Convert(1364));
        }
        [TestMethod]
        public void Convert_1365_Returns_MCCCLXV()
        {
            Assert.AreEqual("MCCCLXV", Converter.Convert(1365));
        }
        [TestMethod]
        public void Convert_1366_Returns_MCCCLXVI()
        {
            Assert.AreEqual("MCCCLXVI", Converter.Convert(1366));
        }
        [TestMethod]
        public void Convert_1367_Returns_MCCCLXVII()
        {
            Assert.AreEqual("MCCCLXVII", Converter.Convert(1367));
        }
        [TestMethod]
        public void Convert_1368_Returns_MCCCLXVIII()
        {
            Assert.AreEqual("MCCCLXVIII", Converter.Convert(1368));
        }
        [TestMethod]
        public void Convert_1369_Returns_MCCCLXIX()
        {
            Assert.AreEqual("MCCCLXIX", Converter.Convert(1369));
        }
        [TestMethod]
        public void Convert_1370_Returns_MCCCLXX()
        {
            Assert.AreEqual("MCCCLXX", Converter.Convert(1370));
        }
        [TestMethod]
        public void Convert_1371_Returns_MCCCLXXI()
        {
            Assert.AreEqual("MCCCLXXI", Converter.Convert(1371));
        }
        [TestMethod]
        public void Convert_1372_Returns_MCCCLXXII()
        {
            Assert.AreEqual("MCCCLXXII", Converter.Convert(1372));
        }
        [TestMethod]
        public void Convert_1373_Returns_MCCCLXXIII()
        {
            Assert.AreEqual("MCCCLXXIII", Converter.Convert(1373));
        }
        [TestMethod]
        public void Convert_1374_Returns_MCCCLXXIV()
        {
            Assert.AreEqual("MCCCLXXIV", Converter.Convert(1374));
        }
        [TestMethod]
        public void Convert_1375_Returns_MCCCLXXV()
        {
            Assert.AreEqual("MCCCLXXV", Converter.Convert(1375));
        }
        [TestMethod]
        public void Convert_1376_Returns_MCCCLXXVI()
        {
            Assert.AreEqual("MCCCLXXVI", Converter.Convert(1376));
        }
        [TestMethod]
        public void Convert_1377_Returns_MCCCLXXVII()
        {
            Assert.AreEqual("MCCCLXXVII", Converter.Convert(1377));
        }
        [TestMethod]
        public void Convert_1378_Returns_MCCCLXXVIII()
        {
            Assert.AreEqual("MCCCLXXVIII", Converter.Convert(1378));
        }
        [TestMethod]
        public void Convert_1379_Returns_MCCCLXXIX()
        {
            Assert.AreEqual("MCCCLXXIX", Converter.Convert(1379));
        }
        [TestMethod]
        public void Convert_1380_Returns_MCCCLXXX()
        {
            Assert.AreEqual("MCCCLXXX", Converter.Convert(1380));
        }
        [TestMethod]
        public void Convert_1381_Returns_MCCCLXXXI()
        {
            Assert.AreEqual("MCCCLXXXI", Converter.Convert(1381));
        }
        [TestMethod]
        public void Convert_1382_Returns_MCCCLXXXII()
        {
            Assert.AreEqual("MCCCLXXXII", Converter.Convert(1382));
        }
        [TestMethod]
        public void Convert_1383_Returns_MCCCLXXXIII()
        {
            Assert.AreEqual("MCCCLXXXIII", Converter.Convert(1383));
        }
        [TestMethod]
        public void Convert_1384_Returns_MCCCLXXXIV()
        {
            Assert.AreEqual("MCCCLXXXIV", Converter.Convert(1384));
        }
        [TestMethod]
        public void Convert_1385_Returns_MCCCLXXXV()
        {
            Assert.AreEqual("MCCCLXXXV", Converter.Convert(1385));
        }
        [TestMethod]
        public void Convert_1386_Returns_MCCCLXXXVI()
        {
            Assert.AreEqual("MCCCLXXXVI", Converter.Convert(1386));
        }
        [TestMethod]
        public void Convert_1387_Returns_MCCCLXXXVII()
        {
            Assert.AreEqual("MCCCLXXXVII", Converter.Convert(1387));
        }
        [TestMethod]
        public void Convert_1388_Returns_MCCCLXXXVIII()
        {
            Assert.AreEqual("MCCCLXXXVIII", Converter.Convert(1388));
        }
        [TestMethod]
        public void Convert_1389_Returns_MCCCLXXXIX()
        {
            Assert.AreEqual("MCCCLXXXIX", Converter.Convert(1389));
        }
        [TestMethod]
        public void Convert_1390_Returns_MCCCXC()
        {
            Assert.AreEqual("MCCCXC", Converter.Convert(1390));
        }
        [TestMethod]
        public void Convert_1391_Returns_MCCCXCI()
        {
            Assert.AreEqual("MCCCXCI", Converter.Convert(1391));
        }
        [TestMethod]
        public void Convert_1392_Returns_MCCCXCII()
        {
            Assert.AreEqual("MCCCXCII", Converter.Convert(1392));
        }
        [TestMethod]
        public void Convert_1393_Returns_MCCCXCIII()
        {
            Assert.AreEqual("MCCCXCIII", Converter.Convert(1393));
        }
        [TestMethod]
        public void Convert_1394_Returns_MCCCXCIV()
        {
            Assert.AreEqual("MCCCXCIV", Converter.Convert(1394));
        }
        [TestMethod]
        public void Convert_1395_Returns_MCCCXCV()
        {
            Assert.AreEqual("MCCCXCV", Converter.Convert(1395));
        }
        [TestMethod]
        public void Convert_1396_Returns_MCCCXCVI()
        {
            Assert.AreEqual("MCCCXCVI", Converter.Convert(1396));
        }
        [TestMethod]
        public void Convert_1397_Returns_MCCCXCVII()
        {
            Assert.AreEqual("MCCCXCVII", Converter.Convert(1397));
        }
        [TestMethod]
        public void Convert_1398_Returns_MCCCXCVIII()
        {
            Assert.AreEqual("MCCCXCVIII", Converter.Convert(1398));
        }
        [TestMethod]
        public void Convert_1399_Returns_MCCCXCIX()
        {
            Assert.AreEqual("MCCCXCIX", Converter.Convert(1399));
        }
        [TestMethod]
        public void Convert_1400_Returns_MCD()
        {
            Assert.AreEqual("MCD", Converter.Convert(1400));
        }
        [TestMethod]
        public void Convert_1401_Returns_MCDI()
        {
            Assert.AreEqual("MCDI", Converter.Convert(1401));
        }
        [TestMethod]
        public void Convert_1402_Returns_MCDII()
        {
            Assert.AreEqual("MCDII", Converter.Convert(1402));
        }
        [TestMethod]
        public void Convert_1403_Returns_MCDIII()
        {
            Assert.AreEqual("MCDIII", Converter.Convert(1403));
        }
        [TestMethod]
        public void Convert_1404_Returns_MCDIV()
        {
            Assert.AreEqual("MCDIV", Converter.Convert(1404));
        }
        [TestMethod]
        public void Convert_1405_Returns_MCDV()
        {
            Assert.AreEqual("MCDV", Converter.Convert(1405));
        }
        [TestMethod]
        public void Convert_1406_Returns_MCDVI()
        {
            Assert.AreEqual("MCDVI", Converter.Convert(1406));
        }
        [TestMethod]
        public void Convert_1407_Returns_MCDVII()
        {
            Assert.AreEqual("MCDVII", Converter.Convert(1407));
        }
        [TestMethod]
        public void Convert_1408_Returns_MCDVIII()
        {
            Assert.AreEqual("MCDVIII", Converter.Convert(1408));
        }
        [TestMethod]
        public void Convert_1409_Returns_MCDIX()
        {
            Assert.AreEqual("MCDIX", Converter.Convert(1409));
        }
        [TestMethod]
        public void Convert_1410_Returns_MCDX()
        {
            Assert.AreEqual("MCDX", Converter.Convert(1410));
        }
        [TestMethod]
        public void Convert_1411_Returns_MCDXI()
        {
            Assert.AreEqual("MCDXI", Converter.Convert(1411));
        }
        [TestMethod]
        public void Convert_1412_Returns_MCDXII()
        {
            Assert.AreEqual("MCDXII", Converter.Convert(1412));
        }
        [TestMethod]
        public void Convert_1413_Returns_MCDXIII()
        {
            Assert.AreEqual("MCDXIII", Converter.Convert(1413));
        }
        [TestMethod]
        public void Convert_1414_Returns_MCDXIV()
        {
            Assert.AreEqual("MCDXIV", Converter.Convert(1414));
        }
        [TestMethod]
        public void Convert_1415_Returns_MCDXV()
        {
            Assert.AreEqual("MCDXV", Converter.Convert(1415));
        }
        [TestMethod]
        public void Convert_1416_Returns_MCDXVI()
        {
            Assert.AreEqual("MCDXVI", Converter.Convert(1416));
        }
        [TestMethod]
        public void Convert_1417_Returns_MCDXVII()
        {
            Assert.AreEqual("MCDXVII", Converter.Convert(1417));
        }
        [TestMethod]
        public void Convert_1418_Returns_MCDXVIII()
        {
            Assert.AreEqual("MCDXVIII", Converter.Convert(1418));
        }
        [TestMethod]
        public void Convert_1419_Returns_MCDXIX()
        {
            Assert.AreEqual("MCDXIX", Converter.Convert(1419));
        }
        [TestMethod]
        public void Convert_1420_Returns_MCDXX()
        {
            Assert.AreEqual("MCDXX", Converter.Convert(1420));
        }
        [TestMethod]
        public void Convert_1421_Returns_MCDXXI()
        {
            Assert.AreEqual("MCDXXI", Converter.Convert(1421));
        }
        [TestMethod]
        public void Convert_1422_Returns_MCDXXII()
        {
            Assert.AreEqual("MCDXXII", Converter.Convert(1422));
        }
        [TestMethod]
        public void Convert_1423_Returns_MCDXXIII()
        {
            Assert.AreEqual("MCDXXIII", Converter.Convert(1423));
        }
        [TestMethod]
        public void Convert_1424_Returns_MCDXXIV()
        {
            Assert.AreEqual("MCDXXIV", Converter.Convert(1424));
        }
        [TestMethod]
        public void Convert_1425_Returns_MCDXXV()
        {
            Assert.AreEqual("MCDXXV", Converter.Convert(1425));
        }
        [TestMethod]
        public void Convert_1426_Returns_MCDXXVI()
        {
            Assert.AreEqual("MCDXXVI", Converter.Convert(1426));
        }
        [TestMethod]
        public void Convert_1427_Returns_MCDXXVII()
        {
            Assert.AreEqual("MCDXXVII", Converter.Convert(1427));
        }
        [TestMethod]
        public void Convert_1428_Returns_MCDXXVIII()
        {
            Assert.AreEqual("MCDXXVIII", Converter.Convert(1428));
        }
        [TestMethod]
        public void Convert_1429_Returns_MCDXXIX()
        {
            Assert.AreEqual("MCDXXIX", Converter.Convert(1429));
        }
        [TestMethod]
        public void Convert_1430_Returns_MCDXXX()
        {
            Assert.AreEqual("MCDXXX", Converter.Convert(1430));
        }
        [TestMethod]
        public void Convert_1431_Returns_MCDXXXI()
        {
            Assert.AreEqual("MCDXXXI", Converter.Convert(1431));
        }
        [TestMethod]
        public void Convert_1432_Returns_MCDXXXII()
        {
            Assert.AreEqual("MCDXXXII", Converter.Convert(1432));
        }
        [TestMethod]
        public void Convert_1433_Returns_MCDXXXIII()
        {
            Assert.AreEqual("MCDXXXIII", Converter.Convert(1433));
        }
        [TestMethod]
        public void Convert_1434_Returns_MCDXXXIV()
        {
            Assert.AreEqual("MCDXXXIV", Converter.Convert(1434));
        }
        [TestMethod]
        public void Convert_1435_Returns_MCDXXXV()
        {
            Assert.AreEqual("MCDXXXV", Converter.Convert(1435));
        }
        [TestMethod]
        public void Convert_1436_Returns_MCDXXXVI()
        {
            Assert.AreEqual("MCDXXXVI", Converter.Convert(1436));
        }
        [TestMethod]
        public void Convert_1437_Returns_MCDXXXVII()
        {
            Assert.AreEqual("MCDXXXVII", Converter.Convert(1437));
        }
        [TestMethod]
        public void Convert_1438_Returns_MCDXXXVIII()
        {
            Assert.AreEqual("MCDXXXVIII", Converter.Convert(1438));
        }
        [TestMethod]
        public void Convert_1439_Returns_MCDXXXIX()
        {
            Assert.AreEqual("MCDXXXIX", Converter.Convert(1439));
        }
        [TestMethod]
        public void Convert_1440_Returns_MCDXL()
        {
            Assert.AreEqual("MCDXL", Converter.Convert(1440));
        }
        [TestMethod]
        public void Convert_1441_Returns_MCDXLI()
        {
            Assert.AreEqual("MCDXLI", Converter.Convert(1441));
        }
        [TestMethod]
        public void Convert_1442_Returns_MCDXLII()
        {
            Assert.AreEqual("MCDXLII", Converter.Convert(1442));
        }
        [TestMethod]
        public void Convert_1443_Returns_MCDXLIII()
        {
            Assert.AreEqual("MCDXLIII", Converter.Convert(1443));
        }
        [TestMethod]
        public void Convert_1444_Returns_MCDXLIV()
        {
            Assert.AreEqual("MCDXLIV", Converter.Convert(1444));
        }
        [TestMethod]
        public void Convert_1445_Returns_MCDXLV()
        {
            Assert.AreEqual("MCDXLV", Converter.Convert(1445));
        }
        [TestMethod]
        public void Convert_1446_Returns_MCDXLVI()
        {
            Assert.AreEqual("MCDXLVI", Converter.Convert(1446));
        }
        [TestMethod]
        public void Convert_1447_Returns_MCDXLVII()
        {
            Assert.AreEqual("MCDXLVII", Converter.Convert(1447));
        }
        [TestMethod]
        public void Convert_1448_Returns_MCDXLVIII()
        {
            Assert.AreEqual("MCDXLVIII", Converter.Convert(1448));
        }
        [TestMethod]
        public void Convert_1449_Returns_MCDXLIX()
        {
            Assert.AreEqual("MCDXLIX", Converter.Convert(1449));
        }
        [TestMethod]
        public void Convert_1450_Returns_MCDL()
        {
            Assert.AreEqual("MCDL", Converter.Convert(1450));
        }
        [TestMethod]
        public void Convert_1451_Returns_MCDLI()
        {
            Assert.AreEqual("MCDLI", Converter.Convert(1451));
        }
        [TestMethod]
        public void Convert_1452_Returns_MCDLII()
        {
            Assert.AreEqual("MCDLII", Converter.Convert(1452));
        }
        [TestMethod]
        public void Convert_1453_Returns_MCDLIII()
        {
            Assert.AreEqual("MCDLIII", Converter.Convert(1453));
        }
        [TestMethod]
        public void Convert_1454_Returns_MCDLIV()
        {
            Assert.AreEqual("MCDLIV", Converter.Convert(1454));
        }
        [TestMethod]
        public void Convert_1455_Returns_MCDLV()
        {
            Assert.AreEqual("MCDLV", Converter.Convert(1455));
        }
        [TestMethod]
        public void Convert_1456_Returns_MCDLVI()
        {
            Assert.AreEqual("MCDLVI", Converter.Convert(1456));
        }
        [TestMethod]
        public void Convert_1457_Returns_MCDLVII()
        {
            Assert.AreEqual("MCDLVII", Converter.Convert(1457));
        }
        [TestMethod]
        public void Convert_1458_Returns_MCDLVIII()
        {
            Assert.AreEqual("MCDLVIII", Converter.Convert(1458));
        }
        [TestMethod]
        public void Convert_1459_Returns_MCDLIX()
        {
            Assert.AreEqual("MCDLIX", Converter.Convert(1459));
        }
        [TestMethod]
        public void Convert_1460_Returns_MCDLX()
        {
            Assert.AreEqual("MCDLX", Converter.Convert(1460));
        }
        [TestMethod]
        public void Convert_1461_Returns_MCDLXI()
        {
            Assert.AreEqual("MCDLXI", Converter.Convert(1461));
        }
        [TestMethod]
        public void Convert_1462_Returns_MCDLXII()
        {
            Assert.AreEqual("MCDLXII", Converter.Convert(1462));
        }
        [TestMethod]
        public void Convert_1463_Returns_MCDLXIII()
        {
            Assert.AreEqual("MCDLXIII", Converter.Convert(1463));
        }
        [TestMethod]
        public void Convert_1464_Returns_MCDLXIV()
        {
            Assert.AreEqual("MCDLXIV", Converter.Convert(1464));
        }
        [TestMethod]
        public void Convert_1465_Returns_MCDLXV()
        {
            Assert.AreEqual("MCDLXV", Converter.Convert(1465));
        }
        [TestMethod]
        public void Convert_1466_Returns_MCDLXVI()
        {
            Assert.AreEqual("MCDLXVI", Converter.Convert(1466));
        }
        [TestMethod]
        public void Convert_1467_Returns_MCDLXVII()
        {
            Assert.AreEqual("MCDLXVII", Converter.Convert(1467));
        }
        [TestMethod]
        public void Convert_1468_Returns_MCDLXVIII()
        {
            Assert.AreEqual("MCDLXVIII", Converter.Convert(1468));
        }
        [TestMethod]
        public void Convert_1469_Returns_MCDLXIX()
        {
            Assert.AreEqual("MCDLXIX", Converter.Convert(1469));
        }
        [TestMethod]
        public void Convert_1470_Returns_MCDLXX()
        {
            Assert.AreEqual("MCDLXX", Converter.Convert(1470));
        }
        [TestMethod]
        public void Convert_1471_Returns_MCDLXXI()
        {
            Assert.AreEqual("MCDLXXI", Converter.Convert(1471));
        }
        [TestMethod]
        public void Convert_1472_Returns_MCDLXXII()
        {
            Assert.AreEqual("MCDLXXII", Converter.Convert(1472));
        }
        [TestMethod]
        public void Convert_1473_Returns_MCDLXXIII()
        {
            Assert.AreEqual("MCDLXXIII", Converter.Convert(1473));
        }
        [TestMethod]
        public void Convert_1474_Returns_MCDLXXIV()
        {
            Assert.AreEqual("MCDLXXIV", Converter.Convert(1474));
        }
        [TestMethod]
        public void Convert_1475_Returns_MCDLXXV()
        {
            Assert.AreEqual("MCDLXXV", Converter.Convert(1475));
        }
        [TestMethod]
        public void Convert_1476_Returns_MCDLXXVI()
        {
            Assert.AreEqual("MCDLXXVI", Converter.Convert(1476));
        }
        [TestMethod]
        public void Convert_1477_Returns_MCDLXXVII()
        {
            Assert.AreEqual("MCDLXXVII", Converter.Convert(1477));
        }
        [TestMethod]
        public void Convert_1478_Returns_MCDLXXVIII()
        {
            Assert.AreEqual("MCDLXXVIII", Converter.Convert(1478));
        }
        [TestMethod]
        public void Convert_1479_Returns_MCDLXXIX()
        {
            Assert.AreEqual("MCDLXXIX", Converter.Convert(1479));
        }
        [TestMethod]
        public void Convert_1480_Returns_MCDLXXX()
        {
            Assert.AreEqual("MCDLXXX", Converter.Convert(1480));
        }
        [TestMethod]
        public void Convert_1481_Returns_MCDLXXXI()
        {
            Assert.AreEqual("MCDLXXXI", Converter.Convert(1481));
        }
        [TestMethod]
        public void Convert_1482_Returns_MCDLXXXII()
        {
            Assert.AreEqual("MCDLXXXII", Converter.Convert(1482));
        }
        [TestMethod]
        public void Convert_1483_Returns_MCDLXXXIII()
        {
            Assert.AreEqual("MCDLXXXIII", Converter.Convert(1483));
        }
        [TestMethod]
        public void Convert_1484_Returns_MCDLXXXIV()
        {
            Assert.AreEqual("MCDLXXXIV", Converter.Convert(1484));
        }
        [TestMethod]
        public void Convert_1485_Returns_MCDLXXXV()
        {
            Assert.AreEqual("MCDLXXXV", Converter.Convert(1485));
        }
        [TestMethod]
        public void Convert_1486_Returns_MCDLXXXVI()
        {
            Assert.AreEqual("MCDLXXXVI", Converter.Convert(1486));
        }
        [TestMethod]
        public void Convert_1487_Returns_MCDLXXXVII()
        {
            Assert.AreEqual("MCDLXXXVII", Converter.Convert(1487));
        }
        [TestMethod]
        public void Convert_1488_Returns_MCDLXXXVIII()
        {
            Assert.AreEqual("MCDLXXXVIII", Converter.Convert(1488));
        }
        [TestMethod]
        public void Convert_1489_Returns_MCDLXXXIX()
        {
            Assert.AreEqual("MCDLXXXIX", Converter.Convert(1489));
        }
        [TestMethod]
        public void Convert_1490_Returns_MCDXC()
        {
            Assert.AreEqual("MCDXC", Converter.Convert(1490));
        }
        [TestMethod]
        public void Convert_1491_Returns_MCDXCI()
        {
            Assert.AreEqual("MCDXCI", Converter.Convert(1491));
        }
        [TestMethod]
        public void Convert_1492_Returns_MCDXCII()
        {
            Assert.AreEqual("MCDXCII", Converter.Convert(1492));
        }
        [TestMethod]
        public void Convert_1493_Returns_MCDXCIII()
        {
            Assert.AreEqual("MCDXCIII", Converter.Convert(1493));
        }
        [TestMethod]
        public void Convert_1494_Returns_MCDXCIV()
        {
            Assert.AreEqual("MCDXCIV", Converter.Convert(1494));
        }
        [TestMethod]
        public void Convert_1495_Returns_MCDXCV()
        {
            Assert.AreEqual("MCDXCV", Converter.Convert(1495));
        }
        [TestMethod]
        public void Convert_1496_Returns_MCDXCVI()
        {
            Assert.AreEqual("MCDXCVI", Converter.Convert(1496));
        }
        [TestMethod]
        public void Convert_1497_Returns_MCDXCVII()
        {
            Assert.AreEqual("MCDXCVII", Converter.Convert(1497));
        }
        [TestMethod]
        public void Convert_1498_Returns_MCDXCVIII()
        {
            Assert.AreEqual("MCDXCVIII", Converter.Convert(1498));
        }
        [TestMethod]
        public void Convert_1499_Returns_MCDXCIX()
        {
            Assert.AreEqual("MCDXCIX", Converter.Convert(1499));
        }
        [TestMethod]
        public void Convert_1500_Returns_MD()
        {
            Assert.AreEqual("MD", Converter.Convert(1500));
        }
        [TestMethod]
        public void Convert_1501_Returns_MDI()
        {
            Assert.AreEqual("MDI", Converter.Convert(1501));
        }
        [TestMethod]
        public void Convert_1502_Returns_MDII()
        {
            Assert.AreEqual("MDII", Converter.Convert(1502));
        }
        [TestMethod]
        public void Convert_1503_Returns_MDIII()
        {
            Assert.AreEqual("MDIII", Converter.Convert(1503));
        }
        [TestMethod]
        public void Convert_1504_Returns_MDIV()
        {
            Assert.AreEqual("MDIV", Converter.Convert(1504));
        }
        [TestMethod]
        public void Convert_1505_Returns_MDV()
        {
            Assert.AreEqual("MDV", Converter.Convert(1505));
        }
        [TestMethod]
        public void Convert_1506_Returns_MDVI()
        {
            Assert.AreEqual("MDVI", Converter.Convert(1506));
        }
        [TestMethod]
        public void Convert_1507_Returns_MDVII()
        {
            Assert.AreEqual("MDVII", Converter.Convert(1507));
        }
        [TestMethod]
        public void Convert_1508_Returns_MDVIII()
        {
            Assert.AreEqual("MDVIII", Converter.Convert(1508));
        }
        [TestMethod]
        public void Convert_1509_Returns_MDIX()
        {
            Assert.AreEqual("MDIX", Converter.Convert(1509));
        }
        [TestMethod]
        public void Convert_1510_Returns_MDX()
        {
            Assert.AreEqual("MDX", Converter.Convert(1510));
        }
        [TestMethod]
        public void Convert_1511_Returns_MDXI()
        {
            Assert.AreEqual("MDXI", Converter.Convert(1511));
        }
        [TestMethod]
        public void Convert_1512_Returns_MDXII()
        {
            Assert.AreEqual("MDXII", Converter.Convert(1512));
        }
        [TestMethod]
        public void Convert_1513_Returns_MDXIII()
        {
            Assert.AreEqual("MDXIII", Converter.Convert(1513));
        }
        [TestMethod]
        public void Convert_1514_Returns_MDXIV()
        {
            Assert.AreEqual("MDXIV", Converter.Convert(1514));
        }
        [TestMethod]
        public void Convert_1515_Returns_MDXV()
        {
            Assert.AreEqual("MDXV", Converter.Convert(1515));
        }
        [TestMethod]
        public void Convert_1516_Returns_MDXVI()
        {
            Assert.AreEqual("MDXVI", Converter.Convert(1516));
        }
        [TestMethod]
        public void Convert_1517_Returns_MDXVII()
        {
            Assert.AreEqual("MDXVII", Converter.Convert(1517));
        }
        [TestMethod]
        public void Convert_1518_Returns_MDXVIII()
        {
            Assert.AreEqual("MDXVIII", Converter.Convert(1518));
        }
        [TestMethod]
        public void Convert_1519_Returns_MDXIX()
        {
            Assert.AreEqual("MDXIX", Converter.Convert(1519));
        }
        [TestMethod]
        public void Convert_1520_Returns_MDXX()
        {
            Assert.AreEqual("MDXX", Converter.Convert(1520));
        }
        [TestMethod]
        public void Convert_1521_Returns_MDXXI()
        {
            Assert.AreEqual("MDXXI", Converter.Convert(1521));
        }
        [TestMethod]
        public void Convert_1522_Returns_MDXXII()
        {
            Assert.AreEqual("MDXXII", Converter.Convert(1522));
        }
        [TestMethod]
        public void Convert_1523_Returns_MDXXIII()
        {
            Assert.AreEqual("MDXXIII", Converter.Convert(1523));
        }
        [TestMethod]
        public void Convert_1524_Returns_MDXXIV()
        {
            Assert.AreEqual("MDXXIV", Converter.Convert(1524));
        }
        [TestMethod]
        public void Convert_1525_Returns_MDXXV()
        {
            Assert.AreEqual("MDXXV", Converter.Convert(1525));
        }
        [TestMethod]
        public void Convert_1526_Returns_MDXXVI()
        {
            Assert.AreEqual("MDXXVI", Converter.Convert(1526));
        }
        [TestMethod]
        public void Convert_1527_Returns_MDXXVII()
        {
            Assert.AreEqual("MDXXVII", Converter.Convert(1527));
        }
        [TestMethod]
        public void Convert_1528_Returns_MDXXVIII()
        {
            Assert.AreEqual("MDXXVIII", Converter.Convert(1528));
        }
        [TestMethod]
        public void Convert_1529_Returns_MDXXIX()
        {
            Assert.AreEqual("MDXXIX", Converter.Convert(1529));
        }
        [TestMethod]
        public void Convert_1530_Returns_MDXXX()
        {
            Assert.AreEqual("MDXXX", Converter.Convert(1530));
        }
        [TestMethod]
        public void Convert_1531_Returns_MDXXXI()
        {
            Assert.AreEqual("MDXXXI", Converter.Convert(1531));
        }
        [TestMethod]
        public void Convert_1532_Returns_MDXXXII()
        {
            Assert.AreEqual("MDXXXII", Converter.Convert(1532));
        }
        [TestMethod]
        public void Convert_1533_Returns_MDXXXIII()
        {
            Assert.AreEqual("MDXXXIII", Converter.Convert(1533));
        }
        [TestMethod]
        public void Convert_1534_Returns_MDXXXIV()
        {
            Assert.AreEqual("MDXXXIV", Converter.Convert(1534));
        }
        [TestMethod]
        public void Convert_1535_Returns_MDXXXV()
        {
            Assert.AreEqual("MDXXXV", Converter.Convert(1535));
        }
        [TestMethod]
        public void Convert_1536_Returns_MDXXXVI()
        {
            Assert.AreEqual("MDXXXVI", Converter.Convert(1536));
        }
        [TestMethod]
        public void Convert_1537_Returns_MDXXXVII()
        {
            Assert.AreEqual("MDXXXVII", Converter.Convert(1537));
        }
        [TestMethod]
        public void Convert_1538_Returns_MDXXXVIII()
        {
            Assert.AreEqual("MDXXXVIII", Converter.Convert(1538));
        }
        [TestMethod]
        public void Convert_1539_Returns_MDXXXIX()
        {
            Assert.AreEqual("MDXXXIX", Converter.Convert(1539));
        }
        [TestMethod]
        public void Convert_1540_Returns_MDXL()
        {
            Assert.AreEqual("MDXL", Converter.Convert(1540));
        }
        [TestMethod]
        public void Convert_1541_Returns_MDXLI()
        {
            Assert.AreEqual("MDXLI", Converter.Convert(1541));
        }
        [TestMethod]
        public void Convert_1542_Returns_MDXLII()
        {
            Assert.AreEqual("MDXLII", Converter.Convert(1542));
        }
        [TestMethod]
        public void Convert_1543_Returns_MDXLIII()
        {
            Assert.AreEqual("MDXLIII", Converter.Convert(1543));
        }
        [TestMethod]
        public void Convert_1544_Returns_MDXLIV()
        {
            Assert.AreEqual("MDXLIV", Converter.Convert(1544));
        }
        [TestMethod]
        public void Convert_1545_Returns_MDXLV()
        {
            Assert.AreEqual("MDXLV", Converter.Convert(1545));
        }
        [TestMethod]
        public void Convert_1546_Returns_MDXLVI()
        {
            Assert.AreEqual("MDXLVI", Converter.Convert(1546));
        }
        [TestMethod]
        public void Convert_1547_Returns_MDXLVII()
        {
            Assert.AreEqual("MDXLVII", Converter.Convert(1547));
        }
        [TestMethod]
        public void Convert_1548_Returns_MDXLVIII()
        {
            Assert.AreEqual("MDXLVIII", Converter.Convert(1548));
        }
        [TestMethod]
        public void Convert_1549_Returns_MDXLIX()
        {
            Assert.AreEqual("MDXLIX", Converter.Convert(1549));
        }
        [TestMethod]
        public void Convert_1550_Returns_MDL()
        {
            Assert.AreEqual("MDL", Converter.Convert(1550));
        }
        [TestMethod]
        public void Convert_1551_Returns_MDLI()
        {
            Assert.AreEqual("MDLI", Converter.Convert(1551));
        }
        [TestMethod]
        public void Convert_1552_Returns_MDLII()
        {
            Assert.AreEqual("MDLII", Converter.Convert(1552));
        }
        [TestMethod]
        public void Convert_1553_Returns_MDLIII()
        {
            Assert.AreEqual("MDLIII", Converter.Convert(1553));
        }
        [TestMethod]
        public void Convert_1554_Returns_MDLIV()
        {
            Assert.AreEqual("MDLIV", Converter.Convert(1554));
        }
        [TestMethod]
        public void Convert_1555_Returns_MDLV()
        {
            Assert.AreEqual("MDLV", Converter.Convert(1555));
        }
        [TestMethod]
        public void Convert_1556_Returns_MDLVI()
        {
            Assert.AreEqual("MDLVI", Converter.Convert(1556));
        }
        [TestMethod]
        public void Convert_1557_Returns_MDLVII()
        {
            Assert.AreEqual("MDLVII", Converter.Convert(1557));
        }
        [TestMethod]
        public void Convert_1558_Returns_MDLVIII()
        {
            Assert.AreEqual("MDLVIII", Converter.Convert(1558));
        }
        [TestMethod]
        public void Convert_1559_Returns_MDLIX()
        {
            Assert.AreEqual("MDLIX", Converter.Convert(1559));
        }
        [TestMethod]
        public void Convert_1560_Returns_MDLX()
        {
            Assert.AreEqual("MDLX", Converter.Convert(1560));
        }
        [TestMethod]
        public void Convert_1561_Returns_MDLXI()
        {
            Assert.AreEqual("MDLXI", Converter.Convert(1561));
        }
        [TestMethod]
        public void Convert_1562_Returns_MDLXII()
        {
            Assert.AreEqual("MDLXII", Converter.Convert(1562));
        }
        [TestMethod]
        public void Convert_1563_Returns_MDLXIII()
        {
            Assert.AreEqual("MDLXIII", Converter.Convert(1563));
        }
        [TestMethod]
        public void Convert_1564_Returns_MDLXIV()
        {
            Assert.AreEqual("MDLXIV", Converter.Convert(1564));
        }
        [TestMethod]
        public void Convert_1565_Returns_MDLXV()
        {
            Assert.AreEqual("MDLXV", Converter.Convert(1565));
        }
        [TestMethod]
        public void Convert_1566_Returns_MDLXVI()
        {
            Assert.AreEqual("MDLXVI", Converter.Convert(1566));
        }
        [TestMethod]
        public void Convert_1567_Returns_MDLXVII()
        {
            Assert.AreEqual("MDLXVII", Converter.Convert(1567));
        }
        [TestMethod]
        public void Convert_1568_Returns_MDLXVIII()
        {
            Assert.AreEqual("MDLXVIII", Converter.Convert(1568));
        }
        [TestMethod]
        public void Convert_1569_Returns_MDLXIX()
        {
            Assert.AreEqual("MDLXIX", Converter.Convert(1569));
        }
        [TestMethod]
        public void Convert_1570_Returns_MDLXX()
        {
            Assert.AreEqual("MDLXX", Converter.Convert(1570));
        }
        [TestMethod]
        public void Convert_1571_Returns_MDLXXI()
        {
            Assert.AreEqual("MDLXXI", Converter.Convert(1571));
        }
        [TestMethod]
        public void Convert_1572_Returns_MDLXXII()
        {
            Assert.AreEqual("MDLXXII", Converter.Convert(1572));
        }
        [TestMethod]
        public void Convert_1573_Returns_MDLXXIII()
        {
            Assert.AreEqual("MDLXXIII", Converter.Convert(1573));
        }
        [TestMethod]
        public void Convert_1574_Returns_MDLXXIV()
        {
            Assert.AreEqual("MDLXXIV", Converter.Convert(1574));
        }
        [TestMethod]
        public void Convert_1575_Returns_MDLXXV()
        {
            Assert.AreEqual("MDLXXV", Converter.Convert(1575));
        }
        [TestMethod]
        public void Convert_1576_Returns_MDLXXVI()
        {
            Assert.AreEqual("MDLXXVI", Converter.Convert(1576));
        }
        [TestMethod]
        public void Convert_1577_Returns_MDLXXVII()
        {
            Assert.AreEqual("MDLXXVII", Converter.Convert(1577));
        }
        [TestMethod]
        public void Convert_1578_Returns_MDLXXVIII()
        {
            Assert.AreEqual("MDLXXVIII", Converter.Convert(1578));
        }
        [TestMethod]
        public void Convert_1579_Returns_MDLXXIX()
        {
            Assert.AreEqual("MDLXXIX", Converter.Convert(1579));
        }
        [TestMethod]
        public void Convert_1580_Returns_MDLXXX()
        {
            Assert.AreEqual("MDLXXX", Converter.Convert(1580));
        }
        [TestMethod]
        public void Convert_1581_Returns_MDLXXXI()
        {
            Assert.AreEqual("MDLXXXI", Converter.Convert(1581));
        }
        [TestMethod]
        public void Convert_1582_Returns_MDLXXXII()
        {
            Assert.AreEqual("MDLXXXII", Converter.Convert(1582));
        }
        [TestMethod]
        public void Convert_1583_Returns_MDLXXXIII()
        {
            Assert.AreEqual("MDLXXXIII", Converter.Convert(1583));
        }
        [TestMethod]
        public void Convert_1584_Returns_MDLXXXIV()
        {
            Assert.AreEqual("MDLXXXIV", Converter.Convert(1584));
        }
        [TestMethod]
        public void Convert_1585_Returns_MDLXXXV()
        {
            Assert.AreEqual("MDLXXXV", Converter.Convert(1585));
        }
        [TestMethod]
        public void Convert_1586_Returns_MDLXXXVI()
        {
            Assert.AreEqual("MDLXXXVI", Converter.Convert(1586));
        }
        [TestMethod]
        public void Convert_1587_Returns_MDLXXXVII()
        {
            Assert.AreEqual("MDLXXXVII", Converter.Convert(1587));
        }
        [TestMethod]
        public void Convert_1588_Returns_MDLXXXVIII()
        {
            Assert.AreEqual("MDLXXXVIII", Converter.Convert(1588));
        }
        [TestMethod]
        public void Convert_1589_Returns_MDLXXXIX()
        {
            Assert.AreEqual("MDLXXXIX", Converter.Convert(1589));
        }
        [TestMethod]
        public void Convert_1590_Returns_MDXC()
        {
            Assert.AreEqual("MDXC", Converter.Convert(1590));
        }
        [TestMethod]
        public void Convert_1591_Returns_MDXCI()
        {
            Assert.AreEqual("MDXCI", Converter.Convert(1591));
        }
        [TestMethod]
        public void Convert_1592_Returns_MDXCII()
        {
            Assert.AreEqual("MDXCII", Converter.Convert(1592));
        }
        [TestMethod]
        public void Convert_1593_Returns_MDXCIII()
        {
            Assert.AreEqual("MDXCIII", Converter.Convert(1593));
        }
        [TestMethod]
        public void Convert_1594_Returns_MDXCIV()
        {
            Assert.AreEqual("MDXCIV", Converter.Convert(1594));
        }
        [TestMethod]
        public void Convert_1595_Returns_MDXCV()
        {
            Assert.AreEqual("MDXCV", Converter.Convert(1595));
        }
        [TestMethod]
        public void Convert_1596_Returns_MDXCVI()
        {
            Assert.AreEqual("MDXCVI", Converter.Convert(1596));
        }
        [TestMethod]
        public void Convert_1597_Returns_MDXCVII()
        {
            Assert.AreEqual("MDXCVII", Converter.Convert(1597));
        }
        [TestMethod]
        public void Convert_1598_Returns_MDXCVIII()
        {
            Assert.AreEqual("MDXCVIII", Converter.Convert(1598));
        }
        [TestMethod]
        public void Convert_1599_Returns_MDXCIX()
        {
            Assert.AreEqual("MDXCIX", Converter.Convert(1599));
        }
        [TestMethod]
        public void Convert_1600_Returns_MDC()
        {
            Assert.AreEqual("MDC", Converter.Convert(1600));
        }
        [TestMethod]
        public void Convert_1601_Returns_MDCI()
        {
            Assert.AreEqual("MDCI", Converter.Convert(1601));
        }
        [TestMethod]
        public void Convert_1602_Returns_MDCII()
        {
            Assert.AreEqual("MDCII", Converter.Convert(1602));
        }
        [TestMethod]
        public void Convert_1603_Returns_MDCIII()
        {
            Assert.AreEqual("MDCIII", Converter.Convert(1603));
        }
        [TestMethod]
        public void Convert_1604_Returns_MDCIV()
        {
            Assert.AreEqual("MDCIV", Converter.Convert(1604));
        }
        [TestMethod]
        public void Convert_1605_Returns_MDCV()
        {
            Assert.AreEqual("MDCV", Converter.Convert(1605));
        }
        [TestMethod]
        public void Convert_1606_Returns_MDCVI()
        {
            Assert.AreEqual("MDCVI", Converter.Convert(1606));
        }
        [TestMethod]
        public void Convert_1607_Returns_MDCVII()
        {
            Assert.AreEqual("MDCVII", Converter.Convert(1607));
        }
        [TestMethod]
        public void Convert_1608_Returns_MDCVIII()
        {
            Assert.AreEqual("MDCVIII", Converter.Convert(1608));
        }
        [TestMethod]
        public void Convert_1609_Returns_MDCIX()
        {
            Assert.AreEqual("MDCIX", Converter.Convert(1609));
        }
        [TestMethod]
        public void Convert_1610_Returns_MDCX()
        {
            Assert.AreEqual("MDCX", Converter.Convert(1610));
        }
        [TestMethod]
        public void Convert_1611_Returns_MDCXI()
        {
            Assert.AreEqual("MDCXI", Converter.Convert(1611));
        }
        [TestMethod]
        public void Convert_1612_Returns_MDCXII()
        {
            Assert.AreEqual("MDCXII", Converter.Convert(1612));
        }
        [TestMethod]
        public void Convert_1613_Returns_MDCXIII()
        {
            Assert.AreEqual("MDCXIII", Converter.Convert(1613));
        }
        [TestMethod]
        public void Convert_1614_Returns_MDCXIV()
        {
            Assert.AreEqual("MDCXIV", Converter.Convert(1614));
        }
        [TestMethod]
        public void Convert_1615_Returns_MDCXV()
        {
            Assert.AreEqual("MDCXV", Converter.Convert(1615));
        }
        [TestMethod]
        public void Convert_1616_Returns_MDCXVI()
        {
            Assert.AreEqual("MDCXVI", Converter.Convert(1616));
        }
        [TestMethod]
        public void Convert_1617_Returns_MDCXVII()
        {
            Assert.AreEqual("MDCXVII", Converter.Convert(1617));
        }
        [TestMethod]
        public void Convert_1618_Returns_MDCXVIII()
        {
            Assert.AreEqual("MDCXVIII", Converter.Convert(1618));
        }
        [TestMethod]
        public void Convert_1619_Returns_MDCXIX()
        {
            Assert.AreEqual("MDCXIX", Converter.Convert(1619));
        }
        [TestMethod]
        public void Convert_1620_Returns_MDCXX()
        {
            Assert.AreEqual("MDCXX", Converter.Convert(1620));
        }
        [TestMethod]
        public void Convert_1621_Returns_MDCXXI()
        {
            Assert.AreEqual("MDCXXI", Converter.Convert(1621));
        }
        [TestMethod]
        public void Convert_1622_Returns_MDCXXII()
        {
            Assert.AreEqual("MDCXXII", Converter.Convert(1622));
        }
        [TestMethod]
        public void Convert_1623_Returns_MDCXXIII()
        {
            Assert.AreEqual("MDCXXIII", Converter.Convert(1623));
        }
        [TestMethod]
        public void Convert_1624_Returns_MDCXXIV()
        {
            Assert.AreEqual("MDCXXIV", Converter.Convert(1624));
        }
        [TestMethod]
        public void Convert_1625_Returns_MDCXXV()
        {
            Assert.AreEqual("MDCXXV", Converter.Convert(1625));
        }
        [TestMethod]
        public void Convert_1626_Returns_MDCXXVI()
        {
            Assert.AreEqual("MDCXXVI", Converter.Convert(1626));
        }
        [TestMethod]
        public void Convert_1627_Returns_MDCXXVII()
        {
            Assert.AreEqual("MDCXXVII", Converter.Convert(1627));
        }
        [TestMethod]
        public void Convert_1628_Returns_MDCXXVIII()
        {
            Assert.AreEqual("MDCXXVIII", Converter.Convert(1628));
        }
        [TestMethod]
        public void Convert_1629_Returns_MDCXXIX()
        {
            Assert.AreEqual("MDCXXIX", Converter.Convert(1629));
        }
        [TestMethod]
        public void Convert_1630_Returns_MDCXXX()
        {
            Assert.AreEqual("MDCXXX", Converter.Convert(1630));
        }
        [TestMethod]
        public void Convert_1631_Returns_MDCXXXI()
        {
            Assert.AreEqual("MDCXXXI", Converter.Convert(1631));
        }
        [TestMethod]
        public void Convert_1632_Returns_MDCXXXII()
        {
            Assert.AreEqual("MDCXXXII", Converter.Convert(1632));
        }
        [TestMethod]
        public void Convert_1633_Returns_MDCXXXIII()
        {
            Assert.AreEqual("MDCXXXIII", Converter.Convert(1633));
        }
        [TestMethod]
        public void Convert_1634_Returns_MDCXXXIV()
        {
            Assert.AreEqual("MDCXXXIV", Converter.Convert(1634));
        }
        [TestMethod]
        public void Convert_1635_Returns_MDCXXXV()
        {
            Assert.AreEqual("MDCXXXV", Converter.Convert(1635));
        }
        [TestMethod]
        public void Convert_1636_Returns_MDCXXXVI()
        {
            Assert.AreEqual("MDCXXXVI", Converter.Convert(1636));
        }
        [TestMethod]
        public void Convert_1637_Returns_MDCXXXVII()
        {
            Assert.AreEqual("MDCXXXVII", Converter.Convert(1637));
        }
        [TestMethod]
        public void Convert_1638_Returns_MDCXXXVIII()
        {
            Assert.AreEqual("MDCXXXVIII", Converter.Convert(1638));
        }
        [TestMethod]
        public void Convert_1639_Returns_MDCXXXIX()
        {
            Assert.AreEqual("MDCXXXIX", Converter.Convert(1639));
        }
        [TestMethod]
        public void Convert_1640_Returns_MDCXL()
        {
            Assert.AreEqual("MDCXL", Converter.Convert(1640));
        }
        [TestMethod]
        public void Convert_1641_Returns_MDCXLI()
        {
            Assert.AreEqual("MDCXLI", Converter.Convert(1641));
        }
        [TestMethod]
        public void Convert_1642_Returns_MDCXLII()
        {
            Assert.AreEqual("MDCXLII", Converter.Convert(1642));
        }
        [TestMethod]
        public void Convert_1643_Returns_MDCXLIII()
        {
            Assert.AreEqual("MDCXLIII", Converter.Convert(1643));
        }
        [TestMethod]
        public void Convert_1644_Returns_MDCXLIV()
        {
            Assert.AreEqual("MDCXLIV", Converter.Convert(1644));
        }
        [TestMethod]
        public void Convert_1645_Returns_MDCXLV()
        {
            Assert.AreEqual("MDCXLV", Converter.Convert(1645));
        }
        [TestMethod]
        public void Convert_1646_Returns_MDCXLVI()
        {
            Assert.AreEqual("MDCXLVI", Converter.Convert(1646));
        }
        [TestMethod]
        public void Convert_1647_Returns_MDCXLVII()
        {
            Assert.AreEqual("MDCXLVII", Converter.Convert(1647));
        }
        [TestMethod]
        public void Convert_1648_Returns_MDCXLVIII()
        {
            Assert.AreEqual("MDCXLVIII", Converter.Convert(1648));
        }
        [TestMethod]
        public void Convert_1649_Returns_MDCXLIX()
        {
            Assert.AreEqual("MDCXLIX", Converter.Convert(1649));
        }
        [TestMethod]
        public void Convert_1650_Returns_MDCL()
        {
            Assert.AreEqual("MDCL", Converter.Convert(1650));
        }
        [TestMethod]
        public void Convert_1651_Returns_MDCLI()
        {
            Assert.AreEqual("MDCLI", Converter.Convert(1651));
        }
        [TestMethod]
        public void Convert_1652_Returns_MDCLII()
        {
            Assert.AreEqual("MDCLII", Converter.Convert(1652));
        }
        [TestMethod]
        public void Convert_1653_Returns_MDCLIII()
        {
            Assert.AreEqual("MDCLIII", Converter.Convert(1653));
        }
        [TestMethod]
        public void Convert_1654_Returns_MDCLIV()
        {
            Assert.AreEqual("MDCLIV", Converter.Convert(1654));
        }
        [TestMethod]
        public void Convert_1655_Returns_MDCLV()
        {
            Assert.AreEqual("MDCLV", Converter.Convert(1655));
        }
        [TestMethod]
        public void Convert_1656_Returns_MDCLVI()
        {
            Assert.AreEqual("MDCLVI", Converter.Convert(1656));
        }
        [TestMethod]
        public void Convert_1657_Returns_MDCLVII()
        {
            Assert.AreEqual("MDCLVII", Converter.Convert(1657));
        }
        [TestMethod]
        public void Convert_1658_Returns_MDCLVIII()
        {
            Assert.AreEqual("MDCLVIII", Converter.Convert(1658));
        }
        [TestMethod]
        public void Convert_1659_Returns_MDCLIX()
        {
            Assert.AreEqual("MDCLIX", Converter.Convert(1659));
        }
        [TestMethod]
        public void Convert_1660_Returns_MDCLX()
        {
            Assert.AreEqual("MDCLX", Converter.Convert(1660));
        }
        [TestMethod]
        public void Convert_1661_Returns_MDCLXI()
        {
            Assert.AreEqual("MDCLXI", Converter.Convert(1661));
        }
        [TestMethod]
        public void Convert_1662_Returns_MDCLXII()
        {
            Assert.AreEqual("MDCLXII", Converter.Convert(1662));
        }
        [TestMethod]
        public void Convert_1663_Returns_MDCLXIII()
        {
            Assert.AreEqual("MDCLXIII", Converter.Convert(1663));
        }
        [TestMethod]
        public void Convert_1664_Returns_MDCLXIV()
        {
            Assert.AreEqual("MDCLXIV", Converter.Convert(1664));
        }
        [TestMethod]
        public void Convert_1665_Returns_MDCLXV()
        {
            Assert.AreEqual("MDCLXV", Converter.Convert(1665));
        }
        [TestMethod]
        public void Convert_1666_Returns_MDCLXVI()
        {
            Assert.AreEqual("MDCLXVI", Converter.Convert(1666));
        }
        [TestMethod]
        public void Convert_1667_Returns_MDCLXVII()
        {
            Assert.AreEqual("MDCLXVII", Converter.Convert(1667));
        }
        [TestMethod]
        public void Convert_1668_Returns_MDCLXVIII()
        {
            Assert.AreEqual("MDCLXVIII", Converter.Convert(1668));
        }
        [TestMethod]
        public void Convert_1669_Returns_MDCLXIX()
        {
            Assert.AreEqual("MDCLXIX", Converter.Convert(1669));
        }
        [TestMethod]
        public void Convert_1670_Returns_MDCLXX()
        {
            Assert.AreEqual("MDCLXX", Converter.Convert(1670));
        }
        [TestMethod]
        public void Convert_1671_Returns_MDCLXXI()
        {
            Assert.AreEqual("MDCLXXI", Converter.Convert(1671));
        }
        [TestMethod]
        public void Convert_1672_Returns_MDCLXXII()
        {
            Assert.AreEqual("MDCLXXII", Converter.Convert(1672));
        }
        [TestMethod]
        public void Convert_1673_Returns_MDCLXXIII()
        {
            Assert.AreEqual("MDCLXXIII", Converter.Convert(1673));
        }
        [TestMethod]
        public void Convert_1674_Returns_MDCLXXIV()
        {
            Assert.AreEqual("MDCLXXIV", Converter.Convert(1674));
        }
        [TestMethod]
        public void Convert_1675_Returns_MDCLXXV()
        {
            Assert.AreEqual("MDCLXXV", Converter.Convert(1675));
        }
        [TestMethod]
        public void Convert_1676_Returns_MDCLXXVI()
        {
            Assert.AreEqual("MDCLXXVI", Converter.Convert(1676));
        }
        [TestMethod]
        public void Convert_1677_Returns_MDCLXXVII()
        {
            Assert.AreEqual("MDCLXXVII", Converter.Convert(1677));
        }
        [TestMethod]
        public void Convert_1678_Returns_MDCLXXVIII()
        {
            Assert.AreEqual("MDCLXXVIII", Converter.Convert(1678));
        }
        [TestMethod]
        public void Convert_1679_Returns_MDCLXXIX()
        {
            Assert.AreEqual("MDCLXXIX", Converter.Convert(1679));
        }
        [TestMethod]
        public void Convert_1680_Returns_MDCLXXX()
        {
            Assert.AreEqual("MDCLXXX", Converter.Convert(1680));
        }
        [TestMethod]
        public void Convert_1681_Returns_MDCLXXXI()
        {
            Assert.AreEqual("MDCLXXXI", Converter.Convert(1681));
        }
        [TestMethod]
        public void Convert_1682_Returns_MDCLXXXII()
        {
            Assert.AreEqual("MDCLXXXII", Converter.Convert(1682));
        }
        [TestMethod]
        public void Convert_1683_Returns_MDCLXXXIII()
        {
            Assert.AreEqual("MDCLXXXIII", Converter.Convert(1683));
        }
        [TestMethod]
        public void Convert_1684_Returns_MDCLXXXIV()
        {
            Assert.AreEqual("MDCLXXXIV", Converter.Convert(1684));
        }
        [TestMethod]
        public void Convert_1685_Returns_MDCLXXXV()
        {
            Assert.AreEqual("MDCLXXXV", Converter.Convert(1685));
        }
        [TestMethod]
        public void Convert_1686_Returns_MDCLXXXVI()
        {
            Assert.AreEqual("MDCLXXXVI", Converter.Convert(1686));
        }
        [TestMethod]
        public void Convert_1687_Returns_MDCLXXXVII()
        {
            Assert.AreEqual("MDCLXXXVII", Converter.Convert(1687));
        }
        [TestMethod]
        public void Convert_1688_Returns_MDCLXXXVIII()
        {
            Assert.AreEqual("MDCLXXXVIII", Converter.Convert(1688));
        }
        [TestMethod]
        public void Convert_1689_Returns_MDCLXXXIX()
        {
            Assert.AreEqual("MDCLXXXIX", Converter.Convert(1689));
        }
        [TestMethod]
        public void Convert_1690_Returns_MDCXC()
        {
            Assert.AreEqual("MDCXC", Converter.Convert(1690));
        }
        [TestMethod]
        public void Convert_1691_Returns_MDCXCI()
        {
            Assert.AreEqual("MDCXCI", Converter.Convert(1691));
        }
        [TestMethod]
        public void Convert_1692_Returns_MDCXCII()
        {
            Assert.AreEqual("MDCXCII", Converter.Convert(1692));
        }
        [TestMethod]
        public void Convert_1693_Returns_MDCXCIII()
        {
            Assert.AreEqual("MDCXCIII", Converter.Convert(1693));
        }
        [TestMethod]
        public void Convert_1694_Returns_MDCXCIV()
        {
            Assert.AreEqual("MDCXCIV", Converter.Convert(1694));
        }
        [TestMethod]
        public void Convert_1695_Returns_MDCXCV()
        {
            Assert.AreEqual("MDCXCV", Converter.Convert(1695));
        }
        [TestMethod]
        public void Convert_1696_Returns_MDCXCVI()
        {
            Assert.AreEqual("MDCXCVI", Converter.Convert(1696));
        }
        [TestMethod]
        public void Convert_1697_Returns_MDCXCVII()
        {
            Assert.AreEqual("MDCXCVII", Converter.Convert(1697));
        }
        [TestMethod]
        public void Convert_1698_Returns_MDCXCVIII()
        {
            Assert.AreEqual("MDCXCVIII", Converter.Convert(1698));
        }
        [TestMethod]
        public void Convert_1699_Returns_MDCXCIX()
        {
            Assert.AreEqual("MDCXCIX", Converter.Convert(1699));
        }
        [TestMethod]
        public void Convert_1700_Returns_MDCC()
        {
            Assert.AreEqual("MDCC", Converter.Convert(1700));
        }
        [TestMethod]
        public void Convert_1701_Returns_MDCCI()
        {
            Assert.AreEqual("MDCCI", Converter.Convert(1701));
        }
        [TestMethod]
        public void Convert_1702_Returns_MDCCII()
        {
            Assert.AreEqual("MDCCII", Converter.Convert(1702));
        }
        [TestMethod]
        public void Convert_1703_Returns_MDCCIII()
        {
            Assert.AreEqual("MDCCIII", Converter.Convert(1703));
        }
        [TestMethod]
        public void Convert_1704_Returns_MDCCIV()
        {
            Assert.AreEqual("MDCCIV", Converter.Convert(1704));
        }
        [TestMethod]
        public void Convert_1705_Returns_MDCCV()
        {
            Assert.AreEqual("MDCCV", Converter.Convert(1705));
        }
        [TestMethod]
        public void Convert_1706_Returns_MDCCVI()
        {
            Assert.AreEqual("MDCCVI", Converter.Convert(1706));
        }
        [TestMethod]
        public void Convert_1707_Returns_MDCCVII()
        {
            Assert.AreEqual("MDCCVII", Converter.Convert(1707));
        }
        [TestMethod]
        public void Convert_1708_Returns_MDCCVIII()
        {
            Assert.AreEqual("MDCCVIII", Converter.Convert(1708));
        }
        [TestMethod]
        public void Convert_1709_Returns_MDCCIX()
        {
            Assert.AreEqual("MDCCIX", Converter.Convert(1709));
        }
        [TestMethod]
        public void Convert_1710_Returns_MDCCX()
        {
            Assert.AreEqual("MDCCX", Converter.Convert(1710));
        }
        [TestMethod]
        public void Convert_1711_Returns_MDCCXI()
        {
            Assert.AreEqual("MDCCXI", Converter.Convert(1711));
        }
        [TestMethod]
        public void Convert_1712_Returns_MDCCXII()
        {
            Assert.AreEqual("MDCCXII", Converter.Convert(1712));
        }
        [TestMethod]
        public void Convert_1713_Returns_MDCCXIII()
        {
            Assert.AreEqual("MDCCXIII", Converter.Convert(1713));
        }
        [TestMethod]
        public void Convert_1714_Returns_MDCCXIV()
        {
            Assert.AreEqual("MDCCXIV", Converter.Convert(1714));
        }
        [TestMethod]
        public void Convert_1715_Returns_MDCCXV()
        {
            Assert.AreEqual("MDCCXV", Converter.Convert(1715));
        }
        [TestMethod]
        public void Convert_1716_Returns_MDCCXVI()
        {
            Assert.AreEqual("MDCCXVI", Converter.Convert(1716));
        }
        [TestMethod]
        public void Convert_1717_Returns_MDCCXVII()
        {
            Assert.AreEqual("MDCCXVII", Converter.Convert(1717));
        }
        [TestMethod]
        public void Convert_1718_Returns_MDCCXVIII()
        {
            Assert.AreEqual("MDCCXVIII", Converter.Convert(1718));
        }
        [TestMethod]
        public void Convert_1719_Returns_MDCCXIX()
        {
            Assert.AreEqual("MDCCXIX", Converter.Convert(1719));
        }
        [TestMethod]
        public void Convert_1720_Returns_MDCCXX()
        {
            Assert.AreEqual("MDCCXX", Converter.Convert(1720));
        }
        [TestMethod]
        public void Convert_1721_Returns_MDCCXXI()
        {
            Assert.AreEqual("MDCCXXI", Converter.Convert(1721));
        }
        [TestMethod]
        public void Convert_1722_Returns_MDCCXXII()
        {
            Assert.AreEqual("MDCCXXII", Converter.Convert(1722));
        }
        [TestMethod]
        public void Convert_1723_Returns_MDCCXXIII()
        {
            Assert.AreEqual("MDCCXXIII", Converter.Convert(1723));
        }
        [TestMethod]
        public void Convert_1724_Returns_MDCCXXIV()
        {
            Assert.AreEqual("MDCCXXIV", Converter.Convert(1724));
        }
        [TestMethod]
        public void Convert_1725_Returns_MDCCXXV()
        {
            Assert.AreEqual("MDCCXXV", Converter.Convert(1725));
        }
        [TestMethod]
        public void Convert_1726_Returns_MDCCXXVI()
        {
            Assert.AreEqual("MDCCXXVI", Converter.Convert(1726));
        }
        [TestMethod]
        public void Convert_1727_Returns_MDCCXXVII()
        {
            Assert.AreEqual("MDCCXXVII", Converter.Convert(1727));
        }
        [TestMethod]
        public void Convert_1728_Returns_MDCCXXVIII()
        {
            Assert.AreEqual("MDCCXXVIII", Converter.Convert(1728));
        }
        [TestMethod]
        public void Convert_1729_Returns_MDCCXXIX()
        {
            Assert.AreEqual("MDCCXXIX", Converter.Convert(1729));
        }
        [TestMethod]
        public void Convert_1730_Returns_MDCCXXX()
        {
            Assert.AreEqual("MDCCXXX", Converter.Convert(1730));
        }
        [TestMethod]
        public void Convert_1731_Returns_MDCCXXXI()
        {
            Assert.AreEqual("MDCCXXXI", Converter.Convert(1731));
        }
        [TestMethod]
        public void Convert_1732_Returns_MDCCXXXII()
        {
            Assert.AreEqual("MDCCXXXII", Converter.Convert(1732));
        }
        [TestMethod]
        public void Convert_1733_Returns_MDCCXXXIII()
        {
            Assert.AreEqual("MDCCXXXIII", Converter.Convert(1733));
        }
        [TestMethod]
        public void Convert_1734_Returns_MDCCXXXIV()
        {
            Assert.AreEqual("MDCCXXXIV", Converter.Convert(1734));
        }
        [TestMethod]
        public void Convert_1735_Returns_MDCCXXXV()
        {
            Assert.AreEqual("MDCCXXXV", Converter.Convert(1735));
        }
        [TestMethod]
        public void Convert_1736_Returns_MDCCXXXVI()
        {
            Assert.AreEqual("MDCCXXXVI", Converter.Convert(1736));
        }
        [TestMethod]
        public void Convert_1737_Returns_MDCCXXXVII()
        {
            Assert.AreEqual("MDCCXXXVII", Converter.Convert(1737));
        }
        [TestMethod]
        public void Convert_1738_Returns_MDCCXXXVIII()
        {
            Assert.AreEqual("MDCCXXXVIII", Converter.Convert(1738));
        }
        [TestMethod]
        public void Convert_1739_Returns_MDCCXXXIX()
        {
            Assert.AreEqual("MDCCXXXIX", Converter.Convert(1739));
        }
        [TestMethod]
        public void Convert_1740_Returns_MDCCXL()
        {
            Assert.AreEqual("MDCCXL", Converter.Convert(1740));
        }
        [TestMethod]
        public void Convert_1741_Returns_MDCCXLI()
        {
            Assert.AreEqual("MDCCXLI", Converter.Convert(1741));
        }
        [TestMethod]
        public void Convert_1742_Returns_MDCCXLII()
        {
            Assert.AreEqual("MDCCXLII", Converter.Convert(1742));
        }
        [TestMethod]
        public void Convert_1743_Returns_MDCCXLIII()
        {
            Assert.AreEqual("MDCCXLIII", Converter.Convert(1743));
        }
        [TestMethod]
        public void Convert_1744_Returns_MDCCXLIV()
        {
            Assert.AreEqual("MDCCXLIV", Converter.Convert(1744));
        }
        [TestMethod]
        public void Convert_1745_Returns_MDCCXLV()
        {
            Assert.AreEqual("MDCCXLV", Converter.Convert(1745));
        }
        [TestMethod]
        public void Convert_1746_Returns_MDCCXLVI()
        {
            Assert.AreEqual("MDCCXLVI", Converter.Convert(1746));
        }
        [TestMethod]
        public void Convert_1747_Returns_MDCCXLVII()
        {
            Assert.AreEqual("MDCCXLVII", Converter.Convert(1747));
        }
        [TestMethod]
        public void Convert_1748_Returns_MDCCXLVIII()
        {
            Assert.AreEqual("MDCCXLVIII", Converter.Convert(1748));
        }
        [TestMethod]
        public void Convert_1749_Returns_MDCCXLIX()
        {
            Assert.AreEqual("MDCCXLIX", Converter.Convert(1749));
        }
        [TestMethod]
        public void Convert_1750_Returns_MDCCL()
        {
            Assert.AreEqual("MDCCL", Converter.Convert(1750));
        }
        [TestMethod]
        public void Convert_1751_Returns_MDCCLI()
        {
            Assert.AreEqual("MDCCLI", Converter.Convert(1751));
        }
        [TestMethod]
        public void Convert_1752_Returns_MDCCLII()
        {
            Assert.AreEqual("MDCCLII", Converter.Convert(1752));
        }
        [TestMethod]
        public void Convert_1753_Returns_MDCCLIII()
        {
            Assert.AreEqual("MDCCLIII", Converter.Convert(1753));
        }
        [TestMethod]
        public void Convert_1754_Returns_MDCCLIV()
        {
            Assert.AreEqual("MDCCLIV", Converter.Convert(1754));
        }
        [TestMethod]
        public void Convert_1755_Returns_MDCCLV()
        {
            Assert.AreEqual("MDCCLV", Converter.Convert(1755));
        }
        [TestMethod]
        public void Convert_1756_Returns_MDCCLVI()
        {
            Assert.AreEqual("MDCCLVI", Converter.Convert(1756));
        }
        [TestMethod]
        public void Convert_1757_Returns_MDCCLVII()
        {
            Assert.AreEqual("MDCCLVII", Converter.Convert(1757));
        }
        [TestMethod]
        public void Convert_1758_Returns_MDCCLVIII()
        {
            Assert.AreEqual("MDCCLVIII", Converter.Convert(1758));
        }
        [TestMethod]
        public void Convert_1759_Returns_MDCCLIX()
        {
            Assert.AreEqual("MDCCLIX", Converter.Convert(1759));
        }
        [TestMethod]
        public void Convert_1760_Returns_MDCCLX()
        {
            Assert.AreEqual("MDCCLX", Converter.Convert(1760));
        }
        [TestMethod]
        public void Convert_1761_Returns_MDCCLXI()
        {
            Assert.AreEqual("MDCCLXI", Converter.Convert(1761));
        }
        [TestMethod]
        public void Convert_1762_Returns_MDCCLXII()
        {
            Assert.AreEqual("MDCCLXII", Converter.Convert(1762));
        }
        [TestMethod]
        public void Convert_1763_Returns_MDCCLXIII()
        {
            Assert.AreEqual("MDCCLXIII", Converter.Convert(1763));
        }
        [TestMethod]
        public void Convert_1764_Returns_MDCCLXIV()
        {
            Assert.AreEqual("MDCCLXIV", Converter.Convert(1764));
        }
        [TestMethod]
        public void Convert_1765_Returns_MDCCLXV()
        {
            Assert.AreEqual("MDCCLXV", Converter.Convert(1765));
        }
        [TestMethod]
        public void Convert_1766_Returns_MDCCLXVI()
        {
            Assert.AreEqual("MDCCLXVI", Converter.Convert(1766));
        }
        [TestMethod]
        public void Convert_1767_Returns_MDCCLXVII()
        {
            Assert.AreEqual("MDCCLXVII", Converter.Convert(1767));
        }
        [TestMethod]
        public void Convert_1768_Returns_MDCCLXVIII()
        {
            Assert.AreEqual("MDCCLXVIII", Converter.Convert(1768));
        }
        [TestMethod]
        public void Convert_1769_Returns_MDCCLXIX()
        {
            Assert.AreEqual("MDCCLXIX", Converter.Convert(1769));
        }
        [TestMethod]
        public void Convert_1770_Returns_MDCCLXX()
        {
            Assert.AreEqual("MDCCLXX", Converter.Convert(1770));
        }
        [TestMethod]
        public void Convert_1771_Returns_MDCCLXXI()
        {
            Assert.AreEqual("MDCCLXXI", Converter.Convert(1771));
        }
        [TestMethod]
        public void Convert_1772_Returns_MDCCLXXII()
        {
            Assert.AreEqual("MDCCLXXII", Converter.Convert(1772));
        }
        [TestMethod]
        public void Convert_1773_Returns_MDCCLXXIII()
        {
            Assert.AreEqual("MDCCLXXIII", Converter.Convert(1773));
        }
        [TestMethod]
        public void Convert_1774_Returns_MDCCLXXIV()
        {
            Assert.AreEqual("MDCCLXXIV", Converter.Convert(1774));
        }
        [TestMethod]
        public void Convert_1775_Returns_MDCCLXXV()
        {
            Assert.AreEqual("MDCCLXXV", Converter.Convert(1775));
        }
        [TestMethod]
        public void Convert_1776_Returns_MDCCLXXVI()
        {
            Assert.AreEqual("MDCCLXXVI", Converter.Convert(1776));
        }
        [TestMethod]
        public void Convert_1777_Returns_MDCCLXXVII()
        {
            Assert.AreEqual("MDCCLXXVII", Converter.Convert(1777));
        }
        [TestMethod]
        public void Convert_1778_Returns_MDCCLXXVIII()
        {
            Assert.AreEqual("MDCCLXXVIII", Converter.Convert(1778));
        }
        [TestMethod]
        public void Convert_1779_Returns_MDCCLXXIX()
        {
            Assert.AreEqual("MDCCLXXIX", Converter.Convert(1779));
        }
        [TestMethod]
        public void Convert_1780_Returns_MDCCLXXX()
        {
            Assert.AreEqual("MDCCLXXX", Converter.Convert(1780));
        }
        [TestMethod]
        public void Convert_1781_Returns_MDCCLXXXI()
        {
            Assert.AreEqual("MDCCLXXXI", Converter.Convert(1781));
        }
        [TestMethod]
        public void Convert_1782_Returns_MDCCLXXXII()
        {
            Assert.AreEqual("MDCCLXXXII", Converter.Convert(1782));
        }
        [TestMethod]
        public void Convert_1783_Returns_MDCCLXXXIII()
        {
            Assert.AreEqual("MDCCLXXXIII", Converter.Convert(1783));
        }
        [TestMethod]
        public void Convert_1784_Returns_MDCCLXXXIV()
        {
            Assert.AreEqual("MDCCLXXXIV", Converter.Convert(1784));
        }
        [TestMethod]
        public void Convert_1785_Returns_MDCCLXXXV()
        {
            Assert.AreEqual("MDCCLXXXV", Converter.Convert(1785));
        }
        [TestMethod]
        public void Convert_1786_Returns_MDCCLXXXVI()
        {
            Assert.AreEqual("MDCCLXXXVI", Converter.Convert(1786));
        }
        [TestMethod]
        public void Convert_1787_Returns_MDCCLXXXVII()
        {
            Assert.AreEqual("MDCCLXXXVII", Converter.Convert(1787));
        }
        [TestMethod]
        public void Convert_1788_Returns_MDCCLXXXVIII()
        {
            Assert.AreEqual("MDCCLXXXVIII", Converter.Convert(1788));
        }
        [TestMethod]
        public void Convert_1789_Returns_MDCCLXXXIX()
        {
            Assert.AreEqual("MDCCLXXXIX", Converter.Convert(1789));
        }
        [TestMethod]
        public void Convert_1790_Returns_MDCCXC()
        {
            Assert.AreEqual("MDCCXC", Converter.Convert(1790));
        }
        [TestMethod]
        public void Convert_1791_Returns_MDCCXCI()
        {
            Assert.AreEqual("MDCCXCI", Converter.Convert(1791));
        }
        [TestMethod]
        public void Convert_1792_Returns_MDCCXCII()
        {
            Assert.AreEqual("MDCCXCII", Converter.Convert(1792));
        }
        [TestMethod]
        public void Convert_1793_Returns_MDCCXCIII()
        {
            Assert.AreEqual("MDCCXCIII", Converter.Convert(1793));
        }
        [TestMethod]
        public void Convert_1794_Returns_MDCCXCIV()
        {
            Assert.AreEqual("MDCCXCIV", Converter.Convert(1794));
        }
        [TestMethod]
        public void Convert_1795_Returns_MDCCXCV()
        {
            Assert.AreEqual("MDCCXCV", Converter.Convert(1795));
        }
        [TestMethod]
        public void Convert_1796_Returns_MDCCXCVI()
        {
            Assert.AreEqual("MDCCXCVI", Converter.Convert(1796));
        }
        [TestMethod]
        public void Convert_1797_Returns_MDCCXCVII()
        {
            Assert.AreEqual("MDCCXCVII", Converter.Convert(1797));
        }
        [TestMethod]
        public void Convert_1798_Returns_MDCCXCVIII()
        {
            Assert.AreEqual("MDCCXCVIII", Converter.Convert(1798));
        }
        [TestMethod]
        public void Convert_1799_Returns_MDCCXCIX()
        {
            Assert.AreEqual("MDCCXCIX", Converter.Convert(1799));
        }
        [TestMethod]
        public void Convert_1800_Returns_MDCCC()
        {
            Assert.AreEqual("MDCCC", Converter.Convert(1800));
        }
        [TestMethod]
        public void Convert_1801_Returns_MDCCCI()
        {
            Assert.AreEqual("MDCCCI", Converter.Convert(1801));
        }
        [TestMethod]
        public void Convert_1802_Returns_MDCCCII()
        {
            Assert.AreEqual("MDCCCII", Converter.Convert(1802));
        }
        [TestMethod]
        public void Convert_1803_Returns_MDCCCIII()
        {
            Assert.AreEqual("MDCCCIII", Converter.Convert(1803));
        }
        [TestMethod]
        public void Convert_1804_Returns_MDCCCIV()
        {
            Assert.AreEqual("MDCCCIV", Converter.Convert(1804));
        }
        [TestMethod]
        public void Convert_1805_Returns_MDCCCV()
        {
            Assert.AreEqual("MDCCCV", Converter.Convert(1805));
        }
        [TestMethod]
        public void Convert_1806_Returns_MDCCCVI()
        {
            Assert.AreEqual("MDCCCVI", Converter.Convert(1806));
        }
        [TestMethod]
        public void Convert_1807_Returns_MDCCCVII()
        {
            Assert.AreEqual("MDCCCVII", Converter.Convert(1807));
        }
        [TestMethod]
        public void Convert_1808_Returns_MDCCCVIII()
        {
            Assert.AreEqual("MDCCCVIII", Converter.Convert(1808));
        }
        [TestMethod]
        public void Convert_1809_Returns_MDCCCIX()
        {
            Assert.AreEqual("MDCCCIX", Converter.Convert(1809));
        }
        [TestMethod]
        public void Convert_1810_Returns_MDCCCX()
        {
            Assert.AreEqual("MDCCCX", Converter.Convert(1810));
        }
        [TestMethod]
        public void Convert_1811_Returns_MDCCCXI()
        {
            Assert.AreEqual("MDCCCXI", Converter.Convert(1811));
        }
        [TestMethod]
        public void Convert_1812_Returns_MDCCCXII()
        {
            Assert.AreEqual("MDCCCXII", Converter.Convert(1812));
        }
        [TestMethod]
        public void Convert_1813_Returns_MDCCCXIII()
        {
            Assert.AreEqual("MDCCCXIII", Converter.Convert(1813));
        }
        [TestMethod]
        public void Convert_1814_Returns_MDCCCXIV()
        {
            Assert.AreEqual("MDCCCXIV", Converter.Convert(1814));
        }
        [TestMethod]
        public void Convert_1815_Returns_MDCCCXV()
        {
            Assert.AreEqual("MDCCCXV", Converter.Convert(1815));
        }
        [TestMethod]
        public void Convert_1816_Returns_MDCCCXVI()
        {
            Assert.AreEqual("MDCCCXVI", Converter.Convert(1816));
        }
        [TestMethod]
        public void Convert_1817_Returns_MDCCCXVII()
        {
            Assert.AreEqual("MDCCCXVII", Converter.Convert(1817));
        }
        [TestMethod]
        public void Convert_1818_Returns_MDCCCXVIII()
        {
            Assert.AreEqual("MDCCCXVIII", Converter.Convert(1818));
        }
        [TestMethod]
        public void Convert_1819_Returns_MDCCCXIX()
        {
            Assert.AreEqual("MDCCCXIX", Converter.Convert(1819));
        }
        [TestMethod]
        public void Convert_1820_Returns_MDCCCXX()
        {
            Assert.AreEqual("MDCCCXX", Converter.Convert(1820));
        }
        [TestMethod]
        public void Convert_1821_Returns_MDCCCXXI()
        {
            Assert.AreEqual("MDCCCXXI", Converter.Convert(1821));
        }
        [TestMethod]
        public void Convert_1822_Returns_MDCCCXXII()
        {
            Assert.AreEqual("MDCCCXXII", Converter.Convert(1822));
        }
        [TestMethod]
        public void Convert_1823_Returns_MDCCCXXIII()
        {
            Assert.AreEqual("MDCCCXXIII", Converter.Convert(1823));
        }
        [TestMethod]
        public void Convert_1824_Returns_MDCCCXXIV()
        {
            Assert.AreEqual("MDCCCXXIV", Converter.Convert(1824));
        }
        [TestMethod]
        public void Convert_1825_Returns_MDCCCXXV()
        {
            Assert.AreEqual("MDCCCXXV", Converter.Convert(1825));
        }
        [TestMethod]
        public void Convert_1826_Returns_MDCCCXXVI()
        {
            Assert.AreEqual("MDCCCXXVI", Converter.Convert(1826));
        }
        [TestMethod]
        public void Convert_1827_Returns_MDCCCXXVII()
        {
            Assert.AreEqual("MDCCCXXVII", Converter.Convert(1827));
        }
        [TestMethod]
        public void Convert_1828_Returns_MDCCCXXVIII()
        {
            Assert.AreEqual("MDCCCXXVIII", Converter.Convert(1828));
        }
        [TestMethod]
        public void Convert_1829_Returns_MDCCCXXIX()
        {
            Assert.AreEqual("MDCCCXXIX", Converter.Convert(1829));
        }
        [TestMethod]
        public void Convert_1830_Returns_MDCCCXXX()
        {
            Assert.AreEqual("MDCCCXXX", Converter.Convert(1830));
        }
        [TestMethod]
        public void Convert_1831_Returns_MDCCCXXXI()
        {
            Assert.AreEqual("MDCCCXXXI", Converter.Convert(1831));
        }
        [TestMethod]
        public void Convert_1832_Returns_MDCCCXXXII()
        {
            Assert.AreEqual("MDCCCXXXII", Converter.Convert(1832));
        }
        [TestMethod]
        public void Convert_1833_Returns_MDCCCXXXIII()
        {
            Assert.AreEqual("MDCCCXXXIII", Converter.Convert(1833));
        }
        [TestMethod]
        public void Convert_1834_Returns_MDCCCXXXIV()
        {
            Assert.AreEqual("MDCCCXXXIV", Converter.Convert(1834));
        }
        [TestMethod]
        public void Convert_1835_Returns_MDCCCXXXV()
        {
            Assert.AreEqual("MDCCCXXXV", Converter.Convert(1835));
        }
        [TestMethod]
        public void Convert_1836_Returns_MDCCCXXXVI()
        {
            Assert.AreEqual("MDCCCXXXVI", Converter.Convert(1836));
        }
        [TestMethod]
        public void Convert_1837_Returns_MDCCCXXXVII()
        {
            Assert.AreEqual("MDCCCXXXVII", Converter.Convert(1837));
        }
        [TestMethod]
        public void Convert_1838_Returns_MDCCCXXXVIII()
        {
            Assert.AreEqual("MDCCCXXXVIII", Converter.Convert(1838));
        }
        [TestMethod]
        public void Convert_1839_Returns_MDCCCXXXIX()
        {
            Assert.AreEqual("MDCCCXXXIX", Converter.Convert(1839));
        }
        [TestMethod]
        public void Convert_1840_Returns_MDCCCXL()
        {
            Assert.AreEqual("MDCCCXL", Converter.Convert(1840));
        }
        [TestMethod]
        public void Convert_1841_Returns_MDCCCXLI()
        {
            Assert.AreEqual("MDCCCXLI", Converter.Convert(1841));
        }
        [TestMethod]
        public void Convert_1842_Returns_MDCCCXLII()
        {
            Assert.AreEqual("MDCCCXLII", Converter.Convert(1842));
        }
        [TestMethod]
        public void Convert_1843_Returns_MDCCCXLIII()
        {
            Assert.AreEqual("MDCCCXLIII", Converter.Convert(1843));
        }
        [TestMethod]
        public void Convert_1844_Returns_MDCCCXLIV()
        {
            Assert.AreEqual("MDCCCXLIV", Converter.Convert(1844));
        }
        [TestMethod]
        public void Convert_1845_Returns_MDCCCXLV()
        {
            Assert.AreEqual("MDCCCXLV", Converter.Convert(1845));
        }
        [TestMethod]
        public void Convert_1846_Returns_MDCCCXLVI()
        {
            Assert.AreEqual("MDCCCXLVI", Converter.Convert(1846));
        }
        [TestMethod]
        public void Convert_1847_Returns_MDCCCXLVII()
        {
            Assert.AreEqual("MDCCCXLVII", Converter.Convert(1847));
        }
        [TestMethod]
        public void Convert_1848_Returns_MDCCCXLVIII()
        {
            Assert.AreEqual("MDCCCXLVIII", Converter.Convert(1848));
        }
        [TestMethod]
        public void Convert_1849_Returns_MDCCCXLIX()
        {
            Assert.AreEqual("MDCCCXLIX", Converter.Convert(1849));
        }
        [TestMethod]
        public void Convert_1850_Returns_MDCCCL()
        {
            Assert.AreEqual("MDCCCL", Converter.Convert(1850));
        }
        [TestMethod]
        public void Convert_1851_Returns_MDCCCLI()
        {
            Assert.AreEqual("MDCCCLI", Converter.Convert(1851));
        }
        [TestMethod]
        public void Convert_1852_Returns_MDCCCLII()
        {
            Assert.AreEqual("MDCCCLII", Converter.Convert(1852));
        }
        [TestMethod]
        public void Convert_1853_Returns_MDCCCLIII()
        {
            Assert.AreEqual("MDCCCLIII", Converter.Convert(1853));
        }
        [TestMethod]
        public void Convert_1854_Returns_MDCCCLIV()
        {
            Assert.AreEqual("MDCCCLIV", Converter.Convert(1854));
        }
        [TestMethod]
        public void Convert_1855_Returns_MDCCCLV()
        {
            Assert.AreEqual("MDCCCLV", Converter.Convert(1855));
        }
        [TestMethod]
        public void Convert_1856_Returns_MDCCCLVI()
        {
            Assert.AreEqual("MDCCCLVI", Converter.Convert(1856));
        }
        [TestMethod]
        public void Convert_1857_Returns_MDCCCLVII()
        {
            Assert.AreEqual("MDCCCLVII", Converter.Convert(1857));
        }
        [TestMethod]
        public void Convert_1858_Returns_MDCCCLVIII()
        {
            Assert.AreEqual("MDCCCLVIII", Converter.Convert(1858));
        }
        [TestMethod]
        public void Convert_1859_Returns_MDCCCLIX()
        {
            Assert.AreEqual("MDCCCLIX", Converter.Convert(1859));
        }
        [TestMethod]
        public void Convert_1860_Returns_MDCCCLX()
        {
            Assert.AreEqual("MDCCCLX", Converter.Convert(1860));
        }
        [TestMethod]
        public void Convert_1861_Returns_MDCCCLXI()
        {
            Assert.AreEqual("MDCCCLXI", Converter.Convert(1861));
        }
        [TestMethod]
        public void Convert_1862_Returns_MDCCCLXII()
        {
            Assert.AreEqual("MDCCCLXII", Converter.Convert(1862));
        }
        [TestMethod]
        public void Convert_1863_Returns_MDCCCLXIII()
        {
            Assert.AreEqual("MDCCCLXIII", Converter.Convert(1863));
        }
        [TestMethod]
        public void Convert_1864_Returns_MDCCCLXIV()
        {
            Assert.AreEqual("MDCCCLXIV", Converter.Convert(1864));
        }
        [TestMethod]
        public void Convert_1865_Returns_MDCCCLXV()
        {
            Assert.AreEqual("MDCCCLXV", Converter.Convert(1865));
        }
        [TestMethod]
        public void Convert_1866_Returns_MDCCCLXVI()
        {
            Assert.AreEqual("MDCCCLXVI", Converter.Convert(1866));
        }
        [TestMethod]
        public void Convert_1867_Returns_MDCCCLXVII()
        {
            Assert.AreEqual("MDCCCLXVII", Converter.Convert(1867));
        }
        [TestMethod]
        public void Convert_1868_Returns_MDCCCLXVIII()
        {
            Assert.AreEqual("MDCCCLXVIII", Converter.Convert(1868));
        }
        [TestMethod]
        public void Convert_1869_Returns_MDCCCLXIX()
        {
            Assert.AreEqual("MDCCCLXIX", Converter.Convert(1869));
        }
        [TestMethod]
        public void Convert_1870_Returns_MDCCCLXX()
        {
            Assert.AreEqual("MDCCCLXX", Converter.Convert(1870));
        }
        [TestMethod]
        public void Convert_1871_Returns_MDCCCLXXI()
        {
            Assert.AreEqual("MDCCCLXXI", Converter.Convert(1871));
        }
        [TestMethod]
        public void Convert_1872_Returns_MDCCCLXXII()
        {
            Assert.AreEqual("MDCCCLXXII", Converter.Convert(1872));
        }
        [TestMethod]
        public void Convert_1873_Returns_MDCCCLXXIII()
        {
            Assert.AreEqual("MDCCCLXXIII", Converter.Convert(1873));
        }
        [TestMethod]
        public void Convert_1874_Returns_MDCCCLXXIV()
        {
            Assert.AreEqual("MDCCCLXXIV", Converter.Convert(1874));
        }
        [TestMethod]
        public void Convert_1875_Returns_MDCCCLXXV()
        {
            Assert.AreEqual("MDCCCLXXV", Converter.Convert(1875));
        }
        [TestMethod]
        public void Convert_1876_Returns_MDCCCLXXVI()
        {
            Assert.AreEqual("MDCCCLXXVI", Converter.Convert(1876));
        }
        [TestMethod]
        public void Convert_1877_Returns_MDCCCLXXVII()
        {
            Assert.AreEqual("MDCCCLXXVII", Converter.Convert(1877));
        }
        [TestMethod]
        public void Convert_1878_Returns_MDCCCLXXVIII()
        {
            Assert.AreEqual("MDCCCLXXVIII", Converter.Convert(1878));
        }
        [TestMethod]
        public void Convert_1879_Returns_MDCCCLXXIX()
        {
            Assert.AreEqual("MDCCCLXXIX", Converter.Convert(1879));
        }
        [TestMethod]
        public void Convert_1880_Returns_MDCCCLXXX()
        {
            Assert.AreEqual("MDCCCLXXX", Converter.Convert(1880));
        }
        [TestMethod]
        public void Convert_1881_Returns_MDCCCLXXXI()
        {
            Assert.AreEqual("MDCCCLXXXI", Converter.Convert(1881));
        }
        [TestMethod]
        public void Convert_1882_Returns_MDCCCLXXXII()
        {
            Assert.AreEqual("MDCCCLXXXII", Converter.Convert(1882));
        }
        [TestMethod]
        public void Convert_1883_Returns_MDCCCLXXXIII()
        {
            Assert.AreEqual("MDCCCLXXXIII", Converter.Convert(1883));
        }
        [TestMethod]
        public void Convert_1884_Returns_MDCCCLXXXIV()
        {
            Assert.AreEqual("MDCCCLXXXIV", Converter.Convert(1884));
        }
        [TestMethod]
        public void Convert_1885_Returns_MDCCCLXXXV()
        {
            Assert.AreEqual("MDCCCLXXXV", Converter.Convert(1885));
        }
        [TestMethod]
        public void Convert_1886_Returns_MDCCCLXXXVI()
        {
            Assert.AreEqual("MDCCCLXXXVI", Converter.Convert(1886));
        }
        [TestMethod]
        public void Convert_1887_Returns_MDCCCLXXXVII()
        {
            Assert.AreEqual("MDCCCLXXXVII", Converter.Convert(1887));
        }
        [TestMethod]
        public void Convert_1888_Returns_MDCCCLXXXVIII()
        {
            Assert.AreEqual("MDCCCLXXXVIII", Converter.Convert(1888));
        }
        [TestMethod]
        public void Convert_1889_Returns_MDCCCLXXXIX()
        {
            Assert.AreEqual("MDCCCLXXXIX", Converter.Convert(1889));
        }
        [TestMethod]
        public void Convert_1890_Returns_MDCCCXC()
        {
            Assert.AreEqual("MDCCCXC", Converter.Convert(1890));
        }
        [TestMethod]
        public void Convert_1891_Returns_MDCCCXCI()
        {
            Assert.AreEqual("MDCCCXCI", Converter.Convert(1891));
        }
        [TestMethod]
        public void Convert_1892_Returns_MDCCCXCII()
        {
            Assert.AreEqual("MDCCCXCII", Converter.Convert(1892));
        }
        [TestMethod]
        public void Convert_1893_Returns_MDCCCXCIII()
        {
            Assert.AreEqual("MDCCCXCIII", Converter.Convert(1893));
        }
        [TestMethod]
        public void Convert_1894_Returns_MDCCCXCIV()
        {
            Assert.AreEqual("MDCCCXCIV", Converter.Convert(1894));
        }
        [TestMethod]
        public void Convert_1895_Returns_MDCCCXCV()
        {
            Assert.AreEqual("MDCCCXCV", Converter.Convert(1895));
        }
        [TestMethod]
        public void Convert_1896_Returns_MDCCCXCVI()
        {
            Assert.AreEqual("MDCCCXCVI", Converter.Convert(1896));
        }
        [TestMethod]
        public void Convert_1897_Returns_MDCCCXCVII()
        {
            Assert.AreEqual("MDCCCXCVII", Converter.Convert(1897));
        }
        [TestMethod]
        public void Convert_1898_Returns_MDCCCXCVIII()
        {
            Assert.AreEqual("MDCCCXCVIII", Converter.Convert(1898));
        }
        [TestMethod]
        public void Convert_1899_Returns_MDCCCXCIX()
        {
            Assert.AreEqual("MDCCCXCIX", Converter.Convert(1899));
        }
        [TestMethod]
        public void Convert_1900_Returns_MCM()
        {
            Assert.AreEqual("MCM", Converter.Convert(1900));
        }
        [TestMethod]
        public void Convert_1901_Returns_MCMI()
        {
            Assert.AreEqual("MCMI", Converter.Convert(1901));
        }
        [TestMethod]
        public void Convert_1902_Returns_MCMII()
        {
            Assert.AreEqual("MCMII", Converter.Convert(1902));
        }
        [TestMethod]
        public void Convert_1903_Returns_MCMIII()
        {
            Assert.AreEqual("MCMIII", Converter.Convert(1903));
        }
        [TestMethod]
        public void Convert_1904_Returns_MCMIV()
        {
            Assert.AreEqual("MCMIV", Converter.Convert(1904));
        }
        [TestMethod]
        public void Convert_1905_Returns_MCMV()
        {
            Assert.AreEqual("MCMV", Converter.Convert(1905));
        }
        [TestMethod]
        public void Convert_1906_Returns_MCMVI()
        {
            Assert.AreEqual("MCMVI", Converter.Convert(1906));
        }
        [TestMethod]
        public void Convert_1907_Returns_MCMVII()
        {
            Assert.AreEqual("MCMVII", Converter.Convert(1907));
        }
        [TestMethod]
        public void Convert_1908_Returns_MCMVIII()
        {
            Assert.AreEqual("MCMVIII", Converter.Convert(1908));
        }
        [TestMethod]
        public void Convert_1909_Returns_MCMIX()
        {
            Assert.AreEqual("MCMIX", Converter.Convert(1909));
        }
        [TestMethod]
        public void Convert_1910_Returns_MCMX()
        {
            Assert.AreEqual("MCMX", Converter.Convert(1910));
        }
        [TestMethod]
        public void Convert_1911_Returns_MCMXI()
        {
            Assert.AreEqual("MCMXI", Converter.Convert(1911));
        }
        [TestMethod]
        public void Convert_1912_Returns_MCMXII()
        {
            Assert.AreEqual("MCMXII", Converter.Convert(1912));
        }
        [TestMethod]
        public void Convert_1913_Returns_MCMXIII()
        {
            Assert.AreEqual("MCMXIII", Converter.Convert(1913));
        }
        [TestMethod]
        public void Convert_1914_Returns_MCMXIV()
        {
            Assert.AreEqual("MCMXIV", Converter.Convert(1914));
        }
        [TestMethod]
        public void Convert_1915_Returns_MCMXV()
        {
            Assert.AreEqual("MCMXV", Converter.Convert(1915));
        }
        [TestMethod]
        public void Convert_1916_Returns_MCMXVI()
        {
            Assert.AreEqual("MCMXVI", Converter.Convert(1916));
        }
        [TestMethod]
        public void Convert_1917_Returns_MCMXVII()
        {
            Assert.AreEqual("MCMXVII", Converter.Convert(1917));
        }
        [TestMethod]
        public void Convert_1918_Returns_MCMXVIII()
        {
            Assert.AreEqual("MCMXVIII", Converter.Convert(1918));
        }
        [TestMethod]
        public void Convert_1919_Returns_MCMXIX()
        {
            Assert.AreEqual("MCMXIX", Converter.Convert(1919));
        }
        [TestMethod]
        public void Convert_1920_Returns_MCMXX()
        {
            Assert.AreEqual("MCMXX", Converter.Convert(1920));
        }
        [TestMethod]
        public void Convert_1921_Returns_MCMXXI()
        {
            Assert.AreEqual("MCMXXI", Converter.Convert(1921));
        }
        [TestMethod]
        public void Convert_1922_Returns_MCMXXII()
        {
            Assert.AreEqual("MCMXXII", Converter.Convert(1922));
        }
        [TestMethod]
        public void Convert_1923_Returns_MCMXXIII()
        {
            Assert.AreEqual("MCMXXIII", Converter.Convert(1923));
        }
        [TestMethod]
        public void Convert_1924_Returns_MCMXXIV()
        {
            Assert.AreEqual("MCMXXIV", Converter.Convert(1924));
        }
        [TestMethod]
        public void Convert_1925_Returns_MCMXXV()
        {
            Assert.AreEqual("MCMXXV", Converter.Convert(1925));
        }
        [TestMethod]
        public void Convert_1926_Returns_MCMXXVI()
        {
            Assert.AreEqual("MCMXXVI", Converter.Convert(1926));
        }
        [TestMethod]
        public void Convert_1927_Returns_MCMXXVII()
        {
            Assert.AreEqual("MCMXXVII", Converter.Convert(1927));
        }
        [TestMethod]
        public void Convert_1928_Returns_MCMXXVIII()
        {
            Assert.AreEqual("MCMXXVIII", Converter.Convert(1928));
        }
        [TestMethod]
        public void Convert_1929_Returns_MCMXXIX()
        {
            Assert.AreEqual("MCMXXIX", Converter.Convert(1929));
        }
        [TestMethod]
        public void Convert_1930_Returns_MCMXXX()
        {
            Assert.AreEqual("MCMXXX", Converter.Convert(1930));
        }
        [TestMethod]
        public void Convert_1931_Returns_MCMXXXI()
        {
            Assert.AreEqual("MCMXXXI", Converter.Convert(1931));
        }
        [TestMethod]
        public void Convert_1932_Returns_MCMXXXII()
        {
            Assert.AreEqual("MCMXXXII", Converter.Convert(1932));
        }
        [TestMethod]
        public void Convert_1933_Returns_MCMXXXIII()
        {
            Assert.AreEqual("MCMXXXIII", Converter.Convert(1933));
        }
        [TestMethod]
        public void Convert_1934_Returns_MCMXXXIV()
        {
            Assert.AreEqual("MCMXXXIV", Converter.Convert(1934));
        }
        [TestMethod]
        public void Convert_1935_Returns_MCMXXXV()
        {
            Assert.AreEqual("MCMXXXV", Converter.Convert(1935));
        }
        [TestMethod]
        public void Convert_1936_Returns_MCMXXXVI()
        {
            Assert.AreEqual("MCMXXXVI", Converter.Convert(1936));
        }
        [TestMethod]
        public void Convert_1937_Returns_MCMXXXVII()
        {
            Assert.AreEqual("MCMXXXVII", Converter.Convert(1937));
        }
        [TestMethod]
        public void Convert_1938_Returns_MCMXXXVIII()
        {
            Assert.AreEqual("MCMXXXVIII", Converter.Convert(1938));
        }
        [TestMethod]
        public void Convert_1939_Returns_MCMXXXIX()
        {
            Assert.AreEqual("MCMXXXIX", Converter.Convert(1939));
        }
        [TestMethod]
        public void Convert_1940_Returns_MCMXL()
        {
            Assert.AreEqual("MCMXL", Converter.Convert(1940));
        }
        [TestMethod]
        public void Convert_1941_Returns_MCMXLI()
        {
            Assert.AreEqual("MCMXLI", Converter.Convert(1941));
        }
        [TestMethod]
        public void Convert_1942_Returns_MCMXLII()
        {
            Assert.AreEqual("MCMXLII", Converter.Convert(1942));
        }
        [TestMethod]
        public void Convert_1943_Returns_MCMXLIII()
        {
            Assert.AreEqual("MCMXLIII", Converter.Convert(1943));
        }
        [TestMethod]
        public void Convert_1944_Returns_MCMXLIV()
        {
            Assert.AreEqual("MCMXLIV", Converter.Convert(1944));
        }
        [TestMethod]
        public void Convert_1945_Returns_MCMXLV()
        {
            Assert.AreEqual("MCMXLV", Converter.Convert(1945));
        }
        [TestMethod]
        public void Convert_1946_Returns_MCMXLVI()
        {
            Assert.AreEqual("MCMXLVI", Converter.Convert(1946));
        }
        [TestMethod]
        public void Convert_1947_Returns_MCMXLVII()
        {
            Assert.AreEqual("MCMXLVII", Converter.Convert(1947));
        }
        [TestMethod]
        public void Convert_1948_Returns_MCMXLVIII()
        {
            Assert.AreEqual("MCMXLVIII", Converter.Convert(1948));
        }
        [TestMethod]
        public void Convert_1949_Returns_MCMXLIX()
        {
            Assert.AreEqual("MCMXLIX", Converter.Convert(1949));
        }
        [TestMethod]
        public void Convert_1950_Returns_MCML()
        {
            Assert.AreEqual("MCML", Converter.Convert(1950));
        }
        [TestMethod]
        public void Convert_1951_Returns_MCMLI()
        {
            Assert.AreEqual("MCMLI", Converter.Convert(1951));
        }
        [TestMethod]
        public void Convert_1952_Returns_MCMLII()
        {
            Assert.AreEqual("MCMLII", Converter.Convert(1952));
        }
        [TestMethod]
        public void Convert_1953_Returns_MCMLIII()
        {
            Assert.AreEqual("MCMLIII", Converter.Convert(1953));
        }
        [TestMethod]
        public void Convert_1954_Returns_MCMLIV()
        {
            Assert.AreEqual("MCMLIV", Converter.Convert(1954));
        }
        [TestMethod]
        public void Convert_1955_Returns_MCMLV()
        {
            Assert.AreEqual("MCMLV", Converter.Convert(1955));
        }
        [TestMethod]
        public void Convert_1956_Returns_MCMLVI()
        {
            Assert.AreEqual("MCMLVI", Converter.Convert(1956));
        }
        [TestMethod]
        public void Convert_1957_Returns_MCMLVII()
        {
            Assert.AreEqual("MCMLVII", Converter.Convert(1957));
        }
        [TestMethod]
        public void Convert_1958_Returns_MCMLVIII()
        {
            Assert.AreEqual("MCMLVIII", Converter.Convert(1958));
        }
        [TestMethod]
        public void Convert_1959_Returns_MCMLIX()
        {
            Assert.AreEqual("MCMLIX", Converter.Convert(1959));
        }
        [TestMethod]
        public void Convert_1960_Returns_MCMLX()
        {
            Assert.AreEqual("MCMLX", Converter.Convert(1960));
        }
        [TestMethod]
        public void Convert_1961_Returns_MCMLXI()
        {
            Assert.AreEqual("MCMLXI", Converter.Convert(1961));
        }
        [TestMethod]
        public void Convert_1962_Returns_MCMLXII()
        {
            Assert.AreEqual("MCMLXII", Converter.Convert(1962));
        }
        [TestMethod]
        public void Convert_1963_Returns_MCMLXIII()
        {
            Assert.AreEqual("MCMLXIII", Converter.Convert(1963));
        }
        [TestMethod]
        public void Convert_1964_Returns_MCMLXIV()
        {
            Assert.AreEqual("MCMLXIV", Converter.Convert(1964));
        }
        [TestMethod]
        public void Convert_1965_Returns_MCMLXV()
        {
            Assert.AreEqual("MCMLXV", Converter.Convert(1965));
        }
        [TestMethod]
        public void Convert_1966_Returns_MCMLXVI()
        {
            Assert.AreEqual("MCMLXVI", Converter.Convert(1966));
        }
        [TestMethod]
        public void Convert_1967_Returns_MCMLXVII()
        {
            Assert.AreEqual("MCMLXVII", Converter.Convert(1967));
        }
        [TestMethod]
        public void Convert_1968_Returns_MCMLXVIII()
        {
            Assert.AreEqual("MCMLXVIII", Converter.Convert(1968));
        }
        [TestMethod]
        public void Convert_1969_Returns_MCMLXIX()
        {
            Assert.AreEqual("MCMLXIX", Converter.Convert(1969));
        }
        [TestMethod]
        public void Convert_1970_Returns_MCMLXX()
        {
            Assert.AreEqual("MCMLXX", Converter.Convert(1970));
        }
        [TestMethod]
        public void Convert_1971_Returns_MCMLXXI()
        {
            Assert.AreEqual("MCMLXXI", Converter.Convert(1971));
        }
        [TestMethod]
        public void Convert_1972_Returns_MCMLXXII()
        {
            Assert.AreEqual("MCMLXXII", Converter.Convert(1972));
        }
        [TestMethod]
        public void Convert_1973_Returns_MCMLXXIII()
        {
            Assert.AreEqual("MCMLXXIII", Converter.Convert(1973));
        }
        [TestMethod]
        public void Convert_1974_Returns_MCMLXXIV()
        {
            Assert.AreEqual("MCMLXXIV", Converter.Convert(1974));
        }
        [TestMethod]
        public void Convert_1975_Returns_MCMLXXV()
        {
            Assert.AreEqual("MCMLXXV", Converter.Convert(1975));
        }
        [TestMethod]
        public void Convert_1976_Returns_MCMLXXVI()
        {
            Assert.AreEqual("MCMLXXVI", Converter.Convert(1976));
        }
        [TestMethod]
        public void Convert_1977_Returns_MCMLXXVII()
        {
            Assert.AreEqual("MCMLXXVII", Converter.Convert(1977));
        }
        [TestMethod]
        public void Convert_1978_Returns_MCMLXXVIII()
        {
            Assert.AreEqual("MCMLXXVIII", Converter.Convert(1978));
        }
        [TestMethod]
        public void Convert_1979_Returns_MCMLXXIX()
        {
            Assert.AreEqual("MCMLXXIX", Converter.Convert(1979));
        }
        [TestMethod]
        public void Convert_1980_Returns_MCMLXXX()
        {
            Assert.AreEqual("MCMLXXX", Converter.Convert(1980));
        }
        [TestMethod]
        public void Convert_1981_Returns_MCMLXXXI()
        {
            Assert.AreEqual("MCMLXXXI", Converter.Convert(1981));
        }
        [TestMethod]
        public void Convert_1982_Returns_MCMLXXXII()
        {
            Assert.AreEqual("MCMLXXXII", Converter.Convert(1982));
        }
        [TestMethod]
        public void Convert_1983_Returns_MCMLXXXIII()
        {
            Assert.AreEqual("MCMLXXXIII", Converter.Convert(1983));
        }
        [TestMethod]
        public void Convert_1984_Returns_MCMLXXXIV()
        {
            Assert.AreEqual("MCMLXXXIV", Converter.Convert(1984));
        }
        [TestMethod]
        public void Convert_1985_Returns_MCMLXXXV()
        {
            Assert.AreEqual("MCMLXXXV", Converter.Convert(1985));
        }
        [TestMethod]
        public void Convert_1986_Returns_MCMLXXXVI()
        {
            Assert.AreEqual("MCMLXXXVI", Converter.Convert(1986));
        }
        [TestMethod]
        public void Convert_1987_Returns_MCMLXXXVII()
        {
            Assert.AreEqual("MCMLXXXVII", Converter.Convert(1987));
        }
        [TestMethod]
        public void Convert_1988_Returns_MCMLXXXVIII()
        {
            Assert.AreEqual("MCMLXXXVIII", Converter.Convert(1988));
        }
        [TestMethod]
        public void Convert_1989_Returns_MCMLXXXIX()
        {
            Assert.AreEqual("MCMLXXXIX", Converter.Convert(1989));
        }
        [TestMethod]
        public void Convert_1990_Returns_MCMXC()
        {
            Assert.AreEqual("MCMXC", Converter.Convert(1990));
        }
        [TestMethod]
        public void Convert_1991_Returns_MCMXCI()
        {
            Assert.AreEqual("MCMXCI", Converter.Convert(1991));
        }
        [TestMethod]
        public void Convert_1992_Returns_MCMXCII()
        {
            Assert.AreEqual("MCMXCII", Converter.Convert(1992));
        }
        [TestMethod]
        public void Convert_1993_Returns_MCMXCIII()
        {
            Assert.AreEqual("MCMXCIII", Converter.Convert(1993));
        }
        [TestMethod]
        public void Convert_1994_Returns_MCMXCIV()
        {
            Assert.AreEqual("MCMXCIV", Converter.Convert(1994));
        }
        [TestMethod]
        public void Convert_1995_Returns_MCMXCV()
        {
            Assert.AreEqual("MCMXCV", Converter.Convert(1995));
        }
        [TestMethod]
        public void Convert_1996_Returns_MCMXCVI()
        {
            Assert.AreEqual("MCMXCVI", Converter.Convert(1996));
        }
        [TestMethod]
        public void Convert_1997_Returns_MCMXCVII()
        {
            Assert.AreEqual("MCMXCVII", Converter.Convert(1997));
        }
        [TestMethod]
        public void Convert_1998_Returns_MCMXCVIII()
        {
            Assert.AreEqual("MCMXCVIII", Converter.Convert(1998));
        }
        [TestMethod]
        public void Convert_1999_Returns_MCMXCIX()
        {
            Assert.AreEqual("MCMXCIX", Converter.Convert(1999));
        }
        [TestMethod]
        public void Convert_2000_Returns_MM()
        {
            Assert.AreEqual("MM", Converter.Convert(2000));
        }
        [TestMethod]
        public void Convert_2001_Returns_MMI()
        {
            Assert.AreEqual("MMI", Converter.Convert(2001));
        }
        [TestMethod]
        public void Convert_2002_Returns_MMII()
        {
            Assert.AreEqual("MMII", Converter.Convert(2002));
        }
        [TestMethod]
        public void Convert_2003_Returns_MMIII()
        {
            Assert.AreEqual("MMIII", Converter.Convert(2003));
        }
        [TestMethod]
        public void Convert_2004_Returns_MMIV()
        {
            Assert.AreEqual("MMIV", Converter.Convert(2004));
        }
        [TestMethod]
        public void Convert_2005_Returns_MMV()
        {
            Assert.AreEqual("MMV", Converter.Convert(2005));
        }
        [TestMethod]
        public void Convert_2006_Returns_MMVI()
        {
            Assert.AreEqual("MMVI", Converter.Convert(2006));
        }
        [TestMethod]
        public void Convert_2007_Returns_MMVII()
        {
            Assert.AreEqual("MMVII", Converter.Convert(2007));
        }
        [TestMethod]
        public void Convert_2008_Returns_MMVIII()
        {
            Assert.AreEqual("MMVIII", Converter.Convert(2008));
        }
        [TestMethod]
        public void Convert_2009_Returns_MMIX()
        {
            Assert.AreEqual("MMIX", Converter.Convert(2009));
        }
        [TestMethod]
        public void Convert_2010_Returns_MMX()
        {
            Assert.AreEqual("MMX", Converter.Convert(2010));
        }
        [TestMethod]
        public void Convert_2011_Returns_MMXI()
        {
            Assert.AreEqual("MMXI", Converter.Convert(2011));
        }
        [TestMethod]
        public void Convert_2012_Returns_MMXII()
        {
            Assert.AreEqual("MMXII", Converter.Convert(2012));
        }
        [TestMethod]
        public void Convert_2013_Returns_MMXIII()
        {
            Assert.AreEqual("MMXIII", Converter.Convert(2013));
        }
        [TestMethod]
        public void Convert_2014_Returns_MMXIV()
        {
            Assert.AreEqual("MMXIV", Converter.Convert(2014));
        }
        [TestMethod]
        public void Convert_2015_Returns_MMXV()
        {
            Assert.AreEqual("MMXV", Converter.Convert(2015));
        }
        [TestMethod]
        public void Convert_2016_Returns_MMXVI()
        {
            Assert.AreEqual("MMXVI", Converter.Convert(2016));
        }
        [TestMethod]
        public void Convert_2017_Returns_MMXVII()
        {
            Assert.AreEqual("MMXVII", Converter.Convert(2017));
        }
        [TestMethod]
        public void Convert_2018_Returns_MMXVIII()
        {
            Assert.AreEqual("MMXVIII", Converter.Convert(2018));
        }
        [TestMethod]
        public void Convert_2019_Returns_MMXIX()
        {
            Assert.AreEqual("MMXIX", Converter.Convert(2019));
        }
        [TestMethod]
        public void Convert_2020_Returns_MMXX()
        {
            Assert.AreEqual("MMXX", Converter.Convert(2020));
        }
        [TestMethod]
        public void Convert_2021_Returns_MMXXI()
        {
            Assert.AreEqual("MMXXI", Converter.Convert(2021));
        }
        [TestMethod]
        public void Convert_2022_Returns_MMXXII()
        {
            Assert.AreEqual("MMXXII", Converter.Convert(2022));
        }
        [TestMethod]
        public void Convert_2023_Returns_MMXXIII()
        {
            Assert.AreEqual("MMXXIII", Converter.Convert(2023));
        }
        [TestMethod]
        public void Convert_2024_Returns_MMXXIV()
        {
            Assert.AreEqual("MMXXIV", Converter.Convert(2024));
        }
        [TestMethod]
        public void Convert_2025_Returns_MMXXV()
        {
            Assert.AreEqual("MMXXV", Converter.Convert(2025));
        }
        [TestMethod]
        public void Convert_2026_Returns_MMXXVI()
        {
            Assert.AreEqual("MMXXVI", Converter.Convert(2026));
        }
        [TestMethod]
        public void Convert_2027_Returns_MMXXVII()
        {
            Assert.AreEqual("MMXXVII", Converter.Convert(2027));
        }
        [TestMethod]
        public void Convert_2028_Returns_MMXXVIII()
        {
            Assert.AreEqual("MMXXVIII", Converter.Convert(2028));
        }
        [TestMethod]
        public void Convert_2029_Returns_MMXXIX()
        {
            Assert.AreEqual("MMXXIX", Converter.Convert(2029));
        }
        [TestMethod]
        public void Convert_2030_Returns_MMXXX()
        {
            Assert.AreEqual("MMXXX", Converter.Convert(2030));
        }
        [TestMethod]
        public void Convert_2031_Returns_MMXXXI()
        {
            Assert.AreEqual("MMXXXI", Converter.Convert(2031));
        }
        [TestMethod]
        public void Convert_2032_Returns_MMXXXII()
        {
            Assert.AreEqual("MMXXXII", Converter.Convert(2032));
        }
        [TestMethod]
        public void Convert_2033_Returns_MMXXXIII()
        {
            Assert.AreEqual("MMXXXIII", Converter.Convert(2033));
        }
        [TestMethod]
        public void Convert_2034_Returns_MMXXXIV()
        {
            Assert.AreEqual("MMXXXIV", Converter.Convert(2034));
        }
        [TestMethod]
        public void Convert_2035_Returns_MMXXXV()
        {
            Assert.AreEqual("MMXXXV", Converter.Convert(2035));
        }
        [TestMethod]
        public void Convert_2036_Returns_MMXXXVI()
        {
            Assert.AreEqual("MMXXXVI", Converter.Convert(2036));
        }
        [TestMethod]
        public void Convert_2037_Returns_MMXXXVII()
        {
            Assert.AreEqual("MMXXXVII", Converter.Convert(2037));
        }
        [TestMethod]
        public void Convert_2038_Returns_MMXXXVIII()
        {
            Assert.AreEqual("MMXXXVIII", Converter.Convert(2038));
        }
        [TestMethod]
        public void Convert_2039_Returns_MMXXXIX()
        {
            Assert.AreEqual("MMXXXIX", Converter.Convert(2039));
        }
        [TestMethod]
        public void Convert_2040_Returns_MMXL()
        {
            Assert.AreEqual("MMXL", Converter.Convert(2040));
        }
        [TestMethod]
        public void Convert_2041_Returns_MMXLI()
        {
            Assert.AreEqual("MMXLI", Converter.Convert(2041));
        }
        [TestMethod]
        public void Convert_2042_Returns_MMXLII()
        {
            Assert.AreEqual("MMXLII", Converter.Convert(2042));
        }
        [TestMethod]
        public void Convert_2043_Returns_MMXLIII()
        {
            Assert.AreEqual("MMXLIII", Converter.Convert(2043));
        }
        [TestMethod]
        public void Convert_2044_Returns_MMXLIV()
        {
            Assert.AreEqual("MMXLIV", Converter.Convert(2044));
        }
        [TestMethod]
        public void Convert_2045_Returns_MMXLV()
        {
            Assert.AreEqual("MMXLV", Converter.Convert(2045));
        }
        [TestMethod]
        public void Convert_2046_Returns_MMXLVI()
        {
            Assert.AreEqual("MMXLVI", Converter.Convert(2046));
        }
        [TestMethod]
        public void Convert_2047_Returns_MMXLVII()
        {
            Assert.AreEqual("MMXLVII", Converter.Convert(2047));
        }
        [TestMethod]
        public void Convert_2048_Returns_MMXLVIII()
        {
            Assert.AreEqual("MMXLVIII", Converter.Convert(2048));
        }
        [TestMethod]
        public void Convert_2049_Returns_MMXLIX()
        {
            Assert.AreEqual("MMXLIX", Converter.Convert(2049));
        }
        [TestMethod]
        public void Convert_2050_Returns_MML()
        {
            Assert.AreEqual("MML", Converter.Convert(2050));
        }
        [TestMethod]
        public void Convert_2051_Returns_MMLI()
        {
            Assert.AreEqual("MMLI", Converter.Convert(2051));
        }
        [TestMethod]
        public void Convert_2052_Returns_MMLII()
        {
            Assert.AreEqual("MMLII", Converter.Convert(2052));
        }
        [TestMethod]
        public void Convert_2053_Returns_MMLIII()
        {
            Assert.AreEqual("MMLIII", Converter.Convert(2053));
        }
        [TestMethod]
        public void Convert_2054_Returns_MMLIV()
        {
            Assert.AreEqual("MMLIV", Converter.Convert(2054));
        }
        [TestMethod]
        public void Convert_2055_Returns_MMLV()
        {
            Assert.AreEqual("MMLV", Converter.Convert(2055));
        }
        [TestMethod]
        public void Convert_2056_Returns_MMLVI()
        {
            Assert.AreEqual("MMLVI", Converter.Convert(2056));
        }
        [TestMethod]
        public void Convert_2057_Returns_MMLVII()
        {
            Assert.AreEqual("MMLVII", Converter.Convert(2057));
        }
        [TestMethod]
        public void Convert_2058_Returns_MMLVIII()
        {
            Assert.AreEqual("MMLVIII", Converter.Convert(2058));
        }
        [TestMethod]
        public void Convert_2059_Returns_MMLIX()
        {
            Assert.AreEqual("MMLIX", Converter.Convert(2059));
        }
        [TestMethod]
        public void Convert_2060_Returns_MMLX()
        {
            Assert.AreEqual("MMLX", Converter.Convert(2060));
        }
        [TestMethod]
        public void Convert_2061_Returns_MMLXI()
        {
            Assert.AreEqual("MMLXI", Converter.Convert(2061));
        }
        [TestMethod]
        public void Convert_2062_Returns_MMLXII()
        {
            Assert.AreEqual("MMLXII", Converter.Convert(2062));
        }
        [TestMethod]
        public void Convert_2063_Returns_MMLXIII()
        {
            Assert.AreEqual("MMLXIII", Converter.Convert(2063));
        }
        [TestMethod]
        public void Convert_2064_Returns_MMLXIV()
        {
            Assert.AreEqual("MMLXIV", Converter.Convert(2064));
        }
        [TestMethod]
        public void Convert_2065_Returns_MMLXV()
        {
            Assert.AreEqual("MMLXV", Converter.Convert(2065));
        }
        [TestMethod]
        public void Convert_2066_Returns_MMLXVI()
        {
            Assert.AreEqual("MMLXVI", Converter.Convert(2066));
        }
        [TestMethod]
        public void Convert_2067_Returns_MMLXVII()
        {
            Assert.AreEqual("MMLXVII", Converter.Convert(2067));
        }
        [TestMethod]
        public void Convert_2068_Returns_MMLXVIII()
        {
            Assert.AreEqual("MMLXVIII", Converter.Convert(2068));
        }
        [TestMethod]
        public void Convert_2069_Returns_MMLXIX()
        {
            Assert.AreEqual("MMLXIX", Converter.Convert(2069));
        }
        [TestMethod]
        public void Convert_2070_Returns_MMLXX()
        {
            Assert.AreEqual("MMLXX", Converter.Convert(2070));
        }
        [TestMethod]
        public void Convert_2071_Returns_MMLXXI()
        {
            Assert.AreEqual("MMLXXI", Converter.Convert(2071));
        }
        [TestMethod]
        public void Convert_2072_Returns_MMLXXII()
        {
            Assert.AreEqual("MMLXXII", Converter.Convert(2072));
        }
        [TestMethod]
        public void Convert_2073_Returns_MMLXXIII()
        {
            Assert.AreEqual("MMLXXIII", Converter.Convert(2073));
        }
        [TestMethod]
        public void Convert_2074_Returns_MMLXXIV()
        {
            Assert.AreEqual("MMLXXIV", Converter.Convert(2074));
        }
        [TestMethod]
        public void Convert_2075_Returns_MMLXXV()
        {
            Assert.AreEqual("MMLXXV", Converter.Convert(2075));
        }
        [TestMethod]
        public void Convert_2076_Returns_MMLXXVI()
        {
            Assert.AreEqual("MMLXXVI", Converter.Convert(2076));
        }
        [TestMethod]
        public void Convert_2077_Returns_MMLXXVII()
        {
            Assert.AreEqual("MMLXXVII", Converter.Convert(2077));
        }
        [TestMethod]
        public void Convert_2078_Returns_MMLXXVIII()
        {
            Assert.AreEqual("MMLXXVIII", Converter.Convert(2078));
        }
        [TestMethod]
        public void Convert_2079_Returns_MMLXXIX()
        {
            Assert.AreEqual("MMLXXIX", Converter.Convert(2079));
        }
        [TestMethod]
        public void Convert_2080_Returns_MMLXXX()
        {
            Assert.AreEqual("MMLXXX", Converter.Convert(2080));
        }
        [TestMethod]
        public void Convert_2081_Returns_MMLXXXI()
        {
            Assert.AreEqual("MMLXXXI", Converter.Convert(2081));
        }
        [TestMethod]
        public void Convert_2082_Returns_MMLXXXII()
        {
            Assert.AreEqual("MMLXXXII", Converter.Convert(2082));
        }
        [TestMethod]
        public void Convert_2083_Returns_MMLXXXIII()
        {
            Assert.AreEqual("MMLXXXIII", Converter.Convert(2083));
        }
        [TestMethod]
        public void Convert_2084_Returns_MMLXXXIV()
        {
            Assert.AreEqual("MMLXXXIV", Converter.Convert(2084));
        }
        [TestMethod]
        public void Convert_2085_Returns_MMLXXXV()
        {
            Assert.AreEqual("MMLXXXV", Converter.Convert(2085));
        }
        [TestMethod]
        public void Convert_2086_Returns_MMLXXXVI()
        {
            Assert.AreEqual("MMLXXXVI", Converter.Convert(2086));
        }
        [TestMethod]
        public void Convert_2087_Returns_MMLXXXVII()
        {
            Assert.AreEqual("MMLXXXVII", Converter.Convert(2087));
        }
        [TestMethod]
        public void Convert_2088_Returns_MMLXXXVIII()
        {
            Assert.AreEqual("MMLXXXVIII", Converter.Convert(2088));
        }
        [TestMethod]
        public void Convert_2089_Returns_MMLXXXIX()
        {
            Assert.AreEqual("MMLXXXIX", Converter.Convert(2089));
        }
        [TestMethod]
        public void Convert_2090_Returns_MMXC()
        {
            Assert.AreEqual("MMXC", Converter.Convert(2090));
        }
        [TestMethod]
        public void Convert_2091_Returns_MMXCI()
        {
            Assert.AreEqual("MMXCI", Converter.Convert(2091));
        }
        [TestMethod]
        public void Convert_2092_Returns_MMXCII()
        {
            Assert.AreEqual("MMXCII", Converter.Convert(2092));
        }
        [TestMethod]
        public void Convert_2093_Returns_MMXCIII()
        {
            Assert.AreEqual("MMXCIII", Converter.Convert(2093));
        }
        [TestMethod]
        public void Convert_2094_Returns_MMXCIV()
        {
            Assert.AreEqual("MMXCIV", Converter.Convert(2094));
        }
        [TestMethod]
        public void Convert_2095_Returns_MMXCV()
        {
            Assert.AreEqual("MMXCV", Converter.Convert(2095));
        }
        [TestMethod]
        public void Convert_2096_Returns_MMXCVI()
        {
            Assert.AreEqual("MMXCVI", Converter.Convert(2096));
        }
        [TestMethod]
        public void Convert_2097_Returns_MMXCVII()
        {
            Assert.AreEqual("MMXCVII", Converter.Convert(2097));
        }
        [TestMethod]
        public void Convert_2098_Returns_MMXCVIII()
        {
            Assert.AreEqual("MMXCVIII", Converter.Convert(2098));
        }
        [TestMethod]
        public void Convert_2099_Returns_MMXCIX()
        {
            Assert.AreEqual("MMXCIX", Converter.Convert(2099));
        }
        [TestMethod]
        public void Convert_2100_Returns_MMC()
        {
            Assert.AreEqual("MMC", Converter.Convert(2100));
        }
        [TestMethod]
        public void Convert_2101_Returns_MMCI()
        {
            Assert.AreEqual("MMCI", Converter.Convert(2101));
        }
        [TestMethod]
        public void Convert_2102_Returns_MMCII()
        {
            Assert.AreEqual("MMCII", Converter.Convert(2102));
        }
        [TestMethod]
        public void Convert_2103_Returns_MMCIII()
        {
            Assert.AreEqual("MMCIII", Converter.Convert(2103));
        }
        [TestMethod]
        public void Convert_2104_Returns_MMCIV()
        {
            Assert.AreEqual("MMCIV", Converter.Convert(2104));
        }
        [TestMethod]
        public void Convert_2105_Returns_MMCV()
        {
            Assert.AreEqual("MMCV", Converter.Convert(2105));
        }
        [TestMethod]
        public void Convert_2106_Returns_MMCVI()
        {
            Assert.AreEqual("MMCVI", Converter.Convert(2106));
        }
        [TestMethod]
        public void Convert_2107_Returns_MMCVII()
        {
            Assert.AreEqual("MMCVII", Converter.Convert(2107));
        }
        [TestMethod]
        public void Convert_2108_Returns_MMCVIII()
        {
            Assert.AreEqual("MMCVIII", Converter.Convert(2108));
        }
        [TestMethod]
        public void Convert_2109_Returns_MMCIX()
        {
            Assert.AreEqual("MMCIX", Converter.Convert(2109));
        }
        [TestMethod]
        public void Convert_2110_Returns_MMCX()
        {
            Assert.AreEqual("MMCX", Converter.Convert(2110));
        }
        [TestMethod]
        public void Convert_2111_Returns_MMCXI()
        {
            Assert.AreEqual("MMCXI", Converter.Convert(2111));
        }
        [TestMethod]
        public void Convert_2112_Returns_MMCXII()
        {
            Assert.AreEqual("MMCXII", Converter.Convert(2112));
        }
        [TestMethod]
        public void Convert_2113_Returns_MMCXIII()
        {
            Assert.AreEqual("MMCXIII", Converter.Convert(2113));
        }
        [TestMethod]
        public void Convert_2114_Returns_MMCXIV()
        {
            Assert.AreEqual("MMCXIV", Converter.Convert(2114));
        }
        [TestMethod]
        public void Convert_2115_Returns_MMCXV()
        {
            Assert.AreEqual("MMCXV", Converter.Convert(2115));
        }
        [TestMethod]
        public void Convert_2116_Returns_MMCXVI()
        {
            Assert.AreEqual("MMCXVI", Converter.Convert(2116));
        }
        [TestMethod]
        public void Convert_2117_Returns_MMCXVII()
        {
            Assert.AreEqual("MMCXVII", Converter.Convert(2117));
        }
        [TestMethod]
        public void Convert_2118_Returns_MMCXVIII()
        {
            Assert.AreEqual("MMCXVIII", Converter.Convert(2118));
        }
        [TestMethod]
        public void Convert_2119_Returns_MMCXIX()
        {
            Assert.AreEqual("MMCXIX", Converter.Convert(2119));
        }
        [TestMethod]
        public void Convert_2120_Returns_MMCXX()
        {
            Assert.AreEqual("MMCXX", Converter.Convert(2120));
        }
        [TestMethod]
        public void Convert_2121_Returns_MMCXXI()
        {
            Assert.AreEqual("MMCXXI", Converter.Convert(2121));
        }
        [TestMethod]
        public void Convert_2122_Returns_MMCXXII()
        {
            Assert.AreEqual("MMCXXII", Converter.Convert(2122));
        }
        [TestMethod]
        public void Convert_2123_Returns_MMCXXIII()
        {
            Assert.AreEqual("MMCXXIII", Converter.Convert(2123));
        }
        [TestMethod]
        public void Convert_2124_Returns_MMCXXIV()
        {
            Assert.AreEqual("MMCXXIV", Converter.Convert(2124));
        }
        [TestMethod]
        public void Convert_2125_Returns_MMCXXV()
        {
            Assert.AreEqual("MMCXXV", Converter.Convert(2125));
        }
        [TestMethod]
        public void Convert_2126_Returns_MMCXXVI()
        {
            Assert.AreEqual("MMCXXVI", Converter.Convert(2126));
        }
        [TestMethod]
        public void Convert_2127_Returns_MMCXXVII()
        {
            Assert.AreEqual("MMCXXVII", Converter.Convert(2127));
        }
        [TestMethod]
        public void Convert_2128_Returns_MMCXXVIII()
        {
            Assert.AreEqual("MMCXXVIII", Converter.Convert(2128));
        }
        [TestMethod]
        public void Convert_2129_Returns_MMCXXIX()
        {
            Assert.AreEqual("MMCXXIX", Converter.Convert(2129));
        }
        [TestMethod]
        public void Convert_2130_Returns_MMCXXX()
        {
            Assert.AreEqual("MMCXXX", Converter.Convert(2130));
        }
        [TestMethod]
        public void Convert_2131_Returns_MMCXXXI()
        {
            Assert.AreEqual("MMCXXXI", Converter.Convert(2131));
        }
        [TestMethod]
        public void Convert_2132_Returns_MMCXXXII()
        {
            Assert.AreEqual("MMCXXXII", Converter.Convert(2132));
        }
        [TestMethod]
        public void Convert_2133_Returns_MMCXXXIII()
        {
            Assert.AreEqual("MMCXXXIII", Converter.Convert(2133));
        }
        [TestMethod]
        public void Convert_2134_Returns_MMCXXXIV()
        {
            Assert.AreEqual("MMCXXXIV", Converter.Convert(2134));
        }
        [TestMethod]
        public void Convert_2135_Returns_MMCXXXV()
        {
            Assert.AreEqual("MMCXXXV", Converter.Convert(2135));
        }
        [TestMethod]
        public void Convert_2136_Returns_MMCXXXVI()
        {
            Assert.AreEqual("MMCXXXVI", Converter.Convert(2136));
        }
        [TestMethod]
        public void Convert_2137_Returns_MMCXXXVII()
        {
            Assert.AreEqual("MMCXXXVII", Converter.Convert(2137));
        }
        [TestMethod]
        public void Convert_2138_Returns_MMCXXXVIII()
        {
            Assert.AreEqual("MMCXXXVIII", Converter.Convert(2138));
        }
        [TestMethod]
        public void Convert_2139_Returns_MMCXXXIX()
        {
            Assert.AreEqual("MMCXXXIX", Converter.Convert(2139));
        }
        [TestMethod]
        public void Convert_2140_Returns_MMCXL()
        {
            Assert.AreEqual("MMCXL", Converter.Convert(2140));
        }
        [TestMethod]
        public void Convert_2141_Returns_MMCXLI()
        {
            Assert.AreEqual("MMCXLI", Converter.Convert(2141));
        }
        [TestMethod]
        public void Convert_2142_Returns_MMCXLII()
        {
            Assert.AreEqual("MMCXLII", Converter.Convert(2142));
        }
        [TestMethod]
        public void Convert_2143_Returns_MMCXLIII()
        {
            Assert.AreEqual("MMCXLIII", Converter.Convert(2143));
        }
        [TestMethod]
        public void Convert_2144_Returns_MMCXLIV()
        {
            Assert.AreEqual("MMCXLIV", Converter.Convert(2144));
        }
        [TestMethod]
        public void Convert_2145_Returns_MMCXLV()
        {
            Assert.AreEqual("MMCXLV", Converter.Convert(2145));
        }
        [TestMethod]
        public void Convert_2146_Returns_MMCXLVI()
        {
            Assert.AreEqual("MMCXLVI", Converter.Convert(2146));
        }
        [TestMethod]
        public void Convert_2147_Returns_MMCXLVII()
        {
            Assert.AreEqual("MMCXLVII", Converter.Convert(2147));
        }
        [TestMethod]
        public void Convert_2148_Returns_MMCXLVIII()
        {
            Assert.AreEqual("MMCXLVIII", Converter.Convert(2148));
        }
        [TestMethod]
        public void Convert_2149_Returns_MMCXLIX()
        {
            Assert.AreEqual("MMCXLIX", Converter.Convert(2149));
        }
        [TestMethod]
        public void Convert_2150_Returns_MMCL()
        {
            Assert.AreEqual("MMCL", Converter.Convert(2150));
        }
        [TestMethod]
        public void Convert_2151_Returns_MMCLI()
        {
            Assert.AreEqual("MMCLI", Converter.Convert(2151));
        }
        [TestMethod]
        public void Convert_2152_Returns_MMCLII()
        {
            Assert.AreEqual("MMCLII", Converter.Convert(2152));
        }
        [TestMethod]
        public void Convert_2153_Returns_MMCLIII()
        {
            Assert.AreEqual("MMCLIII", Converter.Convert(2153));
        }
        [TestMethod]
        public void Convert_2154_Returns_MMCLIV()
        {
            Assert.AreEqual("MMCLIV", Converter.Convert(2154));
        }
        [TestMethod]
        public void Convert_2155_Returns_MMCLV()
        {
            Assert.AreEqual("MMCLV", Converter.Convert(2155));
        }
        [TestMethod]
        public void Convert_2156_Returns_MMCLVI()
        {
            Assert.AreEqual("MMCLVI", Converter.Convert(2156));
        }
        [TestMethod]
        public void Convert_2157_Returns_MMCLVII()
        {
            Assert.AreEqual("MMCLVII", Converter.Convert(2157));
        }
        [TestMethod]
        public void Convert_2158_Returns_MMCLVIII()
        {
            Assert.AreEqual("MMCLVIII", Converter.Convert(2158));
        }
        [TestMethod]
        public void Convert_2159_Returns_MMCLIX()
        {
            Assert.AreEqual("MMCLIX", Converter.Convert(2159));
        }
        [TestMethod]
        public void Convert_2160_Returns_MMCLX()
        {
            Assert.AreEqual("MMCLX", Converter.Convert(2160));
        }
        [TestMethod]
        public void Convert_2161_Returns_MMCLXI()
        {
            Assert.AreEqual("MMCLXI", Converter.Convert(2161));
        }
        [TestMethod]
        public void Convert_2162_Returns_MMCLXII()
        {
            Assert.AreEqual("MMCLXII", Converter.Convert(2162));
        }
        [TestMethod]
        public void Convert_2163_Returns_MMCLXIII()
        {
            Assert.AreEqual("MMCLXIII", Converter.Convert(2163));
        }
        [TestMethod]
        public void Convert_2164_Returns_MMCLXIV()
        {
            Assert.AreEqual("MMCLXIV", Converter.Convert(2164));
        }
        [TestMethod]
        public void Convert_2165_Returns_MMCLXV()
        {
            Assert.AreEqual("MMCLXV", Converter.Convert(2165));
        }
        [TestMethod]
        public void Convert_2166_Returns_MMCLXVI()
        {
            Assert.AreEqual("MMCLXVI", Converter.Convert(2166));
        }
        [TestMethod]
        public void Convert_2167_Returns_MMCLXVII()
        {
            Assert.AreEqual("MMCLXVII", Converter.Convert(2167));
        }
        [TestMethod]
        public void Convert_2168_Returns_MMCLXVIII()
        {
            Assert.AreEqual("MMCLXVIII", Converter.Convert(2168));
        }
        [TestMethod]
        public void Convert_2169_Returns_MMCLXIX()
        {
            Assert.AreEqual("MMCLXIX", Converter.Convert(2169));
        }
        [TestMethod]
        public void Convert_2170_Returns_MMCLXX()
        {
            Assert.AreEqual("MMCLXX", Converter.Convert(2170));
        }
        [TestMethod]
        public void Convert_2171_Returns_MMCLXXI()
        {
            Assert.AreEqual("MMCLXXI", Converter.Convert(2171));
        }
        [TestMethod]
        public void Convert_2172_Returns_MMCLXXII()
        {
            Assert.AreEqual("MMCLXXII", Converter.Convert(2172));
        }
        [TestMethod]
        public void Convert_2173_Returns_MMCLXXIII()
        {
            Assert.AreEqual("MMCLXXIII", Converter.Convert(2173));
        }
        [TestMethod]
        public void Convert_2174_Returns_MMCLXXIV()
        {
            Assert.AreEqual("MMCLXXIV", Converter.Convert(2174));
        }
        [TestMethod]
        public void Convert_2175_Returns_MMCLXXV()
        {
            Assert.AreEqual("MMCLXXV", Converter.Convert(2175));
        }
        [TestMethod]
        public void Convert_2176_Returns_MMCLXXVI()
        {
            Assert.AreEqual("MMCLXXVI", Converter.Convert(2176));
        }
        [TestMethod]
        public void Convert_2177_Returns_MMCLXXVII()
        {
            Assert.AreEqual("MMCLXXVII", Converter.Convert(2177));
        }
        [TestMethod]
        public void Convert_2178_Returns_MMCLXXVIII()
        {
            Assert.AreEqual("MMCLXXVIII", Converter.Convert(2178));
        }
        [TestMethod]
        public void Convert_2179_Returns_MMCLXXIX()
        {
            Assert.AreEqual("MMCLXXIX", Converter.Convert(2179));
        }
        [TestMethod]
        public void Convert_2180_Returns_MMCLXXX()
        {
            Assert.AreEqual("MMCLXXX", Converter.Convert(2180));
        }
        [TestMethod]
        public void Convert_2181_Returns_MMCLXXXI()
        {
            Assert.AreEqual("MMCLXXXI", Converter.Convert(2181));
        }
        [TestMethod]
        public void Convert_2182_Returns_MMCLXXXII()
        {
            Assert.AreEqual("MMCLXXXII", Converter.Convert(2182));
        }
        [TestMethod]
        public void Convert_2183_Returns_MMCLXXXIII()
        {
            Assert.AreEqual("MMCLXXXIII", Converter.Convert(2183));
        }
        [TestMethod]
        public void Convert_2184_Returns_MMCLXXXIV()
        {
            Assert.AreEqual("MMCLXXXIV", Converter.Convert(2184));
        }
        [TestMethod]
        public void Convert_2185_Returns_MMCLXXXV()
        {
            Assert.AreEqual("MMCLXXXV", Converter.Convert(2185));
        }
        [TestMethod]
        public void Convert_2186_Returns_MMCLXXXVI()
        {
            Assert.AreEqual("MMCLXXXVI", Converter.Convert(2186));
        }
        [TestMethod]
        public void Convert_2187_Returns_MMCLXXXVII()
        {
            Assert.AreEqual("MMCLXXXVII", Converter.Convert(2187));
        }
        [TestMethod]
        public void Convert_2188_Returns_MMCLXXXVIII()
        {
            Assert.AreEqual("MMCLXXXVIII", Converter.Convert(2188));
        }
        [TestMethod]
        public void Convert_2189_Returns_MMCLXXXIX()
        {
            Assert.AreEqual("MMCLXXXIX", Converter.Convert(2189));
        }
        [TestMethod]
        public void Convert_2190_Returns_MMCXC()
        {
            Assert.AreEqual("MMCXC", Converter.Convert(2190));
        }
        [TestMethod]
        public void Convert_2191_Returns_MMCXCI()
        {
            Assert.AreEqual("MMCXCI", Converter.Convert(2191));
        }
        [TestMethod]
        public void Convert_2192_Returns_MMCXCII()
        {
            Assert.AreEqual("MMCXCII", Converter.Convert(2192));
        }
        [TestMethod]
        public void Convert_2193_Returns_MMCXCIII()
        {
            Assert.AreEqual("MMCXCIII", Converter.Convert(2193));
        }
        [TestMethod]
        public void Convert_2194_Returns_MMCXCIV()
        {
            Assert.AreEqual("MMCXCIV", Converter.Convert(2194));
        }
        [TestMethod]
        public void Convert_2195_Returns_MMCXCV()
        {
            Assert.AreEqual("MMCXCV", Converter.Convert(2195));
        }
        [TestMethod]
        public void Convert_2196_Returns_MMCXCVI()
        {
            Assert.AreEqual("MMCXCVI", Converter.Convert(2196));
        }
        [TestMethod]
        public void Convert_2197_Returns_MMCXCVII()
        {
            Assert.AreEqual("MMCXCVII", Converter.Convert(2197));
        }
        [TestMethod]
        public void Convert_2198_Returns_MMCXCVIII()
        {
            Assert.AreEqual("MMCXCVIII", Converter.Convert(2198));
        }
        [TestMethod]
        public void Convert_2199_Returns_MMCXCIX()
        {
            Assert.AreEqual("MMCXCIX", Converter.Convert(2199));
        }
        [TestMethod]
        public void Convert_2200_Returns_MMCC()
        {
            Assert.AreEqual("MMCC", Converter.Convert(2200));
        }
        [TestMethod]
        public void Convert_2201_Returns_MMCCI()
        {
            Assert.AreEqual("MMCCI", Converter.Convert(2201));
        }
        [TestMethod]
        public void Convert_2202_Returns_MMCCII()
        {
            Assert.AreEqual("MMCCII", Converter.Convert(2202));
        }
        [TestMethod]
        public void Convert_2203_Returns_MMCCIII()
        {
            Assert.AreEqual("MMCCIII", Converter.Convert(2203));
        }
        [TestMethod]
        public void Convert_2204_Returns_MMCCIV()
        {
            Assert.AreEqual("MMCCIV", Converter.Convert(2204));
        }
        [TestMethod]
        public void Convert_2205_Returns_MMCCV()
        {
            Assert.AreEqual("MMCCV", Converter.Convert(2205));
        }
        [TestMethod]
        public void Convert_2206_Returns_MMCCVI()
        {
            Assert.AreEqual("MMCCVI", Converter.Convert(2206));
        }
        [TestMethod]
        public void Convert_2207_Returns_MMCCVII()
        {
            Assert.AreEqual("MMCCVII", Converter.Convert(2207));
        }
        [TestMethod]
        public void Convert_2208_Returns_MMCCVIII()
        {
            Assert.AreEqual("MMCCVIII", Converter.Convert(2208));
        }
        [TestMethod]
        public void Convert_2209_Returns_MMCCIX()
        {
            Assert.AreEqual("MMCCIX", Converter.Convert(2209));
        }
        [TestMethod]
        public void Convert_2210_Returns_MMCCX()
        {
            Assert.AreEqual("MMCCX", Converter.Convert(2210));
        }
        [TestMethod]
        public void Convert_2211_Returns_MMCCXI()
        {
            Assert.AreEqual("MMCCXI", Converter.Convert(2211));
        }
        [TestMethod]
        public void Convert_2212_Returns_MMCCXII()
        {
            Assert.AreEqual("MMCCXII", Converter.Convert(2212));
        }
        [TestMethod]
        public void Convert_2213_Returns_MMCCXIII()
        {
            Assert.AreEqual("MMCCXIII", Converter.Convert(2213));
        }
        [TestMethod]
        public void Convert_2214_Returns_MMCCXIV()
        {
            Assert.AreEqual("MMCCXIV", Converter.Convert(2214));
        }
        [TestMethod]
        public void Convert_2215_Returns_MMCCXV()
        {
            Assert.AreEqual("MMCCXV", Converter.Convert(2215));
        }
        [TestMethod]
        public void Convert_2216_Returns_MMCCXVI()
        {
            Assert.AreEqual("MMCCXVI", Converter.Convert(2216));
        }
        [TestMethod]
        public void Convert_2217_Returns_MMCCXVII()
        {
            Assert.AreEqual("MMCCXVII", Converter.Convert(2217));
        }
        [TestMethod]
        public void Convert_2218_Returns_MMCCXVIII()
        {
            Assert.AreEqual("MMCCXVIII", Converter.Convert(2218));
        }
        [TestMethod]
        public void Convert_2219_Returns_MMCCXIX()
        {
            Assert.AreEqual("MMCCXIX", Converter.Convert(2219));
        }
        [TestMethod]
        public void Convert_2220_Returns_MMCCXX()
        {
            Assert.AreEqual("MMCCXX", Converter.Convert(2220));
        }
        [TestMethod]
        public void Convert_2221_Returns_MMCCXXI()
        {
            Assert.AreEqual("MMCCXXI", Converter.Convert(2221));
        }
        [TestMethod]
        public void Convert_2222_Returns_MMCCXXII()
        {
            Assert.AreEqual("MMCCXXII", Converter.Convert(2222));
        }
        [TestMethod]
        public void Convert_2223_Returns_MMCCXXIII()
        {
            Assert.AreEqual("MMCCXXIII", Converter.Convert(2223));
        }
        [TestMethod]
        public void Convert_2224_Returns_MMCCXXIV()
        {
            Assert.AreEqual("MMCCXXIV", Converter.Convert(2224));
        }
        [TestMethod]
        public void Convert_2225_Returns_MMCCXXV()
        {
            Assert.AreEqual("MMCCXXV", Converter.Convert(2225));
        }
        [TestMethod]
        public void Convert_2226_Returns_MMCCXXVI()
        {
            Assert.AreEqual("MMCCXXVI", Converter.Convert(2226));
        }
        [TestMethod]
        public void Convert_2227_Returns_MMCCXXVII()
        {
            Assert.AreEqual("MMCCXXVII", Converter.Convert(2227));
        }
        [TestMethod]
        public void Convert_2228_Returns_MMCCXXVIII()
        {
            Assert.AreEqual("MMCCXXVIII", Converter.Convert(2228));
        }
        [TestMethod]
        public void Convert_2229_Returns_MMCCXXIX()
        {
            Assert.AreEqual("MMCCXXIX", Converter.Convert(2229));
        }
        [TestMethod]
        public void Convert_2230_Returns_MMCCXXX()
        {
            Assert.AreEqual("MMCCXXX", Converter.Convert(2230));
        }
        [TestMethod]
        public void Convert_2231_Returns_MMCCXXXI()
        {
            Assert.AreEqual("MMCCXXXI", Converter.Convert(2231));
        }
        [TestMethod]
        public void Convert_2232_Returns_MMCCXXXII()
        {
            Assert.AreEqual("MMCCXXXII", Converter.Convert(2232));
        }
        [TestMethod]
        public void Convert_2233_Returns_MMCCXXXIII()
        {
            Assert.AreEqual("MMCCXXXIII", Converter.Convert(2233));
        }
        [TestMethod]
        public void Convert_2234_Returns_MMCCXXXIV()
        {
            Assert.AreEqual("MMCCXXXIV", Converter.Convert(2234));
        }
        [TestMethod]
        public void Convert_2235_Returns_MMCCXXXV()
        {
            Assert.AreEqual("MMCCXXXV", Converter.Convert(2235));
        }
        [TestMethod]
        public void Convert_2236_Returns_MMCCXXXVI()
        {
            Assert.AreEqual("MMCCXXXVI", Converter.Convert(2236));
        }
        [TestMethod]
        public void Convert_2237_Returns_MMCCXXXVII()
        {
            Assert.AreEqual("MMCCXXXVII", Converter.Convert(2237));
        }
        [TestMethod]
        public void Convert_2238_Returns_MMCCXXXVIII()
        {
            Assert.AreEqual("MMCCXXXVIII", Converter.Convert(2238));
        }
        [TestMethod]
        public void Convert_2239_Returns_MMCCXXXIX()
        {
            Assert.AreEqual("MMCCXXXIX", Converter.Convert(2239));
        }
        [TestMethod]
        public void Convert_2240_Returns_MMCCXL()
        {
            Assert.AreEqual("MMCCXL", Converter.Convert(2240));
        }
        [TestMethod]
        public void Convert_2241_Returns_MMCCXLI()
        {
            Assert.AreEqual("MMCCXLI", Converter.Convert(2241));
        }
        [TestMethod]
        public void Convert_2242_Returns_MMCCXLII()
        {
            Assert.AreEqual("MMCCXLII", Converter.Convert(2242));
        }
        [TestMethod]
        public void Convert_2243_Returns_MMCCXLIII()
        {
            Assert.AreEqual("MMCCXLIII", Converter.Convert(2243));
        }
        [TestMethod]
        public void Convert_2244_Returns_MMCCXLIV()
        {
            Assert.AreEqual("MMCCXLIV", Converter.Convert(2244));
        }
        [TestMethod]
        public void Convert_2245_Returns_MMCCXLV()
        {
            Assert.AreEqual("MMCCXLV", Converter.Convert(2245));
        }
        [TestMethod]
        public void Convert_2246_Returns_MMCCXLVI()
        {
            Assert.AreEqual("MMCCXLVI", Converter.Convert(2246));
        }
        [TestMethod]
        public void Convert_2247_Returns_MMCCXLVII()
        {
            Assert.AreEqual("MMCCXLVII", Converter.Convert(2247));
        }
        [TestMethod]
        public void Convert_2248_Returns_MMCCXLVIII()
        {
            Assert.AreEqual("MMCCXLVIII", Converter.Convert(2248));
        }
        [TestMethod]
        public void Convert_2249_Returns_MMCCXLIX()
        {
            Assert.AreEqual("MMCCXLIX", Converter.Convert(2249));
        }
        [TestMethod]
        public void Convert_2250_Returns_MMCCL()
        {
            Assert.AreEqual("MMCCL", Converter.Convert(2250));
        }
        [TestMethod]
        public void Convert_2251_Returns_MMCCLI()
        {
            Assert.AreEqual("MMCCLI", Converter.Convert(2251));
        }
        [TestMethod]
        public void Convert_2252_Returns_MMCCLII()
        {
            Assert.AreEqual("MMCCLII", Converter.Convert(2252));
        }
        [TestMethod]
        public void Convert_2253_Returns_MMCCLIII()
        {
            Assert.AreEqual("MMCCLIII", Converter.Convert(2253));
        }
        [TestMethod]
        public void Convert_2254_Returns_MMCCLIV()
        {
            Assert.AreEqual("MMCCLIV", Converter.Convert(2254));
        }
        [TestMethod]
        public void Convert_2255_Returns_MMCCLV()
        {
            Assert.AreEqual("MMCCLV", Converter.Convert(2255));
        }
        [TestMethod]
        public void Convert_2256_Returns_MMCCLVI()
        {
            Assert.AreEqual("MMCCLVI", Converter.Convert(2256));
        }
        [TestMethod]
        public void Convert_2257_Returns_MMCCLVII()
        {
            Assert.AreEqual("MMCCLVII", Converter.Convert(2257));
        }
        [TestMethod]
        public void Convert_2258_Returns_MMCCLVIII()
        {
            Assert.AreEqual("MMCCLVIII", Converter.Convert(2258));
        }
        [TestMethod]
        public void Convert_2259_Returns_MMCCLIX()
        {
            Assert.AreEqual("MMCCLIX", Converter.Convert(2259));
        }
        [TestMethod]
        public void Convert_2260_Returns_MMCCLX()
        {
            Assert.AreEqual("MMCCLX", Converter.Convert(2260));
        }
        [TestMethod]
        public void Convert_2261_Returns_MMCCLXI()
        {
            Assert.AreEqual("MMCCLXI", Converter.Convert(2261));
        }
        [TestMethod]
        public void Convert_2262_Returns_MMCCLXII()
        {
            Assert.AreEqual("MMCCLXII", Converter.Convert(2262));
        }
        [TestMethod]
        public void Convert_2263_Returns_MMCCLXIII()
        {
            Assert.AreEqual("MMCCLXIII", Converter.Convert(2263));
        }
        [TestMethod]
        public void Convert_2264_Returns_MMCCLXIV()
        {
            Assert.AreEqual("MMCCLXIV", Converter.Convert(2264));
        }
        [TestMethod]
        public void Convert_2265_Returns_MMCCLXV()
        {
            Assert.AreEqual("MMCCLXV", Converter.Convert(2265));
        }
        [TestMethod]
        public void Convert_2266_Returns_MMCCLXVI()
        {
            Assert.AreEqual("MMCCLXVI", Converter.Convert(2266));
        }
        [TestMethod]
        public void Convert_2267_Returns_MMCCLXVII()
        {
            Assert.AreEqual("MMCCLXVII", Converter.Convert(2267));
        }
        [TestMethod]
        public void Convert_2268_Returns_MMCCLXVIII()
        {
            Assert.AreEqual("MMCCLXVIII", Converter.Convert(2268));
        }
        [TestMethod]
        public void Convert_2269_Returns_MMCCLXIX()
        {
            Assert.AreEqual("MMCCLXIX", Converter.Convert(2269));
        }
        [TestMethod]
        public void Convert_2270_Returns_MMCCLXX()
        {
            Assert.AreEqual("MMCCLXX", Converter.Convert(2270));
        }
        [TestMethod]
        public void Convert_2271_Returns_MMCCLXXI()
        {
            Assert.AreEqual("MMCCLXXI", Converter.Convert(2271));
        }
        [TestMethod]
        public void Convert_2272_Returns_MMCCLXXII()
        {
            Assert.AreEqual("MMCCLXXII", Converter.Convert(2272));
        }
        [TestMethod]
        public void Convert_2273_Returns_MMCCLXXIII()
        {
            Assert.AreEqual("MMCCLXXIII", Converter.Convert(2273));
        }
        [TestMethod]
        public void Convert_2274_Returns_MMCCLXXIV()
        {
            Assert.AreEqual("MMCCLXXIV", Converter.Convert(2274));
        }
        [TestMethod]
        public void Convert_2275_Returns_MMCCLXXV()
        {
            Assert.AreEqual("MMCCLXXV", Converter.Convert(2275));
        }
        [TestMethod]
        public void Convert_2276_Returns_MMCCLXXVI()
        {
            Assert.AreEqual("MMCCLXXVI", Converter.Convert(2276));
        }
        [TestMethod]
        public void Convert_2277_Returns_MMCCLXXVII()
        {
            Assert.AreEqual("MMCCLXXVII", Converter.Convert(2277));
        }
        [TestMethod]
        public void Convert_2278_Returns_MMCCLXXVIII()
        {
            Assert.AreEqual("MMCCLXXVIII", Converter.Convert(2278));
        }
        [TestMethod]
        public void Convert_2279_Returns_MMCCLXXIX()
        {
            Assert.AreEqual("MMCCLXXIX", Converter.Convert(2279));
        }
        [TestMethod]
        public void Convert_2280_Returns_MMCCLXXX()
        {
            Assert.AreEqual("MMCCLXXX", Converter.Convert(2280));
        }
        [TestMethod]
        public void Convert_2281_Returns_MMCCLXXXI()
        {
            Assert.AreEqual("MMCCLXXXI", Converter.Convert(2281));
        }
        [TestMethod]
        public void Convert_2282_Returns_MMCCLXXXII()
        {
            Assert.AreEqual("MMCCLXXXII", Converter.Convert(2282));
        }
        [TestMethod]
        public void Convert_2283_Returns_MMCCLXXXIII()
        {
            Assert.AreEqual("MMCCLXXXIII", Converter.Convert(2283));
        }
        [TestMethod]
        public void Convert_2284_Returns_MMCCLXXXIV()
        {
            Assert.AreEqual("MMCCLXXXIV", Converter.Convert(2284));
        }
        [TestMethod]
        public void Convert_2285_Returns_MMCCLXXXV()
        {
            Assert.AreEqual("MMCCLXXXV", Converter.Convert(2285));
        }
        [TestMethod]
        public void Convert_2286_Returns_MMCCLXXXVI()
        {
            Assert.AreEqual("MMCCLXXXVI", Converter.Convert(2286));
        }
        [TestMethod]
        public void Convert_2287_Returns_MMCCLXXXVII()
        {
            Assert.AreEqual("MMCCLXXXVII", Converter.Convert(2287));
        }
        [TestMethod]
        public void Convert_2288_Returns_MMCCLXXXVIII()
        {
            Assert.AreEqual("MMCCLXXXVIII", Converter.Convert(2288));
        }
        [TestMethod]
        public void Convert_2289_Returns_MMCCLXXXIX()
        {
            Assert.AreEqual("MMCCLXXXIX", Converter.Convert(2289));
        }
        [TestMethod]
        public void Convert_2290_Returns_MMCCXC()
        {
            Assert.AreEqual("MMCCXC", Converter.Convert(2290));
        }
        [TestMethod]
        public void Convert_2291_Returns_MMCCXCI()
        {
            Assert.AreEqual("MMCCXCI", Converter.Convert(2291));
        }
        [TestMethod]
        public void Convert_2292_Returns_MMCCXCII()
        {
            Assert.AreEqual("MMCCXCII", Converter.Convert(2292));
        }
        [TestMethod]
        public void Convert_2293_Returns_MMCCXCIII()
        {
            Assert.AreEqual("MMCCXCIII", Converter.Convert(2293));
        }
        [TestMethod]
        public void Convert_2294_Returns_MMCCXCIV()
        {
            Assert.AreEqual("MMCCXCIV", Converter.Convert(2294));
        }
        [TestMethod]
        public void Convert_2295_Returns_MMCCXCV()
        {
            Assert.AreEqual("MMCCXCV", Converter.Convert(2295));
        }
        [TestMethod]
        public void Convert_2296_Returns_MMCCXCVI()
        {
            Assert.AreEqual("MMCCXCVI", Converter.Convert(2296));
        }
        [TestMethod]
        public void Convert_2297_Returns_MMCCXCVII()
        {
            Assert.AreEqual("MMCCXCVII", Converter.Convert(2297));
        }
        [TestMethod]
        public void Convert_2298_Returns_MMCCXCVIII()
        {
            Assert.AreEqual("MMCCXCVIII", Converter.Convert(2298));
        }
        [TestMethod]
        public void Convert_2299_Returns_MMCCXCIX()
        {
            Assert.AreEqual("MMCCXCIX", Converter.Convert(2299));
        }
        [TestMethod]
        public void Convert_2300_Returns_MMCCC()
        {
            Assert.AreEqual("MMCCC", Converter.Convert(2300));
        }
        [TestMethod]
        public void Convert_2301_Returns_MMCCCI()
        {
            Assert.AreEqual("MMCCCI", Converter.Convert(2301));
        }
        [TestMethod]
        public void Convert_2302_Returns_MMCCCII()
        {
            Assert.AreEqual("MMCCCII", Converter.Convert(2302));
        }
        [TestMethod]
        public void Convert_2303_Returns_MMCCCIII()
        {
            Assert.AreEqual("MMCCCIII", Converter.Convert(2303));
        }
        [TestMethod]
        public void Convert_2304_Returns_MMCCCIV()
        {
            Assert.AreEqual("MMCCCIV", Converter.Convert(2304));
        }
        [TestMethod]
        public void Convert_2305_Returns_MMCCCV()
        {
            Assert.AreEqual("MMCCCV", Converter.Convert(2305));
        }
        [TestMethod]
        public void Convert_2306_Returns_MMCCCVI()
        {
            Assert.AreEqual("MMCCCVI", Converter.Convert(2306));
        }
        [TestMethod]
        public void Convert_2307_Returns_MMCCCVII()
        {
            Assert.AreEqual("MMCCCVII", Converter.Convert(2307));
        }
        [TestMethod]
        public void Convert_2308_Returns_MMCCCVIII()
        {
            Assert.AreEqual("MMCCCVIII", Converter.Convert(2308));
        }
        [TestMethod]
        public void Convert_2309_Returns_MMCCCIX()
        {
            Assert.AreEqual("MMCCCIX", Converter.Convert(2309));
        }
        [TestMethod]
        public void Convert_2310_Returns_MMCCCX()
        {
            Assert.AreEqual("MMCCCX", Converter.Convert(2310));
        }
        [TestMethod]
        public void Convert_2311_Returns_MMCCCXI()
        {
            Assert.AreEqual("MMCCCXI", Converter.Convert(2311));
        }
        [TestMethod]
        public void Convert_2312_Returns_MMCCCXII()
        {
            Assert.AreEqual("MMCCCXII", Converter.Convert(2312));
        }
        [TestMethod]
        public void Convert_2313_Returns_MMCCCXIII()
        {
            Assert.AreEqual("MMCCCXIII", Converter.Convert(2313));
        }
        [TestMethod]
        public void Convert_2314_Returns_MMCCCXIV()
        {
            Assert.AreEqual("MMCCCXIV", Converter.Convert(2314));
        }
        [TestMethod]
        public void Convert_2315_Returns_MMCCCXV()
        {
            Assert.AreEqual("MMCCCXV", Converter.Convert(2315));
        }
        [TestMethod]
        public void Convert_2316_Returns_MMCCCXVI()
        {
            Assert.AreEqual("MMCCCXVI", Converter.Convert(2316));
        }
        [TestMethod]
        public void Convert_2317_Returns_MMCCCXVII()
        {
            Assert.AreEqual("MMCCCXVII", Converter.Convert(2317));
        }
        [TestMethod]
        public void Convert_2318_Returns_MMCCCXVIII()
        {
            Assert.AreEqual("MMCCCXVIII", Converter.Convert(2318));
        }
        [TestMethod]
        public void Convert_2319_Returns_MMCCCXIX()
        {
            Assert.AreEqual("MMCCCXIX", Converter.Convert(2319));
        }
        [TestMethod]
        public void Convert_2320_Returns_MMCCCXX()
        {
            Assert.AreEqual("MMCCCXX", Converter.Convert(2320));
        }
        [TestMethod]
        public void Convert_2321_Returns_MMCCCXXI()
        {
            Assert.AreEqual("MMCCCXXI", Converter.Convert(2321));
        }
        [TestMethod]
        public void Convert_2322_Returns_MMCCCXXII()
        {
            Assert.AreEqual("MMCCCXXII", Converter.Convert(2322));
        }
        [TestMethod]
        public void Convert_2323_Returns_MMCCCXXIII()
        {
            Assert.AreEqual("MMCCCXXIII", Converter.Convert(2323));
        }
        [TestMethod]
        public void Convert_2324_Returns_MMCCCXXIV()
        {
            Assert.AreEqual("MMCCCXXIV", Converter.Convert(2324));
        }
        [TestMethod]
        public void Convert_2325_Returns_MMCCCXXV()
        {
            Assert.AreEqual("MMCCCXXV", Converter.Convert(2325));
        }
        [TestMethod]
        public void Convert_2326_Returns_MMCCCXXVI()
        {
            Assert.AreEqual("MMCCCXXVI", Converter.Convert(2326));
        }
        [TestMethod]
        public void Convert_2327_Returns_MMCCCXXVII()
        {
            Assert.AreEqual("MMCCCXXVII", Converter.Convert(2327));
        }
        [TestMethod]
        public void Convert_2328_Returns_MMCCCXXVIII()
        {
            Assert.AreEqual("MMCCCXXVIII", Converter.Convert(2328));
        }
        [TestMethod]
        public void Convert_2329_Returns_MMCCCXXIX()
        {
            Assert.AreEqual("MMCCCXXIX", Converter.Convert(2329));
        }
        [TestMethod]
        public void Convert_2330_Returns_MMCCCXXX()
        {
            Assert.AreEqual("MMCCCXXX", Converter.Convert(2330));
        }
        [TestMethod]
        public void Convert_2331_Returns_MMCCCXXXI()
        {
            Assert.AreEqual("MMCCCXXXI", Converter.Convert(2331));
        }
        [TestMethod]
        public void Convert_2332_Returns_MMCCCXXXII()
        {
            Assert.AreEqual("MMCCCXXXII", Converter.Convert(2332));
        }
        [TestMethod]
        public void Convert_2333_Returns_MMCCCXXXIII()
        {
            Assert.AreEqual("MMCCCXXXIII", Converter.Convert(2333));
        }
        [TestMethod]
        public void Convert_2334_Returns_MMCCCXXXIV()
        {
            Assert.AreEqual("MMCCCXXXIV", Converter.Convert(2334));
        }
        [TestMethod]
        public void Convert_2335_Returns_MMCCCXXXV()
        {
            Assert.AreEqual("MMCCCXXXV", Converter.Convert(2335));
        }
        [TestMethod]
        public void Convert_2336_Returns_MMCCCXXXVI()
        {
            Assert.AreEqual("MMCCCXXXVI", Converter.Convert(2336));
        }
        [TestMethod]
        public void Convert_2337_Returns_MMCCCXXXVII()
        {
            Assert.AreEqual("MMCCCXXXVII", Converter.Convert(2337));
        }
        [TestMethod]
        public void Convert_2338_Returns_MMCCCXXXVIII()
        {
            Assert.AreEqual("MMCCCXXXVIII", Converter.Convert(2338));
        }
        [TestMethod]
        public void Convert_2339_Returns_MMCCCXXXIX()
        {
            Assert.AreEqual("MMCCCXXXIX", Converter.Convert(2339));
        }
        [TestMethod]
        public void Convert_2340_Returns_MMCCCXL()
        {
            Assert.AreEqual("MMCCCXL", Converter.Convert(2340));
        }
        [TestMethod]
        public void Convert_2341_Returns_MMCCCXLI()
        {
            Assert.AreEqual("MMCCCXLI", Converter.Convert(2341));
        }
        [TestMethod]
        public void Convert_2342_Returns_MMCCCXLII()
        {
            Assert.AreEqual("MMCCCXLII", Converter.Convert(2342));
        }
        [TestMethod]
        public void Convert_2343_Returns_MMCCCXLIII()
        {
            Assert.AreEqual("MMCCCXLIII", Converter.Convert(2343));
        }
        [TestMethod]
        public void Convert_2344_Returns_MMCCCXLIV()
        {
            Assert.AreEqual("MMCCCXLIV", Converter.Convert(2344));
        }
        [TestMethod]
        public void Convert_2345_Returns_MMCCCXLV()
        {
            Assert.AreEqual("MMCCCXLV", Converter.Convert(2345));
        }
        [TestMethod]
        public void Convert_2346_Returns_MMCCCXLVI()
        {
            Assert.AreEqual("MMCCCXLVI", Converter.Convert(2346));
        }
        [TestMethod]
        public void Convert_2347_Returns_MMCCCXLVII()
        {
            Assert.AreEqual("MMCCCXLVII", Converter.Convert(2347));
        }
        [TestMethod]
        public void Convert_2348_Returns_MMCCCXLVIII()
        {
            Assert.AreEqual("MMCCCXLVIII", Converter.Convert(2348));
        }
        [TestMethod]
        public void Convert_2349_Returns_MMCCCXLIX()
        {
            Assert.AreEqual("MMCCCXLIX", Converter.Convert(2349));
        }
        [TestMethod]
        public void Convert_2350_Returns_MMCCCL()
        {
            Assert.AreEqual("MMCCCL", Converter.Convert(2350));
        }
        [TestMethod]
        public void Convert_2351_Returns_MMCCCLI()
        {
            Assert.AreEqual("MMCCCLI", Converter.Convert(2351));
        }
        [TestMethod]
        public void Convert_2352_Returns_MMCCCLII()
        {
            Assert.AreEqual("MMCCCLII", Converter.Convert(2352));
        }
        [TestMethod]
        public void Convert_2353_Returns_MMCCCLIII()
        {
            Assert.AreEqual("MMCCCLIII", Converter.Convert(2353));
        }
        [TestMethod]
        public void Convert_2354_Returns_MMCCCLIV()
        {
            Assert.AreEqual("MMCCCLIV", Converter.Convert(2354));
        }
        [TestMethod]
        public void Convert_2355_Returns_MMCCCLV()
        {
            Assert.AreEqual("MMCCCLV", Converter.Convert(2355));
        }
        [TestMethod]
        public void Convert_2356_Returns_MMCCCLVI()
        {
            Assert.AreEqual("MMCCCLVI", Converter.Convert(2356));
        }
        [TestMethod]
        public void Convert_2357_Returns_MMCCCLVII()
        {
            Assert.AreEqual("MMCCCLVII", Converter.Convert(2357));
        }
        [TestMethod]
        public void Convert_2358_Returns_MMCCCLVIII()
        {
            Assert.AreEqual("MMCCCLVIII", Converter.Convert(2358));
        }
        [TestMethod]
        public void Convert_2359_Returns_MMCCCLIX()
        {
            Assert.AreEqual("MMCCCLIX", Converter.Convert(2359));
        }
        [TestMethod]
        public void Convert_2360_Returns_MMCCCLX()
        {
            Assert.AreEqual("MMCCCLX", Converter.Convert(2360));
        }
        [TestMethod]
        public void Convert_2361_Returns_MMCCCLXI()
        {
            Assert.AreEqual("MMCCCLXI", Converter.Convert(2361));
        }
        [TestMethod]
        public void Convert_2362_Returns_MMCCCLXII()
        {
            Assert.AreEqual("MMCCCLXII", Converter.Convert(2362));
        }
        [TestMethod]
        public void Convert_2363_Returns_MMCCCLXIII()
        {
            Assert.AreEqual("MMCCCLXIII", Converter.Convert(2363));
        }
        [TestMethod]
        public void Convert_2364_Returns_MMCCCLXIV()
        {
            Assert.AreEqual("MMCCCLXIV", Converter.Convert(2364));
        }
        [TestMethod]
        public void Convert_2365_Returns_MMCCCLXV()
        {
            Assert.AreEqual("MMCCCLXV", Converter.Convert(2365));
        }
        [TestMethod]
        public void Convert_2366_Returns_MMCCCLXVI()
        {
            Assert.AreEqual("MMCCCLXVI", Converter.Convert(2366));
        }
        [TestMethod]
        public void Convert_2367_Returns_MMCCCLXVII()
        {
            Assert.AreEqual("MMCCCLXVII", Converter.Convert(2367));
        }
        [TestMethod]
        public void Convert_2368_Returns_MMCCCLXVIII()
        {
            Assert.AreEqual("MMCCCLXVIII", Converter.Convert(2368));
        }
        [TestMethod]
        public void Convert_2369_Returns_MMCCCLXIX()
        {
            Assert.AreEqual("MMCCCLXIX", Converter.Convert(2369));
        }
        [TestMethod]
        public void Convert_2370_Returns_MMCCCLXX()
        {
            Assert.AreEqual("MMCCCLXX", Converter.Convert(2370));
        }
        [TestMethod]
        public void Convert_2371_Returns_MMCCCLXXI()
        {
            Assert.AreEqual("MMCCCLXXI", Converter.Convert(2371));
        }
        [TestMethod]
        public void Convert_2372_Returns_MMCCCLXXII()
        {
            Assert.AreEqual("MMCCCLXXII", Converter.Convert(2372));
        }
        [TestMethod]
        public void Convert_2373_Returns_MMCCCLXXIII()
        {
            Assert.AreEqual("MMCCCLXXIII", Converter.Convert(2373));
        }
        [TestMethod]
        public void Convert_2374_Returns_MMCCCLXXIV()
        {
            Assert.AreEqual("MMCCCLXXIV", Converter.Convert(2374));
        }
        [TestMethod]
        public void Convert_2375_Returns_MMCCCLXXV()
        {
            Assert.AreEqual("MMCCCLXXV", Converter.Convert(2375));
        }
        [TestMethod]
        public void Convert_2376_Returns_MMCCCLXXVI()
        {
            Assert.AreEqual("MMCCCLXXVI", Converter.Convert(2376));
        }
        [TestMethod]
        public void Convert_2377_Returns_MMCCCLXXVII()
        {
            Assert.AreEqual("MMCCCLXXVII", Converter.Convert(2377));
        }
        [TestMethod]
        public void Convert_2378_Returns_MMCCCLXXVIII()
        {
            Assert.AreEqual("MMCCCLXXVIII", Converter.Convert(2378));
        }
        [TestMethod]
        public void Convert_2379_Returns_MMCCCLXXIX()
        {
            Assert.AreEqual("MMCCCLXXIX", Converter.Convert(2379));
        }
        [TestMethod]
        public void Convert_2380_Returns_MMCCCLXXX()
        {
            Assert.AreEqual("MMCCCLXXX", Converter.Convert(2380));
        }
        [TestMethod]
        public void Convert_2381_Returns_MMCCCLXXXI()
        {
            Assert.AreEqual("MMCCCLXXXI", Converter.Convert(2381));
        }
        [TestMethod]
        public void Convert_2382_Returns_MMCCCLXXXII()
        {
            Assert.AreEqual("MMCCCLXXXII", Converter.Convert(2382));
        }
        [TestMethod]
        public void Convert_2383_Returns_MMCCCLXXXIII()
        {
            Assert.AreEqual("MMCCCLXXXIII", Converter.Convert(2383));
        }
        [TestMethod]
        public void Convert_2384_Returns_MMCCCLXXXIV()
        {
            Assert.AreEqual("MMCCCLXXXIV", Converter.Convert(2384));
        }
        [TestMethod]
        public void Convert_2385_Returns_MMCCCLXXXV()
        {
            Assert.AreEqual("MMCCCLXXXV", Converter.Convert(2385));
        }
        [TestMethod]
        public void Convert_2386_Returns_MMCCCLXXXVI()
        {
            Assert.AreEqual("MMCCCLXXXVI", Converter.Convert(2386));
        }
        [TestMethod]
        public void Convert_2387_Returns_MMCCCLXXXVII()
        {
            Assert.AreEqual("MMCCCLXXXVII", Converter.Convert(2387));
        }
        [TestMethod]
        public void Convert_2388_Returns_MMCCCLXXXVIII()
        {
            Assert.AreEqual("MMCCCLXXXVIII", Converter.Convert(2388));
        }
        [TestMethod]
        public void Convert_2389_Returns_MMCCCLXXXIX()
        {
            Assert.AreEqual("MMCCCLXXXIX", Converter.Convert(2389));
        }
        [TestMethod]
        public void Convert_2390_Returns_MMCCCXC()
        {
            Assert.AreEqual("MMCCCXC", Converter.Convert(2390));
        }
        [TestMethod]
        public void Convert_2391_Returns_MMCCCXCI()
        {
            Assert.AreEqual("MMCCCXCI", Converter.Convert(2391));
        }
        [TestMethod]
        public void Convert_2392_Returns_MMCCCXCII()
        {
            Assert.AreEqual("MMCCCXCII", Converter.Convert(2392));
        }
        [TestMethod]
        public void Convert_2393_Returns_MMCCCXCIII()
        {
            Assert.AreEqual("MMCCCXCIII", Converter.Convert(2393));
        }
        [TestMethod]
        public void Convert_2394_Returns_MMCCCXCIV()
        {
            Assert.AreEqual("MMCCCXCIV", Converter.Convert(2394));
        }
        [TestMethod]
        public void Convert_2395_Returns_MMCCCXCV()
        {
            Assert.AreEqual("MMCCCXCV", Converter.Convert(2395));
        }
        [TestMethod]
        public void Convert_2396_Returns_MMCCCXCVI()
        {
            Assert.AreEqual("MMCCCXCVI", Converter.Convert(2396));
        }
        [TestMethod]
        public void Convert_2397_Returns_MMCCCXCVII()
        {
            Assert.AreEqual("MMCCCXCVII", Converter.Convert(2397));
        }
        [TestMethod]
        public void Convert_2398_Returns_MMCCCXCVIII()
        {
            Assert.AreEqual("MMCCCXCVIII", Converter.Convert(2398));
        }
        [TestMethod]
        public void Convert_2399_Returns_MMCCCXCIX()
        {
            Assert.AreEqual("MMCCCXCIX", Converter.Convert(2399));
        }
        [TestMethod]
        public void Convert_2400_Returns_MMCD()
        {
            Assert.AreEqual("MMCD", Converter.Convert(2400));
        }
        [TestMethod]
        public void Convert_2401_Returns_MMCDI()
        {
            Assert.AreEqual("MMCDI", Converter.Convert(2401));
        }
        [TestMethod]
        public void Convert_2402_Returns_MMCDII()
        {
            Assert.AreEqual("MMCDII", Converter.Convert(2402));
        }
        [TestMethod]
        public void Convert_2403_Returns_MMCDIII()
        {
            Assert.AreEqual("MMCDIII", Converter.Convert(2403));
        }
        [TestMethod]
        public void Convert_2404_Returns_MMCDIV()
        {
            Assert.AreEqual("MMCDIV", Converter.Convert(2404));
        }
        [TestMethod]
        public void Convert_2405_Returns_MMCDV()
        {
            Assert.AreEqual("MMCDV", Converter.Convert(2405));
        }
        [TestMethod]
        public void Convert_2406_Returns_MMCDVI()
        {
            Assert.AreEqual("MMCDVI", Converter.Convert(2406));
        }
        [TestMethod]
        public void Convert_2407_Returns_MMCDVII()
        {
            Assert.AreEqual("MMCDVII", Converter.Convert(2407));
        }
        [TestMethod]
        public void Convert_2408_Returns_MMCDVIII()
        {
            Assert.AreEqual("MMCDVIII", Converter.Convert(2408));
        }
        [TestMethod]
        public void Convert_2409_Returns_MMCDIX()
        {
            Assert.AreEqual("MMCDIX", Converter.Convert(2409));
        }
        [TestMethod]
        public void Convert_2410_Returns_MMCDX()
        {
            Assert.AreEqual("MMCDX", Converter.Convert(2410));
        }
        [TestMethod]
        public void Convert_2411_Returns_MMCDXI()
        {
            Assert.AreEqual("MMCDXI", Converter.Convert(2411));
        }
        [TestMethod]
        public void Convert_2412_Returns_MMCDXII()
        {
            Assert.AreEqual("MMCDXII", Converter.Convert(2412));
        }
        [TestMethod]
        public void Convert_2413_Returns_MMCDXIII()
        {
            Assert.AreEqual("MMCDXIII", Converter.Convert(2413));
        }
        [TestMethod]
        public void Convert_2414_Returns_MMCDXIV()
        {
            Assert.AreEqual("MMCDXIV", Converter.Convert(2414));
        }
        [TestMethod]
        public void Convert_2415_Returns_MMCDXV()
        {
            Assert.AreEqual("MMCDXV", Converter.Convert(2415));
        }
        [TestMethod]
        public void Convert_2416_Returns_MMCDXVI()
        {
            Assert.AreEqual("MMCDXVI", Converter.Convert(2416));
        }
        [TestMethod]
        public void Convert_2417_Returns_MMCDXVII()
        {
            Assert.AreEqual("MMCDXVII", Converter.Convert(2417));
        }
        [TestMethod]
        public void Convert_2418_Returns_MMCDXVIII()
        {
            Assert.AreEqual("MMCDXVIII", Converter.Convert(2418));
        }
        [TestMethod]
        public void Convert_2419_Returns_MMCDXIX()
        {
            Assert.AreEqual("MMCDXIX", Converter.Convert(2419));
        }
        [TestMethod]
        public void Convert_2420_Returns_MMCDXX()
        {
            Assert.AreEqual("MMCDXX", Converter.Convert(2420));
        }
        [TestMethod]
        public void Convert_2421_Returns_MMCDXXI()
        {
            Assert.AreEqual("MMCDXXI", Converter.Convert(2421));
        }
        [TestMethod]
        public void Convert_2422_Returns_MMCDXXII()
        {
            Assert.AreEqual("MMCDXXII", Converter.Convert(2422));
        }
        [TestMethod]
        public void Convert_2423_Returns_MMCDXXIII()
        {
            Assert.AreEqual("MMCDXXIII", Converter.Convert(2423));
        }
        [TestMethod]
        public void Convert_2424_Returns_MMCDXXIV()
        {
            Assert.AreEqual("MMCDXXIV", Converter.Convert(2424));
        }
        [TestMethod]
        public void Convert_2425_Returns_MMCDXXV()
        {
            Assert.AreEqual("MMCDXXV", Converter.Convert(2425));
        }
        [TestMethod]
        public void Convert_2426_Returns_MMCDXXVI()
        {
            Assert.AreEqual("MMCDXXVI", Converter.Convert(2426));
        }
        [TestMethod]
        public void Convert_2427_Returns_MMCDXXVII()
        {
            Assert.AreEqual("MMCDXXVII", Converter.Convert(2427));
        }
        [TestMethod]
        public void Convert_2428_Returns_MMCDXXVIII()
        {
            Assert.AreEqual("MMCDXXVIII", Converter.Convert(2428));
        }
        [TestMethod]
        public void Convert_2429_Returns_MMCDXXIX()
        {
            Assert.AreEqual("MMCDXXIX", Converter.Convert(2429));
        }
        [TestMethod]
        public void Convert_2430_Returns_MMCDXXX()
        {
            Assert.AreEqual("MMCDXXX", Converter.Convert(2430));
        }
        [TestMethod]
        public void Convert_2431_Returns_MMCDXXXI()
        {
            Assert.AreEqual("MMCDXXXI", Converter.Convert(2431));
        }
        [TestMethod]
        public void Convert_2432_Returns_MMCDXXXII()
        {
            Assert.AreEqual("MMCDXXXII", Converter.Convert(2432));
        }
        [TestMethod]
        public void Convert_2433_Returns_MMCDXXXIII()
        {
            Assert.AreEqual("MMCDXXXIII", Converter.Convert(2433));
        }
        [TestMethod]
        public void Convert_2434_Returns_MMCDXXXIV()
        {
            Assert.AreEqual("MMCDXXXIV", Converter.Convert(2434));
        }
        [TestMethod]
        public void Convert_2435_Returns_MMCDXXXV()
        {
            Assert.AreEqual("MMCDXXXV", Converter.Convert(2435));
        }
        [TestMethod]
        public void Convert_2436_Returns_MMCDXXXVI()
        {
            Assert.AreEqual("MMCDXXXVI", Converter.Convert(2436));
        }
        [TestMethod]
        public void Convert_2437_Returns_MMCDXXXVII()
        {
            Assert.AreEqual("MMCDXXXVII", Converter.Convert(2437));
        }
        [TestMethod]
        public void Convert_2438_Returns_MMCDXXXVIII()
        {
            Assert.AreEqual("MMCDXXXVIII", Converter.Convert(2438));
        }
        [TestMethod]
        public void Convert_2439_Returns_MMCDXXXIX()
        {
            Assert.AreEqual("MMCDXXXIX", Converter.Convert(2439));
        }
        [TestMethod]
        public void Convert_2440_Returns_MMCDXL()
        {
            Assert.AreEqual("MMCDXL", Converter.Convert(2440));
        }
        [TestMethod]
        public void Convert_2441_Returns_MMCDXLI()
        {
            Assert.AreEqual("MMCDXLI", Converter.Convert(2441));
        }
        [TestMethod]
        public void Convert_2442_Returns_MMCDXLII()
        {
            Assert.AreEqual("MMCDXLII", Converter.Convert(2442));
        }
        [TestMethod]
        public void Convert_2443_Returns_MMCDXLIII()
        {
            Assert.AreEqual("MMCDXLIII", Converter.Convert(2443));
        }
        [TestMethod]
        public void Convert_2444_Returns_MMCDXLIV()
        {
            Assert.AreEqual("MMCDXLIV", Converter.Convert(2444));
        }
        [TestMethod]
        public void Convert_2445_Returns_MMCDXLV()
        {
            Assert.AreEqual("MMCDXLV", Converter.Convert(2445));
        }
        [TestMethod]
        public void Convert_2446_Returns_MMCDXLVI()
        {
            Assert.AreEqual("MMCDXLVI", Converter.Convert(2446));
        }
        [TestMethod]
        public void Convert_2447_Returns_MMCDXLVII()
        {
            Assert.AreEqual("MMCDXLVII", Converter.Convert(2447));
        }
        [TestMethod]
        public void Convert_2448_Returns_MMCDXLVIII()
        {
            Assert.AreEqual("MMCDXLVIII", Converter.Convert(2448));
        }
        [TestMethod]
        public void Convert_2449_Returns_MMCDXLIX()
        {
            Assert.AreEqual("MMCDXLIX", Converter.Convert(2449));
        }
        [TestMethod]
        public void Convert_2450_Returns_MMCDL()
        {
            Assert.AreEqual("MMCDL", Converter.Convert(2450));
        }
        [TestMethod]
        public void Convert_2451_Returns_MMCDLI()
        {
            Assert.AreEqual("MMCDLI", Converter.Convert(2451));
        }
        [TestMethod]
        public void Convert_2452_Returns_MMCDLII()
        {
            Assert.AreEqual("MMCDLII", Converter.Convert(2452));
        }
        [TestMethod]
        public void Convert_2453_Returns_MMCDLIII()
        {
            Assert.AreEqual("MMCDLIII", Converter.Convert(2453));
        }
        [TestMethod]
        public void Convert_2454_Returns_MMCDLIV()
        {
            Assert.AreEqual("MMCDLIV", Converter.Convert(2454));
        }
        [TestMethod]
        public void Convert_2455_Returns_MMCDLV()
        {
            Assert.AreEqual("MMCDLV", Converter.Convert(2455));
        }
        [TestMethod]
        public void Convert_2456_Returns_MMCDLVI()
        {
            Assert.AreEqual("MMCDLVI", Converter.Convert(2456));
        }
        [TestMethod]
        public void Convert_2457_Returns_MMCDLVII()
        {
            Assert.AreEqual("MMCDLVII", Converter.Convert(2457));
        }
        [TestMethod]
        public void Convert_2458_Returns_MMCDLVIII()
        {
            Assert.AreEqual("MMCDLVIII", Converter.Convert(2458));
        }
        [TestMethod]
        public void Convert_2459_Returns_MMCDLIX()
        {
            Assert.AreEqual("MMCDLIX", Converter.Convert(2459));
        }
        [TestMethod]
        public void Convert_2460_Returns_MMCDLX()
        {
            Assert.AreEqual("MMCDLX", Converter.Convert(2460));
        }
        [TestMethod]
        public void Convert_2461_Returns_MMCDLXI()
        {
            Assert.AreEqual("MMCDLXI", Converter.Convert(2461));
        }
        [TestMethod]
        public void Convert_2462_Returns_MMCDLXII()
        {
            Assert.AreEqual("MMCDLXII", Converter.Convert(2462));
        }
        [TestMethod]
        public void Convert_2463_Returns_MMCDLXIII()
        {
            Assert.AreEqual("MMCDLXIII", Converter.Convert(2463));
        }
        [TestMethod]
        public void Convert_2464_Returns_MMCDLXIV()
        {
            Assert.AreEqual("MMCDLXIV", Converter.Convert(2464));
        }
        [TestMethod]
        public void Convert_2465_Returns_MMCDLXV()
        {
            Assert.AreEqual("MMCDLXV", Converter.Convert(2465));
        }
        [TestMethod]
        public void Convert_2466_Returns_MMCDLXVI()
        {
            Assert.AreEqual("MMCDLXVI", Converter.Convert(2466));
        }
        [TestMethod]
        public void Convert_2467_Returns_MMCDLXVII()
        {
            Assert.AreEqual("MMCDLXVII", Converter.Convert(2467));
        }
        [TestMethod]
        public void Convert_2468_Returns_MMCDLXVIII()
        {
            Assert.AreEqual("MMCDLXVIII", Converter.Convert(2468));
        }
        [TestMethod]
        public void Convert_2469_Returns_MMCDLXIX()
        {
            Assert.AreEqual("MMCDLXIX", Converter.Convert(2469));
        }
        [TestMethod]
        public void Convert_2470_Returns_MMCDLXX()
        {
            Assert.AreEqual("MMCDLXX", Converter.Convert(2470));
        }
        [TestMethod]
        public void Convert_2471_Returns_MMCDLXXI()
        {
            Assert.AreEqual("MMCDLXXI", Converter.Convert(2471));
        }
        [TestMethod]
        public void Convert_2472_Returns_MMCDLXXII()
        {
            Assert.AreEqual("MMCDLXXII", Converter.Convert(2472));
        }
        [TestMethod]
        public void Convert_2473_Returns_MMCDLXXIII()
        {
            Assert.AreEqual("MMCDLXXIII", Converter.Convert(2473));
        }
        [TestMethod]
        public void Convert_2474_Returns_MMCDLXXIV()
        {
            Assert.AreEqual("MMCDLXXIV", Converter.Convert(2474));
        }
        [TestMethod]
        public void Convert_2475_Returns_MMCDLXXV()
        {
            Assert.AreEqual("MMCDLXXV", Converter.Convert(2475));
        }
        [TestMethod]
        public void Convert_2476_Returns_MMCDLXXVI()
        {
            Assert.AreEqual("MMCDLXXVI", Converter.Convert(2476));
        }
        [TestMethod]
        public void Convert_2477_Returns_MMCDLXXVII()
        {
            Assert.AreEqual("MMCDLXXVII", Converter.Convert(2477));
        }
        [TestMethod]
        public void Convert_2478_Returns_MMCDLXXVIII()
        {
            Assert.AreEqual("MMCDLXXVIII", Converter.Convert(2478));
        }
        [TestMethod]
        public void Convert_2479_Returns_MMCDLXXIX()
        {
            Assert.AreEqual("MMCDLXXIX", Converter.Convert(2479));
        }
        [TestMethod]
        public void Convert_2480_Returns_MMCDLXXX()
        {
            Assert.AreEqual("MMCDLXXX", Converter.Convert(2480));
        }
        [TestMethod]
        public void Convert_2481_Returns_MMCDLXXXI()
        {
            Assert.AreEqual("MMCDLXXXI", Converter.Convert(2481));
        }
        [TestMethod]
        public void Convert_2482_Returns_MMCDLXXXII()
        {
            Assert.AreEqual("MMCDLXXXII", Converter.Convert(2482));
        }
        [TestMethod]
        public void Convert_2483_Returns_MMCDLXXXIII()
        {
            Assert.AreEqual("MMCDLXXXIII", Converter.Convert(2483));
        }
        [TestMethod]
        public void Convert_2484_Returns_MMCDLXXXIV()
        {
            Assert.AreEqual("MMCDLXXXIV", Converter.Convert(2484));
        }
        [TestMethod]
        public void Convert_2485_Returns_MMCDLXXXV()
        {
            Assert.AreEqual("MMCDLXXXV", Converter.Convert(2485));
        }
        [TestMethod]
        public void Convert_2486_Returns_MMCDLXXXVI()
        {
            Assert.AreEqual("MMCDLXXXVI", Converter.Convert(2486));
        }
        [TestMethod]
        public void Convert_2487_Returns_MMCDLXXXVII()
        {
            Assert.AreEqual("MMCDLXXXVII", Converter.Convert(2487));
        }
        [TestMethod]
        public void Convert_2488_Returns_MMCDLXXXVIII()
        {
            Assert.AreEqual("MMCDLXXXVIII", Converter.Convert(2488));
        }
        [TestMethod]
        public void Convert_2489_Returns_MMCDLXXXIX()
        {
            Assert.AreEqual("MMCDLXXXIX", Converter.Convert(2489));
        }
        [TestMethod]
        public void Convert_2490_Returns_MMCDXC()
        {
            Assert.AreEqual("MMCDXC", Converter.Convert(2490));
        }
        [TestMethod]
        public void Convert_2491_Returns_MMCDXCI()
        {
            Assert.AreEqual("MMCDXCI", Converter.Convert(2491));
        }
        [TestMethod]
        public void Convert_2492_Returns_MMCDXCII()
        {
            Assert.AreEqual("MMCDXCII", Converter.Convert(2492));
        }
        [TestMethod]
        public void Convert_2493_Returns_MMCDXCIII()
        {
            Assert.AreEqual("MMCDXCIII", Converter.Convert(2493));
        }
        [TestMethod]
        public void Convert_2494_Returns_MMCDXCIV()
        {
            Assert.AreEqual("MMCDXCIV", Converter.Convert(2494));
        }
        [TestMethod]
        public void Convert_2495_Returns_MMCDXCV()
        {
            Assert.AreEqual("MMCDXCV", Converter.Convert(2495));
        }
        [TestMethod]
        public void Convert_2496_Returns_MMCDXCVI()
        {
            Assert.AreEqual("MMCDXCVI", Converter.Convert(2496));
        }
        [TestMethod]
        public void Convert_2497_Returns_MMCDXCVII()
        {
            Assert.AreEqual("MMCDXCVII", Converter.Convert(2497));
        }
        [TestMethod]
        public void Convert_2498_Returns_MMCDXCVIII()
        {
            Assert.AreEqual("MMCDXCVIII", Converter.Convert(2498));
        }
        [TestMethod]
        public void Convert_2499_Returns_MMCDXCIX()
        {
            Assert.AreEqual("MMCDXCIX", Converter.Convert(2499));
        }
        [TestMethod]
        public void Convert_2500_Returns_MMD()
        {
            Assert.AreEqual("MMD", Converter.Convert(2500));
        }
        [TestMethod]
        public void Convert_2501_Returns_MMDI()
        {
            Assert.AreEqual("MMDI", Converter.Convert(2501));
        }
        [TestMethod]
        public void Convert_2502_Returns_MMDII()
        {
            Assert.AreEqual("MMDII", Converter.Convert(2502));
        }
        [TestMethod]
        public void Convert_2503_Returns_MMDIII()
        {
            Assert.AreEqual("MMDIII", Converter.Convert(2503));
        }
        [TestMethod]
        public void Convert_2504_Returns_MMDIV()
        {
            Assert.AreEqual("MMDIV", Converter.Convert(2504));
        }
        [TestMethod]
        public void Convert_2505_Returns_MMDV()
        {
            Assert.AreEqual("MMDV", Converter.Convert(2505));
        }
        [TestMethod]
        public void Convert_2506_Returns_MMDVI()
        {
            Assert.AreEqual("MMDVI", Converter.Convert(2506));
        }
        [TestMethod]
        public void Convert_2507_Returns_MMDVII()
        {
            Assert.AreEqual("MMDVII", Converter.Convert(2507));
        }
        [TestMethod]
        public void Convert_2508_Returns_MMDVIII()
        {
            Assert.AreEqual("MMDVIII", Converter.Convert(2508));
        }
        [TestMethod]
        public void Convert_2509_Returns_MMDIX()
        {
            Assert.AreEqual("MMDIX", Converter.Convert(2509));
        }
        [TestMethod]
        public void Convert_2510_Returns_MMDX()
        {
            Assert.AreEqual("MMDX", Converter.Convert(2510));
        }
        [TestMethod]
        public void Convert_2511_Returns_MMDXI()
        {
            Assert.AreEqual("MMDXI", Converter.Convert(2511));
        }
        [TestMethod]
        public void Convert_2512_Returns_MMDXII()
        {
            Assert.AreEqual("MMDXII", Converter.Convert(2512));
        }
        [TestMethod]
        public void Convert_2513_Returns_MMDXIII()
        {
            Assert.AreEqual("MMDXIII", Converter.Convert(2513));
        }
        [TestMethod]
        public void Convert_2514_Returns_MMDXIV()
        {
            Assert.AreEqual("MMDXIV", Converter.Convert(2514));
        }
        [TestMethod]
        public void Convert_2515_Returns_MMDXV()
        {
            Assert.AreEqual("MMDXV", Converter.Convert(2515));
        }
        [TestMethod]
        public void Convert_2516_Returns_MMDXVI()
        {
            Assert.AreEqual("MMDXVI", Converter.Convert(2516));
        }
        [TestMethod]
        public void Convert_2517_Returns_MMDXVII()
        {
            Assert.AreEqual("MMDXVII", Converter.Convert(2517));
        }
        [TestMethod]
        public void Convert_2518_Returns_MMDXVIII()
        {
            Assert.AreEqual("MMDXVIII", Converter.Convert(2518));
        }
        [TestMethod]
        public void Convert_2519_Returns_MMDXIX()
        {
            Assert.AreEqual("MMDXIX", Converter.Convert(2519));
        }
        [TestMethod]
        public void Convert_2520_Returns_MMDXX()
        {
            Assert.AreEqual("MMDXX", Converter.Convert(2520));
        }
        [TestMethod]
        public void Convert_2521_Returns_MMDXXI()
        {
            Assert.AreEqual("MMDXXI", Converter.Convert(2521));
        }
        [TestMethod]
        public void Convert_2522_Returns_MMDXXII()
        {
            Assert.AreEqual("MMDXXII", Converter.Convert(2522));
        }
        [TestMethod]
        public void Convert_2523_Returns_MMDXXIII()
        {
            Assert.AreEqual("MMDXXIII", Converter.Convert(2523));
        }
        [TestMethod]
        public void Convert_2524_Returns_MMDXXIV()
        {
            Assert.AreEqual("MMDXXIV", Converter.Convert(2524));
        }
        [TestMethod]
        public void Convert_2525_Returns_MMDXXV()
        {
            Assert.AreEqual("MMDXXV", Converter.Convert(2525));
        }
        [TestMethod]
        public void Convert_2526_Returns_MMDXXVI()
        {
            Assert.AreEqual("MMDXXVI", Converter.Convert(2526));
        }
        [TestMethod]
        public void Convert_2527_Returns_MMDXXVII()
        {
            Assert.AreEqual("MMDXXVII", Converter.Convert(2527));
        }
        [TestMethod]
        public void Convert_2528_Returns_MMDXXVIII()
        {
            Assert.AreEqual("MMDXXVIII", Converter.Convert(2528));
        }
        [TestMethod]
        public void Convert_2529_Returns_MMDXXIX()
        {
            Assert.AreEqual("MMDXXIX", Converter.Convert(2529));
        }
        [TestMethod]
        public void Convert_2530_Returns_MMDXXX()
        {
            Assert.AreEqual("MMDXXX", Converter.Convert(2530));
        }
        [TestMethod]
        public void Convert_2531_Returns_MMDXXXI()
        {
            Assert.AreEqual("MMDXXXI", Converter.Convert(2531));
        }
        [TestMethod]
        public void Convert_2532_Returns_MMDXXXII()
        {
            Assert.AreEqual("MMDXXXII", Converter.Convert(2532));
        }
        [TestMethod]
        public void Convert_2533_Returns_MMDXXXIII()
        {
            Assert.AreEqual("MMDXXXIII", Converter.Convert(2533));
        }
        [TestMethod]
        public void Convert_2534_Returns_MMDXXXIV()
        {
            Assert.AreEqual("MMDXXXIV", Converter.Convert(2534));
        }
        [TestMethod]
        public void Convert_2535_Returns_MMDXXXV()
        {
            Assert.AreEqual("MMDXXXV", Converter.Convert(2535));
        }
        [TestMethod]
        public void Convert_2536_Returns_MMDXXXVI()
        {
            Assert.AreEqual("MMDXXXVI", Converter.Convert(2536));
        }
        [TestMethod]
        public void Convert_2537_Returns_MMDXXXVII()
        {
            Assert.AreEqual("MMDXXXVII", Converter.Convert(2537));
        }
        [TestMethod]
        public void Convert_2538_Returns_MMDXXXVIII()
        {
            Assert.AreEqual("MMDXXXVIII", Converter.Convert(2538));
        }
        [TestMethod]
        public void Convert_2539_Returns_MMDXXXIX()
        {
            Assert.AreEqual("MMDXXXIX", Converter.Convert(2539));
        }
        [TestMethod]
        public void Convert_2540_Returns_MMDXL()
        {
            Assert.AreEqual("MMDXL", Converter.Convert(2540));
        }
        [TestMethod]
        public void Convert_2541_Returns_MMDXLI()
        {
            Assert.AreEqual("MMDXLI", Converter.Convert(2541));
        }
        [TestMethod]
        public void Convert_2542_Returns_MMDXLII()
        {
            Assert.AreEqual("MMDXLII", Converter.Convert(2542));
        }
        [TestMethod]
        public void Convert_2543_Returns_MMDXLIII()
        {
            Assert.AreEqual("MMDXLIII", Converter.Convert(2543));
        }
        [TestMethod]
        public void Convert_2544_Returns_MMDXLIV()
        {
            Assert.AreEqual("MMDXLIV", Converter.Convert(2544));
        }
        [TestMethod]
        public void Convert_2545_Returns_MMDXLV()
        {
            Assert.AreEqual("MMDXLV", Converter.Convert(2545));
        }
        [TestMethod]
        public void Convert_2546_Returns_MMDXLVI()
        {
            Assert.AreEqual("MMDXLVI", Converter.Convert(2546));
        }
        [TestMethod]
        public void Convert_2547_Returns_MMDXLVII()
        {
            Assert.AreEqual("MMDXLVII", Converter.Convert(2547));
        }
        [TestMethod]
        public void Convert_2548_Returns_MMDXLVIII()
        {
            Assert.AreEqual("MMDXLVIII", Converter.Convert(2548));
        }
        [TestMethod]
        public void Convert_2549_Returns_MMDXLIX()
        {
            Assert.AreEqual("MMDXLIX", Converter.Convert(2549));
        }
        [TestMethod]
        public void Convert_2550_Returns_MMDL()
        {
            Assert.AreEqual("MMDL", Converter.Convert(2550));
        }
        [TestMethod]
        public void Convert_2551_Returns_MMDLI()
        {
            Assert.AreEqual("MMDLI", Converter.Convert(2551));
        }
        [TestMethod]
        public void Convert_2552_Returns_MMDLII()
        {
            Assert.AreEqual("MMDLII", Converter.Convert(2552));
        }
        [TestMethod]
        public void Convert_2553_Returns_MMDLIII()
        {
            Assert.AreEqual("MMDLIII", Converter.Convert(2553));
        }
        [TestMethod]
        public void Convert_2554_Returns_MMDLIV()
        {
            Assert.AreEqual("MMDLIV", Converter.Convert(2554));
        }
        [TestMethod]
        public void Convert_2555_Returns_MMDLV()
        {
            Assert.AreEqual("MMDLV", Converter.Convert(2555));
        }
        [TestMethod]
        public void Convert_2556_Returns_MMDLVI()
        {
            Assert.AreEqual("MMDLVI", Converter.Convert(2556));
        }
        [TestMethod]
        public void Convert_2557_Returns_MMDLVII()
        {
            Assert.AreEqual("MMDLVII", Converter.Convert(2557));
        }
        [TestMethod]
        public void Convert_2558_Returns_MMDLVIII()
        {
            Assert.AreEqual("MMDLVIII", Converter.Convert(2558));
        }
        [TestMethod]
        public void Convert_2559_Returns_MMDLIX()
        {
            Assert.AreEqual("MMDLIX", Converter.Convert(2559));
        }
        [TestMethod]
        public void Convert_2560_Returns_MMDLX()
        {
            Assert.AreEqual("MMDLX", Converter.Convert(2560));
        }
        [TestMethod]
        public void Convert_2561_Returns_MMDLXI()
        {
            Assert.AreEqual("MMDLXI", Converter.Convert(2561));
        }
        [TestMethod]
        public void Convert_2562_Returns_MMDLXII()
        {
            Assert.AreEqual("MMDLXII", Converter.Convert(2562));
        }
        [TestMethod]
        public void Convert_2563_Returns_MMDLXIII()
        {
            Assert.AreEqual("MMDLXIII", Converter.Convert(2563));
        }
        [TestMethod]
        public void Convert_2564_Returns_MMDLXIV()
        {
            Assert.AreEqual("MMDLXIV", Converter.Convert(2564));
        }
        [TestMethod]
        public void Convert_2565_Returns_MMDLXV()
        {
            Assert.AreEqual("MMDLXV", Converter.Convert(2565));
        }
        [TestMethod]
        public void Convert_2566_Returns_MMDLXVI()
        {
            Assert.AreEqual("MMDLXVI", Converter.Convert(2566));
        }
        [TestMethod]
        public void Convert_2567_Returns_MMDLXVII()
        {
            Assert.AreEqual("MMDLXVII", Converter.Convert(2567));
        }
        [TestMethod]
        public void Convert_2568_Returns_MMDLXVIII()
        {
            Assert.AreEqual("MMDLXVIII", Converter.Convert(2568));
        }
        [TestMethod]
        public void Convert_2569_Returns_MMDLXIX()
        {
            Assert.AreEqual("MMDLXIX", Converter.Convert(2569));
        }
        [TestMethod]
        public void Convert_2570_Returns_MMDLXX()
        {
            Assert.AreEqual("MMDLXX", Converter.Convert(2570));
        }
        [TestMethod]
        public void Convert_2571_Returns_MMDLXXI()
        {
            Assert.AreEqual("MMDLXXI", Converter.Convert(2571));
        }
        [TestMethod]
        public void Convert_2572_Returns_MMDLXXII()
        {
            Assert.AreEqual("MMDLXXII", Converter.Convert(2572));
        }
        [TestMethod]
        public void Convert_2573_Returns_MMDLXXIII()
        {
            Assert.AreEqual("MMDLXXIII", Converter.Convert(2573));
        }
        [TestMethod]
        public void Convert_2574_Returns_MMDLXXIV()
        {
            Assert.AreEqual("MMDLXXIV", Converter.Convert(2574));
        }
        [TestMethod]
        public void Convert_2575_Returns_MMDLXXV()
        {
            Assert.AreEqual("MMDLXXV", Converter.Convert(2575));
        }
        [TestMethod]
        public void Convert_2576_Returns_MMDLXXVI()
        {
            Assert.AreEqual("MMDLXXVI", Converter.Convert(2576));
        }
        [TestMethod]
        public void Convert_2577_Returns_MMDLXXVII()
        {
            Assert.AreEqual("MMDLXXVII", Converter.Convert(2577));
        }
        [TestMethod]
        public void Convert_2578_Returns_MMDLXXVIII()
        {
            Assert.AreEqual("MMDLXXVIII", Converter.Convert(2578));
        }
        [TestMethod]
        public void Convert_2579_Returns_MMDLXXIX()
        {
            Assert.AreEqual("MMDLXXIX", Converter.Convert(2579));
        }
        [TestMethod]
        public void Convert_2580_Returns_MMDLXXX()
        {
            Assert.AreEqual("MMDLXXX", Converter.Convert(2580));
        }
        [TestMethod]
        public void Convert_2581_Returns_MMDLXXXI()
        {
            Assert.AreEqual("MMDLXXXI", Converter.Convert(2581));
        }
        [TestMethod]
        public void Convert_2582_Returns_MMDLXXXII()
        {
            Assert.AreEqual("MMDLXXXII", Converter.Convert(2582));
        }
        [TestMethod]
        public void Convert_2583_Returns_MMDLXXXIII()
        {
            Assert.AreEqual("MMDLXXXIII", Converter.Convert(2583));
        }
        [TestMethod]
        public void Convert_2584_Returns_MMDLXXXIV()
        {
            Assert.AreEqual("MMDLXXXIV", Converter.Convert(2584));
        }
        [TestMethod]
        public void Convert_2585_Returns_MMDLXXXV()
        {
            Assert.AreEqual("MMDLXXXV", Converter.Convert(2585));
        }
        [TestMethod]
        public void Convert_2586_Returns_MMDLXXXVI()
        {
            Assert.AreEqual("MMDLXXXVI", Converter.Convert(2586));
        }
        [TestMethod]
        public void Convert_2587_Returns_MMDLXXXVII()
        {
            Assert.AreEqual("MMDLXXXVII", Converter.Convert(2587));
        }
        [TestMethod]
        public void Convert_2588_Returns_MMDLXXXVIII()
        {
            Assert.AreEqual("MMDLXXXVIII", Converter.Convert(2588));
        }
        [TestMethod]
        public void Convert_2589_Returns_MMDLXXXIX()
        {
            Assert.AreEqual("MMDLXXXIX", Converter.Convert(2589));
        }
        [TestMethod]
        public void Convert_2590_Returns_MMDXC()
        {
            Assert.AreEqual("MMDXC", Converter.Convert(2590));
        }
        [TestMethod]
        public void Convert_2591_Returns_MMDXCI()
        {
            Assert.AreEqual("MMDXCI", Converter.Convert(2591));
        }
        [TestMethod]
        public void Convert_2592_Returns_MMDXCII()
        {
            Assert.AreEqual("MMDXCII", Converter.Convert(2592));
        }
        [TestMethod]
        public void Convert_2593_Returns_MMDXCIII()
        {
            Assert.AreEqual("MMDXCIII", Converter.Convert(2593));
        }
        [TestMethod]
        public void Convert_2594_Returns_MMDXCIV()
        {
            Assert.AreEqual("MMDXCIV", Converter.Convert(2594));
        }
        [TestMethod]
        public void Convert_2595_Returns_MMDXCV()
        {
            Assert.AreEqual("MMDXCV", Converter.Convert(2595));
        }
        [TestMethod]
        public void Convert_2596_Returns_MMDXCVI()
        {
            Assert.AreEqual("MMDXCVI", Converter.Convert(2596));
        }
        [TestMethod]
        public void Convert_2597_Returns_MMDXCVII()
        {
            Assert.AreEqual("MMDXCVII", Converter.Convert(2597));
        }
        [TestMethod]
        public void Convert_2598_Returns_MMDXCVIII()
        {
            Assert.AreEqual("MMDXCVIII", Converter.Convert(2598));
        }
        [TestMethod]
        public void Convert_2599_Returns_MMDXCIX()
        {
            Assert.AreEqual("MMDXCIX", Converter.Convert(2599));
        }
        [TestMethod]
        public void Convert_2600_Returns_MMDC()
        {
            Assert.AreEqual("MMDC", Converter.Convert(2600));
        }
        [TestMethod]
        public void Convert_2601_Returns_MMDCI()
        {
            Assert.AreEqual("MMDCI", Converter.Convert(2601));
        }
        [TestMethod]
        public void Convert_2602_Returns_MMDCII()
        {
            Assert.AreEqual("MMDCII", Converter.Convert(2602));
        }
        [TestMethod]
        public void Convert_2603_Returns_MMDCIII()
        {
            Assert.AreEqual("MMDCIII", Converter.Convert(2603));
        }
        [TestMethod]
        public void Convert_2604_Returns_MMDCIV()
        {
            Assert.AreEqual("MMDCIV", Converter.Convert(2604));
        }
        [TestMethod]
        public void Convert_2605_Returns_MMDCV()
        {
            Assert.AreEqual("MMDCV", Converter.Convert(2605));
        }
        [TestMethod]
        public void Convert_2606_Returns_MMDCVI()
        {
            Assert.AreEqual("MMDCVI", Converter.Convert(2606));
        }
        [TestMethod]
        public void Convert_2607_Returns_MMDCVII()
        {
            Assert.AreEqual("MMDCVII", Converter.Convert(2607));
        }
        [TestMethod]
        public void Convert_2608_Returns_MMDCVIII()
        {
            Assert.AreEqual("MMDCVIII", Converter.Convert(2608));
        }
        [TestMethod]
        public void Convert_2609_Returns_MMDCIX()
        {
            Assert.AreEqual("MMDCIX", Converter.Convert(2609));
        }
        [TestMethod]
        public void Convert_2610_Returns_MMDCX()
        {
            Assert.AreEqual("MMDCX", Converter.Convert(2610));
        }
        [TestMethod]
        public void Convert_2611_Returns_MMDCXI()
        {
            Assert.AreEqual("MMDCXI", Converter.Convert(2611));
        }
        [TestMethod]
        public void Convert_2612_Returns_MMDCXII()
        {
            Assert.AreEqual("MMDCXII", Converter.Convert(2612));
        }
        [TestMethod]
        public void Convert_2613_Returns_MMDCXIII()
        {
            Assert.AreEqual("MMDCXIII", Converter.Convert(2613));
        }
        [TestMethod]
        public void Convert_2614_Returns_MMDCXIV()
        {
            Assert.AreEqual("MMDCXIV", Converter.Convert(2614));
        }
        [TestMethod]
        public void Convert_2615_Returns_MMDCXV()
        {
            Assert.AreEqual("MMDCXV", Converter.Convert(2615));
        }
        [TestMethod]
        public void Convert_2616_Returns_MMDCXVI()
        {
            Assert.AreEqual("MMDCXVI", Converter.Convert(2616));
        }
        [TestMethod]
        public void Convert_2617_Returns_MMDCXVII()
        {
            Assert.AreEqual("MMDCXVII", Converter.Convert(2617));
        }
        [TestMethod]
        public void Convert_2618_Returns_MMDCXVIII()
        {
            Assert.AreEqual("MMDCXVIII", Converter.Convert(2618));
        }
        [TestMethod]
        public void Convert_2619_Returns_MMDCXIX()
        {
            Assert.AreEqual("MMDCXIX", Converter.Convert(2619));
        }
        [TestMethod]
        public void Convert_2620_Returns_MMDCXX()
        {
            Assert.AreEqual("MMDCXX", Converter.Convert(2620));
        }
        [TestMethod]
        public void Convert_2621_Returns_MMDCXXI()
        {
            Assert.AreEqual("MMDCXXI", Converter.Convert(2621));
        }
        [TestMethod]
        public void Convert_2622_Returns_MMDCXXII()
        {
            Assert.AreEqual("MMDCXXII", Converter.Convert(2622));
        }
        [TestMethod]
        public void Convert_2623_Returns_MMDCXXIII()
        {
            Assert.AreEqual("MMDCXXIII", Converter.Convert(2623));
        }
        [TestMethod]
        public void Convert_2624_Returns_MMDCXXIV()
        {
            Assert.AreEqual("MMDCXXIV", Converter.Convert(2624));
        }
        [TestMethod]
        public void Convert_2625_Returns_MMDCXXV()
        {
            Assert.AreEqual("MMDCXXV", Converter.Convert(2625));
        }
        [TestMethod]
        public void Convert_2626_Returns_MMDCXXVI()
        {
            Assert.AreEqual("MMDCXXVI", Converter.Convert(2626));
        }
        [TestMethod]
        public void Convert_2627_Returns_MMDCXXVII()
        {
            Assert.AreEqual("MMDCXXVII", Converter.Convert(2627));
        }
        [TestMethod]
        public void Convert_2628_Returns_MMDCXXVIII()
        {
            Assert.AreEqual("MMDCXXVIII", Converter.Convert(2628));
        }
        [TestMethod]
        public void Convert_2629_Returns_MMDCXXIX()
        {
            Assert.AreEqual("MMDCXXIX", Converter.Convert(2629));
        }
        [TestMethod]
        public void Convert_2630_Returns_MMDCXXX()
        {
            Assert.AreEqual("MMDCXXX", Converter.Convert(2630));
        }
        [TestMethod]
        public void Convert_2631_Returns_MMDCXXXI()
        {
            Assert.AreEqual("MMDCXXXI", Converter.Convert(2631));
        }
        [TestMethod]
        public void Convert_2632_Returns_MMDCXXXII()
        {
            Assert.AreEqual("MMDCXXXII", Converter.Convert(2632));
        }
        [TestMethod]
        public void Convert_2633_Returns_MMDCXXXIII()
        {
            Assert.AreEqual("MMDCXXXIII", Converter.Convert(2633));
        }
        [TestMethod]
        public void Convert_2634_Returns_MMDCXXXIV()
        {
            Assert.AreEqual("MMDCXXXIV", Converter.Convert(2634));
        }
        [TestMethod]
        public void Convert_2635_Returns_MMDCXXXV()
        {
            Assert.AreEqual("MMDCXXXV", Converter.Convert(2635));
        }
        [TestMethod]
        public void Convert_2636_Returns_MMDCXXXVI()
        {
            Assert.AreEqual("MMDCXXXVI", Converter.Convert(2636));
        }
        [TestMethod]
        public void Convert_2637_Returns_MMDCXXXVII()
        {
            Assert.AreEqual("MMDCXXXVII", Converter.Convert(2637));
        }
        [TestMethod]
        public void Convert_2638_Returns_MMDCXXXVIII()
        {
            Assert.AreEqual("MMDCXXXVIII", Converter.Convert(2638));
        }
        [TestMethod]
        public void Convert_2639_Returns_MMDCXXXIX()
        {
            Assert.AreEqual("MMDCXXXIX", Converter.Convert(2639));
        }
        [TestMethod]
        public void Convert_2640_Returns_MMDCXL()
        {
            Assert.AreEqual("MMDCXL", Converter.Convert(2640));
        }
        [TestMethod]
        public void Convert_2641_Returns_MMDCXLI()
        {
            Assert.AreEqual("MMDCXLI", Converter.Convert(2641));
        }
        [TestMethod]
        public void Convert_2642_Returns_MMDCXLII()
        {
            Assert.AreEqual("MMDCXLII", Converter.Convert(2642));
        }
        [TestMethod]
        public void Convert_2643_Returns_MMDCXLIII()
        {
            Assert.AreEqual("MMDCXLIII", Converter.Convert(2643));
        }
        [TestMethod]
        public void Convert_2644_Returns_MMDCXLIV()
        {
            Assert.AreEqual("MMDCXLIV", Converter.Convert(2644));
        }
        [TestMethod]
        public void Convert_2645_Returns_MMDCXLV()
        {
            Assert.AreEqual("MMDCXLV", Converter.Convert(2645));
        }
        [TestMethod]
        public void Convert_2646_Returns_MMDCXLVI()
        {
            Assert.AreEqual("MMDCXLVI", Converter.Convert(2646));
        }
        [TestMethod]
        public void Convert_2647_Returns_MMDCXLVII()
        {
            Assert.AreEqual("MMDCXLVII", Converter.Convert(2647));
        }
        [TestMethod]
        public void Convert_2648_Returns_MMDCXLVIII()
        {
            Assert.AreEqual("MMDCXLVIII", Converter.Convert(2648));
        }
        [TestMethod]
        public void Convert_2649_Returns_MMDCXLIX()
        {
            Assert.AreEqual("MMDCXLIX", Converter.Convert(2649));
        }
        [TestMethod]
        public void Convert_2650_Returns_MMDCL()
        {
            Assert.AreEqual("MMDCL", Converter.Convert(2650));
        }
        [TestMethod]
        public void Convert_2651_Returns_MMDCLI()
        {
            Assert.AreEqual("MMDCLI", Converter.Convert(2651));
        }
        [TestMethod]
        public void Convert_2652_Returns_MMDCLII()
        {
            Assert.AreEqual("MMDCLII", Converter.Convert(2652));
        }
        [TestMethod]
        public void Convert_2653_Returns_MMDCLIII()
        {
            Assert.AreEqual("MMDCLIII", Converter.Convert(2653));
        }
        [TestMethod]
        public void Convert_2654_Returns_MMDCLIV()
        {
            Assert.AreEqual("MMDCLIV", Converter.Convert(2654));
        }
        [TestMethod]
        public void Convert_2655_Returns_MMDCLV()
        {
            Assert.AreEqual("MMDCLV", Converter.Convert(2655));
        }
        [TestMethod]
        public void Convert_2656_Returns_MMDCLVI()
        {
            Assert.AreEqual("MMDCLVI", Converter.Convert(2656));
        }
        [TestMethod]
        public void Convert_2657_Returns_MMDCLVII()
        {
            Assert.AreEqual("MMDCLVII", Converter.Convert(2657));
        }
        [TestMethod]
        public void Convert_2658_Returns_MMDCLVIII()
        {
            Assert.AreEqual("MMDCLVIII", Converter.Convert(2658));
        }
        [TestMethod]
        public void Convert_2659_Returns_MMDCLIX()
        {
            Assert.AreEqual("MMDCLIX", Converter.Convert(2659));
        }
        [TestMethod]
        public void Convert_2660_Returns_MMDCLX()
        {
            Assert.AreEqual("MMDCLX", Converter.Convert(2660));
        }
        [TestMethod]
        public void Convert_2661_Returns_MMDCLXI()
        {
            Assert.AreEqual("MMDCLXI", Converter.Convert(2661));
        }
        [TestMethod]
        public void Convert_2662_Returns_MMDCLXII()
        {
            Assert.AreEqual("MMDCLXII", Converter.Convert(2662));
        }
        [TestMethod]
        public void Convert_2663_Returns_MMDCLXIII()
        {
            Assert.AreEqual("MMDCLXIII", Converter.Convert(2663));
        }
        [TestMethod]
        public void Convert_2664_Returns_MMDCLXIV()
        {
            Assert.AreEqual("MMDCLXIV", Converter.Convert(2664));
        }
        [TestMethod]
        public void Convert_2665_Returns_MMDCLXV()
        {
            Assert.AreEqual("MMDCLXV", Converter.Convert(2665));
        }
        [TestMethod]
        public void Convert_2666_Returns_MMDCLXVI()
        {
            Assert.AreEqual("MMDCLXVI", Converter.Convert(2666));
        }
        [TestMethod]
        public void Convert_2667_Returns_MMDCLXVII()
        {
            Assert.AreEqual("MMDCLXVII", Converter.Convert(2667));
        }
        [TestMethod]
        public void Convert_2668_Returns_MMDCLXVIII()
        {
            Assert.AreEqual("MMDCLXVIII", Converter.Convert(2668));
        }
        [TestMethod]
        public void Convert_2669_Returns_MMDCLXIX()
        {
            Assert.AreEqual("MMDCLXIX", Converter.Convert(2669));
        }
        [TestMethod]
        public void Convert_2670_Returns_MMDCLXX()
        {
            Assert.AreEqual("MMDCLXX", Converter.Convert(2670));
        }
        [TestMethod]
        public void Convert_2671_Returns_MMDCLXXI()
        {
            Assert.AreEqual("MMDCLXXI", Converter.Convert(2671));
        }
        [TestMethod]
        public void Convert_2672_Returns_MMDCLXXII()
        {
            Assert.AreEqual("MMDCLXXII", Converter.Convert(2672));
        }
        [TestMethod]
        public void Convert_2673_Returns_MMDCLXXIII()
        {
            Assert.AreEqual("MMDCLXXIII", Converter.Convert(2673));
        }
        [TestMethod]
        public void Convert_2674_Returns_MMDCLXXIV()
        {
            Assert.AreEqual("MMDCLXXIV", Converter.Convert(2674));
        }
        [TestMethod]
        public void Convert_2675_Returns_MMDCLXXV()
        {
            Assert.AreEqual("MMDCLXXV", Converter.Convert(2675));
        }
        [TestMethod]
        public void Convert_2676_Returns_MMDCLXXVI()
        {
            Assert.AreEqual("MMDCLXXVI", Converter.Convert(2676));
        }
        [TestMethod]
        public void Convert_2677_Returns_MMDCLXXVII()
        {
            Assert.AreEqual("MMDCLXXVII", Converter.Convert(2677));
        }
        [TestMethod]
        public void Convert_2678_Returns_MMDCLXXVIII()
        {
            Assert.AreEqual("MMDCLXXVIII", Converter.Convert(2678));
        }
        [TestMethod]
        public void Convert_2679_Returns_MMDCLXXIX()
        {
            Assert.AreEqual("MMDCLXXIX", Converter.Convert(2679));
        }
        [TestMethod]
        public void Convert_2680_Returns_MMDCLXXX()
        {
            Assert.AreEqual("MMDCLXXX", Converter.Convert(2680));
        }
        [TestMethod]
        public void Convert_2681_Returns_MMDCLXXXI()
        {
            Assert.AreEqual("MMDCLXXXI", Converter.Convert(2681));
        }
        [TestMethod]
        public void Convert_2682_Returns_MMDCLXXXII()
        {
            Assert.AreEqual("MMDCLXXXII", Converter.Convert(2682));
        }
        [TestMethod]
        public void Convert_2683_Returns_MMDCLXXXIII()
        {
            Assert.AreEqual("MMDCLXXXIII", Converter.Convert(2683));
        }
        [TestMethod]
        public void Convert_2684_Returns_MMDCLXXXIV()
        {
            Assert.AreEqual("MMDCLXXXIV", Converter.Convert(2684));
        }
        [TestMethod]
        public void Convert_2685_Returns_MMDCLXXXV()
        {
            Assert.AreEqual("MMDCLXXXV", Converter.Convert(2685));
        }
        [TestMethod]
        public void Convert_2686_Returns_MMDCLXXXVI()
        {
            Assert.AreEqual("MMDCLXXXVI", Converter.Convert(2686));
        }
        [TestMethod]
        public void Convert_2687_Returns_MMDCLXXXVII()
        {
            Assert.AreEqual("MMDCLXXXVII", Converter.Convert(2687));
        }
        [TestMethod]
        public void Convert_2688_Returns_MMDCLXXXVIII()
        {
            Assert.AreEqual("MMDCLXXXVIII", Converter.Convert(2688));
        }
        [TestMethod]
        public void Convert_2689_Returns_MMDCLXXXIX()
        {
            Assert.AreEqual("MMDCLXXXIX", Converter.Convert(2689));
        }
        [TestMethod]
        public void Convert_2690_Returns_MMDCXC()
        {
            Assert.AreEqual("MMDCXC", Converter.Convert(2690));
        }
        [TestMethod]
        public void Convert_2691_Returns_MMDCXCI()
        {
            Assert.AreEqual("MMDCXCI", Converter.Convert(2691));
        }
        [TestMethod]
        public void Convert_2692_Returns_MMDCXCII()
        {
            Assert.AreEqual("MMDCXCII", Converter.Convert(2692));
        }
        [TestMethod]
        public void Convert_2693_Returns_MMDCXCIII()
        {
            Assert.AreEqual("MMDCXCIII", Converter.Convert(2693));
        }
        [TestMethod]
        public void Convert_2694_Returns_MMDCXCIV()
        {
            Assert.AreEqual("MMDCXCIV", Converter.Convert(2694));
        }
        [TestMethod]
        public void Convert_2695_Returns_MMDCXCV()
        {
            Assert.AreEqual("MMDCXCV", Converter.Convert(2695));
        }
        [TestMethod]
        public void Convert_2696_Returns_MMDCXCVI()
        {
            Assert.AreEqual("MMDCXCVI", Converter.Convert(2696));
        }
        [TestMethod]
        public void Convert_2697_Returns_MMDCXCVII()
        {
            Assert.AreEqual("MMDCXCVII", Converter.Convert(2697));
        }
        [TestMethod]
        public void Convert_2698_Returns_MMDCXCVIII()
        {
            Assert.AreEqual("MMDCXCVIII", Converter.Convert(2698));
        }
        [TestMethod]
        public void Convert_2699_Returns_MMDCXCIX()
        {
            Assert.AreEqual("MMDCXCIX", Converter.Convert(2699));
        }
        [TestMethod]
        public void Convert_2700_Returns_MMDCC()
        {
            Assert.AreEqual("MMDCC", Converter.Convert(2700));
        }
        [TestMethod]
        public void Convert_2701_Returns_MMDCCI()
        {
            Assert.AreEqual("MMDCCI", Converter.Convert(2701));
        }
        [TestMethod]
        public void Convert_2702_Returns_MMDCCII()
        {
            Assert.AreEqual("MMDCCII", Converter.Convert(2702));
        }
        [TestMethod]
        public void Convert_2703_Returns_MMDCCIII()
        {
            Assert.AreEqual("MMDCCIII", Converter.Convert(2703));
        }
        [TestMethod]
        public void Convert_2704_Returns_MMDCCIV()
        {
            Assert.AreEqual("MMDCCIV", Converter.Convert(2704));
        }
        [TestMethod]
        public void Convert_2705_Returns_MMDCCV()
        {
            Assert.AreEqual("MMDCCV", Converter.Convert(2705));
        }
        [TestMethod]
        public void Convert_2706_Returns_MMDCCVI()
        {
            Assert.AreEqual("MMDCCVI", Converter.Convert(2706));
        }
        [TestMethod]
        public void Convert_2707_Returns_MMDCCVII()
        {
            Assert.AreEqual("MMDCCVII", Converter.Convert(2707));
        }
        [TestMethod]
        public void Convert_2708_Returns_MMDCCVIII()
        {
            Assert.AreEqual("MMDCCVIII", Converter.Convert(2708));
        }
        [TestMethod]
        public void Convert_2709_Returns_MMDCCIX()
        {
            Assert.AreEqual("MMDCCIX", Converter.Convert(2709));
        }
        [TestMethod]
        public void Convert_2710_Returns_MMDCCX()
        {
            Assert.AreEqual("MMDCCX", Converter.Convert(2710));
        }
        [TestMethod]
        public void Convert_2711_Returns_MMDCCXI()
        {
            Assert.AreEqual("MMDCCXI", Converter.Convert(2711));
        }
        [TestMethod]
        public void Convert_2712_Returns_MMDCCXII()
        {
            Assert.AreEqual("MMDCCXII", Converter.Convert(2712));
        }
        [TestMethod]
        public void Convert_2713_Returns_MMDCCXIII()
        {
            Assert.AreEqual("MMDCCXIII", Converter.Convert(2713));
        }
        [TestMethod]
        public void Convert_2714_Returns_MMDCCXIV()
        {
            Assert.AreEqual("MMDCCXIV", Converter.Convert(2714));
        }
        [TestMethod]
        public void Convert_2715_Returns_MMDCCXV()
        {
            Assert.AreEqual("MMDCCXV", Converter.Convert(2715));
        }
        [TestMethod]
        public void Convert_2716_Returns_MMDCCXVI()
        {
            Assert.AreEqual("MMDCCXVI", Converter.Convert(2716));
        }
        [TestMethod]
        public void Convert_2717_Returns_MMDCCXVII()
        {
            Assert.AreEqual("MMDCCXVII", Converter.Convert(2717));
        }
        [TestMethod]
        public void Convert_2718_Returns_MMDCCXVIII()
        {
            Assert.AreEqual("MMDCCXVIII", Converter.Convert(2718));
        }
        [TestMethod]
        public void Convert_2719_Returns_MMDCCXIX()
        {
            Assert.AreEqual("MMDCCXIX", Converter.Convert(2719));
        }
        [TestMethod]
        public void Convert_2720_Returns_MMDCCXX()
        {
            Assert.AreEqual("MMDCCXX", Converter.Convert(2720));
        }
        [TestMethod]
        public void Convert_2721_Returns_MMDCCXXI()
        {
            Assert.AreEqual("MMDCCXXI", Converter.Convert(2721));
        }
        [TestMethod]
        public void Convert_2722_Returns_MMDCCXXII()
        {
            Assert.AreEqual("MMDCCXXII", Converter.Convert(2722));
        }
        [TestMethod]
        public void Convert_2723_Returns_MMDCCXXIII()
        {
            Assert.AreEqual("MMDCCXXIII", Converter.Convert(2723));
        }
        [TestMethod]
        public void Convert_2724_Returns_MMDCCXXIV()
        {
            Assert.AreEqual("MMDCCXXIV", Converter.Convert(2724));
        }
        [TestMethod]
        public void Convert_2725_Returns_MMDCCXXV()
        {
            Assert.AreEqual("MMDCCXXV", Converter.Convert(2725));
        }
        [TestMethod]
        public void Convert_2726_Returns_MMDCCXXVI()
        {
            Assert.AreEqual("MMDCCXXVI", Converter.Convert(2726));
        }
        [TestMethod]
        public void Convert_2727_Returns_MMDCCXXVII()
        {
            Assert.AreEqual("MMDCCXXVII", Converter.Convert(2727));
        }
        [TestMethod]
        public void Convert_2728_Returns_MMDCCXXVIII()
        {
            Assert.AreEqual("MMDCCXXVIII", Converter.Convert(2728));
        }
        [TestMethod]
        public void Convert_2729_Returns_MMDCCXXIX()
        {
            Assert.AreEqual("MMDCCXXIX", Converter.Convert(2729));
        }
        [TestMethod]
        public void Convert_2730_Returns_MMDCCXXX()
        {
            Assert.AreEqual("MMDCCXXX", Converter.Convert(2730));
        }
        [TestMethod]
        public void Convert_2731_Returns_MMDCCXXXI()
        {
            Assert.AreEqual("MMDCCXXXI", Converter.Convert(2731));
        }
        [TestMethod]
        public void Convert_2732_Returns_MMDCCXXXII()
        {
            Assert.AreEqual("MMDCCXXXII", Converter.Convert(2732));
        }
        [TestMethod]
        public void Convert_2733_Returns_MMDCCXXXIII()
        {
            Assert.AreEqual("MMDCCXXXIII", Converter.Convert(2733));
        }
        [TestMethod]
        public void Convert_2734_Returns_MMDCCXXXIV()
        {
            Assert.AreEqual("MMDCCXXXIV", Converter.Convert(2734));
        }
        [TestMethod]
        public void Convert_2735_Returns_MMDCCXXXV()
        {
            Assert.AreEqual("MMDCCXXXV", Converter.Convert(2735));
        }
        [TestMethod]
        public void Convert_2736_Returns_MMDCCXXXVI()
        {
            Assert.AreEqual("MMDCCXXXVI", Converter.Convert(2736));
        }
        [TestMethod]
        public void Convert_2737_Returns_MMDCCXXXVII()
        {
            Assert.AreEqual("MMDCCXXXVII", Converter.Convert(2737));
        }
        [TestMethod]
        public void Convert_2738_Returns_MMDCCXXXVIII()
        {
            Assert.AreEqual("MMDCCXXXVIII", Converter.Convert(2738));
        }
        [TestMethod]
        public void Convert_2739_Returns_MMDCCXXXIX()
        {
            Assert.AreEqual("MMDCCXXXIX", Converter.Convert(2739));
        }
        [TestMethod]
        public void Convert_2740_Returns_MMDCCXL()
        {
            Assert.AreEqual("MMDCCXL", Converter.Convert(2740));
        }
        [TestMethod]
        public void Convert_2741_Returns_MMDCCXLI()
        {
            Assert.AreEqual("MMDCCXLI", Converter.Convert(2741));
        }
        [TestMethod]
        public void Convert_2742_Returns_MMDCCXLII()
        {
            Assert.AreEqual("MMDCCXLII", Converter.Convert(2742));
        }
        [TestMethod]
        public void Convert_2743_Returns_MMDCCXLIII()
        {
            Assert.AreEqual("MMDCCXLIII", Converter.Convert(2743));
        }
        [TestMethod]
        public void Convert_2744_Returns_MMDCCXLIV()
        {
            Assert.AreEqual("MMDCCXLIV", Converter.Convert(2744));
        }
        [TestMethod]
        public void Convert_2745_Returns_MMDCCXLV()
        {
            Assert.AreEqual("MMDCCXLV", Converter.Convert(2745));
        }
        [TestMethod]
        public void Convert_2746_Returns_MMDCCXLVI()
        {
            Assert.AreEqual("MMDCCXLVI", Converter.Convert(2746));
        }
        [TestMethod]
        public void Convert_2747_Returns_MMDCCXLVII()
        {
            Assert.AreEqual("MMDCCXLVII", Converter.Convert(2747));
        }
        [TestMethod]
        public void Convert_2748_Returns_MMDCCXLVIII()
        {
            Assert.AreEqual("MMDCCXLVIII", Converter.Convert(2748));
        }
        [TestMethod]
        public void Convert_2749_Returns_MMDCCXLIX()
        {
            Assert.AreEqual("MMDCCXLIX", Converter.Convert(2749));
        }
        [TestMethod]
        public void Convert_2750_Returns_MMDCCL()
        {
            Assert.AreEqual("MMDCCL", Converter.Convert(2750));
        }
        [TestMethod]
        public void Convert_2751_Returns_MMDCCLI()
        {
            Assert.AreEqual("MMDCCLI", Converter.Convert(2751));
        }
        [TestMethod]
        public void Convert_2752_Returns_MMDCCLII()
        {
            Assert.AreEqual("MMDCCLII", Converter.Convert(2752));
        }
        [TestMethod]
        public void Convert_2753_Returns_MMDCCLIII()
        {
            Assert.AreEqual("MMDCCLIII", Converter.Convert(2753));
        }
        [TestMethod]
        public void Convert_2754_Returns_MMDCCLIV()
        {
            Assert.AreEqual("MMDCCLIV", Converter.Convert(2754));
        }
        [TestMethod]
        public void Convert_2755_Returns_MMDCCLV()
        {
            Assert.AreEqual("MMDCCLV", Converter.Convert(2755));
        }
        [TestMethod]
        public void Convert_2756_Returns_MMDCCLVI()
        {
            Assert.AreEqual("MMDCCLVI", Converter.Convert(2756));
        }
        [TestMethod]
        public void Convert_2757_Returns_MMDCCLVII()
        {
            Assert.AreEqual("MMDCCLVII", Converter.Convert(2757));
        }
        [TestMethod]
        public void Convert_2758_Returns_MMDCCLVIII()
        {
            Assert.AreEqual("MMDCCLVIII", Converter.Convert(2758));
        }
        [TestMethod]
        public void Convert_2759_Returns_MMDCCLIX()
        {
            Assert.AreEqual("MMDCCLIX", Converter.Convert(2759));
        }
        [TestMethod]
        public void Convert_2760_Returns_MMDCCLX()
        {
            Assert.AreEqual("MMDCCLX", Converter.Convert(2760));
        }
        [TestMethod]
        public void Convert_2761_Returns_MMDCCLXI()
        {
            Assert.AreEqual("MMDCCLXI", Converter.Convert(2761));
        }
        [TestMethod]
        public void Convert_2762_Returns_MMDCCLXII()
        {
            Assert.AreEqual("MMDCCLXII", Converter.Convert(2762));
        }
        [TestMethod]
        public void Convert_2763_Returns_MMDCCLXIII()
        {
            Assert.AreEqual("MMDCCLXIII", Converter.Convert(2763));
        }
        [TestMethod]
        public void Convert_2764_Returns_MMDCCLXIV()
        {
            Assert.AreEqual("MMDCCLXIV", Converter.Convert(2764));
        }
        [TestMethod]
        public void Convert_2765_Returns_MMDCCLXV()
        {
            Assert.AreEqual("MMDCCLXV", Converter.Convert(2765));
        }
        [TestMethod]
        public void Convert_2766_Returns_MMDCCLXVI()
        {
            Assert.AreEqual("MMDCCLXVI", Converter.Convert(2766));
        }
        [TestMethod]
        public void Convert_2767_Returns_MMDCCLXVII()
        {
            Assert.AreEqual("MMDCCLXVII", Converter.Convert(2767));
        }
        [TestMethod]
        public void Convert_2768_Returns_MMDCCLXVIII()
        {
            Assert.AreEqual("MMDCCLXVIII", Converter.Convert(2768));
        }
        [TestMethod]
        public void Convert_2769_Returns_MMDCCLXIX()
        {
            Assert.AreEqual("MMDCCLXIX", Converter.Convert(2769));
        }
        [TestMethod]
        public void Convert_2770_Returns_MMDCCLXX()
        {
            Assert.AreEqual("MMDCCLXX", Converter.Convert(2770));
        }
        [TestMethod]
        public void Convert_2771_Returns_MMDCCLXXI()
        {
            Assert.AreEqual("MMDCCLXXI", Converter.Convert(2771));
        }
        [TestMethod]
        public void Convert_2772_Returns_MMDCCLXXII()
        {
            Assert.AreEqual("MMDCCLXXII", Converter.Convert(2772));
        }
        [TestMethod]
        public void Convert_2773_Returns_MMDCCLXXIII()
        {
            Assert.AreEqual("MMDCCLXXIII", Converter.Convert(2773));
        }
        [TestMethod]
        public void Convert_2774_Returns_MMDCCLXXIV()
        {
            Assert.AreEqual("MMDCCLXXIV", Converter.Convert(2774));
        }
        [TestMethod]
        public void Convert_2775_Returns_MMDCCLXXV()
        {
            Assert.AreEqual("MMDCCLXXV", Converter.Convert(2775));
        }
        [TestMethod]
        public void Convert_2776_Returns_MMDCCLXXVI()
        {
            Assert.AreEqual("MMDCCLXXVI", Converter.Convert(2776));
        }
        [TestMethod]
        public void Convert_2777_Returns_MMDCCLXXVII()
        {
            Assert.AreEqual("MMDCCLXXVII", Converter.Convert(2777));
        }
        [TestMethod]
        public void Convert_2778_Returns_MMDCCLXXVIII()
        {
            Assert.AreEqual("MMDCCLXXVIII", Converter.Convert(2778));
        }
        [TestMethod]
        public void Convert_2779_Returns_MMDCCLXXIX()
        {
            Assert.AreEqual("MMDCCLXXIX", Converter.Convert(2779));
        }
        [TestMethod]
        public void Convert_2780_Returns_MMDCCLXXX()
        {
            Assert.AreEqual("MMDCCLXXX", Converter.Convert(2780));
        }
        [TestMethod]
        public void Convert_2781_Returns_MMDCCLXXXI()
        {
            Assert.AreEqual("MMDCCLXXXI", Converter.Convert(2781));
        }
        [TestMethod]
        public void Convert_2782_Returns_MMDCCLXXXII()
        {
            Assert.AreEqual("MMDCCLXXXII", Converter.Convert(2782));
        }
        [TestMethod]
        public void Convert_2783_Returns_MMDCCLXXXIII()
        {
            Assert.AreEqual("MMDCCLXXXIII", Converter.Convert(2783));
        }
        [TestMethod]
        public void Convert_2784_Returns_MMDCCLXXXIV()
        {
            Assert.AreEqual("MMDCCLXXXIV", Converter.Convert(2784));
        }
        [TestMethod]
        public void Convert_2785_Returns_MMDCCLXXXV()
        {
            Assert.AreEqual("MMDCCLXXXV", Converter.Convert(2785));
        }
        [TestMethod]
        public void Convert_2786_Returns_MMDCCLXXXVI()
        {
            Assert.AreEqual("MMDCCLXXXVI", Converter.Convert(2786));
        }
        [TestMethod]
        public void Convert_2787_Returns_MMDCCLXXXVII()
        {
            Assert.AreEqual("MMDCCLXXXVII", Converter.Convert(2787));
        }
        [TestMethod]
        public void Convert_2788_Returns_MMDCCLXXXVIII()
        {
            Assert.AreEqual("MMDCCLXXXVIII", Converter.Convert(2788));
        }
        [TestMethod]
        public void Convert_2789_Returns_MMDCCLXXXIX()
        {
            Assert.AreEqual("MMDCCLXXXIX", Converter.Convert(2789));
        }
        [TestMethod]
        public void Convert_2790_Returns_MMDCCXC()
        {
            Assert.AreEqual("MMDCCXC", Converter.Convert(2790));
        }
        [TestMethod]
        public void Convert_2791_Returns_MMDCCXCI()
        {
            Assert.AreEqual("MMDCCXCI", Converter.Convert(2791));
        }
        [TestMethod]
        public void Convert_2792_Returns_MMDCCXCII()
        {
            Assert.AreEqual("MMDCCXCII", Converter.Convert(2792));
        }
        [TestMethod]
        public void Convert_2793_Returns_MMDCCXCIII()
        {
            Assert.AreEqual("MMDCCXCIII", Converter.Convert(2793));
        }
        [TestMethod]
        public void Convert_2794_Returns_MMDCCXCIV()
        {
            Assert.AreEqual("MMDCCXCIV", Converter.Convert(2794));
        }
        [TestMethod]
        public void Convert_2795_Returns_MMDCCXCV()
        {
            Assert.AreEqual("MMDCCXCV", Converter.Convert(2795));
        }
        [TestMethod]
        public void Convert_2796_Returns_MMDCCXCVI()
        {
            Assert.AreEqual("MMDCCXCVI", Converter.Convert(2796));
        }
        [TestMethod]
        public void Convert_2797_Returns_MMDCCXCVII()
        {
            Assert.AreEqual("MMDCCXCVII", Converter.Convert(2797));
        }
        [TestMethod]
        public void Convert_2798_Returns_MMDCCXCVIII()
        {
            Assert.AreEqual("MMDCCXCVIII", Converter.Convert(2798));
        }
        [TestMethod]
        public void Convert_2799_Returns_MMDCCXCIX()
        {
            Assert.AreEqual("MMDCCXCIX", Converter.Convert(2799));
        }
        [TestMethod]
        public void Convert_2800_Returns_MMDCCC()
        {
            Assert.AreEqual("MMDCCC", Converter.Convert(2800));
        }
        [TestMethod]
        public void Convert_2801_Returns_MMDCCCI()
        {
            Assert.AreEqual("MMDCCCI", Converter.Convert(2801));
        }
        [TestMethod]
        public void Convert_2802_Returns_MMDCCCII()
        {
            Assert.AreEqual("MMDCCCII", Converter.Convert(2802));
        }
        [TestMethod]
        public void Convert_2803_Returns_MMDCCCIII()
        {
            Assert.AreEqual("MMDCCCIII", Converter.Convert(2803));
        }
        [TestMethod]
        public void Convert_2804_Returns_MMDCCCIV()
        {
            Assert.AreEqual("MMDCCCIV", Converter.Convert(2804));
        }
        [TestMethod]
        public void Convert_2805_Returns_MMDCCCV()
        {
            Assert.AreEqual("MMDCCCV", Converter.Convert(2805));
        }
        [TestMethod]
        public void Convert_2806_Returns_MMDCCCVI()
        {
            Assert.AreEqual("MMDCCCVI", Converter.Convert(2806));
        }
        [TestMethod]
        public void Convert_2807_Returns_MMDCCCVII()
        {
            Assert.AreEqual("MMDCCCVII", Converter.Convert(2807));
        }
        [TestMethod]
        public void Convert_2808_Returns_MMDCCCVIII()
        {
            Assert.AreEqual("MMDCCCVIII", Converter.Convert(2808));
        }
        [TestMethod]
        public void Convert_2809_Returns_MMDCCCIX()
        {
            Assert.AreEqual("MMDCCCIX", Converter.Convert(2809));
        }
        [TestMethod]
        public void Convert_2810_Returns_MMDCCCX()
        {
            Assert.AreEqual("MMDCCCX", Converter.Convert(2810));
        }
        [TestMethod]
        public void Convert_2811_Returns_MMDCCCXI()
        {
            Assert.AreEqual("MMDCCCXI", Converter.Convert(2811));
        }
        [TestMethod]
        public void Convert_2812_Returns_MMDCCCXII()
        {
            Assert.AreEqual("MMDCCCXII", Converter.Convert(2812));
        }
        [TestMethod]
        public void Convert_2813_Returns_MMDCCCXIII()
        {
            Assert.AreEqual("MMDCCCXIII", Converter.Convert(2813));
        }
        [TestMethod]
        public void Convert_2814_Returns_MMDCCCXIV()
        {
            Assert.AreEqual("MMDCCCXIV", Converter.Convert(2814));
        }
        [TestMethod]
        public void Convert_2815_Returns_MMDCCCXV()
        {
            Assert.AreEqual("MMDCCCXV", Converter.Convert(2815));
        }
        [TestMethod]
        public void Convert_2816_Returns_MMDCCCXVI()
        {
            Assert.AreEqual("MMDCCCXVI", Converter.Convert(2816));
        }
        [TestMethod]
        public void Convert_2817_Returns_MMDCCCXVII()
        {
            Assert.AreEqual("MMDCCCXVII", Converter.Convert(2817));
        }
        [TestMethod]
        public void Convert_2818_Returns_MMDCCCXVIII()
        {
            Assert.AreEqual("MMDCCCXVIII", Converter.Convert(2818));
        }
        [TestMethod]
        public void Convert_2819_Returns_MMDCCCXIX()
        {
            Assert.AreEqual("MMDCCCXIX", Converter.Convert(2819));
        }
        [TestMethod]
        public void Convert_2820_Returns_MMDCCCXX()
        {
            Assert.AreEqual("MMDCCCXX", Converter.Convert(2820));
        }
        [TestMethod]
        public void Convert_2821_Returns_MMDCCCXXI()
        {
            Assert.AreEqual("MMDCCCXXI", Converter.Convert(2821));
        }
        [TestMethod]
        public void Convert_2822_Returns_MMDCCCXXII()
        {
            Assert.AreEqual("MMDCCCXXII", Converter.Convert(2822));
        }
        [TestMethod]
        public void Convert_2823_Returns_MMDCCCXXIII()
        {
            Assert.AreEqual("MMDCCCXXIII", Converter.Convert(2823));
        }
        [TestMethod]
        public void Convert_2824_Returns_MMDCCCXXIV()
        {
            Assert.AreEqual("MMDCCCXXIV", Converter.Convert(2824));
        }
        [TestMethod]
        public void Convert_2825_Returns_MMDCCCXXV()
        {
            Assert.AreEqual("MMDCCCXXV", Converter.Convert(2825));
        }
        [TestMethod]
        public void Convert_2826_Returns_MMDCCCXXVI()
        {
            Assert.AreEqual("MMDCCCXXVI", Converter.Convert(2826));
        }
        [TestMethod]
        public void Convert_2827_Returns_MMDCCCXXVII()
        {
            Assert.AreEqual("MMDCCCXXVII", Converter.Convert(2827));
        }
        [TestMethod]
        public void Convert_2828_Returns_MMDCCCXXVIII()
        {
            Assert.AreEqual("MMDCCCXXVIII", Converter.Convert(2828));
        }
        [TestMethod]
        public void Convert_2829_Returns_MMDCCCXXIX()
        {
            Assert.AreEqual("MMDCCCXXIX", Converter.Convert(2829));
        }
        [TestMethod]
        public void Convert_2830_Returns_MMDCCCXXX()
        {
            Assert.AreEqual("MMDCCCXXX", Converter.Convert(2830));
        }
        [TestMethod]
        public void Convert_2831_Returns_MMDCCCXXXI()
        {
            Assert.AreEqual("MMDCCCXXXI", Converter.Convert(2831));
        }
        [TestMethod]
        public void Convert_2832_Returns_MMDCCCXXXII()
        {
            Assert.AreEqual("MMDCCCXXXII", Converter.Convert(2832));
        }
        [TestMethod]
        public void Convert_2833_Returns_MMDCCCXXXIII()
        {
            Assert.AreEqual("MMDCCCXXXIII", Converter.Convert(2833));
        }
        [TestMethod]
        public void Convert_2834_Returns_MMDCCCXXXIV()
        {
            Assert.AreEqual("MMDCCCXXXIV", Converter.Convert(2834));
        }
        [TestMethod]
        public void Convert_2835_Returns_MMDCCCXXXV()
        {
            Assert.AreEqual("MMDCCCXXXV", Converter.Convert(2835));
        }
        [TestMethod]
        public void Convert_2836_Returns_MMDCCCXXXVI()
        {
            Assert.AreEqual("MMDCCCXXXVI", Converter.Convert(2836));
        }
        [TestMethod]
        public void Convert_2837_Returns_MMDCCCXXXVII()
        {
            Assert.AreEqual("MMDCCCXXXVII", Converter.Convert(2837));
        }
        [TestMethod]
        public void Convert_2838_Returns_MMDCCCXXXVIII()
        {
            Assert.AreEqual("MMDCCCXXXVIII", Converter.Convert(2838));
        }
        [TestMethod]
        public void Convert_2839_Returns_MMDCCCXXXIX()
        {
            Assert.AreEqual("MMDCCCXXXIX", Converter.Convert(2839));
        }
        [TestMethod]
        public void Convert_2840_Returns_MMDCCCXL()
        {
            Assert.AreEqual("MMDCCCXL", Converter.Convert(2840));
        }
        [TestMethod]
        public void Convert_2841_Returns_MMDCCCXLI()
        {
            Assert.AreEqual("MMDCCCXLI", Converter.Convert(2841));
        }
        [TestMethod]
        public void Convert_2842_Returns_MMDCCCXLII()
        {
            Assert.AreEqual("MMDCCCXLII", Converter.Convert(2842));
        }
        [TestMethod]
        public void Convert_2843_Returns_MMDCCCXLIII()
        {
            Assert.AreEqual("MMDCCCXLIII", Converter.Convert(2843));
        }
        [TestMethod]
        public void Convert_2844_Returns_MMDCCCXLIV()
        {
            Assert.AreEqual("MMDCCCXLIV", Converter.Convert(2844));
        }
        [TestMethod]
        public void Convert_2845_Returns_MMDCCCXLV()
        {
            Assert.AreEqual("MMDCCCXLV", Converter.Convert(2845));
        }
        [TestMethod]
        public void Convert_2846_Returns_MMDCCCXLVI()
        {
            Assert.AreEqual("MMDCCCXLVI", Converter.Convert(2846));
        }
        [TestMethod]
        public void Convert_2847_Returns_MMDCCCXLVII()
        {
            Assert.AreEqual("MMDCCCXLVII", Converter.Convert(2847));
        }
        [TestMethod]
        public void Convert_2848_Returns_MMDCCCXLVIII()
        {
            Assert.AreEqual("MMDCCCXLVIII", Converter.Convert(2848));
        }
        [TestMethod]
        public void Convert_2849_Returns_MMDCCCXLIX()
        {
            Assert.AreEqual("MMDCCCXLIX", Converter.Convert(2849));
        }
        [TestMethod]
        public void Convert_2850_Returns_MMDCCCL()
        {
            Assert.AreEqual("MMDCCCL", Converter.Convert(2850));
        }
        [TestMethod]
        public void Convert_2851_Returns_MMDCCCLI()
        {
            Assert.AreEqual("MMDCCCLI", Converter.Convert(2851));
        }
        [TestMethod]
        public void Convert_2852_Returns_MMDCCCLII()
        {
            Assert.AreEqual("MMDCCCLII", Converter.Convert(2852));
        }
        [TestMethod]
        public void Convert_2853_Returns_MMDCCCLIII()
        {
            Assert.AreEqual("MMDCCCLIII", Converter.Convert(2853));
        }
        [TestMethod]
        public void Convert_2854_Returns_MMDCCCLIV()
        {
            Assert.AreEqual("MMDCCCLIV", Converter.Convert(2854));
        }
        [TestMethod]
        public void Convert_2855_Returns_MMDCCCLV()
        {
            Assert.AreEqual("MMDCCCLV", Converter.Convert(2855));
        }
        [TestMethod]
        public void Convert_2856_Returns_MMDCCCLVI()
        {
            Assert.AreEqual("MMDCCCLVI", Converter.Convert(2856));
        }
        [TestMethod]
        public void Convert_2857_Returns_MMDCCCLVII()
        {
            Assert.AreEqual("MMDCCCLVII", Converter.Convert(2857));
        }
        [TestMethod]
        public void Convert_2858_Returns_MMDCCCLVIII()
        {
            Assert.AreEqual("MMDCCCLVIII", Converter.Convert(2858));
        }
        [TestMethod]
        public void Convert_2859_Returns_MMDCCCLIX()
        {
            Assert.AreEqual("MMDCCCLIX", Converter.Convert(2859));
        }
        [TestMethod]
        public void Convert_2860_Returns_MMDCCCLX()
        {
            Assert.AreEqual("MMDCCCLX", Converter.Convert(2860));
        }
        [TestMethod]
        public void Convert_2861_Returns_MMDCCCLXI()
        {
            Assert.AreEqual("MMDCCCLXI", Converter.Convert(2861));
        }
        [TestMethod]
        public void Convert_2862_Returns_MMDCCCLXII()
        {
            Assert.AreEqual("MMDCCCLXII", Converter.Convert(2862));
        }
        [TestMethod]
        public void Convert_2863_Returns_MMDCCCLXIII()
        {
            Assert.AreEqual("MMDCCCLXIII", Converter.Convert(2863));
        }
        [TestMethod]
        public void Convert_2864_Returns_MMDCCCLXIV()
        {
            Assert.AreEqual("MMDCCCLXIV", Converter.Convert(2864));
        }
        [TestMethod]
        public void Convert_2865_Returns_MMDCCCLXV()
        {
            Assert.AreEqual("MMDCCCLXV", Converter.Convert(2865));
        }
        [TestMethod]
        public void Convert_2866_Returns_MMDCCCLXVI()
        {
            Assert.AreEqual("MMDCCCLXVI", Converter.Convert(2866));
        }
        [TestMethod]
        public void Convert_2867_Returns_MMDCCCLXVII()
        {
            Assert.AreEqual("MMDCCCLXVII", Converter.Convert(2867));
        }
        [TestMethod]
        public void Convert_2868_Returns_MMDCCCLXVIII()
        {
            Assert.AreEqual("MMDCCCLXVIII", Converter.Convert(2868));
        }
        [TestMethod]
        public void Convert_2869_Returns_MMDCCCLXIX()
        {
            Assert.AreEqual("MMDCCCLXIX", Converter.Convert(2869));
        }
        [TestMethod]
        public void Convert_2870_Returns_MMDCCCLXX()
        {
            Assert.AreEqual("MMDCCCLXX", Converter.Convert(2870));
        }
        [TestMethod]
        public void Convert_2871_Returns_MMDCCCLXXI()
        {
            Assert.AreEqual("MMDCCCLXXI", Converter.Convert(2871));
        }
        [TestMethod]
        public void Convert_2872_Returns_MMDCCCLXXII()
        {
            Assert.AreEqual("MMDCCCLXXII", Converter.Convert(2872));
        }
        [TestMethod]
        public void Convert_2873_Returns_MMDCCCLXXIII()
        {
            Assert.AreEqual("MMDCCCLXXIII", Converter.Convert(2873));
        }
        [TestMethod]
        public void Convert_2874_Returns_MMDCCCLXXIV()
        {
            Assert.AreEqual("MMDCCCLXXIV", Converter.Convert(2874));
        }
        [TestMethod]
        public void Convert_2875_Returns_MMDCCCLXXV()
        {
            Assert.AreEqual("MMDCCCLXXV", Converter.Convert(2875));
        }
        [TestMethod]
        public void Convert_2876_Returns_MMDCCCLXXVI()
        {
            Assert.AreEqual("MMDCCCLXXVI", Converter.Convert(2876));
        }
        [TestMethod]
        public void Convert_2877_Returns_MMDCCCLXXVII()
        {
            Assert.AreEqual("MMDCCCLXXVII", Converter.Convert(2877));
        }
        [TestMethod]
        public void Convert_2878_Returns_MMDCCCLXXVIII()
        {
            Assert.AreEqual("MMDCCCLXXVIII", Converter.Convert(2878));
        }
        [TestMethod]
        public void Convert_2879_Returns_MMDCCCLXXIX()
        {
            Assert.AreEqual("MMDCCCLXXIX", Converter.Convert(2879));
        }
        [TestMethod]
        public void Convert_2880_Returns_MMDCCCLXXX()
        {
            Assert.AreEqual("MMDCCCLXXX", Converter.Convert(2880));
        }
        [TestMethod]
        public void Convert_2881_Returns_MMDCCCLXXXI()
        {
            Assert.AreEqual("MMDCCCLXXXI", Converter.Convert(2881));
        }
        [TestMethod]
        public void Convert_2882_Returns_MMDCCCLXXXII()
        {
            Assert.AreEqual("MMDCCCLXXXII", Converter.Convert(2882));
        }
        [TestMethod]
        public void Convert_2883_Returns_MMDCCCLXXXIII()
        {
            Assert.AreEqual("MMDCCCLXXXIII", Converter.Convert(2883));
        }
        [TestMethod]
        public void Convert_2884_Returns_MMDCCCLXXXIV()
        {
            Assert.AreEqual("MMDCCCLXXXIV", Converter.Convert(2884));
        }
        [TestMethod]
        public void Convert_2885_Returns_MMDCCCLXXXV()
        {
            Assert.AreEqual("MMDCCCLXXXV", Converter.Convert(2885));
        }
        [TestMethod]
        public void Convert_2886_Returns_MMDCCCLXXXVI()
        {
            Assert.AreEqual("MMDCCCLXXXVI", Converter.Convert(2886));
        }
        [TestMethod]
        public void Convert_2887_Returns_MMDCCCLXXXVII()
        {
            Assert.AreEqual("MMDCCCLXXXVII", Converter.Convert(2887));
        }
        [TestMethod]
        public void Convert_2888_Returns_MMDCCCLXXXVIII()
        {
            Assert.AreEqual("MMDCCCLXXXVIII", Converter.Convert(2888));
        }
        [TestMethod]
        public void Convert_2889_Returns_MMDCCCLXXXIX()
        {
            Assert.AreEqual("MMDCCCLXXXIX", Converter.Convert(2889));
        }
        [TestMethod]
        public void Convert_2890_Returns_MMDCCCXC()
        {
            Assert.AreEqual("MMDCCCXC", Converter.Convert(2890));
        }
        [TestMethod]
        public void Convert_2891_Returns_MMDCCCXCI()
        {
            Assert.AreEqual("MMDCCCXCI", Converter.Convert(2891));
        }
        [TestMethod]
        public void Convert_2892_Returns_MMDCCCXCII()
        {
            Assert.AreEqual("MMDCCCXCII", Converter.Convert(2892));
        }
        [TestMethod]
        public void Convert_2893_Returns_MMDCCCXCIII()
        {
            Assert.AreEqual("MMDCCCXCIII", Converter.Convert(2893));
        }
        [TestMethod]
        public void Convert_2894_Returns_MMDCCCXCIV()
        {
            Assert.AreEqual("MMDCCCXCIV", Converter.Convert(2894));
        }
        [TestMethod]
        public void Convert_2895_Returns_MMDCCCXCV()
        {
            Assert.AreEqual("MMDCCCXCV", Converter.Convert(2895));
        }
        [TestMethod]
        public void Convert_2896_Returns_MMDCCCXCVI()
        {
            Assert.AreEqual("MMDCCCXCVI", Converter.Convert(2896));
        }
        [TestMethod]
        public void Convert_2897_Returns_MMDCCCXCVII()
        {
            Assert.AreEqual("MMDCCCXCVII", Converter.Convert(2897));
        }
        [TestMethod]
        public void Convert_2898_Returns_MMDCCCXCVIII()
        {
            Assert.AreEqual("MMDCCCXCVIII", Converter.Convert(2898));
        }
        [TestMethod]
        public void Convert_2899_Returns_MMDCCCXCIX()
        {
            Assert.AreEqual("MMDCCCXCIX", Converter.Convert(2899));
        }
        [TestMethod]
        public void Convert_2900_Returns_MMCM()
        {
            Assert.AreEqual("MMCM", Converter.Convert(2900));
        }
        [TestMethod]
        public void Convert_2901_Returns_MMCMI()
        {
            Assert.AreEqual("MMCMI", Converter.Convert(2901));
        }
        [TestMethod]
        public void Convert_2902_Returns_MMCMII()
        {
            Assert.AreEqual("MMCMII", Converter.Convert(2902));
        }
        [TestMethod]
        public void Convert_2903_Returns_MMCMIII()
        {
            Assert.AreEqual("MMCMIII", Converter.Convert(2903));
        }
        [TestMethod]
        public void Convert_2904_Returns_MMCMIV()
        {
            Assert.AreEqual("MMCMIV", Converter.Convert(2904));
        }
        [TestMethod]
        public void Convert_2905_Returns_MMCMV()
        {
            Assert.AreEqual("MMCMV", Converter.Convert(2905));
        }
        [TestMethod]
        public void Convert_2906_Returns_MMCMVI()
        {
            Assert.AreEqual("MMCMVI", Converter.Convert(2906));
        }
        [TestMethod]
        public void Convert_2907_Returns_MMCMVII()
        {
            Assert.AreEqual("MMCMVII", Converter.Convert(2907));
        }
        [TestMethod]
        public void Convert_2908_Returns_MMCMVIII()
        {
            Assert.AreEqual("MMCMVIII", Converter.Convert(2908));
        }
        [TestMethod]
        public void Convert_2909_Returns_MMCMIX()
        {
            Assert.AreEqual("MMCMIX", Converter.Convert(2909));
        }
        [TestMethod]
        public void Convert_2910_Returns_MMCMX()
        {
            Assert.AreEqual("MMCMX", Converter.Convert(2910));
        }
        [TestMethod]
        public void Convert_2911_Returns_MMCMXI()
        {
            Assert.AreEqual("MMCMXI", Converter.Convert(2911));
        }
        [TestMethod]
        public void Convert_2912_Returns_MMCMXII()
        {
            Assert.AreEqual("MMCMXII", Converter.Convert(2912));
        }
        [TestMethod]
        public void Convert_2913_Returns_MMCMXIII()
        {
            Assert.AreEqual("MMCMXIII", Converter.Convert(2913));
        }
        [TestMethod]
        public void Convert_2914_Returns_MMCMXIV()
        {
            Assert.AreEqual("MMCMXIV", Converter.Convert(2914));
        }
        [TestMethod]
        public void Convert_2915_Returns_MMCMXV()
        {
            Assert.AreEqual("MMCMXV", Converter.Convert(2915));
        }
        [TestMethod]
        public void Convert_2916_Returns_MMCMXVI()
        {
            Assert.AreEqual("MMCMXVI", Converter.Convert(2916));
        }
        [TestMethod]
        public void Convert_2917_Returns_MMCMXVII()
        {
            Assert.AreEqual("MMCMXVII", Converter.Convert(2917));
        }
        [TestMethod]
        public void Convert_2918_Returns_MMCMXVIII()
        {
            Assert.AreEqual("MMCMXVIII", Converter.Convert(2918));
        }
        [TestMethod]
        public void Convert_2919_Returns_MMCMXIX()
        {
            Assert.AreEqual("MMCMXIX", Converter.Convert(2919));
        }
        [TestMethod]
        public void Convert_2920_Returns_MMCMXX()
        {
            Assert.AreEqual("MMCMXX", Converter.Convert(2920));
        }
        [TestMethod]
        public void Convert_2921_Returns_MMCMXXI()
        {
            Assert.AreEqual("MMCMXXI", Converter.Convert(2921));
        }
        [TestMethod]
        public void Convert_2922_Returns_MMCMXXII()
        {
            Assert.AreEqual("MMCMXXII", Converter.Convert(2922));
        }
        [TestMethod]
        public void Convert_2923_Returns_MMCMXXIII()
        {
            Assert.AreEqual("MMCMXXIII", Converter.Convert(2923));
        }
        [TestMethod]
        public void Convert_2924_Returns_MMCMXXIV()
        {
            Assert.AreEqual("MMCMXXIV", Converter.Convert(2924));
        }
        [TestMethod]
        public void Convert_2925_Returns_MMCMXXV()
        {
            Assert.AreEqual("MMCMXXV", Converter.Convert(2925));
        }
        [TestMethod]
        public void Convert_2926_Returns_MMCMXXVI()
        {
            Assert.AreEqual("MMCMXXVI", Converter.Convert(2926));
        }
        [TestMethod]
        public void Convert_2927_Returns_MMCMXXVII()
        {
            Assert.AreEqual("MMCMXXVII", Converter.Convert(2927));
        }
        [TestMethod]
        public void Convert_2928_Returns_MMCMXXVIII()
        {
            Assert.AreEqual("MMCMXXVIII", Converter.Convert(2928));
        }
        [TestMethod]
        public void Convert_2929_Returns_MMCMXXIX()
        {
            Assert.AreEqual("MMCMXXIX", Converter.Convert(2929));
        }
        [TestMethod]
        public void Convert_2930_Returns_MMCMXXX()
        {
            Assert.AreEqual("MMCMXXX", Converter.Convert(2930));
        }
        [TestMethod]
        public void Convert_2931_Returns_MMCMXXXI()
        {
            Assert.AreEqual("MMCMXXXI", Converter.Convert(2931));
        }
        [TestMethod]
        public void Convert_2932_Returns_MMCMXXXII()
        {
            Assert.AreEqual("MMCMXXXII", Converter.Convert(2932));
        }
        [TestMethod]
        public void Convert_2933_Returns_MMCMXXXIII()
        {
            Assert.AreEqual("MMCMXXXIII", Converter.Convert(2933));
        }
        [TestMethod]
        public void Convert_2934_Returns_MMCMXXXIV()
        {
            Assert.AreEqual("MMCMXXXIV", Converter.Convert(2934));
        }
        [TestMethod]
        public void Convert_2935_Returns_MMCMXXXV()
        {
            Assert.AreEqual("MMCMXXXV", Converter.Convert(2935));
        }
        [TestMethod]
        public void Convert_2936_Returns_MMCMXXXVI()
        {
            Assert.AreEqual("MMCMXXXVI", Converter.Convert(2936));
        }
        [TestMethod]
        public void Convert_2937_Returns_MMCMXXXVII()
        {
            Assert.AreEqual("MMCMXXXVII", Converter.Convert(2937));
        }
        [TestMethod]
        public void Convert_2938_Returns_MMCMXXXVIII()
        {
            Assert.AreEqual("MMCMXXXVIII", Converter.Convert(2938));
        }
        [TestMethod]
        public void Convert_2939_Returns_MMCMXXXIX()
        {
            Assert.AreEqual("MMCMXXXIX", Converter.Convert(2939));
        }
        [TestMethod]
        public void Convert_2940_Returns_MMCMXL()
        {
            Assert.AreEqual("MMCMXL", Converter.Convert(2940));
        }
        [TestMethod]
        public void Convert_2941_Returns_MMCMXLI()
        {
            Assert.AreEqual("MMCMXLI", Converter.Convert(2941));
        }
        [TestMethod]
        public void Convert_2942_Returns_MMCMXLII()
        {
            Assert.AreEqual("MMCMXLII", Converter.Convert(2942));
        }
        [TestMethod]
        public void Convert_2943_Returns_MMCMXLIII()
        {
            Assert.AreEqual("MMCMXLIII", Converter.Convert(2943));
        }
        [TestMethod]
        public void Convert_2944_Returns_MMCMXLIV()
        {
            Assert.AreEqual("MMCMXLIV", Converter.Convert(2944));
        }
        [TestMethod]
        public void Convert_2945_Returns_MMCMXLV()
        {
            Assert.AreEqual("MMCMXLV", Converter.Convert(2945));
        }
        [TestMethod]
        public void Convert_2946_Returns_MMCMXLVI()
        {
            Assert.AreEqual("MMCMXLVI", Converter.Convert(2946));
        }
        [TestMethod]
        public void Convert_2947_Returns_MMCMXLVII()
        {
            Assert.AreEqual("MMCMXLVII", Converter.Convert(2947));
        }
        [TestMethod]
        public void Convert_2948_Returns_MMCMXLVIII()
        {
            Assert.AreEqual("MMCMXLVIII", Converter.Convert(2948));
        }
        [TestMethod]
        public void Convert_2949_Returns_MMCMXLIX()
        {
            Assert.AreEqual("MMCMXLIX", Converter.Convert(2949));
        }
        [TestMethod]
        public void Convert_2950_Returns_MMCML()
        {
            Assert.AreEqual("MMCML", Converter.Convert(2950));
        }
        [TestMethod]
        public void Convert_2951_Returns_MMCMLI()
        {
            Assert.AreEqual("MMCMLI", Converter.Convert(2951));
        }
        [TestMethod]
        public void Convert_2952_Returns_MMCMLII()
        {
            Assert.AreEqual("MMCMLII", Converter.Convert(2952));
        }
        [TestMethod]
        public void Convert_2953_Returns_MMCMLIII()
        {
            Assert.AreEqual("MMCMLIII", Converter.Convert(2953));
        }
        [TestMethod]
        public void Convert_2954_Returns_MMCMLIV()
        {
            Assert.AreEqual("MMCMLIV", Converter.Convert(2954));
        }
        [TestMethod]
        public void Convert_2955_Returns_MMCMLV()
        {
            Assert.AreEqual("MMCMLV", Converter.Convert(2955));
        }
        [TestMethod]
        public void Convert_2956_Returns_MMCMLVI()
        {
            Assert.AreEqual("MMCMLVI", Converter.Convert(2956));
        }
        [TestMethod]
        public void Convert_2957_Returns_MMCMLVII()
        {
            Assert.AreEqual("MMCMLVII", Converter.Convert(2957));
        }
        [TestMethod]
        public void Convert_2958_Returns_MMCMLVIII()
        {
            Assert.AreEqual("MMCMLVIII", Converter.Convert(2958));
        }
        [TestMethod]
        public void Convert_2959_Returns_MMCMLIX()
        {
            Assert.AreEqual("MMCMLIX", Converter.Convert(2959));
        }
        [TestMethod]
        public void Convert_2960_Returns_MMCMLX()
        {
            Assert.AreEqual("MMCMLX", Converter.Convert(2960));
        }
        [TestMethod]
        public void Convert_2961_Returns_MMCMLXI()
        {
            Assert.AreEqual("MMCMLXI", Converter.Convert(2961));
        }
        [TestMethod]
        public void Convert_2962_Returns_MMCMLXII()
        {
            Assert.AreEqual("MMCMLXII", Converter.Convert(2962));
        }
        [TestMethod]
        public void Convert_2963_Returns_MMCMLXIII()
        {
            Assert.AreEqual("MMCMLXIII", Converter.Convert(2963));
        }
        [TestMethod]
        public void Convert_2964_Returns_MMCMLXIV()
        {
            Assert.AreEqual("MMCMLXIV", Converter.Convert(2964));
        }
        [TestMethod]
        public void Convert_2965_Returns_MMCMLXV()
        {
            Assert.AreEqual("MMCMLXV", Converter.Convert(2965));
        }
        [TestMethod]
        public void Convert_2966_Returns_MMCMLXVI()
        {
            Assert.AreEqual("MMCMLXVI", Converter.Convert(2966));
        }
        [TestMethod]
        public void Convert_2967_Returns_MMCMLXVII()
        {
            Assert.AreEqual("MMCMLXVII", Converter.Convert(2967));
        }
        [TestMethod]
        public void Convert_2968_Returns_MMCMLXVIII()
        {
            Assert.AreEqual("MMCMLXVIII", Converter.Convert(2968));
        }
        [TestMethod]
        public void Convert_2969_Returns_MMCMLXIX()
        {
            Assert.AreEqual("MMCMLXIX", Converter.Convert(2969));
        }
        [TestMethod]
        public void Convert_2970_Returns_MMCMLXX()
        {
            Assert.AreEqual("MMCMLXX", Converter.Convert(2970));
        }
        [TestMethod]
        public void Convert_2971_Returns_MMCMLXXI()
        {
            Assert.AreEqual("MMCMLXXI", Converter.Convert(2971));
        }
        [TestMethod]
        public void Convert_2972_Returns_MMCMLXXII()
        {
            Assert.AreEqual("MMCMLXXII", Converter.Convert(2972));
        }
        [TestMethod]
        public void Convert_2973_Returns_MMCMLXXIII()
        {
            Assert.AreEqual("MMCMLXXIII", Converter.Convert(2973));
        }
        [TestMethod]
        public void Convert_2974_Returns_MMCMLXXIV()
        {
            Assert.AreEqual("MMCMLXXIV", Converter.Convert(2974));
        }
        [TestMethod]
        public void Convert_2975_Returns_MMCMLXXV()
        {
            Assert.AreEqual("MMCMLXXV", Converter.Convert(2975));
        }
        [TestMethod]
        public void Convert_2976_Returns_MMCMLXXVI()
        {
            Assert.AreEqual("MMCMLXXVI", Converter.Convert(2976));
        }
        [TestMethod]
        public void Convert_2977_Returns_MMCMLXXVII()
        {
            Assert.AreEqual("MMCMLXXVII", Converter.Convert(2977));
        }
        [TestMethod]
        public void Convert_2978_Returns_MMCMLXXVIII()
        {
            Assert.AreEqual("MMCMLXXVIII", Converter.Convert(2978));
        }
        [TestMethod]
        public void Convert_2979_Returns_MMCMLXXIX()
        {
            Assert.AreEqual("MMCMLXXIX", Converter.Convert(2979));
        }
        [TestMethod]
        public void Convert_2980_Returns_MMCMLXXX()
        {
            Assert.AreEqual("MMCMLXXX", Converter.Convert(2980));
        }
        [TestMethod]
        public void Convert_2981_Returns_MMCMLXXXI()
        {
            Assert.AreEqual("MMCMLXXXI", Converter.Convert(2981));
        }
        [TestMethod]
        public void Convert_2982_Returns_MMCMLXXXII()
        {
            Assert.AreEqual("MMCMLXXXII", Converter.Convert(2982));
        }
        [TestMethod]
        public void Convert_2983_Returns_MMCMLXXXIII()
        {
            Assert.AreEqual("MMCMLXXXIII", Converter.Convert(2983));
        }
        [TestMethod]
        public void Convert_2984_Returns_MMCMLXXXIV()
        {
            Assert.AreEqual("MMCMLXXXIV", Converter.Convert(2984));
        }
        [TestMethod]
        public void Convert_2985_Returns_MMCMLXXXV()
        {
            Assert.AreEqual("MMCMLXXXV", Converter.Convert(2985));
        }
        [TestMethod]
        public void Convert_2986_Returns_MMCMLXXXVI()
        {
            Assert.AreEqual("MMCMLXXXVI", Converter.Convert(2986));
        }
        [TestMethod]
        public void Convert_2987_Returns_MMCMLXXXVII()
        {
            Assert.AreEqual("MMCMLXXXVII", Converter.Convert(2987));
        }
        [TestMethod]
        public void Convert_2988_Returns_MMCMLXXXVIII()
        {
            Assert.AreEqual("MMCMLXXXVIII", Converter.Convert(2988));
        }
        [TestMethod]
        public void Convert_2989_Returns_MMCMLXXXIX()
        {
            Assert.AreEqual("MMCMLXXXIX", Converter.Convert(2989));
        }
        [TestMethod]
        public void Convert_2990_Returns_MMCMXC()
        {
            Assert.AreEqual("MMCMXC", Converter.Convert(2990));
        }
        [TestMethod]
        public void Convert_2991_Returns_MMCMXCI()
        {
            Assert.AreEqual("MMCMXCI", Converter.Convert(2991));
        }
        [TestMethod]
        public void Convert_2992_Returns_MMCMXCII()
        {
            Assert.AreEqual("MMCMXCII", Converter.Convert(2992));
        }
        [TestMethod]
        public void Convert_2993_Returns_MMCMXCIII()
        {
            Assert.AreEqual("MMCMXCIII", Converter.Convert(2993));
        }
        [TestMethod]
        public void Convert_2994_Returns_MMCMXCIV()
        {
            Assert.AreEqual("MMCMXCIV", Converter.Convert(2994));
        }
        [TestMethod]
        public void Convert_2995_Returns_MMCMXCV()
        {
            Assert.AreEqual("MMCMXCV", Converter.Convert(2995));
        }
        [TestMethod]
        public void Convert_2996_Returns_MMCMXCVI()
        {
            Assert.AreEqual("MMCMXCVI", Converter.Convert(2996));
        }
        [TestMethod]
        public void Convert_2997_Returns_MMCMXCVII()
        {
            Assert.AreEqual("MMCMXCVII", Converter.Convert(2997));
        }
        [TestMethod]
        public void Convert_2998_Returns_MMCMXCVIII()
        {
            Assert.AreEqual("MMCMXCVIII", Converter.Convert(2998));
        }
        [TestMethod]
        public void Convert_2999_Returns_MMCMXCIX()
        {
            Assert.AreEqual("MMCMXCIX", Converter.Convert(2999));
        }
        [TestMethod]
        public void Convert_3000_Returns_MMM()
        {
            Assert.AreEqual("MMM", Converter.Convert(3000));
        }
        [TestMethod]
        public void Convert_3001_Returns_MMMI()
        {
            Assert.AreEqual("MMMI", Converter.Convert(3001));
        }
        [TestMethod]
        public void Convert_3002_Returns_MMMII()
        {
            Assert.AreEqual("MMMII", Converter.Convert(3002));
        }
        [TestMethod]
        public void Convert_3003_Returns_MMMIII()
        {
            Assert.AreEqual("MMMIII", Converter.Convert(3003));
        }
        [TestMethod]
        public void Convert_3004_Returns_MMMIV()
        {
            Assert.AreEqual("MMMIV", Converter.Convert(3004));
        }
        [TestMethod]
        public void Convert_3005_Returns_MMMV()
        {
            Assert.AreEqual("MMMV", Converter.Convert(3005));
        }
        [TestMethod]
        public void Convert_3006_Returns_MMMVI()
        {
            Assert.AreEqual("MMMVI", Converter.Convert(3006));
        }
        [TestMethod]
        public void Convert_3007_Returns_MMMVII()
        {
            Assert.AreEqual("MMMVII", Converter.Convert(3007));
        }
        [TestMethod]
        public void Convert_3008_Returns_MMMVIII()
        {
            Assert.AreEqual("MMMVIII", Converter.Convert(3008));
        }
        [TestMethod]
        public void Convert_3009_Returns_MMMIX()
        {
            Assert.AreEqual("MMMIX", Converter.Convert(3009));
        }
        [TestMethod]
        public void Convert_3010_Returns_MMMX()
        {
            Assert.AreEqual("MMMX", Converter.Convert(3010));
        }
        [TestMethod]
        public void Convert_3011_Returns_MMMXI()
        {
            Assert.AreEqual("MMMXI", Converter.Convert(3011));
        }
        [TestMethod]
        public void Convert_3012_Returns_MMMXII()
        {
            Assert.AreEqual("MMMXII", Converter.Convert(3012));
        }
        [TestMethod]
        public void Convert_3013_Returns_MMMXIII()
        {
            Assert.AreEqual("MMMXIII", Converter.Convert(3013));
        }
        [TestMethod]
        public void Convert_3014_Returns_MMMXIV()
        {
            Assert.AreEqual("MMMXIV", Converter.Convert(3014));
        }
        [TestMethod]
        public void Convert_3015_Returns_MMMXV()
        {
            Assert.AreEqual("MMMXV", Converter.Convert(3015));
        }
        [TestMethod]
        public void Convert_3016_Returns_MMMXVI()
        {
            Assert.AreEqual("MMMXVI", Converter.Convert(3016));
        }
        [TestMethod]
        public void Convert_3017_Returns_MMMXVII()
        {
            Assert.AreEqual("MMMXVII", Converter.Convert(3017));
        }
        [TestMethod]
        public void Convert_3018_Returns_MMMXVIII()
        {
            Assert.AreEqual("MMMXVIII", Converter.Convert(3018));
        }
        [TestMethod]
        public void Convert_3019_Returns_MMMXIX()
        {
            Assert.AreEqual("MMMXIX", Converter.Convert(3019));
        }
        [TestMethod]
        public void Convert_3020_Returns_MMMXX()
        {
            Assert.AreEqual("MMMXX", Converter.Convert(3020));
        }
        [TestMethod]
        public void Convert_3021_Returns_MMMXXI()
        {
            Assert.AreEqual("MMMXXI", Converter.Convert(3021));
        }
        [TestMethod]
        public void Convert_3022_Returns_MMMXXII()
        {
            Assert.AreEqual("MMMXXII", Converter.Convert(3022));
        }
        [TestMethod]
        public void Convert_3023_Returns_MMMXXIII()
        {
            Assert.AreEqual("MMMXXIII", Converter.Convert(3023));
        }
        [TestMethod]
        public void Convert_3024_Returns_MMMXXIV()
        {
            Assert.AreEqual("MMMXXIV", Converter.Convert(3024));
        }
        [TestMethod]
        public void Convert_3025_Returns_MMMXXV()
        {
            Assert.AreEqual("MMMXXV", Converter.Convert(3025));
        }
        [TestMethod]
        public void Convert_3026_Returns_MMMXXVI()
        {
            Assert.AreEqual("MMMXXVI", Converter.Convert(3026));
        }
        [TestMethod]
        public void Convert_3027_Returns_MMMXXVII()
        {
            Assert.AreEqual("MMMXXVII", Converter.Convert(3027));
        }
        [TestMethod]
        public void Convert_3028_Returns_MMMXXVIII()
        {
            Assert.AreEqual("MMMXXVIII", Converter.Convert(3028));
        }
        [TestMethod]
        public void Convert_3029_Returns_MMMXXIX()
        {
            Assert.AreEqual("MMMXXIX", Converter.Convert(3029));
        }
        [TestMethod]
        public void Convert_3030_Returns_MMMXXX()
        {
            Assert.AreEqual("MMMXXX", Converter.Convert(3030));
        }
        [TestMethod]
        public void Convert_3031_Returns_MMMXXXI()
        {
            Assert.AreEqual("MMMXXXI", Converter.Convert(3031));
        }
        [TestMethod]
        public void Convert_3032_Returns_MMMXXXII()
        {
            Assert.AreEqual("MMMXXXII", Converter.Convert(3032));
        }
        [TestMethod]
        public void Convert_3033_Returns_MMMXXXIII()
        {
            Assert.AreEqual("MMMXXXIII", Converter.Convert(3033));
        }
        [TestMethod]
        public void Convert_3034_Returns_MMMXXXIV()
        {
            Assert.AreEqual("MMMXXXIV", Converter.Convert(3034));
        }
        [TestMethod]
        public void Convert_3035_Returns_MMMXXXV()
        {
            Assert.AreEqual("MMMXXXV", Converter.Convert(3035));
        }
        [TestMethod]
        public void Convert_3036_Returns_MMMXXXVI()
        {
            Assert.AreEqual("MMMXXXVI", Converter.Convert(3036));
        }
        [TestMethod]
        public void Convert_3037_Returns_MMMXXXVII()
        {
            Assert.AreEqual("MMMXXXVII", Converter.Convert(3037));
        }
        [TestMethod]
        public void Convert_3038_Returns_MMMXXXVIII()
        {
            Assert.AreEqual("MMMXXXVIII", Converter.Convert(3038));
        }
        [TestMethod]
        public void Convert_3039_Returns_MMMXXXIX()
        {
            Assert.AreEqual("MMMXXXIX", Converter.Convert(3039));
        }
        [TestMethod]
        public void Convert_3040_Returns_MMMXL()
        {
            Assert.AreEqual("MMMXL", Converter.Convert(3040));
        }
        [TestMethod]
        public void Convert_3041_Returns_MMMXLI()
        {
            Assert.AreEqual("MMMXLI", Converter.Convert(3041));
        }
        [TestMethod]
        public void Convert_3042_Returns_MMMXLII()
        {
            Assert.AreEqual("MMMXLII", Converter.Convert(3042));
        }
        [TestMethod]
        public void Convert_3043_Returns_MMMXLIII()
        {
            Assert.AreEqual("MMMXLIII", Converter.Convert(3043));
        }
        [TestMethod]
        public void Convert_3044_Returns_MMMXLIV()
        {
            Assert.AreEqual("MMMXLIV", Converter.Convert(3044));
        }
        [TestMethod]
        public void Convert_3045_Returns_MMMXLV()
        {
            Assert.AreEqual("MMMXLV", Converter.Convert(3045));
        }
        [TestMethod]
        public void Convert_3046_Returns_MMMXLVI()
        {
            Assert.AreEqual("MMMXLVI", Converter.Convert(3046));
        }
        [TestMethod]
        public void Convert_3047_Returns_MMMXLVII()
        {
            Assert.AreEqual("MMMXLVII", Converter.Convert(3047));
        }
        [TestMethod]
        public void Convert_3048_Returns_MMMXLVIII()
        {
            Assert.AreEqual("MMMXLVIII", Converter.Convert(3048));
        }
        [TestMethod]
        public void Convert_3049_Returns_MMMXLIX()
        {
            Assert.AreEqual("MMMXLIX", Converter.Convert(3049));
        }
        [TestMethod]
        public void Convert_3050_Returns_MMML()
        {
            Assert.AreEqual("MMML", Converter.Convert(3050));
        }
        [TestMethod]
        public void Convert_3051_Returns_MMMLI()
        {
            Assert.AreEqual("MMMLI", Converter.Convert(3051));
        }
        [TestMethod]
        public void Convert_3052_Returns_MMMLII()
        {
            Assert.AreEqual("MMMLII", Converter.Convert(3052));
        }
        [TestMethod]
        public void Convert_3053_Returns_MMMLIII()
        {
            Assert.AreEqual("MMMLIII", Converter.Convert(3053));
        }
        [TestMethod]
        public void Convert_3054_Returns_MMMLIV()
        {
            Assert.AreEqual("MMMLIV", Converter.Convert(3054));
        }
        [TestMethod]
        public void Convert_3055_Returns_MMMLV()
        {
            Assert.AreEqual("MMMLV", Converter.Convert(3055));
        }
        [TestMethod]
        public void Convert_3056_Returns_MMMLVI()
        {
            Assert.AreEqual("MMMLVI", Converter.Convert(3056));
        }
        [TestMethod]
        public void Convert_3057_Returns_MMMLVII()
        {
            Assert.AreEqual("MMMLVII", Converter.Convert(3057));
        }
        [TestMethod]
        public void Convert_3058_Returns_MMMLVIII()
        {
            Assert.AreEqual("MMMLVIII", Converter.Convert(3058));
        }
        [TestMethod]
        public void Convert_3059_Returns_MMMLIX()
        {
            Assert.AreEqual("MMMLIX", Converter.Convert(3059));
        }
        [TestMethod]
        public void Convert_3060_Returns_MMMLX()
        {
            Assert.AreEqual("MMMLX", Converter.Convert(3060));
        }
        [TestMethod]
        public void Convert_3061_Returns_MMMLXI()
        {
            Assert.AreEqual("MMMLXI", Converter.Convert(3061));
        }
        [TestMethod]
        public void Convert_3062_Returns_MMMLXII()
        {
            Assert.AreEqual("MMMLXII", Converter.Convert(3062));
        }
        [TestMethod]
        public void Convert_3063_Returns_MMMLXIII()
        {
            Assert.AreEqual("MMMLXIII", Converter.Convert(3063));
        }
        [TestMethod]
        public void Convert_3064_Returns_MMMLXIV()
        {
            Assert.AreEqual("MMMLXIV", Converter.Convert(3064));
        }
        [TestMethod]
        public void Convert_3065_Returns_MMMLXV()
        {
            Assert.AreEqual("MMMLXV", Converter.Convert(3065));
        }
        [TestMethod]
        public void Convert_3066_Returns_MMMLXVI()
        {
            Assert.AreEqual("MMMLXVI", Converter.Convert(3066));
        }
        [TestMethod]
        public void Convert_3067_Returns_MMMLXVII()
        {
            Assert.AreEqual("MMMLXVII", Converter.Convert(3067));
        }
        [TestMethod]
        public void Convert_3068_Returns_MMMLXVIII()
        {
            Assert.AreEqual("MMMLXVIII", Converter.Convert(3068));
        }
        [TestMethod]
        public void Convert_3069_Returns_MMMLXIX()
        {
            Assert.AreEqual("MMMLXIX", Converter.Convert(3069));
        }
        [TestMethod]
        public void Convert_3070_Returns_MMMLXX()
        {
            Assert.AreEqual("MMMLXX", Converter.Convert(3070));
        }
        [TestMethod]
        public void Convert_3071_Returns_MMMLXXI()
        {
            Assert.AreEqual("MMMLXXI", Converter.Convert(3071));
        }
        [TestMethod]
        public void Convert_3072_Returns_MMMLXXII()
        {
            Assert.AreEqual("MMMLXXII", Converter.Convert(3072));
        }
        [TestMethod]
        public void Convert_3073_Returns_MMMLXXIII()
        {
            Assert.AreEqual("MMMLXXIII", Converter.Convert(3073));
        }
        [TestMethod]
        public void Convert_3074_Returns_MMMLXXIV()
        {
            Assert.AreEqual("MMMLXXIV", Converter.Convert(3074));
        }
        [TestMethod]
        public void Convert_3075_Returns_MMMLXXV()
        {
            Assert.AreEqual("MMMLXXV", Converter.Convert(3075));
        }
        [TestMethod]
        public void Convert_3076_Returns_MMMLXXVI()
        {
            Assert.AreEqual("MMMLXXVI", Converter.Convert(3076));
        }
        [TestMethod]
        public void Convert_3077_Returns_MMMLXXVII()
        {
            Assert.AreEqual("MMMLXXVII", Converter.Convert(3077));
        }
        [TestMethod]
        public void Convert_3078_Returns_MMMLXXVIII()
        {
            Assert.AreEqual("MMMLXXVIII", Converter.Convert(3078));
        }
        [TestMethod]
        public void Convert_3079_Returns_MMMLXXIX()
        {
            Assert.AreEqual("MMMLXXIX", Converter.Convert(3079));
        }
        [TestMethod]
        public void Convert_3080_Returns_MMMLXXX()
        {
            Assert.AreEqual("MMMLXXX", Converter.Convert(3080));
        }
        [TestMethod]
        public void Convert_3081_Returns_MMMLXXXI()
        {
            Assert.AreEqual("MMMLXXXI", Converter.Convert(3081));
        }
        [TestMethod]
        public void Convert_3082_Returns_MMMLXXXII()
        {
            Assert.AreEqual("MMMLXXXII", Converter.Convert(3082));
        }
        [TestMethod]
        public void Convert_3083_Returns_MMMLXXXIII()
        {
            Assert.AreEqual("MMMLXXXIII", Converter.Convert(3083));
        }
        [TestMethod]
        public void Convert_3084_Returns_MMMLXXXIV()
        {
            Assert.AreEqual("MMMLXXXIV", Converter.Convert(3084));
        }
        [TestMethod]
        public void Convert_3085_Returns_MMMLXXXV()
        {
            Assert.AreEqual("MMMLXXXV", Converter.Convert(3085));
        }
        [TestMethod]
        public void Convert_3086_Returns_MMMLXXXVI()
        {
            Assert.AreEqual("MMMLXXXVI", Converter.Convert(3086));
        }
        [TestMethod]
        public void Convert_3087_Returns_MMMLXXXVII()
        {
            Assert.AreEqual("MMMLXXXVII", Converter.Convert(3087));
        }
        [TestMethod]
        public void Convert_3088_Returns_MMMLXXXVIII()
        {
            Assert.AreEqual("MMMLXXXVIII", Converter.Convert(3088));
        }
        [TestMethod]
        public void Convert_3089_Returns_MMMLXXXIX()
        {
            Assert.AreEqual("MMMLXXXIX", Converter.Convert(3089));
        }
        [TestMethod]
        public void Convert_3090_Returns_MMMXC()
        {
            Assert.AreEqual("MMMXC", Converter.Convert(3090));
        }
        [TestMethod]
        public void Convert_3091_Returns_MMMXCI()
        {
            Assert.AreEqual("MMMXCI", Converter.Convert(3091));
        }
        [TestMethod]
        public void Convert_3092_Returns_MMMXCII()
        {
            Assert.AreEqual("MMMXCII", Converter.Convert(3092));
        }
        [TestMethod]
        public void Convert_3093_Returns_MMMXCIII()
        {
            Assert.AreEqual("MMMXCIII", Converter.Convert(3093));
        }
        [TestMethod]
        public void Convert_3094_Returns_MMMXCIV()
        {
            Assert.AreEqual("MMMXCIV", Converter.Convert(3094));
        }
        [TestMethod]
        public void Convert_3095_Returns_MMMXCV()
        {
            Assert.AreEqual("MMMXCV", Converter.Convert(3095));
        }
        [TestMethod]
        public void Convert_3096_Returns_MMMXCVI()
        {
            Assert.AreEqual("MMMXCVI", Converter.Convert(3096));
        }
        [TestMethod]
        public void Convert_3097_Returns_MMMXCVII()
        {
            Assert.AreEqual("MMMXCVII", Converter.Convert(3097));
        }
        [TestMethod]
        public void Convert_3098_Returns_MMMXCVIII()
        {
            Assert.AreEqual("MMMXCVIII", Converter.Convert(3098));
        }
        [TestMethod]
        public void Convert_3099_Returns_MMMXCIX()
        {
            Assert.AreEqual("MMMXCIX", Converter.Convert(3099));
        }
        [TestMethod]
        public void Convert_3100_Returns_MMMC()
        {
            Assert.AreEqual("MMMC", Converter.Convert(3100));
        }
        [TestMethod]
        public void Convert_3101_Returns_MMMCI()
        {
            Assert.AreEqual("MMMCI", Converter.Convert(3101));
        }
        [TestMethod]
        public void Convert_3102_Returns_MMMCII()
        {
            Assert.AreEqual("MMMCII", Converter.Convert(3102));
        }
        [TestMethod]
        public void Convert_3103_Returns_MMMCIII()
        {
            Assert.AreEqual("MMMCIII", Converter.Convert(3103));
        }
        [TestMethod]
        public void Convert_3104_Returns_MMMCIV()
        {
            Assert.AreEqual("MMMCIV", Converter.Convert(3104));
        }
        [TestMethod]
        public void Convert_3105_Returns_MMMCV()
        {
            Assert.AreEqual("MMMCV", Converter.Convert(3105));
        }
        [TestMethod]
        public void Convert_3106_Returns_MMMCVI()
        {
            Assert.AreEqual("MMMCVI", Converter.Convert(3106));
        }
        [TestMethod]
        public void Convert_3107_Returns_MMMCVII()
        {
            Assert.AreEqual("MMMCVII", Converter.Convert(3107));
        }
        [TestMethod]
        public void Convert_3108_Returns_MMMCVIII()
        {
            Assert.AreEqual("MMMCVIII", Converter.Convert(3108));
        }
        [TestMethod]
        public void Convert_3109_Returns_MMMCIX()
        {
            Assert.AreEqual("MMMCIX", Converter.Convert(3109));
        }
        [TestMethod]
        public void Convert_3110_Returns_MMMCX()
        {
            Assert.AreEqual("MMMCX", Converter.Convert(3110));
        }
        [TestMethod]
        public void Convert_3111_Returns_MMMCXI()
        {
            Assert.AreEqual("MMMCXI", Converter.Convert(3111));
        }
        [TestMethod]
        public void Convert_3112_Returns_MMMCXII()
        {
            Assert.AreEqual("MMMCXII", Converter.Convert(3112));
        }
        [TestMethod]
        public void Convert_3113_Returns_MMMCXIII()
        {
            Assert.AreEqual("MMMCXIII", Converter.Convert(3113));
        }
        [TestMethod]
        public void Convert_3114_Returns_MMMCXIV()
        {
            Assert.AreEqual("MMMCXIV", Converter.Convert(3114));
        }
        [TestMethod]
        public void Convert_3115_Returns_MMMCXV()
        {
            Assert.AreEqual("MMMCXV", Converter.Convert(3115));
        }
        [TestMethod]
        public void Convert_3116_Returns_MMMCXVI()
        {
            Assert.AreEqual("MMMCXVI", Converter.Convert(3116));
        }
        [TestMethod]
        public void Convert_3117_Returns_MMMCXVII()
        {
            Assert.AreEqual("MMMCXVII", Converter.Convert(3117));
        }
        [TestMethod]
        public void Convert_3118_Returns_MMMCXVIII()
        {
            Assert.AreEqual("MMMCXVIII", Converter.Convert(3118));
        }
        [TestMethod]
        public void Convert_3119_Returns_MMMCXIX()
        {
            Assert.AreEqual("MMMCXIX", Converter.Convert(3119));
        }
        [TestMethod]
        public void Convert_3120_Returns_MMMCXX()
        {
            Assert.AreEqual("MMMCXX", Converter.Convert(3120));
        }
        [TestMethod]
        public void Convert_3121_Returns_MMMCXXI()
        {
            Assert.AreEqual("MMMCXXI", Converter.Convert(3121));
        }
        [TestMethod]
        public void Convert_3122_Returns_MMMCXXII()
        {
            Assert.AreEqual("MMMCXXII", Converter.Convert(3122));
        }
        [TestMethod]
        public void Convert_3123_Returns_MMMCXXIII()
        {
            Assert.AreEqual("MMMCXXIII", Converter.Convert(3123));
        }
        [TestMethod]
        public void Convert_3124_Returns_MMMCXXIV()
        {
            Assert.AreEqual("MMMCXXIV", Converter.Convert(3124));
        }
        [TestMethod]
        public void Convert_3125_Returns_MMMCXXV()
        {
            Assert.AreEqual("MMMCXXV", Converter.Convert(3125));
        }
        [TestMethod]
        public void Convert_3126_Returns_MMMCXXVI()
        {
            Assert.AreEqual("MMMCXXVI", Converter.Convert(3126));
        }
        [TestMethod]
        public void Convert_3127_Returns_MMMCXXVII()
        {
            Assert.AreEqual("MMMCXXVII", Converter.Convert(3127));
        }
        [TestMethod]
        public void Convert_3128_Returns_MMMCXXVIII()
        {
            Assert.AreEqual("MMMCXXVIII", Converter.Convert(3128));
        }
        [TestMethod]
        public void Convert_3129_Returns_MMMCXXIX()
        {
            Assert.AreEqual("MMMCXXIX", Converter.Convert(3129));
        }
        [TestMethod]
        public void Convert_3130_Returns_MMMCXXX()
        {
            Assert.AreEqual("MMMCXXX", Converter.Convert(3130));
        }
        [TestMethod]
        public void Convert_3131_Returns_MMMCXXXI()
        {
            Assert.AreEqual("MMMCXXXI", Converter.Convert(3131));
        }
        [TestMethod]
        public void Convert_3132_Returns_MMMCXXXII()
        {
            Assert.AreEqual("MMMCXXXII", Converter.Convert(3132));
        }
        [TestMethod]
        public void Convert_3133_Returns_MMMCXXXIII()
        {
            Assert.AreEqual("MMMCXXXIII", Converter.Convert(3133));
        }
        [TestMethod]
        public void Convert_3134_Returns_MMMCXXXIV()
        {
            Assert.AreEqual("MMMCXXXIV", Converter.Convert(3134));
        }
        [TestMethod]
        public void Convert_3135_Returns_MMMCXXXV()
        {
            Assert.AreEqual("MMMCXXXV", Converter.Convert(3135));
        }
        [TestMethod]
        public void Convert_3136_Returns_MMMCXXXVI()
        {
            Assert.AreEqual("MMMCXXXVI", Converter.Convert(3136));
        }
        [TestMethod]
        public void Convert_3137_Returns_MMMCXXXVII()
        {
            Assert.AreEqual("MMMCXXXVII", Converter.Convert(3137));
        }
        [TestMethod]
        public void Convert_3138_Returns_MMMCXXXVIII()
        {
            Assert.AreEqual("MMMCXXXVIII", Converter.Convert(3138));
        }
        [TestMethod]
        public void Convert_3139_Returns_MMMCXXXIX()
        {
            Assert.AreEqual("MMMCXXXIX", Converter.Convert(3139));
        }
        [TestMethod]
        public void Convert_3140_Returns_MMMCXL()
        {
            Assert.AreEqual("MMMCXL", Converter.Convert(3140));
        }
        [TestMethod]
        public void Convert_3141_Returns_MMMCXLI()
        {
            Assert.AreEqual("MMMCXLI", Converter.Convert(3141));
        }
        [TestMethod]
        public void Convert_3142_Returns_MMMCXLII()
        {
            Assert.AreEqual("MMMCXLII", Converter.Convert(3142));
        }
        [TestMethod]
        public void Convert_3143_Returns_MMMCXLIII()
        {
            Assert.AreEqual("MMMCXLIII", Converter.Convert(3143));
        }
        [TestMethod]
        public void Convert_3144_Returns_MMMCXLIV()
        {
            Assert.AreEqual("MMMCXLIV", Converter.Convert(3144));
        }
        [TestMethod]
        public void Convert_3145_Returns_MMMCXLV()
        {
            Assert.AreEqual("MMMCXLV", Converter.Convert(3145));
        }
        [TestMethod]
        public void Convert_3146_Returns_MMMCXLVI()
        {
            Assert.AreEqual("MMMCXLVI", Converter.Convert(3146));
        }
        [TestMethod]
        public void Convert_3147_Returns_MMMCXLVII()
        {
            Assert.AreEqual("MMMCXLVII", Converter.Convert(3147));
        }
        [TestMethod]
        public void Convert_3148_Returns_MMMCXLVIII()
        {
            Assert.AreEqual("MMMCXLVIII", Converter.Convert(3148));
        }
        [TestMethod]
        public void Convert_3149_Returns_MMMCXLIX()
        {
            Assert.AreEqual("MMMCXLIX", Converter.Convert(3149));
        }
        [TestMethod]
        public void Convert_3150_Returns_MMMCL()
        {
            Assert.AreEqual("MMMCL", Converter.Convert(3150));
        }
        [TestMethod]
        public void Convert_3151_Returns_MMMCLI()
        {
            Assert.AreEqual("MMMCLI", Converter.Convert(3151));
        }
        [TestMethod]
        public void Convert_3152_Returns_MMMCLII()
        {
            Assert.AreEqual("MMMCLII", Converter.Convert(3152));
        }
        [TestMethod]
        public void Convert_3153_Returns_MMMCLIII()
        {
            Assert.AreEqual("MMMCLIII", Converter.Convert(3153));
        }
        [TestMethod]
        public void Convert_3154_Returns_MMMCLIV()
        {
            Assert.AreEqual("MMMCLIV", Converter.Convert(3154));
        }
        [TestMethod]
        public void Convert_3155_Returns_MMMCLV()
        {
            Assert.AreEqual("MMMCLV", Converter.Convert(3155));
        }
        [TestMethod]
        public void Convert_3156_Returns_MMMCLVI()
        {
            Assert.AreEqual("MMMCLVI", Converter.Convert(3156));
        }
        [TestMethod]
        public void Convert_3157_Returns_MMMCLVII()
        {
            Assert.AreEqual("MMMCLVII", Converter.Convert(3157));
        }
        [TestMethod]
        public void Convert_3158_Returns_MMMCLVIII()
        {
            Assert.AreEqual("MMMCLVIII", Converter.Convert(3158));
        }
        [TestMethod]
        public void Convert_3159_Returns_MMMCLIX()
        {
            Assert.AreEqual("MMMCLIX", Converter.Convert(3159));
        }
        [TestMethod]
        public void Convert_3160_Returns_MMMCLX()
        {
            Assert.AreEqual("MMMCLX", Converter.Convert(3160));
        }
        [TestMethod]
        public void Convert_3161_Returns_MMMCLXI()
        {
            Assert.AreEqual("MMMCLXI", Converter.Convert(3161));
        }
        [TestMethod]
        public void Convert_3162_Returns_MMMCLXII()
        {
            Assert.AreEqual("MMMCLXII", Converter.Convert(3162));
        }
        [TestMethod]
        public void Convert_3163_Returns_MMMCLXIII()
        {
            Assert.AreEqual("MMMCLXIII", Converter.Convert(3163));
        }
        [TestMethod]
        public void Convert_3164_Returns_MMMCLXIV()
        {
            Assert.AreEqual("MMMCLXIV", Converter.Convert(3164));
        }
        [TestMethod]
        public void Convert_3165_Returns_MMMCLXV()
        {
            Assert.AreEqual("MMMCLXV", Converter.Convert(3165));
        }
        [TestMethod]
        public void Convert_3166_Returns_MMMCLXVI()
        {
            Assert.AreEqual("MMMCLXVI", Converter.Convert(3166));
        }
        [TestMethod]
        public void Convert_3167_Returns_MMMCLXVII()
        {
            Assert.AreEqual("MMMCLXVII", Converter.Convert(3167));
        }
        [TestMethod]
        public void Convert_3168_Returns_MMMCLXVIII()
        {
            Assert.AreEqual("MMMCLXVIII", Converter.Convert(3168));
        }
        [TestMethod]
        public void Convert_3169_Returns_MMMCLXIX()
        {
            Assert.AreEqual("MMMCLXIX", Converter.Convert(3169));
        }
        [TestMethod]
        public void Convert_3170_Returns_MMMCLXX()
        {
            Assert.AreEqual("MMMCLXX", Converter.Convert(3170));
        }
        [TestMethod]
        public void Convert_3171_Returns_MMMCLXXI()
        {
            Assert.AreEqual("MMMCLXXI", Converter.Convert(3171));
        }
        [TestMethod]
        public void Convert_3172_Returns_MMMCLXXII()
        {
            Assert.AreEqual("MMMCLXXII", Converter.Convert(3172));
        }
        [TestMethod]
        public void Convert_3173_Returns_MMMCLXXIII()
        {
            Assert.AreEqual("MMMCLXXIII", Converter.Convert(3173));
        }
        [TestMethod]
        public void Convert_3174_Returns_MMMCLXXIV()
        {
            Assert.AreEqual("MMMCLXXIV", Converter.Convert(3174));
        }
        [TestMethod]
        public void Convert_3175_Returns_MMMCLXXV()
        {
            Assert.AreEqual("MMMCLXXV", Converter.Convert(3175));
        }
        [TestMethod]
        public void Convert_3176_Returns_MMMCLXXVI()
        {
            Assert.AreEqual("MMMCLXXVI", Converter.Convert(3176));
        }
        [TestMethod]
        public void Convert_3177_Returns_MMMCLXXVII()
        {
            Assert.AreEqual("MMMCLXXVII", Converter.Convert(3177));
        }
        [TestMethod]
        public void Convert_3178_Returns_MMMCLXXVIII()
        {
            Assert.AreEqual("MMMCLXXVIII", Converter.Convert(3178));
        }
        [TestMethod]
        public void Convert_3179_Returns_MMMCLXXIX()
        {
            Assert.AreEqual("MMMCLXXIX", Converter.Convert(3179));
        }
        [TestMethod]
        public void Convert_3180_Returns_MMMCLXXX()
        {
            Assert.AreEqual("MMMCLXXX", Converter.Convert(3180));
        }
        [TestMethod]
        public void Convert_3181_Returns_MMMCLXXXI()
        {
            Assert.AreEqual("MMMCLXXXI", Converter.Convert(3181));
        }
        [TestMethod]
        public void Convert_3182_Returns_MMMCLXXXII()
        {
            Assert.AreEqual("MMMCLXXXII", Converter.Convert(3182));
        }
        [TestMethod]
        public void Convert_3183_Returns_MMMCLXXXIII()
        {
            Assert.AreEqual("MMMCLXXXIII", Converter.Convert(3183));
        }
        [TestMethod]
        public void Convert_3184_Returns_MMMCLXXXIV()
        {
            Assert.AreEqual("MMMCLXXXIV", Converter.Convert(3184));
        }
        [TestMethod]
        public void Convert_3185_Returns_MMMCLXXXV()
        {
            Assert.AreEqual("MMMCLXXXV", Converter.Convert(3185));
        }
        [TestMethod]
        public void Convert_3186_Returns_MMMCLXXXVI()
        {
            Assert.AreEqual("MMMCLXXXVI", Converter.Convert(3186));
        }
        [TestMethod]
        public void Convert_3187_Returns_MMMCLXXXVII()
        {
            Assert.AreEqual("MMMCLXXXVII", Converter.Convert(3187));
        }
        [TestMethod]
        public void Convert_3188_Returns_MMMCLXXXVIII()
        {
            Assert.AreEqual("MMMCLXXXVIII", Converter.Convert(3188));
        }
        [TestMethod]
        public void Convert_3189_Returns_MMMCLXXXIX()
        {
            Assert.AreEqual("MMMCLXXXIX", Converter.Convert(3189));
        }
        [TestMethod]
        public void Convert_3190_Returns_MMMCXC()
        {
            Assert.AreEqual("MMMCXC", Converter.Convert(3190));
        }
        [TestMethod]
        public void Convert_3191_Returns_MMMCXCI()
        {
            Assert.AreEqual("MMMCXCI", Converter.Convert(3191));
        }
        [TestMethod]
        public void Convert_3192_Returns_MMMCXCII()
        {
            Assert.AreEqual("MMMCXCII", Converter.Convert(3192));
        }
        [TestMethod]
        public void Convert_3193_Returns_MMMCXCIII()
        {
            Assert.AreEqual("MMMCXCIII", Converter.Convert(3193));
        }
        [TestMethod]
        public void Convert_3194_Returns_MMMCXCIV()
        {
            Assert.AreEqual("MMMCXCIV", Converter.Convert(3194));
        }
        [TestMethod]
        public void Convert_3195_Returns_MMMCXCV()
        {
            Assert.AreEqual("MMMCXCV", Converter.Convert(3195));
        }
        [TestMethod]
        public void Convert_3196_Returns_MMMCXCVI()
        {
            Assert.AreEqual("MMMCXCVI", Converter.Convert(3196));
        }
        [TestMethod]
        public void Convert_3197_Returns_MMMCXCVII()
        {
            Assert.AreEqual("MMMCXCVII", Converter.Convert(3197));
        }
        [TestMethod]
        public void Convert_3198_Returns_MMMCXCVIII()
        {
            Assert.AreEqual("MMMCXCVIII", Converter.Convert(3198));
        }
        [TestMethod]
        public void Convert_3199_Returns_MMMCXCIX()
        {
            Assert.AreEqual("MMMCXCIX", Converter.Convert(3199));
        }
        [TestMethod]
        public void Convert_3200_Returns_MMMCC()
        {
            Assert.AreEqual("MMMCC", Converter.Convert(3200));
        }
        [TestMethod]
        public void Convert_3201_Returns_MMMCCI()
        {
            Assert.AreEqual("MMMCCI", Converter.Convert(3201));
        }
        [TestMethod]
        public void Convert_3202_Returns_MMMCCII()
        {
            Assert.AreEqual("MMMCCII", Converter.Convert(3202));
        }
        [TestMethod]
        public void Convert_3203_Returns_MMMCCIII()
        {
            Assert.AreEqual("MMMCCIII", Converter.Convert(3203));
        }
        [TestMethod]
        public void Convert_3204_Returns_MMMCCIV()
        {
            Assert.AreEqual("MMMCCIV", Converter.Convert(3204));
        }
        [TestMethod]
        public void Convert_3205_Returns_MMMCCV()
        {
            Assert.AreEqual("MMMCCV", Converter.Convert(3205));
        }
        [TestMethod]
        public void Convert_3206_Returns_MMMCCVI()
        {
            Assert.AreEqual("MMMCCVI", Converter.Convert(3206));
        }
        [TestMethod]
        public void Convert_3207_Returns_MMMCCVII()
        {
            Assert.AreEqual("MMMCCVII", Converter.Convert(3207));
        }
        [TestMethod]
        public void Convert_3208_Returns_MMMCCVIII()
        {
            Assert.AreEqual("MMMCCVIII", Converter.Convert(3208));
        }
        [TestMethod]
        public void Convert_3209_Returns_MMMCCIX()
        {
            Assert.AreEqual("MMMCCIX", Converter.Convert(3209));
        }
        [TestMethod]
        public void Convert_3210_Returns_MMMCCX()
        {
            Assert.AreEqual("MMMCCX", Converter.Convert(3210));
        }
        [TestMethod]
        public void Convert_3211_Returns_MMMCCXI()
        {
            Assert.AreEqual("MMMCCXI", Converter.Convert(3211));
        }
        [TestMethod]
        public void Convert_3212_Returns_MMMCCXII()
        {
            Assert.AreEqual("MMMCCXII", Converter.Convert(3212));
        }
        [TestMethod]
        public void Convert_3213_Returns_MMMCCXIII()
        {
            Assert.AreEqual("MMMCCXIII", Converter.Convert(3213));
        }
        [TestMethod]
        public void Convert_3214_Returns_MMMCCXIV()
        {
            Assert.AreEqual("MMMCCXIV", Converter.Convert(3214));
        }
        [TestMethod]
        public void Convert_3215_Returns_MMMCCXV()
        {
            Assert.AreEqual("MMMCCXV", Converter.Convert(3215));
        }
        [TestMethod]
        public void Convert_3216_Returns_MMMCCXVI()
        {
            Assert.AreEqual("MMMCCXVI", Converter.Convert(3216));
        }
        [TestMethod]
        public void Convert_3217_Returns_MMMCCXVII()
        {
            Assert.AreEqual("MMMCCXVII", Converter.Convert(3217));
        }
        [TestMethod]
        public void Convert_3218_Returns_MMMCCXVIII()
        {
            Assert.AreEqual("MMMCCXVIII", Converter.Convert(3218));
        }
        [TestMethod]
        public void Convert_3219_Returns_MMMCCXIX()
        {
            Assert.AreEqual("MMMCCXIX", Converter.Convert(3219));
        }
        [TestMethod]
        public void Convert_3220_Returns_MMMCCXX()
        {
            Assert.AreEqual("MMMCCXX", Converter.Convert(3220));
        }
        [TestMethod]
        public void Convert_3221_Returns_MMMCCXXI()
        {
            Assert.AreEqual("MMMCCXXI", Converter.Convert(3221));
        }
        [TestMethod]
        public void Convert_3222_Returns_MMMCCXXII()
        {
            Assert.AreEqual("MMMCCXXII", Converter.Convert(3222));
        }
        [TestMethod]
        public void Convert_3223_Returns_MMMCCXXIII()
        {
            Assert.AreEqual("MMMCCXXIII", Converter.Convert(3223));
        }
        [TestMethod]
        public void Convert_3224_Returns_MMMCCXXIV()
        {
            Assert.AreEqual("MMMCCXXIV", Converter.Convert(3224));
        }
        [TestMethod]
        public void Convert_3225_Returns_MMMCCXXV()
        {
            Assert.AreEqual("MMMCCXXV", Converter.Convert(3225));
        }
        [TestMethod]
        public void Convert_3226_Returns_MMMCCXXVI()
        {
            Assert.AreEqual("MMMCCXXVI", Converter.Convert(3226));
        }
        [TestMethod]
        public void Convert_3227_Returns_MMMCCXXVII()
        {
            Assert.AreEqual("MMMCCXXVII", Converter.Convert(3227));
        }
        [TestMethod]
        public void Convert_3228_Returns_MMMCCXXVIII()
        {
            Assert.AreEqual("MMMCCXXVIII", Converter.Convert(3228));
        }
        [TestMethod]
        public void Convert_3229_Returns_MMMCCXXIX()
        {
            Assert.AreEqual("MMMCCXXIX", Converter.Convert(3229));
        }
        [TestMethod]
        public void Convert_3230_Returns_MMMCCXXX()
        {
            Assert.AreEqual("MMMCCXXX", Converter.Convert(3230));
        }
        [TestMethod]
        public void Convert_3231_Returns_MMMCCXXXI()
        {
            Assert.AreEqual("MMMCCXXXI", Converter.Convert(3231));
        }
        [TestMethod]
        public void Convert_3232_Returns_MMMCCXXXII()
        {
            Assert.AreEqual("MMMCCXXXII", Converter.Convert(3232));
        }
        [TestMethod]
        public void Convert_3233_Returns_MMMCCXXXIII()
        {
            Assert.AreEqual("MMMCCXXXIII", Converter.Convert(3233));
        }
        [TestMethod]
        public void Convert_3234_Returns_MMMCCXXXIV()
        {
            Assert.AreEqual("MMMCCXXXIV", Converter.Convert(3234));
        }
        [TestMethod]
        public void Convert_3235_Returns_MMMCCXXXV()
        {
            Assert.AreEqual("MMMCCXXXV", Converter.Convert(3235));
        }
        [TestMethod]
        public void Convert_3236_Returns_MMMCCXXXVI()
        {
            Assert.AreEqual("MMMCCXXXVI", Converter.Convert(3236));
        }
        [TestMethod]
        public void Convert_3237_Returns_MMMCCXXXVII()
        {
            Assert.AreEqual("MMMCCXXXVII", Converter.Convert(3237));
        }
        [TestMethod]
        public void Convert_3238_Returns_MMMCCXXXVIII()
        {
            Assert.AreEqual("MMMCCXXXVIII", Converter.Convert(3238));
        }
        [TestMethod]
        public void Convert_3239_Returns_MMMCCXXXIX()
        {
            Assert.AreEqual("MMMCCXXXIX", Converter.Convert(3239));
        }
        [TestMethod]
        public void Convert_3240_Returns_MMMCCXL()
        {
            Assert.AreEqual("MMMCCXL", Converter.Convert(3240));
        }
        [TestMethod]
        public void Convert_3241_Returns_MMMCCXLI()
        {
            Assert.AreEqual("MMMCCXLI", Converter.Convert(3241));
        }
        [TestMethod]
        public void Convert_3242_Returns_MMMCCXLII()
        {
            Assert.AreEqual("MMMCCXLII", Converter.Convert(3242));
        }
        [TestMethod]
        public void Convert_3243_Returns_MMMCCXLIII()
        {
            Assert.AreEqual("MMMCCXLIII", Converter.Convert(3243));
        }
        [TestMethod]
        public void Convert_3244_Returns_MMMCCXLIV()
        {
            Assert.AreEqual("MMMCCXLIV", Converter.Convert(3244));
        }
        [TestMethod]
        public void Convert_3245_Returns_MMMCCXLV()
        {
            Assert.AreEqual("MMMCCXLV", Converter.Convert(3245));
        }
        [TestMethod]
        public void Convert_3246_Returns_MMMCCXLVI()
        {
            Assert.AreEqual("MMMCCXLVI", Converter.Convert(3246));
        }
        [TestMethod]
        public void Convert_3247_Returns_MMMCCXLVII()
        {
            Assert.AreEqual("MMMCCXLVII", Converter.Convert(3247));
        }
        [TestMethod]
        public void Convert_3248_Returns_MMMCCXLVIII()
        {
            Assert.AreEqual("MMMCCXLVIII", Converter.Convert(3248));
        }
        [TestMethod]
        public void Convert_3249_Returns_MMMCCXLIX()
        {
            Assert.AreEqual("MMMCCXLIX", Converter.Convert(3249));
        }
        [TestMethod]
        public void Convert_3250_Returns_MMMCCL()
        {
            Assert.AreEqual("MMMCCL", Converter.Convert(3250));
        }
        [TestMethod]
        public void Convert_3251_Returns_MMMCCLI()
        {
            Assert.AreEqual("MMMCCLI", Converter.Convert(3251));
        }
        [TestMethod]
        public void Convert_3252_Returns_MMMCCLII()
        {
            Assert.AreEqual("MMMCCLII", Converter.Convert(3252));
        }
        [TestMethod]
        public void Convert_3253_Returns_MMMCCLIII()
        {
            Assert.AreEqual("MMMCCLIII", Converter.Convert(3253));
        }
        [TestMethod]
        public void Convert_3254_Returns_MMMCCLIV()
        {
            Assert.AreEqual("MMMCCLIV", Converter.Convert(3254));
        }
        [TestMethod]
        public void Convert_3255_Returns_MMMCCLV()
        {
            Assert.AreEqual("MMMCCLV", Converter.Convert(3255));
        }
        [TestMethod]
        public void Convert_3256_Returns_MMMCCLVI()
        {
            Assert.AreEqual("MMMCCLVI", Converter.Convert(3256));
        }
        [TestMethod]
        public void Convert_3257_Returns_MMMCCLVII()
        {
            Assert.AreEqual("MMMCCLVII", Converter.Convert(3257));
        }
        [TestMethod]
        public void Convert_3258_Returns_MMMCCLVIII()
        {
            Assert.AreEqual("MMMCCLVIII", Converter.Convert(3258));
        }
        [TestMethod]
        public void Convert_3259_Returns_MMMCCLIX()
        {
            Assert.AreEqual("MMMCCLIX", Converter.Convert(3259));
        }
        [TestMethod]
        public void Convert_3260_Returns_MMMCCLX()
        {
            Assert.AreEqual("MMMCCLX", Converter.Convert(3260));
        }
        [TestMethod]
        public void Convert_3261_Returns_MMMCCLXI()
        {
            Assert.AreEqual("MMMCCLXI", Converter.Convert(3261));
        }
        [TestMethod]
        public void Convert_3262_Returns_MMMCCLXII()
        {
            Assert.AreEqual("MMMCCLXII", Converter.Convert(3262));
        }
        [TestMethod]
        public void Convert_3263_Returns_MMMCCLXIII()
        {
            Assert.AreEqual("MMMCCLXIII", Converter.Convert(3263));
        }
        [TestMethod]
        public void Convert_3264_Returns_MMMCCLXIV()
        {
            Assert.AreEqual("MMMCCLXIV", Converter.Convert(3264));
        }
        [TestMethod]
        public void Convert_3265_Returns_MMMCCLXV()
        {
            Assert.AreEqual("MMMCCLXV", Converter.Convert(3265));
        }
        [TestMethod]
        public void Convert_3266_Returns_MMMCCLXVI()
        {
            Assert.AreEqual("MMMCCLXVI", Converter.Convert(3266));
        }
        [TestMethod]
        public void Convert_3267_Returns_MMMCCLXVII()
        {
            Assert.AreEqual("MMMCCLXVII", Converter.Convert(3267));
        }
        [TestMethod]
        public void Convert_3268_Returns_MMMCCLXVIII()
        {
            Assert.AreEqual("MMMCCLXVIII", Converter.Convert(3268));
        }
        [TestMethod]
        public void Convert_3269_Returns_MMMCCLXIX()
        {
            Assert.AreEqual("MMMCCLXIX", Converter.Convert(3269));
        }
        [TestMethod]
        public void Convert_3270_Returns_MMMCCLXX()
        {
            Assert.AreEqual("MMMCCLXX", Converter.Convert(3270));
        }
        [TestMethod]
        public void Convert_3271_Returns_MMMCCLXXI()
        {
            Assert.AreEqual("MMMCCLXXI", Converter.Convert(3271));
        }
        [TestMethod]
        public void Convert_3272_Returns_MMMCCLXXII()
        {
            Assert.AreEqual("MMMCCLXXII", Converter.Convert(3272));
        }
        [TestMethod]
        public void Convert_3273_Returns_MMMCCLXXIII()
        {
            Assert.AreEqual("MMMCCLXXIII", Converter.Convert(3273));
        }
        [TestMethod]
        public void Convert_3274_Returns_MMMCCLXXIV()
        {
            Assert.AreEqual("MMMCCLXXIV", Converter.Convert(3274));
        }
        [TestMethod]
        public void Convert_3275_Returns_MMMCCLXXV()
        {
            Assert.AreEqual("MMMCCLXXV", Converter.Convert(3275));
        }
        [TestMethod]
        public void Convert_3276_Returns_MMMCCLXXVI()
        {
            Assert.AreEqual("MMMCCLXXVI", Converter.Convert(3276));
        }
        [TestMethod]
        public void Convert_3277_Returns_MMMCCLXXVII()
        {
            Assert.AreEqual("MMMCCLXXVII", Converter.Convert(3277));
        }
        [TestMethod]
        public void Convert_3278_Returns_MMMCCLXXVIII()
        {
            Assert.AreEqual("MMMCCLXXVIII", Converter.Convert(3278));
        }
        [TestMethod]
        public void Convert_3279_Returns_MMMCCLXXIX()
        {
            Assert.AreEqual("MMMCCLXXIX", Converter.Convert(3279));
        }
        [TestMethod]
        public void Convert_3280_Returns_MMMCCLXXX()
        {
            Assert.AreEqual("MMMCCLXXX", Converter.Convert(3280));
        }
        [TestMethod]
        public void Convert_3281_Returns_MMMCCLXXXI()
        {
            Assert.AreEqual("MMMCCLXXXI", Converter.Convert(3281));
        }
        [TestMethod]
        public void Convert_3282_Returns_MMMCCLXXXII()
        {
            Assert.AreEqual("MMMCCLXXXII", Converter.Convert(3282));
        }
        [TestMethod]
        public void Convert_3283_Returns_MMMCCLXXXIII()
        {
            Assert.AreEqual("MMMCCLXXXIII", Converter.Convert(3283));
        }
        [TestMethod]
        public void Convert_3284_Returns_MMMCCLXXXIV()
        {
            Assert.AreEqual("MMMCCLXXXIV", Converter.Convert(3284));
        }
        [TestMethod]
        public void Convert_3285_Returns_MMMCCLXXXV()
        {
            Assert.AreEqual("MMMCCLXXXV", Converter.Convert(3285));
        }
        [TestMethod]
        public void Convert_3286_Returns_MMMCCLXXXVI()
        {
            Assert.AreEqual("MMMCCLXXXVI", Converter.Convert(3286));
        }
        [TestMethod]
        public void Convert_3287_Returns_MMMCCLXXXVII()
        {
            Assert.AreEqual("MMMCCLXXXVII", Converter.Convert(3287));
        }
        [TestMethod]
        public void Convert_3288_Returns_MMMCCLXXXVIII()
        {
            Assert.AreEqual("MMMCCLXXXVIII", Converter.Convert(3288));
        }
        [TestMethod]
        public void Convert_3289_Returns_MMMCCLXXXIX()
        {
            Assert.AreEqual("MMMCCLXXXIX", Converter.Convert(3289));
        }
        [TestMethod]
        public void Convert_3290_Returns_MMMCCXC()
        {
            Assert.AreEqual("MMMCCXC", Converter.Convert(3290));
        }
        [TestMethod]
        public void Convert_3291_Returns_MMMCCXCI()
        {
            Assert.AreEqual("MMMCCXCI", Converter.Convert(3291));
        }
        [TestMethod]
        public void Convert_3292_Returns_MMMCCXCII()
        {
            Assert.AreEqual("MMMCCXCII", Converter.Convert(3292));
        }
        [TestMethod]
        public void Convert_3293_Returns_MMMCCXCIII()
        {
            Assert.AreEqual("MMMCCXCIII", Converter.Convert(3293));
        }
        [TestMethod]
        public void Convert_3294_Returns_MMMCCXCIV()
        {
            Assert.AreEqual("MMMCCXCIV", Converter.Convert(3294));
        }
        [TestMethod]
        public void Convert_3295_Returns_MMMCCXCV()
        {
            Assert.AreEqual("MMMCCXCV", Converter.Convert(3295));
        }
        [TestMethod]
        public void Convert_3296_Returns_MMMCCXCVI()
        {
            Assert.AreEqual("MMMCCXCVI", Converter.Convert(3296));
        }
        [TestMethod]
        public void Convert_3297_Returns_MMMCCXCVII()
        {
            Assert.AreEqual("MMMCCXCVII", Converter.Convert(3297));
        }
        [TestMethod]
        public void Convert_3298_Returns_MMMCCXCVIII()
        {
            Assert.AreEqual("MMMCCXCVIII", Converter.Convert(3298));
        }
        [TestMethod]
        public void Convert_3299_Returns_MMMCCXCIX()
        {
            Assert.AreEqual("MMMCCXCIX", Converter.Convert(3299));
        }
        [TestMethod]
        public void Convert_3300_Returns_MMMCCC()
        {
            Assert.AreEqual("MMMCCC", Converter.Convert(3300));
        }
        [TestMethod]
        public void Convert_3301_Returns_MMMCCCI()
        {
            Assert.AreEqual("MMMCCCI", Converter.Convert(3301));
        }
        [TestMethod]
        public void Convert_3302_Returns_MMMCCCII()
        {
            Assert.AreEqual("MMMCCCII", Converter.Convert(3302));
        }
        [TestMethod]
        public void Convert_3303_Returns_MMMCCCIII()
        {
            Assert.AreEqual("MMMCCCIII", Converter.Convert(3303));
        }
        [TestMethod]
        public void Convert_3304_Returns_MMMCCCIV()
        {
            Assert.AreEqual("MMMCCCIV", Converter.Convert(3304));
        }
        [TestMethod]
        public void Convert_3305_Returns_MMMCCCV()
        {
            Assert.AreEqual("MMMCCCV", Converter.Convert(3305));
        }
        [TestMethod]
        public void Convert_3306_Returns_MMMCCCVI()
        {
            Assert.AreEqual("MMMCCCVI", Converter.Convert(3306));
        }
        [TestMethod]
        public void Convert_3307_Returns_MMMCCCVII()
        {
            Assert.AreEqual("MMMCCCVII", Converter.Convert(3307));
        }
        [TestMethod]
        public void Convert_3308_Returns_MMMCCCVIII()
        {
            Assert.AreEqual("MMMCCCVIII", Converter.Convert(3308));
        }
        [TestMethod]
        public void Convert_3309_Returns_MMMCCCIX()
        {
            Assert.AreEqual("MMMCCCIX", Converter.Convert(3309));
        }
        [TestMethod]
        public void Convert_3310_Returns_MMMCCCX()
        {
            Assert.AreEqual("MMMCCCX", Converter.Convert(3310));
        }
        [TestMethod]
        public void Convert_3311_Returns_MMMCCCXI()
        {
            Assert.AreEqual("MMMCCCXI", Converter.Convert(3311));
        }
        [TestMethod]
        public void Convert_3312_Returns_MMMCCCXII()
        {
            Assert.AreEqual("MMMCCCXII", Converter.Convert(3312));
        }
        [TestMethod]
        public void Convert_3313_Returns_MMMCCCXIII()
        {
            Assert.AreEqual("MMMCCCXIII", Converter.Convert(3313));
        }
        [TestMethod]
        public void Convert_3314_Returns_MMMCCCXIV()
        {
            Assert.AreEqual("MMMCCCXIV", Converter.Convert(3314));
        }
        [TestMethod]
        public void Convert_3315_Returns_MMMCCCXV()
        {
            Assert.AreEqual("MMMCCCXV", Converter.Convert(3315));
        }
        [TestMethod]
        public void Convert_3316_Returns_MMMCCCXVI()
        {
            Assert.AreEqual("MMMCCCXVI", Converter.Convert(3316));
        }
        [TestMethod]
        public void Convert_3317_Returns_MMMCCCXVII()
        {
            Assert.AreEqual("MMMCCCXVII", Converter.Convert(3317));
        }
        [TestMethod]
        public void Convert_3318_Returns_MMMCCCXVIII()
        {
            Assert.AreEqual("MMMCCCXVIII", Converter.Convert(3318));
        }
        [TestMethod]
        public void Convert_3319_Returns_MMMCCCXIX()
        {
            Assert.AreEqual("MMMCCCXIX", Converter.Convert(3319));
        }
        [TestMethod]
        public void Convert_3320_Returns_MMMCCCXX()
        {
            Assert.AreEqual("MMMCCCXX", Converter.Convert(3320));
        }
        [TestMethod]
        public void Convert_3321_Returns_MMMCCCXXI()
        {
            Assert.AreEqual("MMMCCCXXI", Converter.Convert(3321));
        }
        [TestMethod]
        public void Convert_3322_Returns_MMMCCCXXII()
        {
            Assert.AreEqual("MMMCCCXXII", Converter.Convert(3322));
        }
        [TestMethod]
        public void Convert_3323_Returns_MMMCCCXXIII()
        {
            Assert.AreEqual("MMMCCCXXIII", Converter.Convert(3323));
        }
        [TestMethod]
        public void Convert_3324_Returns_MMMCCCXXIV()
        {
            Assert.AreEqual("MMMCCCXXIV", Converter.Convert(3324));
        }
        [TestMethod]
        public void Convert_3325_Returns_MMMCCCXXV()
        {
            Assert.AreEqual("MMMCCCXXV", Converter.Convert(3325));
        }
        [TestMethod]
        public void Convert_3326_Returns_MMMCCCXXVI()
        {
            Assert.AreEqual("MMMCCCXXVI", Converter.Convert(3326));
        }
        [TestMethod]
        public void Convert_3327_Returns_MMMCCCXXVII()
        {
            Assert.AreEqual("MMMCCCXXVII", Converter.Convert(3327));
        }
        [TestMethod]
        public void Convert_3328_Returns_MMMCCCXXVIII()
        {
            Assert.AreEqual("MMMCCCXXVIII", Converter.Convert(3328));
        }
        [TestMethod]
        public void Convert_3329_Returns_MMMCCCXXIX()
        {
            Assert.AreEqual("MMMCCCXXIX", Converter.Convert(3329));
        }
        [TestMethod]
        public void Convert_3330_Returns_MMMCCCXXX()
        {
            Assert.AreEqual("MMMCCCXXX", Converter.Convert(3330));
        }
        [TestMethod]
        public void Convert_3331_Returns_MMMCCCXXXI()
        {
            Assert.AreEqual("MMMCCCXXXI", Converter.Convert(3331));
        }
        [TestMethod]
        public void Convert_3332_Returns_MMMCCCXXXII()
        {
            Assert.AreEqual("MMMCCCXXXII", Converter.Convert(3332));
        }
        [TestMethod]
        public void Convert_3333_Returns_MMMCCCXXXIII()
        {
            Assert.AreEqual("MMMCCCXXXIII", Converter.Convert(3333));
        }
        [TestMethod]
        public void Convert_3334_Returns_MMMCCCXXXIV()
        {
            Assert.AreEqual("MMMCCCXXXIV", Converter.Convert(3334));
        }
        [TestMethod]
        public void Convert_3335_Returns_MMMCCCXXXV()
        {
            Assert.AreEqual("MMMCCCXXXV", Converter.Convert(3335));
        }
        [TestMethod]
        public void Convert_3336_Returns_MMMCCCXXXVI()
        {
            Assert.AreEqual("MMMCCCXXXVI", Converter.Convert(3336));
        }
        [TestMethod]
        public void Convert_3337_Returns_MMMCCCXXXVII()
        {
            Assert.AreEqual("MMMCCCXXXVII", Converter.Convert(3337));
        }
        [TestMethod]
        public void Convert_3338_Returns_MMMCCCXXXVIII()
        {
            Assert.AreEqual("MMMCCCXXXVIII", Converter.Convert(3338));
        }
        [TestMethod]
        public void Convert_3339_Returns_MMMCCCXXXIX()
        {
            Assert.AreEqual("MMMCCCXXXIX", Converter.Convert(3339));
        }
        [TestMethod]
        public void Convert_3340_Returns_MMMCCCXL()
        {
            Assert.AreEqual("MMMCCCXL", Converter.Convert(3340));
        }
        [TestMethod]
        public void Convert_3341_Returns_MMMCCCXLI()
        {
            Assert.AreEqual("MMMCCCXLI", Converter.Convert(3341));
        }
        [TestMethod]
        public void Convert_3342_Returns_MMMCCCXLII()
        {
            Assert.AreEqual("MMMCCCXLII", Converter.Convert(3342));
        }
        [TestMethod]
        public void Convert_3343_Returns_MMMCCCXLIII()
        {
            Assert.AreEqual("MMMCCCXLIII", Converter.Convert(3343));
        }
        [TestMethod]
        public void Convert_3344_Returns_MMMCCCXLIV()
        {
            Assert.AreEqual("MMMCCCXLIV", Converter.Convert(3344));
        }
        [TestMethod]
        public void Convert_3345_Returns_MMMCCCXLV()
        {
            Assert.AreEqual("MMMCCCXLV", Converter.Convert(3345));
        }
        [TestMethod]
        public void Convert_3346_Returns_MMMCCCXLVI()
        {
            Assert.AreEqual("MMMCCCXLVI", Converter.Convert(3346));
        }
        [TestMethod]
        public void Convert_3347_Returns_MMMCCCXLVII()
        {
            Assert.AreEqual("MMMCCCXLVII", Converter.Convert(3347));
        }
        [TestMethod]
        public void Convert_3348_Returns_MMMCCCXLVIII()
        {
            Assert.AreEqual("MMMCCCXLVIII", Converter.Convert(3348));
        }
        [TestMethod]
        public void Convert_3349_Returns_MMMCCCXLIX()
        {
            Assert.AreEqual("MMMCCCXLIX", Converter.Convert(3349));
        }
        [TestMethod]
        public void Convert_3350_Returns_MMMCCCL()
        {
            Assert.AreEqual("MMMCCCL", Converter.Convert(3350));
        }
        [TestMethod]
        public void Convert_3351_Returns_MMMCCCLI()
        {
            Assert.AreEqual("MMMCCCLI", Converter.Convert(3351));
        }
        [TestMethod]
        public void Convert_3352_Returns_MMMCCCLII()
        {
            Assert.AreEqual("MMMCCCLII", Converter.Convert(3352));
        }
        [TestMethod]
        public void Convert_3353_Returns_MMMCCCLIII()
        {
            Assert.AreEqual("MMMCCCLIII", Converter.Convert(3353));
        }
        [TestMethod]
        public void Convert_3354_Returns_MMMCCCLIV()
        {
            Assert.AreEqual("MMMCCCLIV", Converter.Convert(3354));
        }
        [TestMethod]
        public void Convert_3355_Returns_MMMCCCLV()
        {
            Assert.AreEqual("MMMCCCLV", Converter.Convert(3355));
        }
        [TestMethod]
        public void Convert_3356_Returns_MMMCCCLVI()
        {
            Assert.AreEqual("MMMCCCLVI", Converter.Convert(3356));
        }
        [TestMethod]
        public void Convert_3357_Returns_MMMCCCLVII()
        {
            Assert.AreEqual("MMMCCCLVII", Converter.Convert(3357));
        }
        [TestMethod]
        public void Convert_3358_Returns_MMMCCCLVIII()
        {
            Assert.AreEqual("MMMCCCLVIII", Converter.Convert(3358));
        }
        [TestMethod]
        public void Convert_3359_Returns_MMMCCCLIX()
        {
            Assert.AreEqual("MMMCCCLIX", Converter.Convert(3359));
        }
        [TestMethod]
        public void Convert_3360_Returns_MMMCCCLX()
        {
            Assert.AreEqual("MMMCCCLX", Converter.Convert(3360));
        }
        [TestMethod]
        public void Convert_3361_Returns_MMMCCCLXI()
        {
            Assert.AreEqual("MMMCCCLXI", Converter.Convert(3361));
        }
        [TestMethod]
        public void Convert_3362_Returns_MMMCCCLXII()
        {
            Assert.AreEqual("MMMCCCLXII", Converter.Convert(3362));
        }
        [TestMethod]
        public void Convert_3363_Returns_MMMCCCLXIII()
        {
            Assert.AreEqual("MMMCCCLXIII", Converter.Convert(3363));
        }
        [TestMethod]
        public void Convert_3364_Returns_MMMCCCLXIV()
        {
            Assert.AreEqual("MMMCCCLXIV", Converter.Convert(3364));
        }
        [TestMethod]
        public void Convert_3365_Returns_MMMCCCLXV()
        {
            Assert.AreEqual("MMMCCCLXV", Converter.Convert(3365));
        }
        [TestMethod]
        public void Convert_3366_Returns_MMMCCCLXVI()
        {
            Assert.AreEqual("MMMCCCLXVI", Converter.Convert(3366));
        }
        [TestMethod]
        public void Convert_3367_Returns_MMMCCCLXVII()
        {
            Assert.AreEqual("MMMCCCLXVII", Converter.Convert(3367));
        }
        [TestMethod]
        public void Convert_3368_Returns_MMMCCCLXVIII()
        {
            Assert.AreEqual("MMMCCCLXVIII", Converter.Convert(3368));
        }
        [TestMethod]
        public void Convert_3369_Returns_MMMCCCLXIX()
        {
            Assert.AreEqual("MMMCCCLXIX", Converter.Convert(3369));
        }
        [TestMethod]
        public void Convert_3370_Returns_MMMCCCLXX()
        {
            Assert.AreEqual("MMMCCCLXX", Converter.Convert(3370));
        }
        [TestMethod]
        public void Convert_3371_Returns_MMMCCCLXXI()
        {
            Assert.AreEqual("MMMCCCLXXI", Converter.Convert(3371));
        }
        [TestMethod]
        public void Convert_3372_Returns_MMMCCCLXXII()
        {
            Assert.AreEqual("MMMCCCLXXII", Converter.Convert(3372));
        }
        [TestMethod]
        public void Convert_3373_Returns_MMMCCCLXXIII()
        {
            Assert.AreEqual("MMMCCCLXXIII", Converter.Convert(3373));
        }
        [TestMethod]
        public void Convert_3374_Returns_MMMCCCLXXIV()
        {
            Assert.AreEqual("MMMCCCLXXIV", Converter.Convert(3374));
        }
        [TestMethod]
        public void Convert_3375_Returns_MMMCCCLXXV()
        {
            Assert.AreEqual("MMMCCCLXXV", Converter.Convert(3375));
        }
        [TestMethod]
        public void Convert_3376_Returns_MMMCCCLXXVI()
        {
            Assert.AreEqual("MMMCCCLXXVI", Converter.Convert(3376));
        }
        [TestMethod]
        public void Convert_3377_Returns_MMMCCCLXXVII()
        {
            Assert.AreEqual("MMMCCCLXXVII", Converter.Convert(3377));
        }
        [TestMethod]
        public void Convert_3378_Returns_MMMCCCLXXVIII()
        {
            Assert.AreEqual("MMMCCCLXXVIII", Converter.Convert(3378));
        }
        [TestMethod]
        public void Convert_3379_Returns_MMMCCCLXXIX()
        {
            Assert.AreEqual("MMMCCCLXXIX", Converter.Convert(3379));
        }
        [TestMethod]
        public void Convert_3380_Returns_MMMCCCLXXX()
        {
            Assert.AreEqual("MMMCCCLXXX", Converter.Convert(3380));
        }
        [TestMethod]
        public void Convert_3381_Returns_MMMCCCLXXXI()
        {
            Assert.AreEqual("MMMCCCLXXXI", Converter.Convert(3381));
        }
        [TestMethod]
        public void Convert_3382_Returns_MMMCCCLXXXII()
        {
            Assert.AreEqual("MMMCCCLXXXII", Converter.Convert(3382));
        }
        [TestMethod]
        public void Convert_3383_Returns_MMMCCCLXXXIII()
        {
            Assert.AreEqual("MMMCCCLXXXIII", Converter.Convert(3383));
        }
        [TestMethod]
        public void Convert_3384_Returns_MMMCCCLXXXIV()
        {
            Assert.AreEqual("MMMCCCLXXXIV", Converter.Convert(3384));
        }
        [TestMethod]
        public void Convert_3385_Returns_MMMCCCLXXXV()
        {
            Assert.AreEqual("MMMCCCLXXXV", Converter.Convert(3385));
        }
        [TestMethod]
        public void Convert_3386_Returns_MMMCCCLXXXVI()
        {
            Assert.AreEqual("MMMCCCLXXXVI", Converter.Convert(3386));
        }
        [TestMethod]
        public void Convert_3387_Returns_MMMCCCLXXXVII()
        {
            Assert.AreEqual("MMMCCCLXXXVII", Converter.Convert(3387));
        }
        [TestMethod]
        public void Convert_3388_Returns_MMMCCCLXXXVIII()
        {
            Assert.AreEqual("MMMCCCLXXXVIII", Converter.Convert(3388));
        }
        [TestMethod]
        public void Convert_3389_Returns_MMMCCCLXXXIX()
        {
            Assert.AreEqual("MMMCCCLXXXIX", Converter.Convert(3389));
        }
        [TestMethod]
        public void Convert_3390_Returns_MMMCCCXC()
        {
            Assert.AreEqual("MMMCCCXC", Converter.Convert(3390));
        }
        [TestMethod]
        public void Convert_3391_Returns_MMMCCCXCI()
        {
            Assert.AreEqual("MMMCCCXCI", Converter.Convert(3391));
        }
        [TestMethod]
        public void Convert_3392_Returns_MMMCCCXCII()
        {
            Assert.AreEqual("MMMCCCXCII", Converter.Convert(3392));
        }
        [TestMethod]
        public void Convert_3393_Returns_MMMCCCXCIII()
        {
            Assert.AreEqual("MMMCCCXCIII", Converter.Convert(3393));
        }
        [TestMethod]
        public void Convert_3394_Returns_MMMCCCXCIV()
        {
            Assert.AreEqual("MMMCCCXCIV", Converter.Convert(3394));
        }
        [TestMethod]
        public void Convert_3395_Returns_MMMCCCXCV()
        {
            Assert.AreEqual("MMMCCCXCV", Converter.Convert(3395));
        }
        [TestMethod]
        public void Convert_3396_Returns_MMMCCCXCVI()
        {
            Assert.AreEqual("MMMCCCXCVI", Converter.Convert(3396));
        }
        [TestMethod]
        public void Convert_3397_Returns_MMMCCCXCVII()
        {
            Assert.AreEqual("MMMCCCXCVII", Converter.Convert(3397));
        }
        [TestMethod]
        public void Convert_3398_Returns_MMMCCCXCVIII()
        {
            Assert.AreEqual("MMMCCCXCVIII", Converter.Convert(3398));
        }
        [TestMethod]
        public void Convert_3399_Returns_MMMCCCXCIX()
        {
            Assert.AreEqual("MMMCCCXCIX", Converter.Convert(3399));
        }
        [TestMethod]
        public void Convert_3400_Returns_MMMCD()
        {
            Assert.AreEqual("MMMCD", Converter.Convert(3400));
        }
        [TestMethod]
        public void Convert_3401_Returns_MMMCDI()
        {
            Assert.AreEqual("MMMCDI", Converter.Convert(3401));
        }
        [TestMethod]
        public void Convert_3402_Returns_MMMCDII()
        {
            Assert.AreEqual("MMMCDII", Converter.Convert(3402));
        }
        [TestMethod]
        public void Convert_3403_Returns_MMMCDIII()
        {
            Assert.AreEqual("MMMCDIII", Converter.Convert(3403));
        }
        [TestMethod]
        public void Convert_3404_Returns_MMMCDIV()
        {
            Assert.AreEqual("MMMCDIV", Converter.Convert(3404));
        }
        [TestMethod]
        public void Convert_3405_Returns_MMMCDV()
        {
            Assert.AreEqual("MMMCDV", Converter.Convert(3405));
        }
        [TestMethod]
        public void Convert_3406_Returns_MMMCDVI()
        {
            Assert.AreEqual("MMMCDVI", Converter.Convert(3406));
        }
        [TestMethod]
        public void Convert_3407_Returns_MMMCDVII()
        {
            Assert.AreEqual("MMMCDVII", Converter.Convert(3407));
        }
        [TestMethod]
        public void Convert_3408_Returns_MMMCDVIII()
        {
            Assert.AreEqual("MMMCDVIII", Converter.Convert(3408));
        }
        [TestMethod]
        public void Convert_3409_Returns_MMMCDIX()
        {
            Assert.AreEqual("MMMCDIX", Converter.Convert(3409));
        }
        [TestMethod]
        public void Convert_3410_Returns_MMMCDX()
        {
            Assert.AreEqual("MMMCDX", Converter.Convert(3410));
        }
        [TestMethod]
        public void Convert_3411_Returns_MMMCDXI()
        {
            Assert.AreEqual("MMMCDXI", Converter.Convert(3411));
        }
        [TestMethod]
        public void Convert_3412_Returns_MMMCDXII()
        {
            Assert.AreEqual("MMMCDXII", Converter.Convert(3412));
        }
        [TestMethod]
        public void Convert_3413_Returns_MMMCDXIII()
        {
            Assert.AreEqual("MMMCDXIII", Converter.Convert(3413));
        }
        [TestMethod]
        public void Convert_3414_Returns_MMMCDXIV()
        {
            Assert.AreEqual("MMMCDXIV", Converter.Convert(3414));
        }
        [TestMethod]
        public void Convert_3415_Returns_MMMCDXV()
        {
            Assert.AreEqual("MMMCDXV", Converter.Convert(3415));
        }
        [TestMethod]
        public void Convert_3416_Returns_MMMCDXVI()
        {
            Assert.AreEqual("MMMCDXVI", Converter.Convert(3416));
        }
        [TestMethod]
        public void Convert_3417_Returns_MMMCDXVII()
        {
            Assert.AreEqual("MMMCDXVII", Converter.Convert(3417));
        }
        [TestMethod]
        public void Convert_3418_Returns_MMMCDXVIII()
        {
            Assert.AreEqual("MMMCDXVIII", Converter.Convert(3418));
        }
        [TestMethod]
        public void Convert_3419_Returns_MMMCDXIX()
        {
            Assert.AreEqual("MMMCDXIX", Converter.Convert(3419));
        }
        [TestMethod]
        public void Convert_3420_Returns_MMMCDXX()
        {
            Assert.AreEqual("MMMCDXX", Converter.Convert(3420));
        }
        [TestMethod]
        public void Convert_3421_Returns_MMMCDXXI()
        {
            Assert.AreEqual("MMMCDXXI", Converter.Convert(3421));
        }
        [TestMethod]
        public void Convert_3422_Returns_MMMCDXXII()
        {
            Assert.AreEqual("MMMCDXXII", Converter.Convert(3422));
        }
        [TestMethod]
        public void Convert_3423_Returns_MMMCDXXIII()
        {
            Assert.AreEqual("MMMCDXXIII", Converter.Convert(3423));
        }
        [TestMethod]
        public void Convert_3424_Returns_MMMCDXXIV()
        {
            Assert.AreEqual("MMMCDXXIV", Converter.Convert(3424));
        }
        [TestMethod]
        public void Convert_3425_Returns_MMMCDXXV()
        {
            Assert.AreEqual("MMMCDXXV", Converter.Convert(3425));
        }
        [TestMethod]
        public void Convert_3426_Returns_MMMCDXXVI()
        {
            Assert.AreEqual("MMMCDXXVI", Converter.Convert(3426));
        }
        [TestMethod]
        public void Convert_3427_Returns_MMMCDXXVII()
        {
            Assert.AreEqual("MMMCDXXVII", Converter.Convert(3427));
        }
        [TestMethod]
        public void Convert_3428_Returns_MMMCDXXVIII()
        {
            Assert.AreEqual("MMMCDXXVIII", Converter.Convert(3428));
        }
        [TestMethod]
        public void Convert_3429_Returns_MMMCDXXIX()
        {
            Assert.AreEqual("MMMCDXXIX", Converter.Convert(3429));
        }
        [TestMethod]
        public void Convert_3430_Returns_MMMCDXXX()
        {
            Assert.AreEqual("MMMCDXXX", Converter.Convert(3430));
        }
        [TestMethod]
        public void Convert_3431_Returns_MMMCDXXXI()
        {
            Assert.AreEqual("MMMCDXXXI", Converter.Convert(3431));
        }
        [TestMethod]
        public void Convert_3432_Returns_MMMCDXXXII()
        {
            Assert.AreEqual("MMMCDXXXII", Converter.Convert(3432));
        }
        [TestMethod]
        public void Convert_3433_Returns_MMMCDXXXIII()
        {
            Assert.AreEqual("MMMCDXXXIII", Converter.Convert(3433));
        }
        [TestMethod]
        public void Convert_3434_Returns_MMMCDXXXIV()
        {
            Assert.AreEqual("MMMCDXXXIV", Converter.Convert(3434));
        }
        [TestMethod]
        public void Convert_3435_Returns_MMMCDXXXV()
        {
            Assert.AreEqual("MMMCDXXXV", Converter.Convert(3435));
        }
        [TestMethod]
        public void Convert_3436_Returns_MMMCDXXXVI()
        {
            Assert.AreEqual("MMMCDXXXVI", Converter.Convert(3436));
        }
        [TestMethod]
        public void Convert_3437_Returns_MMMCDXXXVII()
        {
            Assert.AreEqual("MMMCDXXXVII", Converter.Convert(3437));
        }
        [TestMethod]
        public void Convert_3438_Returns_MMMCDXXXVIII()
        {
            Assert.AreEqual("MMMCDXXXVIII", Converter.Convert(3438));
        }
        [TestMethod]
        public void Convert_3439_Returns_MMMCDXXXIX()
        {
            Assert.AreEqual("MMMCDXXXIX", Converter.Convert(3439));
        }
        [TestMethod]
        public void Convert_3440_Returns_MMMCDXL()
        {
            Assert.AreEqual("MMMCDXL", Converter.Convert(3440));
        }
        [TestMethod]
        public void Convert_3441_Returns_MMMCDXLI()
        {
            Assert.AreEqual("MMMCDXLI", Converter.Convert(3441));
        }
        [TestMethod]
        public void Convert_3442_Returns_MMMCDXLII()
        {
            Assert.AreEqual("MMMCDXLII", Converter.Convert(3442));
        }
        [TestMethod]
        public void Convert_3443_Returns_MMMCDXLIII()
        {
            Assert.AreEqual("MMMCDXLIII", Converter.Convert(3443));
        }
        [TestMethod]
        public void Convert_3444_Returns_MMMCDXLIV()
        {
            Assert.AreEqual("MMMCDXLIV", Converter.Convert(3444));
        }
        [TestMethod]
        public void Convert_3445_Returns_MMMCDXLV()
        {
            Assert.AreEqual("MMMCDXLV", Converter.Convert(3445));
        }
        [TestMethod]
        public void Convert_3446_Returns_MMMCDXLVI()
        {
            Assert.AreEqual("MMMCDXLVI", Converter.Convert(3446));
        }
        [TestMethod]
        public void Convert_3447_Returns_MMMCDXLVII()
        {
            Assert.AreEqual("MMMCDXLVII", Converter.Convert(3447));
        }
        [TestMethod]
        public void Convert_3448_Returns_MMMCDXLVIII()
        {
            Assert.AreEqual("MMMCDXLVIII", Converter.Convert(3448));
        }
        [TestMethod]
        public void Convert_3449_Returns_MMMCDXLIX()
        {
            Assert.AreEqual("MMMCDXLIX", Converter.Convert(3449));
        }
        [TestMethod]
        public void Convert_3450_Returns_MMMCDL()
        {
            Assert.AreEqual("MMMCDL", Converter.Convert(3450));
        }
        [TestMethod]
        public void Convert_3451_Returns_MMMCDLI()
        {
            Assert.AreEqual("MMMCDLI", Converter.Convert(3451));
        }
        [TestMethod]
        public void Convert_3452_Returns_MMMCDLII()
        {
            Assert.AreEqual("MMMCDLII", Converter.Convert(3452));
        }
        [TestMethod]
        public void Convert_3453_Returns_MMMCDLIII()
        {
            Assert.AreEqual("MMMCDLIII", Converter.Convert(3453));
        }
        [TestMethod]
        public void Convert_3454_Returns_MMMCDLIV()
        {
            Assert.AreEqual("MMMCDLIV", Converter.Convert(3454));
        }
        [TestMethod]
        public void Convert_3455_Returns_MMMCDLV()
        {
            Assert.AreEqual("MMMCDLV", Converter.Convert(3455));
        }
        [TestMethod]
        public void Convert_3456_Returns_MMMCDLVI()
        {
            Assert.AreEqual("MMMCDLVI", Converter.Convert(3456));
        }
        [TestMethod]
        public void Convert_3457_Returns_MMMCDLVII()
        {
            Assert.AreEqual("MMMCDLVII", Converter.Convert(3457));
        }
        [TestMethod]
        public void Convert_3458_Returns_MMMCDLVIII()
        {
            Assert.AreEqual("MMMCDLVIII", Converter.Convert(3458));
        }
        [TestMethod]
        public void Convert_3459_Returns_MMMCDLIX()
        {
            Assert.AreEqual("MMMCDLIX", Converter.Convert(3459));
        }
        [TestMethod]
        public void Convert_3460_Returns_MMMCDLX()
        {
            Assert.AreEqual("MMMCDLX", Converter.Convert(3460));
        }
        [TestMethod]
        public void Convert_3461_Returns_MMMCDLXI()
        {
            Assert.AreEqual("MMMCDLXI", Converter.Convert(3461));
        }
        [TestMethod]
        public void Convert_3462_Returns_MMMCDLXII()
        {
            Assert.AreEqual("MMMCDLXII", Converter.Convert(3462));
        }
        [TestMethod]
        public void Convert_3463_Returns_MMMCDLXIII()
        {
            Assert.AreEqual("MMMCDLXIII", Converter.Convert(3463));
        }
        [TestMethod]
        public void Convert_3464_Returns_MMMCDLXIV()
        {
            Assert.AreEqual("MMMCDLXIV", Converter.Convert(3464));
        }
        [TestMethod]
        public void Convert_3465_Returns_MMMCDLXV()
        {
            Assert.AreEqual("MMMCDLXV", Converter.Convert(3465));
        }
        [TestMethod]
        public void Convert_3466_Returns_MMMCDLXVI()
        {
            Assert.AreEqual("MMMCDLXVI", Converter.Convert(3466));
        }
        [TestMethod]
        public void Convert_3467_Returns_MMMCDLXVII()
        {
            Assert.AreEqual("MMMCDLXVII", Converter.Convert(3467));
        }
        [TestMethod]
        public void Convert_3468_Returns_MMMCDLXVIII()
        {
            Assert.AreEqual("MMMCDLXVIII", Converter.Convert(3468));
        }
        [TestMethod]
        public void Convert_3469_Returns_MMMCDLXIX()
        {
            Assert.AreEqual("MMMCDLXIX", Converter.Convert(3469));
        }
        [TestMethod]
        public void Convert_3470_Returns_MMMCDLXX()
        {
            Assert.AreEqual("MMMCDLXX", Converter.Convert(3470));
        }
        [TestMethod]
        public void Convert_3471_Returns_MMMCDLXXI()
        {
            Assert.AreEqual("MMMCDLXXI", Converter.Convert(3471));
        }
        [TestMethod]
        public void Convert_3472_Returns_MMMCDLXXII()
        {
            Assert.AreEqual("MMMCDLXXII", Converter.Convert(3472));
        }
        [TestMethod]
        public void Convert_3473_Returns_MMMCDLXXIII()
        {
            Assert.AreEqual("MMMCDLXXIII", Converter.Convert(3473));
        }
        [TestMethod]
        public void Convert_3474_Returns_MMMCDLXXIV()
        {
            Assert.AreEqual("MMMCDLXXIV", Converter.Convert(3474));
        }
        [TestMethod]
        public void Convert_3475_Returns_MMMCDLXXV()
        {
            Assert.AreEqual("MMMCDLXXV", Converter.Convert(3475));
        }
        [TestMethod]
        public void Convert_3476_Returns_MMMCDLXXVI()
        {
            Assert.AreEqual("MMMCDLXXVI", Converter.Convert(3476));
        }
        [TestMethod]
        public void Convert_3477_Returns_MMMCDLXXVII()
        {
            Assert.AreEqual("MMMCDLXXVII", Converter.Convert(3477));
        }
        [TestMethod]
        public void Convert_3478_Returns_MMMCDLXXVIII()
        {
            Assert.AreEqual("MMMCDLXXVIII", Converter.Convert(3478));
        }
        [TestMethod]
        public void Convert_3479_Returns_MMMCDLXXIX()
        {
            Assert.AreEqual("MMMCDLXXIX", Converter.Convert(3479));
        }
        [TestMethod]
        public void Convert_3480_Returns_MMMCDLXXX()
        {
            Assert.AreEqual("MMMCDLXXX", Converter.Convert(3480));
        }
        [TestMethod]
        public void Convert_3481_Returns_MMMCDLXXXI()
        {
            Assert.AreEqual("MMMCDLXXXI", Converter.Convert(3481));
        }
        [TestMethod]
        public void Convert_3482_Returns_MMMCDLXXXII()
        {
            Assert.AreEqual("MMMCDLXXXII", Converter.Convert(3482));
        }
        [TestMethod]
        public void Convert_3483_Returns_MMMCDLXXXIII()
        {
            Assert.AreEqual("MMMCDLXXXIII", Converter.Convert(3483));
        }
        [TestMethod]
        public void Convert_3484_Returns_MMMCDLXXXIV()
        {
            Assert.AreEqual("MMMCDLXXXIV", Converter.Convert(3484));
        }
        [TestMethod]
        public void Convert_3485_Returns_MMMCDLXXXV()
        {
            Assert.AreEqual("MMMCDLXXXV", Converter.Convert(3485));
        }
        [TestMethod]
        public void Convert_3486_Returns_MMMCDLXXXVI()
        {
            Assert.AreEqual("MMMCDLXXXVI", Converter.Convert(3486));
        }
        [TestMethod]
        public void Convert_3487_Returns_MMMCDLXXXVII()
        {
            Assert.AreEqual("MMMCDLXXXVII", Converter.Convert(3487));
        }
        [TestMethod]
        public void Convert_3488_Returns_MMMCDLXXXVIII()
        {
            Assert.AreEqual("MMMCDLXXXVIII", Converter.Convert(3488));
        }
        [TestMethod]
        public void Convert_3489_Returns_MMMCDLXXXIX()
        {
            Assert.AreEqual("MMMCDLXXXIX", Converter.Convert(3489));
        }
        [TestMethod]
        public void Convert_3490_Returns_MMMCDXC()
        {
            Assert.AreEqual("MMMCDXC", Converter.Convert(3490));
        }
        [TestMethod]
        public void Convert_3491_Returns_MMMCDXCI()
        {
            Assert.AreEqual("MMMCDXCI", Converter.Convert(3491));
        }
        [TestMethod]
        public void Convert_3492_Returns_MMMCDXCII()
        {
            Assert.AreEqual("MMMCDXCII", Converter.Convert(3492));
        }
        [TestMethod]
        public void Convert_3493_Returns_MMMCDXCIII()
        {
            Assert.AreEqual("MMMCDXCIII", Converter.Convert(3493));
        }
        [TestMethod]
        public void Convert_3494_Returns_MMMCDXCIV()
        {
            Assert.AreEqual("MMMCDXCIV", Converter.Convert(3494));
        }
        [TestMethod]
        public void Convert_3495_Returns_MMMCDXCV()
        {
            Assert.AreEqual("MMMCDXCV", Converter.Convert(3495));
        }
        [TestMethod]
        public void Convert_3496_Returns_MMMCDXCVI()
        {
            Assert.AreEqual("MMMCDXCVI", Converter.Convert(3496));
        }
        [TestMethod]
        public void Convert_3497_Returns_MMMCDXCVII()
        {
            Assert.AreEqual("MMMCDXCVII", Converter.Convert(3497));
        }
        [TestMethod]
        public void Convert_3498_Returns_MMMCDXCVIII()
        {
            Assert.AreEqual("MMMCDXCVIII", Converter.Convert(3498));
        }
        [TestMethod]
        public void Convert_3499_Returns_MMMCDXCIX()
        {
            Assert.AreEqual("MMMCDXCIX", Converter.Convert(3499));
        }
        [TestMethod]
        public void Convert_3500_Returns_MMMD()
        {
            Assert.AreEqual("MMMD", Converter.Convert(3500));
        }
        [TestMethod]
        public void Convert_3501_Returns_MMMDI()
        {
            Assert.AreEqual("MMMDI", Converter.Convert(3501));
        }
        [TestMethod]
        public void Convert_3502_Returns_MMMDII()
        {
            Assert.AreEqual("MMMDII", Converter.Convert(3502));
        }
        [TestMethod]
        public void Convert_3503_Returns_MMMDIII()
        {
            Assert.AreEqual("MMMDIII", Converter.Convert(3503));
        }
        [TestMethod]
        public void Convert_3504_Returns_MMMDIV()
        {
            Assert.AreEqual("MMMDIV", Converter.Convert(3504));
        }
        [TestMethod]
        public void Convert_3505_Returns_MMMDV()
        {
            Assert.AreEqual("MMMDV", Converter.Convert(3505));
        }
        [TestMethod]
        public void Convert_3506_Returns_MMMDVI()
        {
            Assert.AreEqual("MMMDVI", Converter.Convert(3506));
        }
        [TestMethod]
        public void Convert_3507_Returns_MMMDVII()
        {
            Assert.AreEqual("MMMDVII", Converter.Convert(3507));
        }
        [TestMethod]
        public void Convert_3508_Returns_MMMDVIII()
        {
            Assert.AreEqual("MMMDVIII", Converter.Convert(3508));
        }
        [TestMethod]
        public void Convert_3509_Returns_MMMDIX()
        {
            Assert.AreEqual("MMMDIX", Converter.Convert(3509));
        }
        [TestMethod]
        public void Convert_3510_Returns_MMMDX()
        {
            Assert.AreEqual("MMMDX", Converter.Convert(3510));
        }
        [TestMethod]
        public void Convert_3511_Returns_MMMDXI()
        {
            Assert.AreEqual("MMMDXI", Converter.Convert(3511));
        }
        [TestMethod]
        public void Convert_3512_Returns_MMMDXII()
        {
            Assert.AreEqual("MMMDXII", Converter.Convert(3512));
        }
        [TestMethod]
        public void Convert_3513_Returns_MMMDXIII()
        {
            Assert.AreEqual("MMMDXIII", Converter.Convert(3513));
        }
        [TestMethod]
        public void Convert_3514_Returns_MMMDXIV()
        {
            Assert.AreEqual("MMMDXIV", Converter.Convert(3514));
        }
        [TestMethod]
        public void Convert_3515_Returns_MMMDXV()
        {
            Assert.AreEqual("MMMDXV", Converter.Convert(3515));
        }
        [TestMethod]
        public void Convert_3516_Returns_MMMDXVI()
        {
            Assert.AreEqual("MMMDXVI", Converter.Convert(3516));
        }
        [TestMethod]
        public void Convert_3517_Returns_MMMDXVII()
        {
            Assert.AreEqual("MMMDXVII", Converter.Convert(3517));
        }
        [TestMethod]
        public void Convert_3518_Returns_MMMDXVIII()
        {
            Assert.AreEqual("MMMDXVIII", Converter.Convert(3518));
        }
        [TestMethod]
        public void Convert_3519_Returns_MMMDXIX()
        {
            Assert.AreEqual("MMMDXIX", Converter.Convert(3519));
        }
        [TestMethod]
        public void Convert_3520_Returns_MMMDXX()
        {
            Assert.AreEqual("MMMDXX", Converter.Convert(3520));
        }
        [TestMethod]
        public void Convert_3521_Returns_MMMDXXI()
        {
            Assert.AreEqual("MMMDXXI", Converter.Convert(3521));
        }
        [TestMethod]
        public void Convert_3522_Returns_MMMDXXII()
        {
            Assert.AreEqual("MMMDXXII", Converter.Convert(3522));
        }
        [TestMethod]
        public void Convert_3523_Returns_MMMDXXIII()
        {
            Assert.AreEqual("MMMDXXIII", Converter.Convert(3523));
        }
        [TestMethod]
        public void Convert_3524_Returns_MMMDXXIV()
        {
            Assert.AreEqual("MMMDXXIV", Converter.Convert(3524));
        }
        [TestMethod]
        public void Convert_3525_Returns_MMMDXXV()
        {
            Assert.AreEqual("MMMDXXV", Converter.Convert(3525));
        }
        [TestMethod]
        public void Convert_3526_Returns_MMMDXXVI()
        {
            Assert.AreEqual("MMMDXXVI", Converter.Convert(3526));
        }
        [TestMethod]
        public void Convert_3527_Returns_MMMDXXVII()
        {
            Assert.AreEqual("MMMDXXVII", Converter.Convert(3527));
        }
        [TestMethod]
        public void Convert_3528_Returns_MMMDXXVIII()
        {
            Assert.AreEqual("MMMDXXVIII", Converter.Convert(3528));
        }
        [TestMethod]
        public void Convert_3529_Returns_MMMDXXIX()
        {
            Assert.AreEqual("MMMDXXIX", Converter.Convert(3529));
        }
        [TestMethod]
        public void Convert_3530_Returns_MMMDXXX()
        {
            Assert.AreEqual("MMMDXXX", Converter.Convert(3530));
        }
        [TestMethod]
        public void Convert_3531_Returns_MMMDXXXI()
        {
            Assert.AreEqual("MMMDXXXI", Converter.Convert(3531));
        }
        [TestMethod]
        public void Convert_3532_Returns_MMMDXXXII()
        {
            Assert.AreEqual("MMMDXXXII", Converter.Convert(3532));
        }
        [TestMethod]
        public void Convert_3533_Returns_MMMDXXXIII()
        {
            Assert.AreEqual("MMMDXXXIII", Converter.Convert(3533));
        }
        [TestMethod]
        public void Convert_3534_Returns_MMMDXXXIV()
        {
            Assert.AreEqual("MMMDXXXIV", Converter.Convert(3534));
        }
        [TestMethod]
        public void Convert_3535_Returns_MMMDXXXV()
        {
            Assert.AreEqual("MMMDXXXV", Converter.Convert(3535));
        }
        [TestMethod]
        public void Convert_3536_Returns_MMMDXXXVI()
        {
            Assert.AreEqual("MMMDXXXVI", Converter.Convert(3536));
        }
        [TestMethod]
        public void Convert_3537_Returns_MMMDXXXVII()
        {
            Assert.AreEqual("MMMDXXXVII", Converter.Convert(3537));
        }
        [TestMethod]
        public void Convert_3538_Returns_MMMDXXXVIII()
        {
            Assert.AreEqual("MMMDXXXVIII", Converter.Convert(3538));
        }
        [TestMethod]
        public void Convert_3539_Returns_MMMDXXXIX()
        {
            Assert.AreEqual("MMMDXXXIX", Converter.Convert(3539));
        }
        [TestMethod]
        public void Convert_3540_Returns_MMMDXL()
        {
            Assert.AreEqual("MMMDXL", Converter.Convert(3540));
        }
        [TestMethod]
        public void Convert_3541_Returns_MMMDXLI()
        {
            Assert.AreEqual("MMMDXLI", Converter.Convert(3541));
        }
        [TestMethod]
        public void Convert_3542_Returns_MMMDXLII()
        {
            Assert.AreEqual("MMMDXLII", Converter.Convert(3542));
        }
        [TestMethod]
        public void Convert_3543_Returns_MMMDXLIII()
        {
            Assert.AreEqual("MMMDXLIII", Converter.Convert(3543));
        }
        [TestMethod]
        public void Convert_3544_Returns_MMMDXLIV()
        {
            Assert.AreEqual("MMMDXLIV", Converter.Convert(3544));
        }
        [TestMethod]
        public void Convert_3545_Returns_MMMDXLV()
        {
            Assert.AreEqual("MMMDXLV", Converter.Convert(3545));
        }
        [TestMethod]
        public void Convert_3546_Returns_MMMDXLVI()
        {
            Assert.AreEqual("MMMDXLVI", Converter.Convert(3546));
        }
        [TestMethod]
        public void Convert_3547_Returns_MMMDXLVII()
        {
            Assert.AreEqual("MMMDXLVII", Converter.Convert(3547));
        }
        [TestMethod]
        public void Convert_3548_Returns_MMMDXLVIII()
        {
            Assert.AreEqual("MMMDXLVIII", Converter.Convert(3548));
        }
        [TestMethod]
        public void Convert_3549_Returns_MMMDXLIX()
        {
            Assert.AreEqual("MMMDXLIX", Converter.Convert(3549));
        }
        [TestMethod]
        public void Convert_3550_Returns_MMMDL()
        {
            Assert.AreEqual("MMMDL", Converter.Convert(3550));
        }
        [TestMethod]
        public void Convert_3551_Returns_MMMDLI()
        {
            Assert.AreEqual("MMMDLI", Converter.Convert(3551));
        }
        [TestMethod]
        public void Convert_3552_Returns_MMMDLII()
        {
            Assert.AreEqual("MMMDLII", Converter.Convert(3552));
        }
        [TestMethod]
        public void Convert_3553_Returns_MMMDLIII()
        {
            Assert.AreEqual("MMMDLIII", Converter.Convert(3553));
        }
        [TestMethod]
        public void Convert_3554_Returns_MMMDLIV()
        {
            Assert.AreEqual("MMMDLIV", Converter.Convert(3554));
        }
        [TestMethod]
        public void Convert_3555_Returns_MMMDLV()
        {
            Assert.AreEqual("MMMDLV", Converter.Convert(3555));
        }
        [TestMethod]
        public void Convert_3556_Returns_MMMDLVI()
        {
            Assert.AreEqual("MMMDLVI", Converter.Convert(3556));
        }
        [TestMethod]
        public void Convert_3557_Returns_MMMDLVII()
        {
            Assert.AreEqual("MMMDLVII", Converter.Convert(3557));
        }
        [TestMethod]
        public void Convert_3558_Returns_MMMDLVIII()
        {
            Assert.AreEqual("MMMDLVIII", Converter.Convert(3558));
        }
        [TestMethod]
        public void Convert_3559_Returns_MMMDLIX()
        {
            Assert.AreEqual("MMMDLIX", Converter.Convert(3559));
        }
        [TestMethod]
        public void Convert_3560_Returns_MMMDLX()
        {
            Assert.AreEqual("MMMDLX", Converter.Convert(3560));
        }
        [TestMethod]
        public void Convert_3561_Returns_MMMDLXI()
        {
            Assert.AreEqual("MMMDLXI", Converter.Convert(3561));
        }
        [TestMethod]
        public void Convert_3562_Returns_MMMDLXII()
        {
            Assert.AreEqual("MMMDLXII", Converter.Convert(3562));
        }
        [TestMethod]
        public void Convert_3563_Returns_MMMDLXIII()
        {
            Assert.AreEqual("MMMDLXIII", Converter.Convert(3563));
        }
        [TestMethod]
        public void Convert_3564_Returns_MMMDLXIV()
        {
            Assert.AreEqual("MMMDLXIV", Converter.Convert(3564));
        }
        [TestMethod]
        public void Convert_3565_Returns_MMMDLXV()
        {
            Assert.AreEqual("MMMDLXV", Converter.Convert(3565));
        }
        [TestMethod]
        public void Convert_3566_Returns_MMMDLXVI()
        {
            Assert.AreEqual("MMMDLXVI", Converter.Convert(3566));
        }
        [TestMethod]
        public void Convert_3567_Returns_MMMDLXVII()
        {
            Assert.AreEqual("MMMDLXVII", Converter.Convert(3567));
        }
        [TestMethod]
        public void Convert_3568_Returns_MMMDLXVIII()
        {
            Assert.AreEqual("MMMDLXVIII", Converter.Convert(3568));
        }
        [TestMethod]
        public void Convert_3569_Returns_MMMDLXIX()
        {
            Assert.AreEqual("MMMDLXIX", Converter.Convert(3569));
        }
        [TestMethod]
        public void Convert_3570_Returns_MMMDLXX()
        {
            Assert.AreEqual("MMMDLXX", Converter.Convert(3570));
        }
        [TestMethod]
        public void Convert_3571_Returns_MMMDLXXI()
        {
            Assert.AreEqual("MMMDLXXI", Converter.Convert(3571));
        }
        [TestMethod]
        public void Convert_3572_Returns_MMMDLXXII()
        {
            Assert.AreEqual("MMMDLXXII", Converter.Convert(3572));
        }
        [TestMethod]
        public void Convert_3573_Returns_MMMDLXXIII()
        {
            Assert.AreEqual("MMMDLXXIII", Converter.Convert(3573));
        }
        [TestMethod]
        public void Convert_3574_Returns_MMMDLXXIV()
        {
            Assert.AreEqual("MMMDLXXIV", Converter.Convert(3574));
        }
        [TestMethod]
        public void Convert_3575_Returns_MMMDLXXV()
        {
            Assert.AreEqual("MMMDLXXV", Converter.Convert(3575));
        }
        [TestMethod]
        public void Convert_3576_Returns_MMMDLXXVI()
        {
            Assert.AreEqual("MMMDLXXVI", Converter.Convert(3576));
        }
        [TestMethod]
        public void Convert_3577_Returns_MMMDLXXVII()
        {
            Assert.AreEqual("MMMDLXXVII", Converter.Convert(3577));
        }
        [TestMethod]
        public void Convert_3578_Returns_MMMDLXXVIII()
        {
            Assert.AreEqual("MMMDLXXVIII", Converter.Convert(3578));
        }
        [TestMethod]
        public void Convert_3579_Returns_MMMDLXXIX()
        {
            Assert.AreEqual("MMMDLXXIX", Converter.Convert(3579));
        }
        [TestMethod]
        public void Convert_3580_Returns_MMMDLXXX()
        {
            Assert.AreEqual("MMMDLXXX", Converter.Convert(3580));
        }
        [TestMethod]
        public void Convert_3581_Returns_MMMDLXXXI()
        {
            Assert.AreEqual("MMMDLXXXI", Converter.Convert(3581));
        }
        [TestMethod]
        public void Convert_3582_Returns_MMMDLXXXII()
        {
            Assert.AreEqual("MMMDLXXXII", Converter.Convert(3582));
        }
        [TestMethod]
        public void Convert_3583_Returns_MMMDLXXXIII()
        {
            Assert.AreEqual("MMMDLXXXIII", Converter.Convert(3583));
        }
        [TestMethod]
        public void Convert_3584_Returns_MMMDLXXXIV()
        {
            Assert.AreEqual("MMMDLXXXIV", Converter.Convert(3584));
        }
        [TestMethod]
        public void Convert_3585_Returns_MMMDLXXXV()
        {
            Assert.AreEqual("MMMDLXXXV", Converter.Convert(3585));
        }
        [TestMethod]
        public void Convert_3586_Returns_MMMDLXXXVI()
        {
            Assert.AreEqual("MMMDLXXXVI", Converter.Convert(3586));
        }
        [TestMethod]
        public void Convert_3587_Returns_MMMDLXXXVII()
        {
            Assert.AreEqual("MMMDLXXXVII", Converter.Convert(3587));
        }
        [TestMethod]
        public void Convert_3588_Returns_MMMDLXXXVIII()
        {
            Assert.AreEqual("MMMDLXXXVIII", Converter.Convert(3588));
        }
        [TestMethod]
        public void Convert_3589_Returns_MMMDLXXXIX()
        {
            Assert.AreEqual("MMMDLXXXIX", Converter.Convert(3589));
        }
        [TestMethod]
        public void Convert_3590_Returns_MMMDXC()
        {
            Assert.AreEqual("MMMDXC", Converter.Convert(3590));
        }
        [TestMethod]
        public void Convert_3591_Returns_MMMDXCI()
        {
            Assert.AreEqual("MMMDXCI", Converter.Convert(3591));
        }
        [TestMethod]
        public void Convert_3592_Returns_MMMDXCII()
        {
            Assert.AreEqual("MMMDXCII", Converter.Convert(3592));
        }
        [TestMethod]
        public void Convert_3593_Returns_MMMDXCIII()
        {
            Assert.AreEqual("MMMDXCIII", Converter.Convert(3593));
        }
        [TestMethod]
        public void Convert_3594_Returns_MMMDXCIV()
        {
            Assert.AreEqual("MMMDXCIV", Converter.Convert(3594));
        }
        [TestMethod]
        public void Convert_3595_Returns_MMMDXCV()
        {
            Assert.AreEqual("MMMDXCV", Converter.Convert(3595));
        }
        [TestMethod]
        public void Convert_3596_Returns_MMMDXCVI()
        {
            Assert.AreEqual("MMMDXCVI", Converter.Convert(3596));
        }
        [TestMethod]
        public void Convert_3597_Returns_MMMDXCVII()
        {
            Assert.AreEqual("MMMDXCVII", Converter.Convert(3597));
        }
        [TestMethod]
        public void Convert_3598_Returns_MMMDXCVIII()
        {
            Assert.AreEqual("MMMDXCVIII", Converter.Convert(3598));
        }
        [TestMethod]
        public void Convert_3599_Returns_MMMDXCIX()
        {
            Assert.AreEqual("MMMDXCIX", Converter.Convert(3599));
        }
        [TestMethod]
        public void Convert_3600_Returns_MMMDC()
        {
            Assert.AreEqual("MMMDC", Converter.Convert(3600));
        }
        [TestMethod]
        public void Convert_3601_Returns_MMMDCI()
        {
            Assert.AreEqual("MMMDCI", Converter.Convert(3601));
        }
        [TestMethod]
        public void Convert_3602_Returns_MMMDCII()
        {
            Assert.AreEqual("MMMDCII", Converter.Convert(3602));
        }
        [TestMethod]
        public void Convert_3603_Returns_MMMDCIII()
        {
            Assert.AreEqual("MMMDCIII", Converter.Convert(3603));
        }
        [TestMethod]
        public void Convert_3604_Returns_MMMDCIV()
        {
            Assert.AreEqual("MMMDCIV", Converter.Convert(3604));
        }
        [TestMethod]
        public void Convert_3605_Returns_MMMDCV()
        {
            Assert.AreEqual("MMMDCV", Converter.Convert(3605));
        }
        [TestMethod]
        public void Convert_3606_Returns_MMMDCVI()
        {
            Assert.AreEqual("MMMDCVI", Converter.Convert(3606));
        }
        [TestMethod]
        public void Convert_3607_Returns_MMMDCVII()
        {
            Assert.AreEqual("MMMDCVII", Converter.Convert(3607));
        }
        [TestMethod]
        public void Convert_3608_Returns_MMMDCVIII()
        {
            Assert.AreEqual("MMMDCVIII", Converter.Convert(3608));
        }
        [TestMethod]
        public void Convert_3609_Returns_MMMDCIX()
        {
            Assert.AreEqual("MMMDCIX", Converter.Convert(3609));
        }
        [TestMethod]
        public void Convert_3610_Returns_MMMDCX()
        {
            Assert.AreEqual("MMMDCX", Converter.Convert(3610));
        }
        [TestMethod]
        public void Convert_3611_Returns_MMMDCXI()
        {
            Assert.AreEqual("MMMDCXI", Converter.Convert(3611));
        }
        [TestMethod]
        public void Convert_3612_Returns_MMMDCXII()
        {
            Assert.AreEqual("MMMDCXII", Converter.Convert(3612));
        }
        [TestMethod]
        public void Convert_3613_Returns_MMMDCXIII()
        {
            Assert.AreEqual("MMMDCXIII", Converter.Convert(3613));
        }
        [TestMethod]
        public void Convert_3614_Returns_MMMDCXIV()
        {
            Assert.AreEqual("MMMDCXIV", Converter.Convert(3614));
        }
        [TestMethod]
        public void Convert_3615_Returns_MMMDCXV()
        {
            Assert.AreEqual("MMMDCXV", Converter.Convert(3615));
        }
        [TestMethod]
        public void Convert_3616_Returns_MMMDCXVI()
        {
            Assert.AreEqual("MMMDCXVI", Converter.Convert(3616));
        }
        [TestMethod]
        public void Convert_3617_Returns_MMMDCXVII()
        {
            Assert.AreEqual("MMMDCXVII", Converter.Convert(3617));
        }
        [TestMethod]
        public void Convert_3618_Returns_MMMDCXVIII()
        {
            Assert.AreEqual("MMMDCXVIII", Converter.Convert(3618));
        }
        [TestMethod]
        public void Convert_3619_Returns_MMMDCXIX()
        {
            Assert.AreEqual("MMMDCXIX", Converter.Convert(3619));
        }
        [TestMethod]
        public void Convert_3620_Returns_MMMDCXX()
        {
            Assert.AreEqual("MMMDCXX", Converter.Convert(3620));
        }
        [TestMethod]
        public void Convert_3621_Returns_MMMDCXXI()
        {
            Assert.AreEqual("MMMDCXXI", Converter.Convert(3621));
        }
        [TestMethod]
        public void Convert_3622_Returns_MMMDCXXII()
        {
            Assert.AreEqual("MMMDCXXII", Converter.Convert(3622));
        }
        [TestMethod]
        public void Convert_3623_Returns_MMMDCXXIII()
        {
            Assert.AreEqual("MMMDCXXIII", Converter.Convert(3623));
        }
        [TestMethod]
        public void Convert_3624_Returns_MMMDCXXIV()
        {
            Assert.AreEqual("MMMDCXXIV", Converter.Convert(3624));
        }
        [TestMethod]
        public void Convert_3625_Returns_MMMDCXXV()
        {
            Assert.AreEqual("MMMDCXXV", Converter.Convert(3625));
        }
        [TestMethod]
        public void Convert_3626_Returns_MMMDCXXVI()
        {
            Assert.AreEqual("MMMDCXXVI", Converter.Convert(3626));
        }
        [TestMethod]
        public void Convert_3627_Returns_MMMDCXXVII()
        {
            Assert.AreEqual("MMMDCXXVII", Converter.Convert(3627));
        }
        [TestMethod]
        public void Convert_3628_Returns_MMMDCXXVIII()
        {
            Assert.AreEqual("MMMDCXXVIII", Converter.Convert(3628));
        }
        [TestMethod]
        public void Convert_3629_Returns_MMMDCXXIX()
        {
            Assert.AreEqual("MMMDCXXIX", Converter.Convert(3629));
        }
        [TestMethod]
        public void Convert_3630_Returns_MMMDCXXX()
        {
            Assert.AreEqual("MMMDCXXX", Converter.Convert(3630));
        }
        [TestMethod]
        public void Convert_3631_Returns_MMMDCXXXI()
        {
            Assert.AreEqual("MMMDCXXXI", Converter.Convert(3631));
        }
        [TestMethod]
        public void Convert_3632_Returns_MMMDCXXXII()
        {
            Assert.AreEqual("MMMDCXXXII", Converter.Convert(3632));
        }
        [TestMethod]
        public void Convert_3633_Returns_MMMDCXXXIII()
        {
            Assert.AreEqual("MMMDCXXXIII", Converter.Convert(3633));
        }
        [TestMethod]
        public void Convert_3634_Returns_MMMDCXXXIV()
        {
            Assert.AreEqual("MMMDCXXXIV", Converter.Convert(3634));
        }
        [TestMethod]
        public void Convert_3635_Returns_MMMDCXXXV()
        {
            Assert.AreEqual("MMMDCXXXV", Converter.Convert(3635));
        }
        [TestMethod]
        public void Convert_3636_Returns_MMMDCXXXVI()
        {
            Assert.AreEqual("MMMDCXXXVI", Converter.Convert(3636));
        }
        [TestMethod]
        public void Convert_3637_Returns_MMMDCXXXVII()
        {
            Assert.AreEqual("MMMDCXXXVII", Converter.Convert(3637));
        }
        [TestMethod]
        public void Convert_3638_Returns_MMMDCXXXVIII()
        {
            Assert.AreEqual("MMMDCXXXVIII", Converter.Convert(3638));
        }
        [TestMethod]
        public void Convert_3639_Returns_MMMDCXXXIX()
        {
            Assert.AreEqual("MMMDCXXXIX", Converter.Convert(3639));
        }
        [TestMethod]
        public void Convert_3640_Returns_MMMDCXL()
        {
            Assert.AreEqual("MMMDCXL", Converter.Convert(3640));
        }
        [TestMethod]
        public void Convert_3641_Returns_MMMDCXLI()
        {
            Assert.AreEqual("MMMDCXLI", Converter.Convert(3641));
        }
        [TestMethod]
        public void Convert_3642_Returns_MMMDCXLII()
        {
            Assert.AreEqual("MMMDCXLII", Converter.Convert(3642));
        }
        [TestMethod]
        public void Convert_3643_Returns_MMMDCXLIII()
        {
            Assert.AreEqual("MMMDCXLIII", Converter.Convert(3643));
        }
        [TestMethod]
        public void Convert_3644_Returns_MMMDCXLIV()
        {
            Assert.AreEqual("MMMDCXLIV", Converter.Convert(3644));
        }
        [TestMethod]
        public void Convert_3645_Returns_MMMDCXLV()
        {
            Assert.AreEqual("MMMDCXLV", Converter.Convert(3645));
        }
        [TestMethod]
        public void Convert_3646_Returns_MMMDCXLVI()
        {
            Assert.AreEqual("MMMDCXLVI", Converter.Convert(3646));
        }
        [TestMethod]
        public void Convert_3647_Returns_MMMDCXLVII()
        {
            Assert.AreEqual("MMMDCXLVII", Converter.Convert(3647));
        }
        [TestMethod]
        public void Convert_3648_Returns_MMMDCXLVIII()
        {
            Assert.AreEqual("MMMDCXLVIII", Converter.Convert(3648));
        }
        [TestMethod]
        public void Convert_3649_Returns_MMMDCXLIX()
        {
            Assert.AreEqual("MMMDCXLIX", Converter.Convert(3649));
        }
        [TestMethod]
        public void Convert_3650_Returns_MMMDCL()
        {
            Assert.AreEqual("MMMDCL", Converter.Convert(3650));
        }
        [TestMethod]
        public void Convert_3651_Returns_MMMDCLI()
        {
            Assert.AreEqual("MMMDCLI", Converter.Convert(3651));
        }
        [TestMethod]
        public void Convert_3652_Returns_MMMDCLII()
        {
            Assert.AreEqual("MMMDCLII", Converter.Convert(3652));
        }
        [TestMethod]
        public void Convert_3653_Returns_MMMDCLIII()
        {
            Assert.AreEqual("MMMDCLIII", Converter.Convert(3653));
        }
        [TestMethod]
        public void Convert_3654_Returns_MMMDCLIV()
        {
            Assert.AreEqual("MMMDCLIV", Converter.Convert(3654));
        }
        [TestMethod]
        public void Convert_3655_Returns_MMMDCLV()
        {
            Assert.AreEqual("MMMDCLV", Converter.Convert(3655));
        }
        [TestMethod]
        public void Convert_3656_Returns_MMMDCLVI()
        {
            Assert.AreEqual("MMMDCLVI", Converter.Convert(3656));
        }
        [TestMethod]
        public void Convert_3657_Returns_MMMDCLVII()
        {
            Assert.AreEqual("MMMDCLVII", Converter.Convert(3657));
        }
        [TestMethod]
        public void Convert_3658_Returns_MMMDCLVIII()
        {
            Assert.AreEqual("MMMDCLVIII", Converter.Convert(3658));
        }
        [TestMethod]
        public void Convert_3659_Returns_MMMDCLIX()
        {
            Assert.AreEqual("MMMDCLIX", Converter.Convert(3659));
        }
        [TestMethod]
        public void Convert_3660_Returns_MMMDCLX()
        {
            Assert.AreEqual("MMMDCLX", Converter.Convert(3660));
        }
        [TestMethod]
        public void Convert_3661_Returns_MMMDCLXI()
        {
            Assert.AreEqual("MMMDCLXI", Converter.Convert(3661));
        }
        [TestMethod]
        public void Convert_3662_Returns_MMMDCLXII()
        {
            Assert.AreEqual("MMMDCLXII", Converter.Convert(3662));
        }
        [TestMethod]
        public void Convert_3663_Returns_MMMDCLXIII()
        {
            Assert.AreEqual("MMMDCLXIII", Converter.Convert(3663));
        }
        [TestMethod]
        public void Convert_3664_Returns_MMMDCLXIV()
        {
            Assert.AreEqual("MMMDCLXIV", Converter.Convert(3664));
        }
        [TestMethod]
        public void Convert_3665_Returns_MMMDCLXV()
        {
            Assert.AreEqual("MMMDCLXV", Converter.Convert(3665));
        }
        [TestMethod]
        public void Convert_3666_Returns_MMMDCLXVI()
        {
            Assert.AreEqual("MMMDCLXVI", Converter.Convert(3666));
        }
        [TestMethod]
        public void Convert_3667_Returns_MMMDCLXVII()
        {
            Assert.AreEqual("MMMDCLXVII", Converter.Convert(3667));
        }
        [TestMethod]
        public void Convert_3668_Returns_MMMDCLXVIII()
        {
            Assert.AreEqual("MMMDCLXVIII", Converter.Convert(3668));
        }
        [TestMethod]
        public void Convert_3669_Returns_MMMDCLXIX()
        {
            Assert.AreEqual("MMMDCLXIX", Converter.Convert(3669));
        }
        [TestMethod]
        public void Convert_3670_Returns_MMMDCLXX()
        {
            Assert.AreEqual("MMMDCLXX", Converter.Convert(3670));
        }
        [TestMethod]
        public void Convert_3671_Returns_MMMDCLXXI()
        {
            Assert.AreEqual("MMMDCLXXI", Converter.Convert(3671));
        }
        [TestMethod]
        public void Convert_3672_Returns_MMMDCLXXII()
        {
            Assert.AreEqual("MMMDCLXXII", Converter.Convert(3672));
        }
        [TestMethod]
        public void Convert_3673_Returns_MMMDCLXXIII()
        {
            Assert.AreEqual("MMMDCLXXIII", Converter.Convert(3673));
        }
        [TestMethod]
        public void Convert_3674_Returns_MMMDCLXXIV()
        {
            Assert.AreEqual("MMMDCLXXIV", Converter.Convert(3674));
        }
        [TestMethod]
        public void Convert_3675_Returns_MMMDCLXXV()
        {
            Assert.AreEqual("MMMDCLXXV", Converter.Convert(3675));
        }
        [TestMethod]
        public void Convert_3676_Returns_MMMDCLXXVI()
        {
            Assert.AreEqual("MMMDCLXXVI", Converter.Convert(3676));
        }
        [TestMethod]
        public void Convert_3677_Returns_MMMDCLXXVII()
        {
            Assert.AreEqual("MMMDCLXXVII", Converter.Convert(3677));
        }
        [TestMethod]
        public void Convert_3678_Returns_MMMDCLXXVIII()
        {
            Assert.AreEqual("MMMDCLXXVIII", Converter.Convert(3678));
        }
        [TestMethod]
        public void Convert_3679_Returns_MMMDCLXXIX()
        {
            Assert.AreEqual("MMMDCLXXIX", Converter.Convert(3679));
        }
        [TestMethod]
        public void Convert_3680_Returns_MMMDCLXXX()
        {
            Assert.AreEqual("MMMDCLXXX", Converter.Convert(3680));
        }
        [TestMethod]
        public void Convert_3681_Returns_MMMDCLXXXI()
        {
            Assert.AreEqual("MMMDCLXXXI", Converter.Convert(3681));
        }
        [TestMethod]
        public void Convert_3682_Returns_MMMDCLXXXII()
        {
            Assert.AreEqual("MMMDCLXXXII", Converter.Convert(3682));
        }
        [TestMethod]
        public void Convert_3683_Returns_MMMDCLXXXIII()
        {
            Assert.AreEqual("MMMDCLXXXIII", Converter.Convert(3683));
        }
        [TestMethod]
        public void Convert_3684_Returns_MMMDCLXXXIV()
        {
            Assert.AreEqual("MMMDCLXXXIV", Converter.Convert(3684));
        }
        [TestMethod]
        public void Convert_3685_Returns_MMMDCLXXXV()
        {
            Assert.AreEqual("MMMDCLXXXV", Converter.Convert(3685));
        }
        [TestMethod]
        public void Convert_3686_Returns_MMMDCLXXXVI()
        {
            Assert.AreEqual("MMMDCLXXXVI", Converter.Convert(3686));
        }
        [TestMethod]
        public void Convert_3687_Returns_MMMDCLXXXVII()
        {
            Assert.AreEqual("MMMDCLXXXVII", Converter.Convert(3687));
        }
        [TestMethod]
        public void Convert_3688_Returns_MMMDCLXXXVIII()
        {
            Assert.AreEqual("MMMDCLXXXVIII", Converter.Convert(3688));
        }
        [TestMethod]
        public void Convert_3689_Returns_MMMDCLXXXIX()
        {
            Assert.AreEqual("MMMDCLXXXIX", Converter.Convert(3689));
        }
        [TestMethod]
        public void Convert_3690_Returns_MMMDCXC()
        {
            Assert.AreEqual("MMMDCXC", Converter.Convert(3690));
        }
        [TestMethod]
        public void Convert_3691_Returns_MMMDCXCI()
        {
            Assert.AreEqual("MMMDCXCI", Converter.Convert(3691));
        }
        [TestMethod]
        public void Convert_3692_Returns_MMMDCXCII()
        {
            Assert.AreEqual("MMMDCXCII", Converter.Convert(3692));
        }
        [TestMethod]
        public void Convert_3693_Returns_MMMDCXCIII()
        {
            Assert.AreEqual("MMMDCXCIII", Converter.Convert(3693));
        }
        [TestMethod]
        public void Convert_3694_Returns_MMMDCXCIV()
        {
            Assert.AreEqual("MMMDCXCIV", Converter.Convert(3694));
        }
        [TestMethod]
        public void Convert_3695_Returns_MMMDCXCV()
        {
            Assert.AreEqual("MMMDCXCV", Converter.Convert(3695));
        }
        [TestMethod]
        public void Convert_3696_Returns_MMMDCXCVI()
        {
            Assert.AreEqual("MMMDCXCVI", Converter.Convert(3696));
        }
        [TestMethod]
        public void Convert_3697_Returns_MMMDCXCVII()
        {
            Assert.AreEqual("MMMDCXCVII", Converter.Convert(3697));
        }
        [TestMethod]
        public void Convert_3698_Returns_MMMDCXCVIII()
        {
            Assert.AreEqual("MMMDCXCVIII", Converter.Convert(3698));
        }
        [TestMethod]
        public void Convert_3699_Returns_MMMDCXCIX()
        {
            Assert.AreEqual("MMMDCXCIX", Converter.Convert(3699));
        }
        [TestMethod]
        public void Convert_3700_Returns_MMMDCC()
        {
            Assert.AreEqual("MMMDCC", Converter.Convert(3700));
        }
        [TestMethod]
        public void Convert_3701_Returns_MMMDCCI()
        {
            Assert.AreEqual("MMMDCCI", Converter.Convert(3701));
        }
        [TestMethod]
        public void Convert_3702_Returns_MMMDCCII()
        {
            Assert.AreEqual("MMMDCCII", Converter.Convert(3702));
        }
        [TestMethod]
        public void Convert_3703_Returns_MMMDCCIII()
        {
            Assert.AreEqual("MMMDCCIII", Converter.Convert(3703));
        }
        [TestMethod]
        public void Convert_3704_Returns_MMMDCCIV()
        {
            Assert.AreEqual("MMMDCCIV", Converter.Convert(3704));
        }
        [TestMethod]
        public void Convert_3705_Returns_MMMDCCV()
        {
            Assert.AreEqual("MMMDCCV", Converter.Convert(3705));
        }
        [TestMethod]
        public void Convert_3706_Returns_MMMDCCVI()
        {
            Assert.AreEqual("MMMDCCVI", Converter.Convert(3706));
        }
        [TestMethod]
        public void Convert_3707_Returns_MMMDCCVII()
        {
            Assert.AreEqual("MMMDCCVII", Converter.Convert(3707));
        }
        [TestMethod]
        public void Convert_3708_Returns_MMMDCCVIII()
        {
            Assert.AreEqual("MMMDCCVIII", Converter.Convert(3708));
        }
        [TestMethod]
        public void Convert_3709_Returns_MMMDCCIX()
        {
            Assert.AreEqual("MMMDCCIX", Converter.Convert(3709));
        }
        [TestMethod]
        public void Convert_3710_Returns_MMMDCCX()
        {
            Assert.AreEqual("MMMDCCX", Converter.Convert(3710));
        }
        [TestMethod]
        public void Convert_3711_Returns_MMMDCCXI()
        {
            Assert.AreEqual("MMMDCCXI", Converter.Convert(3711));
        }
        [TestMethod]
        public void Convert_3712_Returns_MMMDCCXII()
        {
            Assert.AreEqual("MMMDCCXII", Converter.Convert(3712));
        }
        [TestMethod]
        public void Convert_3713_Returns_MMMDCCXIII()
        {
            Assert.AreEqual("MMMDCCXIII", Converter.Convert(3713));
        }
        [TestMethod]
        public void Convert_3714_Returns_MMMDCCXIV()
        {
            Assert.AreEqual("MMMDCCXIV", Converter.Convert(3714));
        }
        [TestMethod]
        public void Convert_3715_Returns_MMMDCCXV()
        {
            Assert.AreEqual("MMMDCCXV", Converter.Convert(3715));
        }
        [TestMethod]
        public void Convert_3716_Returns_MMMDCCXVI()
        {
            Assert.AreEqual("MMMDCCXVI", Converter.Convert(3716));
        }
        [TestMethod]
        public void Convert_3717_Returns_MMMDCCXVII()
        {
            Assert.AreEqual("MMMDCCXVII", Converter.Convert(3717));
        }
        [TestMethod]
        public void Convert_3718_Returns_MMMDCCXVIII()
        {
            Assert.AreEqual("MMMDCCXVIII", Converter.Convert(3718));
        }
        [TestMethod]
        public void Convert_3719_Returns_MMMDCCXIX()
        {
            Assert.AreEqual("MMMDCCXIX", Converter.Convert(3719));
        }
        [TestMethod]
        public void Convert_3720_Returns_MMMDCCXX()
        {
            Assert.AreEqual("MMMDCCXX", Converter.Convert(3720));
        }
        [TestMethod]
        public void Convert_3721_Returns_MMMDCCXXI()
        {
            Assert.AreEqual("MMMDCCXXI", Converter.Convert(3721));
        }
        [TestMethod]
        public void Convert_3722_Returns_MMMDCCXXII()
        {
            Assert.AreEqual("MMMDCCXXII", Converter.Convert(3722));
        }
        [TestMethod]
        public void Convert_3723_Returns_MMMDCCXXIII()
        {
            Assert.AreEqual("MMMDCCXXIII", Converter.Convert(3723));
        }
        [TestMethod]
        public void Convert_3724_Returns_MMMDCCXXIV()
        {
            Assert.AreEqual("MMMDCCXXIV", Converter.Convert(3724));
        }
        [TestMethod]
        public void Convert_3725_Returns_MMMDCCXXV()
        {
            Assert.AreEqual("MMMDCCXXV", Converter.Convert(3725));
        }
        [TestMethod]
        public void Convert_3726_Returns_MMMDCCXXVI()
        {
            Assert.AreEqual("MMMDCCXXVI", Converter.Convert(3726));
        }
        [TestMethod]
        public void Convert_3727_Returns_MMMDCCXXVII()
        {
            Assert.AreEqual("MMMDCCXXVII", Converter.Convert(3727));
        }
        [TestMethod]
        public void Convert_3728_Returns_MMMDCCXXVIII()
        {
            Assert.AreEqual("MMMDCCXXVIII", Converter.Convert(3728));
        }
        [TestMethod]
        public void Convert_3729_Returns_MMMDCCXXIX()
        {
            Assert.AreEqual("MMMDCCXXIX", Converter.Convert(3729));
        }
        [TestMethod]
        public void Convert_3730_Returns_MMMDCCXXX()
        {
            Assert.AreEqual("MMMDCCXXX", Converter.Convert(3730));
        }
        [TestMethod]
        public void Convert_3731_Returns_MMMDCCXXXI()
        {
            Assert.AreEqual("MMMDCCXXXI", Converter.Convert(3731));
        }
        [TestMethod]
        public void Convert_3732_Returns_MMMDCCXXXII()
        {
            Assert.AreEqual("MMMDCCXXXII", Converter.Convert(3732));
        }
        [TestMethod]
        public void Convert_3733_Returns_MMMDCCXXXIII()
        {
            Assert.AreEqual("MMMDCCXXXIII", Converter.Convert(3733));
        }
        [TestMethod]
        public void Convert_3734_Returns_MMMDCCXXXIV()
        {
            Assert.AreEqual("MMMDCCXXXIV", Converter.Convert(3734));
        }
        [TestMethod]
        public void Convert_3735_Returns_MMMDCCXXXV()
        {
            Assert.AreEqual("MMMDCCXXXV", Converter.Convert(3735));
        }
        [TestMethod]
        public void Convert_3736_Returns_MMMDCCXXXVI()
        {
            Assert.AreEqual("MMMDCCXXXVI", Converter.Convert(3736));
        }
        [TestMethod]
        public void Convert_3737_Returns_MMMDCCXXXVII()
        {
            Assert.AreEqual("MMMDCCXXXVII", Converter.Convert(3737));
        }
        [TestMethod]
        public void Convert_3738_Returns_MMMDCCXXXVIII()
        {
            Assert.AreEqual("MMMDCCXXXVIII", Converter.Convert(3738));
        }
        [TestMethod]
        public void Convert_3739_Returns_MMMDCCXXXIX()
        {
            Assert.AreEqual("MMMDCCXXXIX", Converter.Convert(3739));
        }
        [TestMethod]
        public void Convert_3740_Returns_MMMDCCXL()
        {
            Assert.AreEqual("MMMDCCXL", Converter.Convert(3740));
        }
        [TestMethod]
        public void Convert_3741_Returns_MMMDCCXLI()
        {
            Assert.AreEqual("MMMDCCXLI", Converter.Convert(3741));
        }
        [TestMethod]
        public void Convert_3742_Returns_MMMDCCXLII()
        {
            Assert.AreEqual("MMMDCCXLII", Converter.Convert(3742));
        }
        [TestMethod]
        public void Convert_3743_Returns_MMMDCCXLIII()
        {
            Assert.AreEqual("MMMDCCXLIII", Converter.Convert(3743));
        }
        [TestMethod]
        public void Convert_3744_Returns_MMMDCCXLIV()
        {
            Assert.AreEqual("MMMDCCXLIV", Converter.Convert(3744));
        }
        [TestMethod]
        public void Convert_3745_Returns_MMMDCCXLV()
        {
            Assert.AreEqual("MMMDCCXLV", Converter.Convert(3745));
        }
        [TestMethod]
        public void Convert_3746_Returns_MMMDCCXLVI()
        {
            Assert.AreEqual("MMMDCCXLVI", Converter.Convert(3746));
        }
        [TestMethod]
        public void Convert_3747_Returns_MMMDCCXLVII()
        {
            Assert.AreEqual("MMMDCCXLVII", Converter.Convert(3747));
        }
        [TestMethod]
        public void Convert_3748_Returns_MMMDCCXLVIII()
        {
            Assert.AreEqual("MMMDCCXLVIII", Converter.Convert(3748));
        }
        [TestMethod]
        public void Convert_3749_Returns_MMMDCCXLIX()
        {
            Assert.AreEqual("MMMDCCXLIX", Converter.Convert(3749));
        }
        [TestMethod]
        public void Convert_3750_Returns_MMMDCCL()
        {
            Assert.AreEqual("MMMDCCL", Converter.Convert(3750));
        }
        [TestMethod]
        public void Convert_3751_Returns_MMMDCCLI()
        {
            Assert.AreEqual("MMMDCCLI", Converter.Convert(3751));
        }
        [TestMethod]
        public void Convert_3752_Returns_MMMDCCLII()
        {
            Assert.AreEqual("MMMDCCLII", Converter.Convert(3752));
        }
        [TestMethod]
        public void Convert_3753_Returns_MMMDCCLIII()
        {
            Assert.AreEqual("MMMDCCLIII", Converter.Convert(3753));
        }
        [TestMethod]
        public void Convert_3754_Returns_MMMDCCLIV()
        {
            Assert.AreEqual("MMMDCCLIV", Converter.Convert(3754));
        }
        [TestMethod]
        public void Convert_3755_Returns_MMMDCCLV()
        {
            Assert.AreEqual("MMMDCCLV", Converter.Convert(3755));
        }
        [TestMethod]
        public void Convert_3756_Returns_MMMDCCLVI()
        {
            Assert.AreEqual("MMMDCCLVI", Converter.Convert(3756));
        }
        [TestMethod]
        public void Convert_3757_Returns_MMMDCCLVII()
        {
            Assert.AreEqual("MMMDCCLVII", Converter.Convert(3757));
        }
        [TestMethod]
        public void Convert_3758_Returns_MMMDCCLVIII()
        {
            Assert.AreEqual("MMMDCCLVIII", Converter.Convert(3758));
        }
        [TestMethod]
        public void Convert_3759_Returns_MMMDCCLIX()
        {
            Assert.AreEqual("MMMDCCLIX", Converter.Convert(3759));
        }
        [TestMethod]
        public void Convert_3760_Returns_MMMDCCLX()
        {
            Assert.AreEqual("MMMDCCLX", Converter.Convert(3760));
        }
        [TestMethod]
        public void Convert_3761_Returns_MMMDCCLXI()
        {
            Assert.AreEqual("MMMDCCLXI", Converter.Convert(3761));
        }
        [TestMethod]
        public void Convert_3762_Returns_MMMDCCLXII()
        {
            Assert.AreEqual("MMMDCCLXII", Converter.Convert(3762));
        }
        [TestMethod]
        public void Convert_3763_Returns_MMMDCCLXIII()
        {
            Assert.AreEqual("MMMDCCLXIII", Converter.Convert(3763));
        }
        [TestMethod]
        public void Convert_3764_Returns_MMMDCCLXIV()
        {
            Assert.AreEqual("MMMDCCLXIV", Converter.Convert(3764));
        }
        [TestMethod]
        public void Convert_3765_Returns_MMMDCCLXV()
        {
            Assert.AreEqual("MMMDCCLXV", Converter.Convert(3765));
        }
        [TestMethod]
        public void Convert_3766_Returns_MMMDCCLXVI()
        {
            Assert.AreEqual("MMMDCCLXVI", Converter.Convert(3766));
        }
        [TestMethod]
        public void Convert_3767_Returns_MMMDCCLXVII()
        {
            Assert.AreEqual("MMMDCCLXVII", Converter.Convert(3767));
        }
        [TestMethod]
        public void Convert_3768_Returns_MMMDCCLXVIII()
        {
            Assert.AreEqual("MMMDCCLXVIII", Converter.Convert(3768));
        }
        [TestMethod]
        public void Convert_3769_Returns_MMMDCCLXIX()
        {
            Assert.AreEqual("MMMDCCLXIX", Converter.Convert(3769));
        }
        [TestMethod]
        public void Convert_3770_Returns_MMMDCCLXX()
        {
            Assert.AreEqual("MMMDCCLXX", Converter.Convert(3770));
        }
        [TestMethod]
        public void Convert_3771_Returns_MMMDCCLXXI()
        {
            Assert.AreEqual("MMMDCCLXXI", Converter.Convert(3771));
        }
        [TestMethod]
        public void Convert_3772_Returns_MMMDCCLXXII()
        {
            Assert.AreEqual("MMMDCCLXXII", Converter.Convert(3772));
        }
        [TestMethod]
        public void Convert_3773_Returns_MMMDCCLXXIII()
        {
            Assert.AreEqual("MMMDCCLXXIII", Converter.Convert(3773));
        }
        [TestMethod]
        public void Convert_3774_Returns_MMMDCCLXXIV()
        {
            Assert.AreEqual("MMMDCCLXXIV", Converter.Convert(3774));
        }
        [TestMethod]
        public void Convert_3775_Returns_MMMDCCLXXV()
        {
            Assert.AreEqual("MMMDCCLXXV", Converter.Convert(3775));
        }
        [TestMethod]
        public void Convert_3776_Returns_MMMDCCLXXVI()
        {
            Assert.AreEqual("MMMDCCLXXVI", Converter.Convert(3776));
        }
        [TestMethod]
        public void Convert_3777_Returns_MMMDCCLXXVII()
        {
            Assert.AreEqual("MMMDCCLXXVII", Converter.Convert(3777));
        }
        [TestMethod]
        public void Convert_3778_Returns_MMMDCCLXXVIII()
        {
            Assert.AreEqual("MMMDCCLXXVIII", Converter.Convert(3778));
        }
        [TestMethod]
        public void Convert_3779_Returns_MMMDCCLXXIX()
        {
            Assert.AreEqual("MMMDCCLXXIX", Converter.Convert(3779));
        }
        [TestMethod]
        public void Convert_3780_Returns_MMMDCCLXXX()
        {
            Assert.AreEqual("MMMDCCLXXX", Converter.Convert(3780));
        }
        [TestMethod]
        public void Convert_3781_Returns_MMMDCCLXXXI()
        {
            Assert.AreEqual("MMMDCCLXXXI", Converter.Convert(3781));
        }
        [TestMethod]
        public void Convert_3782_Returns_MMMDCCLXXXII()
        {
            Assert.AreEqual("MMMDCCLXXXII", Converter.Convert(3782));
        }
        [TestMethod]
        public void Convert_3783_Returns_MMMDCCLXXXIII()
        {
            Assert.AreEqual("MMMDCCLXXXIII", Converter.Convert(3783));
        }
        [TestMethod]
        public void Convert_3784_Returns_MMMDCCLXXXIV()
        {
            Assert.AreEqual("MMMDCCLXXXIV", Converter.Convert(3784));
        }
        [TestMethod]
        public void Convert_3785_Returns_MMMDCCLXXXV()
        {
            Assert.AreEqual("MMMDCCLXXXV", Converter.Convert(3785));
        }
        [TestMethod]
        public void Convert_3786_Returns_MMMDCCLXXXVI()
        {
            Assert.AreEqual("MMMDCCLXXXVI", Converter.Convert(3786));
        }
        [TestMethod]
        public void Convert_3787_Returns_MMMDCCLXXXVII()
        {
            Assert.AreEqual("MMMDCCLXXXVII", Converter.Convert(3787));
        }
        [TestMethod]
        public void Convert_3788_Returns_MMMDCCLXXXVIII()
        {
            Assert.AreEqual("MMMDCCLXXXVIII", Converter.Convert(3788));
        }
        [TestMethod]
        public void Convert_3789_Returns_MMMDCCLXXXIX()
        {
            Assert.AreEqual("MMMDCCLXXXIX", Converter.Convert(3789));
        }
        [TestMethod]
        public void Convert_3790_Returns_MMMDCCXC()
        {
            Assert.AreEqual("MMMDCCXC", Converter.Convert(3790));
        }
        [TestMethod]
        public void Convert_3791_Returns_MMMDCCXCI()
        {
            Assert.AreEqual("MMMDCCXCI", Converter.Convert(3791));
        }
        [TestMethod]
        public void Convert_3792_Returns_MMMDCCXCII()
        {
            Assert.AreEqual("MMMDCCXCII", Converter.Convert(3792));
        }
        [TestMethod]
        public void Convert_3793_Returns_MMMDCCXCIII()
        {
            Assert.AreEqual("MMMDCCXCIII", Converter.Convert(3793));
        }
        [TestMethod]
        public void Convert_3794_Returns_MMMDCCXCIV()
        {
            Assert.AreEqual("MMMDCCXCIV", Converter.Convert(3794));
        }
        [TestMethod]
        public void Convert_3795_Returns_MMMDCCXCV()
        {
            Assert.AreEqual("MMMDCCXCV", Converter.Convert(3795));
        }
        [TestMethod]
        public void Convert_3796_Returns_MMMDCCXCVI()
        {
            Assert.AreEqual("MMMDCCXCVI", Converter.Convert(3796));
        }
        [TestMethod]
        public void Convert_3797_Returns_MMMDCCXCVII()
        {
            Assert.AreEqual("MMMDCCXCVII", Converter.Convert(3797));
        }
        [TestMethod]
        public void Convert_3798_Returns_MMMDCCXCVIII()
        {
            Assert.AreEqual("MMMDCCXCVIII", Converter.Convert(3798));
        }
        [TestMethod]
        public void Convert_3799_Returns_MMMDCCXCIX()
        {
            Assert.AreEqual("MMMDCCXCIX", Converter.Convert(3799));
        }
        [TestMethod]
        public void Convert_3800_Returns_MMMDCCC()
        {
            Assert.AreEqual("MMMDCCC", Converter.Convert(3800));
        }
        [TestMethod]
        public void Convert_3801_Returns_MMMDCCCI()
        {
            Assert.AreEqual("MMMDCCCI", Converter.Convert(3801));
        }
        [TestMethod]
        public void Convert_3802_Returns_MMMDCCCII()
        {
            Assert.AreEqual("MMMDCCCII", Converter.Convert(3802));
        }
        [TestMethod]
        public void Convert_3803_Returns_MMMDCCCIII()
        {
            Assert.AreEqual("MMMDCCCIII", Converter.Convert(3803));
        }
        [TestMethod]
        public void Convert_3804_Returns_MMMDCCCIV()
        {
            Assert.AreEqual("MMMDCCCIV", Converter.Convert(3804));
        }
        [TestMethod]
        public void Convert_3805_Returns_MMMDCCCV()
        {
            Assert.AreEqual("MMMDCCCV", Converter.Convert(3805));
        }
        [TestMethod]
        public void Convert_3806_Returns_MMMDCCCVI()
        {
            Assert.AreEqual("MMMDCCCVI", Converter.Convert(3806));
        }
        [TestMethod]
        public void Convert_3807_Returns_MMMDCCCVII()
        {
            Assert.AreEqual("MMMDCCCVII", Converter.Convert(3807));
        }
        [TestMethod]
        public void Convert_3808_Returns_MMMDCCCVIII()
        {
            Assert.AreEqual("MMMDCCCVIII", Converter.Convert(3808));
        }
        [TestMethod]
        public void Convert_3809_Returns_MMMDCCCIX()
        {
            Assert.AreEqual("MMMDCCCIX", Converter.Convert(3809));
        }
        [TestMethod]
        public void Convert_3810_Returns_MMMDCCCX()
        {
            Assert.AreEqual("MMMDCCCX", Converter.Convert(3810));
        }
        [TestMethod]
        public void Convert_3811_Returns_MMMDCCCXI()
        {
            Assert.AreEqual("MMMDCCCXI", Converter.Convert(3811));
        }
        [TestMethod]
        public void Convert_3812_Returns_MMMDCCCXII()
        {
            Assert.AreEqual("MMMDCCCXII", Converter.Convert(3812));
        }
        [TestMethod]
        public void Convert_3813_Returns_MMMDCCCXIII()
        {
            Assert.AreEqual("MMMDCCCXIII", Converter.Convert(3813));
        }
        [TestMethod]
        public void Convert_3814_Returns_MMMDCCCXIV()
        {
            Assert.AreEqual("MMMDCCCXIV", Converter.Convert(3814));
        }
        [TestMethod]
        public void Convert_3815_Returns_MMMDCCCXV()
        {
            Assert.AreEqual("MMMDCCCXV", Converter.Convert(3815));
        }
        [TestMethod]
        public void Convert_3816_Returns_MMMDCCCXVI()
        {
            Assert.AreEqual("MMMDCCCXVI", Converter.Convert(3816));
        }
        [TestMethod]
        public void Convert_3817_Returns_MMMDCCCXVII()
        {
            Assert.AreEqual("MMMDCCCXVII", Converter.Convert(3817));
        }
        [TestMethod]
        public void Convert_3818_Returns_MMMDCCCXVIII()
        {
            Assert.AreEqual("MMMDCCCXVIII", Converter.Convert(3818));
        }
        [TestMethod]
        public void Convert_3819_Returns_MMMDCCCXIX()
        {
            Assert.AreEqual("MMMDCCCXIX", Converter.Convert(3819));
        }
        [TestMethod]
        public void Convert_3820_Returns_MMMDCCCXX()
        {
            Assert.AreEqual("MMMDCCCXX", Converter.Convert(3820));
        }
        [TestMethod]
        public void Convert_3821_Returns_MMMDCCCXXI()
        {
            Assert.AreEqual("MMMDCCCXXI", Converter.Convert(3821));
        }
        [TestMethod]
        public void Convert_3822_Returns_MMMDCCCXXII()
        {
            Assert.AreEqual("MMMDCCCXXII", Converter.Convert(3822));
        }
        [TestMethod]
        public void Convert_3823_Returns_MMMDCCCXXIII()
        {
            Assert.AreEqual("MMMDCCCXXIII", Converter.Convert(3823));
        }
        [TestMethod]
        public void Convert_3824_Returns_MMMDCCCXXIV()
        {
            Assert.AreEqual("MMMDCCCXXIV", Converter.Convert(3824));
        }
        [TestMethod]
        public void Convert_3825_Returns_MMMDCCCXXV()
        {
            Assert.AreEqual("MMMDCCCXXV", Converter.Convert(3825));
        }
        [TestMethod]
        public void Convert_3826_Returns_MMMDCCCXXVI()
        {
            Assert.AreEqual("MMMDCCCXXVI", Converter.Convert(3826));
        }
        [TestMethod]
        public void Convert_3827_Returns_MMMDCCCXXVII()
        {
            Assert.AreEqual("MMMDCCCXXVII", Converter.Convert(3827));
        }
        [TestMethod]
        public void Convert_3828_Returns_MMMDCCCXXVIII()
        {
            Assert.AreEqual("MMMDCCCXXVIII", Converter.Convert(3828));
        }
        [TestMethod]
        public void Convert_3829_Returns_MMMDCCCXXIX()
        {
            Assert.AreEqual("MMMDCCCXXIX", Converter.Convert(3829));
        }
        [TestMethod]
        public void Convert_3830_Returns_MMMDCCCXXX()
        {
            Assert.AreEqual("MMMDCCCXXX", Converter.Convert(3830));
        }
        [TestMethod]
        public void Convert_3831_Returns_MMMDCCCXXXI()
        {
            Assert.AreEqual("MMMDCCCXXXI", Converter.Convert(3831));
        }
        [TestMethod]
        public void Convert_3832_Returns_MMMDCCCXXXII()
        {
            Assert.AreEqual("MMMDCCCXXXII", Converter.Convert(3832));
        }
        [TestMethod]
        public void Convert_3833_Returns_MMMDCCCXXXIII()
        {
            Assert.AreEqual("MMMDCCCXXXIII", Converter.Convert(3833));
        }
        [TestMethod]
        public void Convert_3834_Returns_MMMDCCCXXXIV()
        {
            Assert.AreEqual("MMMDCCCXXXIV", Converter.Convert(3834));
        }
        [TestMethod]
        public void Convert_3835_Returns_MMMDCCCXXXV()
        {
            Assert.AreEqual("MMMDCCCXXXV", Converter.Convert(3835));
        }
        [TestMethod]
        public void Convert_3836_Returns_MMMDCCCXXXVI()
        {
            Assert.AreEqual("MMMDCCCXXXVI", Converter.Convert(3836));
        }
        [TestMethod]
        public void Convert_3837_Returns_MMMDCCCXXXVII()
        {
            Assert.AreEqual("MMMDCCCXXXVII", Converter.Convert(3837));
        }
        [TestMethod]
        public void Convert_3838_Returns_MMMDCCCXXXVIII()
        {
            Assert.AreEqual("MMMDCCCXXXVIII", Converter.Convert(3838));
        }
        [TestMethod]
        public void Convert_3839_Returns_MMMDCCCXXXIX()
        {
            Assert.AreEqual("MMMDCCCXXXIX", Converter.Convert(3839));
        }
        [TestMethod]
        public void Convert_3840_Returns_MMMDCCCXL()
        {
            Assert.AreEqual("MMMDCCCXL", Converter.Convert(3840));
        }
        [TestMethod]
        public void Convert_3841_Returns_MMMDCCCXLI()
        {
            Assert.AreEqual("MMMDCCCXLI", Converter.Convert(3841));
        }
        [TestMethod]
        public void Convert_3842_Returns_MMMDCCCXLII()
        {
            Assert.AreEqual("MMMDCCCXLII", Converter.Convert(3842));
        }
        [TestMethod]
        public void Convert_3843_Returns_MMMDCCCXLIII()
        {
            Assert.AreEqual("MMMDCCCXLIII", Converter.Convert(3843));
        }
        [TestMethod]
        public void Convert_3844_Returns_MMMDCCCXLIV()
        {
            Assert.AreEqual("MMMDCCCXLIV", Converter.Convert(3844));
        }
        [TestMethod]
        public void Convert_3845_Returns_MMMDCCCXLV()
        {
            Assert.AreEqual("MMMDCCCXLV", Converter.Convert(3845));
        }
        [TestMethod]
        public void Convert_3846_Returns_MMMDCCCXLVI()
        {
            Assert.AreEqual("MMMDCCCXLVI", Converter.Convert(3846));
        }
        [TestMethod]
        public void Convert_3847_Returns_MMMDCCCXLVII()
        {
            Assert.AreEqual("MMMDCCCXLVII", Converter.Convert(3847));
        }
        [TestMethod]
        public void Convert_3848_Returns_MMMDCCCXLVIII()
        {
            Assert.AreEqual("MMMDCCCXLVIII", Converter.Convert(3848));
        }
        [TestMethod]
        public void Convert_3849_Returns_MMMDCCCXLIX()
        {
            Assert.AreEqual("MMMDCCCXLIX", Converter.Convert(3849));
        }
        [TestMethod]
        public void Convert_3850_Returns_MMMDCCCL()
        {
            Assert.AreEqual("MMMDCCCL", Converter.Convert(3850));
        }
        [TestMethod]
        public void Convert_3851_Returns_MMMDCCCLI()
        {
            Assert.AreEqual("MMMDCCCLI", Converter.Convert(3851));
        }
        [TestMethod]
        public void Convert_3852_Returns_MMMDCCCLII()
        {
            Assert.AreEqual("MMMDCCCLII", Converter.Convert(3852));
        }
        [TestMethod]
        public void Convert_3853_Returns_MMMDCCCLIII()
        {
            Assert.AreEqual("MMMDCCCLIII", Converter.Convert(3853));
        }
        [TestMethod]
        public void Convert_3854_Returns_MMMDCCCLIV()
        {
            Assert.AreEqual("MMMDCCCLIV", Converter.Convert(3854));
        }
        [TestMethod]
        public void Convert_3855_Returns_MMMDCCCLV()
        {
            Assert.AreEqual("MMMDCCCLV", Converter.Convert(3855));
        }
        [TestMethod]
        public void Convert_3856_Returns_MMMDCCCLVI()
        {
            Assert.AreEqual("MMMDCCCLVI", Converter.Convert(3856));
        }
        [TestMethod]
        public void Convert_3857_Returns_MMMDCCCLVII()
        {
            Assert.AreEqual("MMMDCCCLVII", Converter.Convert(3857));
        }
        [TestMethod]
        public void Convert_3858_Returns_MMMDCCCLVIII()
        {
            Assert.AreEqual("MMMDCCCLVIII", Converter.Convert(3858));
        }
        [TestMethod]
        public void Convert_3859_Returns_MMMDCCCLIX()
        {
            Assert.AreEqual("MMMDCCCLIX", Converter.Convert(3859));
        }
        [TestMethod]
        public void Convert_3860_Returns_MMMDCCCLX()
        {
            Assert.AreEqual("MMMDCCCLX", Converter.Convert(3860));
        }
        [TestMethod]
        public void Convert_3861_Returns_MMMDCCCLXI()
        {
            Assert.AreEqual("MMMDCCCLXI", Converter.Convert(3861));
        }
        [TestMethod]
        public void Convert_3862_Returns_MMMDCCCLXII()
        {
            Assert.AreEqual("MMMDCCCLXII", Converter.Convert(3862));
        }
        [TestMethod]
        public void Convert_3863_Returns_MMMDCCCLXIII()
        {
            Assert.AreEqual("MMMDCCCLXIII", Converter.Convert(3863));
        }
        [TestMethod]
        public void Convert_3864_Returns_MMMDCCCLXIV()
        {
            Assert.AreEqual("MMMDCCCLXIV", Converter.Convert(3864));
        }
        [TestMethod]
        public void Convert_3865_Returns_MMMDCCCLXV()
        {
            Assert.AreEqual("MMMDCCCLXV", Converter.Convert(3865));
        }
        [TestMethod]
        public void Convert_3866_Returns_MMMDCCCLXVI()
        {
            Assert.AreEqual("MMMDCCCLXVI", Converter.Convert(3866));
        }
        [TestMethod]
        public void Convert_3867_Returns_MMMDCCCLXVII()
        {
            Assert.AreEqual("MMMDCCCLXVII", Converter.Convert(3867));
        }
        [TestMethod]
        public void Convert_3868_Returns_MMMDCCCLXVIII()
        {
            Assert.AreEqual("MMMDCCCLXVIII", Converter.Convert(3868));
        }
        [TestMethod]
        public void Convert_3869_Returns_MMMDCCCLXIX()
        {
            Assert.AreEqual("MMMDCCCLXIX", Converter.Convert(3869));
        }
        [TestMethod]
        public void Convert_3870_Returns_MMMDCCCLXX()
        {
            Assert.AreEqual("MMMDCCCLXX", Converter.Convert(3870));
        }
        [TestMethod]
        public void Convert_3871_Returns_MMMDCCCLXXI()
        {
            Assert.AreEqual("MMMDCCCLXXI", Converter.Convert(3871));
        }
        [TestMethod]
        public void Convert_3872_Returns_MMMDCCCLXXII()
        {
            Assert.AreEqual("MMMDCCCLXXII", Converter.Convert(3872));
        }
        [TestMethod]
        public void Convert_3873_Returns_MMMDCCCLXXIII()
        {
            Assert.AreEqual("MMMDCCCLXXIII", Converter.Convert(3873));
        }
        [TestMethod]
        public void Convert_3874_Returns_MMMDCCCLXXIV()
        {
            Assert.AreEqual("MMMDCCCLXXIV", Converter.Convert(3874));
        }
        [TestMethod]
        public void Convert_3875_Returns_MMMDCCCLXXV()
        {
            Assert.AreEqual("MMMDCCCLXXV", Converter.Convert(3875));
        }
        [TestMethod]
        public void Convert_3876_Returns_MMMDCCCLXXVI()
        {
            Assert.AreEqual("MMMDCCCLXXVI", Converter.Convert(3876));
        }
        [TestMethod]
        public void Convert_3877_Returns_MMMDCCCLXXVII()
        {
            Assert.AreEqual("MMMDCCCLXXVII", Converter.Convert(3877));
        }
        [TestMethod]
        public void Convert_3878_Returns_MMMDCCCLXXVIII()
        {
            Assert.AreEqual("MMMDCCCLXXVIII", Converter.Convert(3878));
        }
        [TestMethod]
        public void Convert_3879_Returns_MMMDCCCLXXIX()
        {
            Assert.AreEqual("MMMDCCCLXXIX", Converter.Convert(3879));
        }
        [TestMethod]
        public void Convert_3880_Returns_MMMDCCCLXXX()
        {
            Assert.AreEqual("MMMDCCCLXXX", Converter.Convert(3880));
        }
        [TestMethod]
        public void Convert_3881_Returns_MMMDCCCLXXXI()
        {
            Assert.AreEqual("MMMDCCCLXXXI", Converter.Convert(3881));
        }
        [TestMethod]
        public void Convert_3882_Returns_MMMDCCCLXXXII()
        {
            Assert.AreEqual("MMMDCCCLXXXII", Converter.Convert(3882));
        }
        [TestMethod]
        public void Convert_3883_Returns_MMMDCCCLXXXIII()
        {
            Assert.AreEqual("MMMDCCCLXXXIII", Converter.Convert(3883));
        }
        [TestMethod]
        public void Convert_3884_Returns_MMMDCCCLXXXIV()
        {
            Assert.AreEqual("MMMDCCCLXXXIV", Converter.Convert(3884));
        }
        [TestMethod]
        public void Convert_3885_Returns_MMMDCCCLXXXV()
        {
            Assert.AreEqual("MMMDCCCLXXXV", Converter.Convert(3885));
        }
        [TestMethod]
        public void Convert_3886_Returns_MMMDCCCLXXXVI()
        {
            Assert.AreEqual("MMMDCCCLXXXVI", Converter.Convert(3886));
        }
        [TestMethod]
        public void Convert_3887_Returns_MMMDCCCLXXXVII()
        {
            Assert.AreEqual("MMMDCCCLXXXVII", Converter.Convert(3887));
        }
        [TestMethod]
        public void Convert_3888_Returns_MMMDCCCLXXXVIII()
        {
            Assert.AreEqual("MMMDCCCLXXXVIII", Converter.Convert(3888));
        }
        [TestMethod]
        public void Convert_3889_Returns_MMMDCCCLXXXIX()
        {
            Assert.AreEqual("MMMDCCCLXXXIX", Converter.Convert(3889));
        }
        [TestMethod]
        public void Convert_3890_Returns_MMMDCCCXC()
        {
            Assert.AreEqual("MMMDCCCXC", Converter.Convert(3890));
        }
        [TestMethod]
        public void Convert_3891_Returns_MMMDCCCXCI()
        {
            Assert.AreEqual("MMMDCCCXCI", Converter.Convert(3891));
        }
        [TestMethod]
        public void Convert_3892_Returns_MMMDCCCXCII()
        {
            Assert.AreEqual("MMMDCCCXCII", Converter.Convert(3892));
        }
        [TestMethod]
        public void Convert_3893_Returns_MMMDCCCXCIII()
        {
            Assert.AreEqual("MMMDCCCXCIII", Converter.Convert(3893));
        }
        [TestMethod]
        public void Convert_3894_Returns_MMMDCCCXCIV()
        {
            Assert.AreEqual("MMMDCCCXCIV", Converter.Convert(3894));
        }
        [TestMethod]
        public void Convert_3895_Returns_MMMDCCCXCV()
        {
            Assert.AreEqual("MMMDCCCXCV", Converter.Convert(3895));
        }
        [TestMethod]
        public void Convert_3896_Returns_MMMDCCCXCVI()
        {
            Assert.AreEqual("MMMDCCCXCVI", Converter.Convert(3896));
        }
        [TestMethod]
        public void Convert_3897_Returns_MMMDCCCXCVII()
        {
            Assert.AreEqual("MMMDCCCXCVII", Converter.Convert(3897));
        }
        [TestMethod]
        public void Convert_3898_Returns_MMMDCCCXCVIII()
        {
            Assert.AreEqual("MMMDCCCXCVIII", Converter.Convert(3898));
        }
        [TestMethod]
        public void Convert_3899_Returns_MMMDCCCXCIX()
        {
            Assert.AreEqual("MMMDCCCXCIX", Converter.Convert(3899));
        }
        [TestMethod]
        public void Convert_3900_Returns_MMMCM()
        {
            Assert.AreEqual("MMMCM", Converter.Convert(3900));
        }
        [TestMethod]
        public void Convert_3901_Returns_MMMCMI()
        {
            Assert.AreEqual("MMMCMI", Converter.Convert(3901));
        }
        [TestMethod]
        public void Convert_3902_Returns_MMMCMII()
        {
            Assert.AreEqual("MMMCMII", Converter.Convert(3902));
        }
        [TestMethod]
        public void Convert_3903_Returns_MMMCMIII()
        {
            Assert.AreEqual("MMMCMIII", Converter.Convert(3903));
        }
        [TestMethod]
        public void Convert_3904_Returns_MMMCMIV()
        {
            Assert.AreEqual("MMMCMIV", Converter.Convert(3904));
        }
        [TestMethod]
        public void Convert_3905_Returns_MMMCMV()
        {
            Assert.AreEqual("MMMCMV", Converter.Convert(3905));
        }
        [TestMethod]
        public void Convert_3906_Returns_MMMCMVI()
        {
            Assert.AreEqual("MMMCMVI", Converter.Convert(3906));
        }
        [TestMethod]
        public void Convert_3907_Returns_MMMCMVII()
        {
            Assert.AreEqual("MMMCMVII", Converter.Convert(3907));
        }
        [TestMethod]
        public void Convert_3908_Returns_MMMCMVIII()
        {
            Assert.AreEqual("MMMCMVIII", Converter.Convert(3908));
        }
        [TestMethod]
        public void Convert_3909_Returns_MMMCMIX()
        {
            Assert.AreEqual("MMMCMIX", Converter.Convert(3909));
        }
        [TestMethod]
        public void Convert_3910_Returns_MMMCMX()
        {
            Assert.AreEqual("MMMCMX", Converter.Convert(3910));
        }
        [TestMethod]
        public void Convert_3911_Returns_MMMCMXI()
        {
            Assert.AreEqual("MMMCMXI", Converter.Convert(3911));
        }
        [TestMethod]
        public void Convert_3912_Returns_MMMCMXII()
        {
            Assert.AreEqual("MMMCMXII", Converter.Convert(3912));
        }
        [TestMethod]
        public void Convert_3913_Returns_MMMCMXIII()
        {
            Assert.AreEqual("MMMCMXIII", Converter.Convert(3913));
        }
        [TestMethod]
        public void Convert_3914_Returns_MMMCMXIV()
        {
            Assert.AreEqual("MMMCMXIV", Converter.Convert(3914));
        }
        [TestMethod]
        public void Convert_3915_Returns_MMMCMXV()
        {
            Assert.AreEqual("MMMCMXV", Converter.Convert(3915));
        }
        [TestMethod]
        public void Convert_3916_Returns_MMMCMXVI()
        {
            Assert.AreEqual("MMMCMXVI", Converter.Convert(3916));
        }
        [TestMethod]
        public void Convert_3917_Returns_MMMCMXVII()
        {
            Assert.AreEqual("MMMCMXVII", Converter.Convert(3917));
        }
        [TestMethod]
        public void Convert_3918_Returns_MMMCMXVIII()
        {
            Assert.AreEqual("MMMCMXVIII", Converter.Convert(3918));
        }
        [TestMethod]
        public void Convert_3919_Returns_MMMCMXIX()
        {
            Assert.AreEqual("MMMCMXIX", Converter.Convert(3919));
        }
        [TestMethod]
        public void Convert_3920_Returns_MMMCMXX()
        {
            Assert.AreEqual("MMMCMXX", Converter.Convert(3920));
        }
        [TestMethod]
        public void Convert_3921_Returns_MMMCMXXI()
        {
            Assert.AreEqual("MMMCMXXI", Converter.Convert(3921));
        }
        [TestMethod]
        public void Convert_3922_Returns_MMMCMXXII()
        {
            Assert.AreEqual("MMMCMXXII", Converter.Convert(3922));
        }
        [TestMethod]
        public void Convert_3923_Returns_MMMCMXXIII()
        {
            Assert.AreEqual("MMMCMXXIII", Converter.Convert(3923));
        }
        [TestMethod]
        public void Convert_3924_Returns_MMMCMXXIV()
        {
            Assert.AreEqual("MMMCMXXIV", Converter.Convert(3924));
        }
        [TestMethod]
        public void Convert_3925_Returns_MMMCMXXV()
        {
            Assert.AreEqual("MMMCMXXV", Converter.Convert(3925));
        }
        [TestMethod]
        public void Convert_3926_Returns_MMMCMXXVI()
        {
            Assert.AreEqual("MMMCMXXVI", Converter.Convert(3926));
        }
        [TestMethod]
        public void Convert_3927_Returns_MMMCMXXVII()
        {
            Assert.AreEqual("MMMCMXXVII", Converter.Convert(3927));
        }
        [TestMethod]
        public void Convert_3928_Returns_MMMCMXXVIII()
        {
            Assert.AreEqual("MMMCMXXVIII", Converter.Convert(3928));
        }
        [TestMethod]
        public void Convert_3929_Returns_MMMCMXXIX()
        {
            Assert.AreEqual("MMMCMXXIX", Converter.Convert(3929));
        }
        [TestMethod]
        public void Convert_3930_Returns_MMMCMXXX()
        {
            Assert.AreEqual("MMMCMXXX", Converter.Convert(3930));
        }
        [TestMethod]
        public void Convert_3931_Returns_MMMCMXXXI()
        {
            Assert.AreEqual("MMMCMXXXI", Converter.Convert(3931));
        }
        [TestMethod]
        public void Convert_3932_Returns_MMMCMXXXII()
        {
            Assert.AreEqual("MMMCMXXXII", Converter.Convert(3932));
        }
        [TestMethod]
        public void Convert_3933_Returns_MMMCMXXXIII()
        {
            Assert.AreEqual("MMMCMXXXIII", Converter.Convert(3933));
        }
        [TestMethod]
        public void Convert_3934_Returns_MMMCMXXXIV()
        {
            Assert.AreEqual("MMMCMXXXIV", Converter.Convert(3934));
        }
        [TestMethod]
        public void Convert_3935_Returns_MMMCMXXXV()
        {
            Assert.AreEqual("MMMCMXXXV", Converter.Convert(3935));
        }
        [TestMethod]
        public void Convert_3936_Returns_MMMCMXXXVI()
        {
            Assert.AreEqual("MMMCMXXXVI", Converter.Convert(3936));
        }
        [TestMethod]
        public void Convert_3937_Returns_MMMCMXXXVII()
        {
            Assert.AreEqual("MMMCMXXXVII", Converter.Convert(3937));
        }
        [TestMethod]
        public void Convert_3938_Returns_MMMCMXXXVIII()
        {
            Assert.AreEqual("MMMCMXXXVIII", Converter.Convert(3938));
        }
        [TestMethod]
        public void Convert_3939_Returns_MMMCMXXXIX()
        {
            Assert.AreEqual("MMMCMXXXIX", Converter.Convert(3939));
        }
        [TestMethod]
        public void Convert_3940_Returns_MMMCMXL()
        {
            Assert.AreEqual("MMMCMXL", Converter.Convert(3940));
        }
        [TestMethod]
        public void Convert_3941_Returns_MMMCMXLI()
        {
            Assert.AreEqual("MMMCMXLI", Converter.Convert(3941));
        }
        [TestMethod]
        public void Convert_3942_Returns_MMMCMXLII()
        {
            Assert.AreEqual("MMMCMXLII", Converter.Convert(3942));
        }
        [TestMethod]
        public void Convert_3943_Returns_MMMCMXLIII()
        {
            Assert.AreEqual("MMMCMXLIII", Converter.Convert(3943));
        }
        [TestMethod]
        public void Convert_3944_Returns_MMMCMXLIV()
        {
            Assert.AreEqual("MMMCMXLIV", Converter.Convert(3944));
        }
        [TestMethod]
        public void Convert_3945_Returns_MMMCMXLV()
        {
            Assert.AreEqual("MMMCMXLV", Converter.Convert(3945));
        }
        [TestMethod]
        public void Convert_3946_Returns_MMMCMXLVI()
        {
            Assert.AreEqual("MMMCMXLVI", Converter.Convert(3946));
        }
        [TestMethod]
        public void Convert_3947_Returns_MMMCMXLVII()
        {
            Assert.AreEqual("MMMCMXLVII", Converter.Convert(3947));
        }
        [TestMethod]
        public void Convert_3948_Returns_MMMCMXLVIII()
        {
            Assert.AreEqual("MMMCMXLVIII", Converter.Convert(3948));
        }
        [TestMethod]
        public void Convert_3949_Returns_MMMCMXLIX()
        {
            Assert.AreEqual("MMMCMXLIX", Converter.Convert(3949));
        }
        [TestMethod]
        public void Convert_3950_Returns_MMMCML()
        {
            Assert.AreEqual("MMMCML", Converter.Convert(3950));
        }
        [TestMethod]
        public void Convert_3951_Returns_MMMCMLI()
        {
            Assert.AreEqual("MMMCMLI", Converter.Convert(3951));
        }
        [TestMethod]
        public void Convert_3952_Returns_MMMCMLII()
        {
            Assert.AreEqual("MMMCMLII", Converter.Convert(3952));
        }
        [TestMethod]
        public void Convert_3953_Returns_MMMCMLIII()
        {
            Assert.AreEqual("MMMCMLIII", Converter.Convert(3953));
        }
        [TestMethod]
        public void Convert_3954_Returns_MMMCMLIV()
        {
            Assert.AreEqual("MMMCMLIV", Converter.Convert(3954));
        }
        [TestMethod]
        public void Convert_3955_Returns_MMMCMLV()
        {
            Assert.AreEqual("MMMCMLV", Converter.Convert(3955));
        }
        [TestMethod]
        public void Convert_3956_Returns_MMMCMLVI()
        {
            Assert.AreEqual("MMMCMLVI", Converter.Convert(3956));
        }
        [TestMethod]
        public void Convert_3957_Returns_MMMCMLVII()
        {
            Assert.AreEqual("MMMCMLVII", Converter.Convert(3957));
        }
        [TestMethod]
        public void Convert_3958_Returns_MMMCMLVIII()
        {
            Assert.AreEqual("MMMCMLVIII", Converter.Convert(3958));
        }
        [TestMethod]
        public void Convert_3959_Returns_MMMCMLIX()
        {
            Assert.AreEqual("MMMCMLIX", Converter.Convert(3959));
        }
        [TestMethod]
        public void Convert_3960_Returns_MMMCMLX()
        {
            Assert.AreEqual("MMMCMLX", Converter.Convert(3960));
        }
        [TestMethod]
        public void Convert_3961_Returns_MMMCMLXI()
        {
            Assert.AreEqual("MMMCMLXI", Converter.Convert(3961));
        }
        [TestMethod]
        public void Convert_3962_Returns_MMMCMLXII()
        {
            Assert.AreEqual("MMMCMLXII", Converter.Convert(3962));
        }
        [TestMethod]
        public void Convert_3963_Returns_MMMCMLXIII()
        {
            Assert.AreEqual("MMMCMLXIII", Converter.Convert(3963));
        }
        [TestMethod]
        public void Convert_3964_Returns_MMMCMLXIV()
        {
            Assert.AreEqual("MMMCMLXIV", Converter.Convert(3964));
        }
        [TestMethod]
        public void Convert_3965_Returns_MMMCMLXV()
        {
            Assert.AreEqual("MMMCMLXV", Converter.Convert(3965));
        }
        [TestMethod]
        public void Convert_3966_Returns_MMMCMLXVI()
        {
            Assert.AreEqual("MMMCMLXVI", Converter.Convert(3966));
        }
        [TestMethod]
        public void Convert_3967_Returns_MMMCMLXVII()
        {
            Assert.AreEqual("MMMCMLXVII", Converter.Convert(3967));
        }
        [TestMethod]
        public void Convert_3968_Returns_MMMCMLXVIII()
        {
            Assert.AreEqual("MMMCMLXVIII", Converter.Convert(3968));
        }
        [TestMethod]
        public void Convert_3969_Returns_MMMCMLXIX()
        {
            Assert.AreEqual("MMMCMLXIX", Converter.Convert(3969));
        }
        [TestMethod]
        public void Convert_3970_Returns_MMMCMLXX()
        {
            Assert.AreEqual("MMMCMLXX", Converter.Convert(3970));
        }
        [TestMethod]
        public void Convert_3971_Returns_MMMCMLXXI()
        {
            Assert.AreEqual("MMMCMLXXI", Converter.Convert(3971));
        }
        [TestMethod]
        public void Convert_3972_Returns_MMMCMLXXII()
        {
            Assert.AreEqual("MMMCMLXXII", Converter.Convert(3972));
        }
        [TestMethod]
        public void Convert_3973_Returns_MMMCMLXXIII()
        {
            Assert.AreEqual("MMMCMLXXIII", Converter.Convert(3973));
        }
        [TestMethod]
        public void Convert_3974_Returns_MMMCMLXXIV()
        {
            Assert.AreEqual("MMMCMLXXIV", Converter.Convert(3974));
        }
        [TestMethod]
        public void Convert_3975_Returns_MMMCMLXXV()
        {
            Assert.AreEqual("MMMCMLXXV", Converter.Convert(3975));
        }
        [TestMethod]
        public void Convert_3976_Returns_MMMCMLXXVI()
        {
            Assert.AreEqual("MMMCMLXXVI", Converter.Convert(3976));
        }
        [TestMethod]
        public void Convert_3977_Returns_MMMCMLXXVII()
        {
            Assert.AreEqual("MMMCMLXXVII", Converter.Convert(3977));
        }
        [TestMethod]
        public void Convert_3978_Returns_MMMCMLXXVIII()
        {
            Assert.AreEqual("MMMCMLXXVIII", Converter.Convert(3978));
        }
        [TestMethod]
        public void Convert_3979_Returns_MMMCMLXXIX()
        {
            Assert.AreEqual("MMMCMLXXIX", Converter.Convert(3979));
        }
        [TestMethod]
        public void Convert_3980_Returns_MMMCMLXXX()
        {
            Assert.AreEqual("MMMCMLXXX", Converter.Convert(3980));
        }
        [TestMethod]
        public void Convert_3981_Returns_MMMCMLXXXI()
        {
            Assert.AreEqual("MMMCMLXXXI", Converter.Convert(3981));
        }
        [TestMethod]
        public void Convert_3982_Returns_MMMCMLXXXII()
        {
            Assert.AreEqual("MMMCMLXXXII", Converter.Convert(3982));
        }
        [TestMethod]
        public void Convert_3983_Returns_MMMCMLXXXIII()
        {
            Assert.AreEqual("MMMCMLXXXIII", Converter.Convert(3983));
        }
        [TestMethod]
        public void Convert_3984_Returns_MMMCMLXXXIV()
        {
            Assert.AreEqual("MMMCMLXXXIV", Converter.Convert(3984));
        }
        [TestMethod]
        public void Convert_3985_Returns_MMMCMLXXXV()
        {
            Assert.AreEqual("MMMCMLXXXV", Converter.Convert(3985));
        }
        [TestMethod]
        public void Convert_3986_Returns_MMMCMLXXXVI()
        {
            Assert.AreEqual("MMMCMLXXXVI", Converter.Convert(3986));
        }
        [TestMethod]
        public void Convert_3987_Returns_MMMCMLXXXVII()
        {
            Assert.AreEqual("MMMCMLXXXVII", Converter.Convert(3987));
        }
        [TestMethod]
        public void Convert_3988_Returns_MMMCMLXXXVIII()
        {
            Assert.AreEqual("MMMCMLXXXVIII", Converter.Convert(3988));
        }
        [TestMethod]
        public void Convert_3989_Returns_MMMCMLXXXIX()
        {
            Assert.AreEqual("MMMCMLXXXIX", Converter.Convert(3989));
        }
        [TestMethod]
        public void Convert_3990_Returns_MMMCMXC()
        {
            Assert.AreEqual("MMMCMXC", Converter.Convert(3990));
        }
        [TestMethod]
        public void Convert_3991_Returns_MMMCMXCI()
        {
            Assert.AreEqual("MMMCMXCI", Converter.Convert(3991));
        }
        [TestMethod]
        public void Convert_3992_Returns_MMMCMXCII()
        {
            Assert.AreEqual("MMMCMXCII", Converter.Convert(3992));
        }
        [TestMethod]
        public void Convert_3993_Returns_MMMCMXCIII()
        {
            Assert.AreEqual("MMMCMXCIII", Converter.Convert(3993));
        }
        [TestMethod]
        public void Convert_3994_Returns_MMMCMXCIV()
        {
            Assert.AreEqual("MMMCMXCIV", Converter.Convert(3994));
        }
        [TestMethod]
        public void Convert_3995_Returns_MMMCMXCV()
        {
            Assert.AreEqual("MMMCMXCV", Converter.Convert(3995));
        }
        [TestMethod]
        public void Convert_3996_Returns_MMMCMXCVI()
        {
            Assert.AreEqual("MMMCMXCVI", Converter.Convert(3996));
        }
        [TestMethod]
        public void Convert_3997_Returns_MMMCMXCVII()
        {
            Assert.AreEqual("MMMCMXCVII", Converter.Convert(3997));
        }
        [TestMethod]
        public void Convert_3998_Returns_MMMCMXCVIII()
        {
            Assert.AreEqual("MMMCMXCVIII", Converter.Convert(3998));
        }
        [TestMethod]
        public void Convert_3999_Returns_MMMCMXCIX()
        {
            Assert.AreEqual("MMMCMXCIX", Converter.Convert(3999));
        }


    }
}
