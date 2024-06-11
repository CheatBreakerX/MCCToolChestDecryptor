using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MCCToolChestDecryptor {
	internal class Class50 {
		internal static string GetObfuscatedString(int stringId) {
			int num = 173;
			byte[] array = new byte[32];
			int num2 = 0;
			byte[] array2 = new byte[16];
			int num3 = 0;
			MemoryStream memoryStream = null;
			ICryptoTransform cryptoTransform = null;
			CryptoStream cryptoStream = null;
			SymmetricAlgorithm symmetricAlgorithm = null;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			uint num7 = 0U;
			uint num8 = 0U;
			uint num9 = 0U;
			uint num10 = 0U;
			int num11 = 0;
			int num12 = 0;
			uint num13 = 255U;
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			int num17 = 0;
			uint num18 = 0U;
			uint num21 = 0U;
			int num22 = 0;
			uint num23 = 0U;
			byte[] array4 = new byte[0];
			byte[] array5 = new byte[0];
			byte[] array6 = new byte[0];
			byte[] assemblyPublicKeyToken = null;
			goto IL_1F89;
		IL_1789:
			for (; ; )
			{
				switch (num)
				{
					case 0:
						goto IL_1EBE;
					case 1:
						goto IL_B81;
					case 2:
						goto IL_6FF;
					case 3:
						goto IL_167;
					case 4:
						goto IL_10B6;
					case 5:
						goto IL_551;
					case 6:
						goto IL_11E2;
					case 7:
						goto IL_879;
					case 8:
						goto IL_5B7;
					case 9:
						goto IL_114D;
					case 10:
						goto IL_1335;
					case 11:
						goto IL_F4F;
					case 12:
						goto IL_1096;
					case 13:
						goto IL_8A6;
					case 14:
					case 293:
						goto IL_213;
					case 15:
						goto IL_22F;
					case 16:
						goto IL_1133;
					case 17:
						goto IL_616;
					case 18:
						goto IL_59D;
					case 19:
						goto IL_13AD;
					case 20:
						goto IL_11FC;
					case 21:
						goto IL_BB3;
					case 22:
						goto IL_3A8;
					case 23:
						goto IL_1E47;
					case 24:
						goto IL_957;
					case 25:
						goto IL_9B5;
					case 26:
						goto IL_DF5;
					case 27:
						goto IL_F5C;
					case 28:
						goto IL_D1;
					case 29:
						goto IL_50B;
					case 30:
						goto IL_1766;
					case 31:
						goto IL_BBA;
					case 32:
						goto IL_1E10;
					case 33:
						goto IL_340;
					case 34:
						goto IL_1E59;
					case 35:
						goto IL_FF7;
					case 36:
						goto IL_F8D;
					case 37:
						goto IL_86B;
					case 38:
						goto IL_936;
					case 39:
						goto IL_365;
					case 40:
						goto IL_3CC;
					case 41:
						goto IL_1269;
					case 42:
						goto IL_E85;
					case 43:
						goto IL_B91;
					case 44:
						goto IL_1259;
					case 45:
						goto IL_C88;
					case 46:
						goto IL_15AD;
					case 47:
						goto IL_3B8;
					case 48:
						goto IL_C7;
					case 49:
						goto IL_126;
					case 50:
						goto IL_ACB;
					case 51:
						goto IL_159E;
					case 52:
						goto IL_1390;
					case 53:
						goto IL_A7A;
					case 54:
						goto IL_130B;
					case 55:
						goto IL_995;
					case 56:
						goto IL_1524;
					case 57:
						goto IL_4E9;
					case 58:
						goto IL_5F5;
					case 59:
						goto IL_E21;
					case 60:
						goto IL_14D;
					case 61:
						goto IL_12EE;
					case 62:
						goto IL_740;
					case 63:
						goto IL_606;
					case 64:
						goto IL_1720;
					case 65:
						goto IL_130;
					case 66:
						goto IL_35C;
					case 67:
						goto IL_AC1;
					case 68:
						goto IL_353;
					case 69:
						goto IL_AB1;
					case 70:
						goto IL_989;
					case 71:
						break;
					case 72:
						goto IL_ECC;
					case 73:
						goto IL_D08;
					case 74:
						goto IL_10EF;
					case 75:
						goto IL_166D;
					case 76:
						goto IL_A1E;
					case 77:
						goto IL_BE4;
					case 78:
						goto IL_1E53;
					case 79:
						goto IL_464;
					case 80:
						goto IL_181;
					case 81:
						goto IL_1AB;
					case 82:
						goto IL_817;
					case 83:
					case 178:
						goto IL_EFE;
					case 84:
						goto IL_7AA;
					case 85:
						goto IL_16DD;
					case 86:
						goto IL_1CF;
					case 87:
						goto IL_1719;
					case 88:
						goto IL_633;
					case 89:
						goto IL_9C6;
					case 90:
						goto IL_9F2;
					case 91:
						goto IL_680;
					case 92:
						array[26] = (byte)num2;
						goto IL_14A8;
					case 93:
					case 331:
						goto IL_C84;
					case 94:
						goto IL_A2A;
					case 95:
						goto IL_1472;
					case 96:
						goto IL_4CB;
					case 97:
						goto IL_836;
					case 98:
						goto IL_DE1;
					case 99:
						goto IL_5AD;
					case 100:
						goto IL_814;
					case 101:
						goto IL_7E3;
					case 102:
						goto IL_1E38;
					case 103:
						goto IL_338;
					case 104:
						goto IL_C49;
					case 105:
					case 381:
						goto IL_D74;
					case 106:
						goto IL_169F;
					case 107:
						goto IL_B31;
					case 108:
						goto IL_9B8;
					case 109:
						goto IL_B44;
					case 110:
						array[30] = (byte)num2;
						goto IL_155C;
					case 111:
					case 279:
						goto IL_F08;
					case 112:
						goto IL_6C;
					case 113:
						goto IL_D82;
					case 114:
						goto IL_191;
					case 115:
						goto IL_1D9;
					case 116:
						goto IL_798;
					case 117:
						goto IL_C53;
					case 118:
						goto IL_1EF1;
					case 119:
						goto IL_EA6;
					case 120:
						goto IL_1F4E;
					case 121:
						goto IL_207;
					case 122:
						goto IL_602;
					case 123:
						goto IL_15D3;
					case 124:
						goto IL_750;
					case 125:
						goto IL_E05;
					case 126:
						goto IL_118C;
					case 127:
						goto IL_1758;
					case 128:
						goto IL_898;
					case 129:
						goto IL_EE;
					case 130:
						goto IL_6A8;
					case 131:
						goto IL_8FF;
					case 132:
						goto IL_1F9D;
					case 133:
						goto IL_173A;
					case 134:
						goto IL_C2E;
					case 135:
						goto IL_304;
					case 136:
						goto IL_1F19;
					case 137:
						goto IL_10FD;
					case 138:
						goto IL_1F0D;
					case 139:
						goto IL_1ED5;
					case 140:
						goto IL_1F27;
					case 141:
						goto IL_802;
					case 142:
						goto IL_AE8;
					case 143:
						goto IL_C01;
					case 144:
						goto IL_4DC;
					case 145:
						goto IL_7C4;
					case 146:
						goto IL_161C;
					case 147:
						goto IL_1BB;
					case 148:
						goto IL_8C1;
					case 149:
						goto IL_1ECB;
					case 150:
						goto IL_156E;
					case 151:
						goto IL_D96;
					case 152:
					case 287:
						goto IL_E91;
					case 153:
						goto IL_2EA;
					case 154:
						goto IL_4FF;
					case 155:
						goto IL_B21;
					case 156:
						goto IL_155C;
					case 157:
						goto IL_2CB;
					case 158:
						goto IL_1380;
					case 159:
						goto IL_44F;
					case 160:
						goto IL_A3A;
					case 161:
						goto IL_1C5;
					case 162:
						goto IL_1216;
					case 163:
						goto IL_64A;
					case 164:
						goto IL_549;
					case 165:
						goto IL_AEC;
					case 166:
						goto IL_B71;
					case 167:
						goto IL_20;
					case 168:
						goto IL_139D;
					case 169:
						goto IL_DC1;
					case 170:
						goto IL_1548;
					case 171:
						goto IL_1533;
					case 172:
						goto IL_1645;
					case 173:
						goto IL_1F89;
					case 174:
						goto IL_259;
					case 175:
						goto IL_1A4;
					case 176:
						goto IL_11C;
					case 177:
						goto IL_36A;
					case 179:
						goto IL_15F6;
					case 180:
						goto IL_BF2;
					case 181:
						goto IL_825;
					case 182:
						goto IL_140F;
					case 183:
						goto IL_75A;
					case 184:
						goto IL_1022;
					case 185:
						goto IL_85B;
					case 186:
						goto IL_1121;
					case 187:
						goto IL_972;
					case 188:
						goto IL_1514;
					case 189:
						goto IL_379;
					case 190:
						goto IL_522;
					case 191:
						goto IL_AF6;
					case 192:
						goto IL_AA4;
					case 193:
						goto IL_D5E;
					case 194:
						goto IL_423;
					case 195:
						goto IL_51;
					case 196:
						goto IL_CEE;
					case 197:
						goto IL_1639;
					case 198:
						goto IL_EE5;
					case 199:
						goto IL_697;
					case 200:
					case 245:
						goto IL_97B;
					case 201:
						goto IL_1507;
					case 202:
						goto IL_D18;
					case 203:
						goto IL_4B8;
					case 204:
						goto IL_5CB;
					case 205:
						goto IL_3A1;
					case 206:
						goto IL_924;
					case 207:
						goto IL_3DC;
					case 208:
						goto IL_14F2;
					case 209:
						goto IL_10D8;
					case 210:
						goto IL_7D4;
					case 211:
						goto IL_A05;
					case 212:
						goto IL_409;
					case 213:
						goto IL_1E9E;
					case 214:
						goto IL_FB4;
					case 215:
						goto IL_F15;
					case 216:
						goto IL_F2C;
					case 217:
						goto IL_16C9;
					case 218:
						goto IL_9C9;
					case 219:
						goto IL_8E5;
					case 220:
						goto IL_15D;
					case 221:
						goto IL_6E4;
					case 222:
						goto IL_C10;
					case 223:
						goto IL_57F;
					case 224:
						goto IL_1116;
					case 225:
						goto IL_1F30;
					case 226:
						goto IL_1EDF;
					case 227:
						goto IL_14D9;
					case 228:
						goto IL_164D;
					case 229:
						goto IL_11D1;
					case 230:
						array[30] = 18;
						goto IL_1449;
					case 231:
						goto IL_F41;
					case 232:
						goto IL_42D;
					case 233:
						goto IL_3F9;
					case 234:
						goto IL_14A8;
					case 235:
						goto IL_1063;
					case 236:
						goto IL_269;
					case 237:
						goto IL_327;
					case 238:
						goto IL_A5D;
					case 239:
						goto IL_13B7;
					case 240:
						goto IL_CEA;
					case 241:
						goto IL_102;
					case 242:
						goto IL_A16;
					case 243:
						goto IL_9E0;
					case 244:
						goto IL_100F;
					case 246:
						goto IL_13FF;
					case 247:
						goto IL_165E;
					case 248:
						goto IL_9A3;
					case 249:
						goto IL_2D8;
					case 250:
						goto IL_16AC;
					case 251:
						goto IL_1043;
					case 252:
						goto IL_A0D;
					case 253:
						array2[11] = 162;
						goto IL_1431;
					case 254:
						goto IL_A4C;
					case 255:
						goto IL_162A;
					case 256:
						goto IL_1465;
					case 257:
					case 319:
						goto IL_52E;
					case 258:
						goto IL_90D;
					case 259:
						goto IL_1E92;
					case 260:
						goto IL_844;
					case 261:
						goto IL_E5F;
					case 262:
						goto IL_858;
					case 263:
						goto IL_42;
					case 264:
						goto IL_102C;
					case 265:
						goto IL_13FB;
					case 266:
						goto IL_E6B;
					case 267:
						goto IL_1449;
					case 268:
						goto IL_1E29;
					case 269:
						goto IL_470;
					case 270:
						goto IL_1163;
					case 271:
						goto IL_16F3;
					case 272:
						goto IL_623;
					case 273:
						goto IL_8CF;
					case 274:
						goto IL_34;
					case 275:
						goto IL_132B;
					case 276:
						goto IL_724;
					case 277:
						goto IL_EB4;
					case 278:
						goto IL_4BB;
					case 280:
						goto IL_1245;
					case 281:
						goto IL_78F;
					case 282:
						goto IL_1605;
					case 283:
						goto IL_442;
					case 284:
						goto IL_1778;
					case 285:
						goto IL_1730;
					case 286:
						goto IL_9D1;
					case 288:
						goto IL_1431;
					case 289:
						goto IL_8B6;
					case 290:
						goto IL_BD6;
					case 291:
						goto IL_255;
					case 292:
						goto IL_167F;
					case 294:
						goto IL_DA4;
					case 295:
						goto IL_10E6;
					case 296:
						goto IL_15E6;
					case 297:
						goto IL_B06;
					case 298:
						goto IL_1E3;
					case 299:
						goto IL_F78;
					case 300:
						goto IL_1685;
					case 301:
						goto IL_FE6;
					case 302:
						goto IL_6B8;
					case 303:
						goto IL_1706;
					case 304:
						goto IL_16B9;
					case 305:
						goto IL_8F3;
					case 306:
						goto IL_120C;
					case 307:
						goto IL_4A1;
					case 308:
						goto IL_1171;
					case 309:
						goto IL_140;
					case 310:
						goto IL_FBD;
					case 311:
						goto IL_BC8;
					case 312:
						goto IL_1EAE;
					case 313:
						goto IL_16E7;
					case 314:
						goto IL_FE9;
					case 315:
						goto IL_B5A;
					case 316:
						goto IL_8B;
					case 317:
						goto IL_563;
					case 318:
						goto IL_174C;
					case 320:
						goto IL_2E;
					case 321:
						goto IL_FD7;
					case 322:
						goto IL_1255;
					case 323:
						goto IL_24B;
					case 324:
						goto IL_2F7;
					case 325:
						goto IL_11B7;
					case 326:
						goto IL_12DE;
					case 327:
						array[8] = (byte)num2;
						goto IL_13FB;
					case 328:
						goto IL_13CF;
					case 329:
						goto IL_DCE;
					case 330:
						goto IL_319;
					case 332:
						goto IL_1086;
					case 333:
						goto IL_896;
					case 334:
						goto IL_D89;
					case 335:
						goto IL_4D3;
					case 336:
						goto IL_2BD;
					case 337:
						goto IL_AA;
					case 338:
						goto IL_1E80;
					case 339:
						goto IL_12FB;
					case 340:
						goto IL_6D9;
					case 341:
						goto IL_966;
					case 342:
						goto IL_5DB;
					case 343:
						goto IL_E59;
					case 344:
						goto IL_850;
					case 345:
						goto IL_1073;
					case 346:
						goto IL_3C5;
					case 347:
						num2 = 157;
						goto IL_1380;
					case 348:
						goto IL_11F2;
					case 349:
						goto IL_5C7;
					case 350:
						goto IL_FA5;
					case 351:
						goto IL_B14;
					case 352:
						goto IL_112;
					case 353:
						goto IL_1119;
					case 354:
						array[25] = 162;
						goto IL_12DA;
					case 355:
						goto IL_11D8;
					case 356:
						goto IL_1039;
					case 357:
						goto IL_C1F;
					case 358:
						goto IL_E2C;
					case 359:
						goto IL_76E;
					case 360:
						goto IL_884;
					case 361:
						goto IL_A32;
					case 362:
						goto IL_AD8;
					case 363:
						goto IL_6F7;
					case 364:
						goto IL_949;
					case 365:
						goto IL_E4;
					case 366:
						goto IL_D28;
					case 367:
						goto IL_C91;
					case 368:
						goto IL_BA;
					case 369:
						goto IL_1053;
					case 370:
						goto IL_1F6B;
					case 371:
						goto IL_777;
					case 372:
						goto IL_7A;
					case 373:
						goto IL_60;
					case 374:
						goto IL_1327;
					case 375:
						goto IL_113F;
					case 376:
						goto IL_12DA;
					case 377:
						goto IL_6D5;
					case 378:
						goto IL_83;
					case 379:
						goto IL_916;
					case 380:
						goto IL_1650;
					case 382:
						goto IL_6A1;
					case 383:
						goto IL_E39;
					case 384:
						goto IL_1E6B;
					case 385:
						goto IL_12C3;
					case 386:
						goto IL_30B;
					case 387:
						goto IL_12B7;
					case 388:
						goto IL_1FA4;
					case 389:
						goto IL_370;
					case 390:
						goto IL_1613;
					case 391:
						goto IL_94;
					case 392:
						goto IL_1184;
					case 393:
						goto IL_71B;
					case 394:
						goto IL_1ED;
					case 395:
						goto IL_73C;
					case 396:
						goto IL_1693;
					case 397:
						goto IL_FE;
					case 398:
						goto IL_2AB;
					case 399:
						goto IL_1298;
					case 400:
						goto IL_B6A;
					case 401:
						goto IL_10A6;
					case 402:
						goto IL_FC5;
					case 403:
						array[31] = 106;
						goto IL_1245;
					case 404:
						goto IL_11AD;
					case 405:
						goto IL_A97;
					case 406:
						goto IL_669;
					case 407:
						goto IL_10D5;
					case 408:
						goto IL_B0A;
					case 409:
						goto IL_87C;
					case 410:
						goto IL_16CD;
					case 411:
						goto IL_3E9;
					case 412:
						goto IL_2A4;
					case 413:
						goto IL_28B;
					case 414:
						return Encoding.Unicode.GetString(Class50.byte_3, stringId + 4, BitConverter.ToInt32(Class50.byte_3, stringId));
					default:
						num = 2;
						continue;
				}
			IL_1279:
				array[31] = 100;
				num = 377;
				continue;
			IL_1269:
				array[31] = 120;
				goto IL_1279;
			IL_1259:
				array[31] = (byte)num2;
				goto IL_1269;
			IL_1255:
				num2 = 30;
				goto IL_1259;
			IL_1245:
				array[31] = 123;
				goto IL_1255;
			IL_1298:
				array[31] = (byte)num2;
				num = 403;
				continue;
			IL_13CF:
				num2 = 133;
				goto IL_1298;
			IL_155C:
				array[30] = 207;
				goto IL_13CF;
			IL_130B:
				num2 = 140;
				num = 92;
				continue;
			IL_12FB:
				array[26] = (byte)num2;
				goto IL_130B;
			IL_12EE:
				num2 = 134;
				goto IL_12FB;
			IL_12DE:
				array[25] = (byte)num2;
				goto IL_12EE;
			IL_12DA:
				num2 = 12;
				goto IL_12DE;
			IL_1335:
				array[1] = 131;
				num = 250;
				continue;
			IL_132B:
				array[0] = (byte)num2;
				goto IL_1335;
			IL_1327:
				num2 = 59;
				goto IL_132B;
			IL_13B7:
				array[0] = 128;
				goto IL_1327;
			IL_13AD:
				array[0] = 119;
				goto IL_13B7;
			IL_139D:
				array[0] = (byte)num2;
				goto IL_13AD;
			IL_1390:
				num2 = 134;
				goto IL_139D;
			IL_1380:
				array[0] = (byte)num2;
				goto IL_1390;
			IL_140F:
				array[8] = 147;
				num = 404;
				continue;
			IL_13FF:
				array[8] = (byte)num2;
				goto IL_140F;
			IL_13FB:
				num2 = 107;
				goto IL_13FF;
			IL_1431:
				num3 = 117;
				num = 238;
				continue;
			IL_1449:
				num2 = 137;
				num = 110;
				continue;
			IL_14A8:
				array[26] = 148;
				num = 51;
			}
		IL_10D5:
			num3 = 96;
		IL_10D8:
			array2[14] = (byte)num3;
		IL_10E6:
			num3 = 120;
		IL_10EF:
			array2[14] = (byte)num3;
		IL_10FD:
			array2[14] = 96;
		IL_1116:
			num3 = 73;
		IL_1119:
			array2[14] = (byte)num3;
		IL_1121:
			array2[15] = 150;
		IL_1133:
			num3 = 240;
		IL_113F:
			array2[15] = (byte)num3;
		IL_114D:
			num3 = 139;
		IL_1163:
			array2[15] = (byte)num3;
		IL_1171:
			num3 = 62;
		IL_1184:
			array2[15] = (byte)num3;
		IL_118C:
			array2[15] = 198;
			goto IL_76E;
		IL_11AD:
			num2 = 112;
		IL_11B7:
			array[8] = (byte)num2;
		IL_11D1:
			num2 = 141;
		IL_11D8:
			array[8] = (byte)num2;
		IL_11E2:
			array[8] = 57;
		IL_11F2:
			num2 = 106;
		IL_11FC:
			array[9] = (byte)num2;
		IL_120C:
			num2 = 125;
		IL_1216:
			array[9] = (byte)num2;
				goto IL_16F3;
		IL_12B7:
			array2[13] = 144;
		IL_12C3:
			array2[13] = 136;
			goto IL_10D5;
		IL_1465:
			array[3] = 138;
		IL_1472:
			array[4] = 166;
			goto IL_73C;
		IL_14D9:
			num2 = 121;
			goto IL_D08;
		IL_14F2:
			array[13] = 124;
			goto IL_423;
		IL_1507:
			array2[13] = (byte)num3;
			goto IL_12B7;
		IL_1514:
			array[26] = (byte)num2;
		IL_1524:
			num2 = 101;
			goto IL_F2C;
		IL_1533:
			array[19] = (byte)num2;
			goto IL_DC1;
		IL_1548:
			array2[11] = 39;
			goto IL_F41;
		IL_156E:
			array[21] = (byte)num2;
			goto IL_14D9;
		IL_159E:
			num2 = 30;
			goto IL_1514;
		IL_15AD:
			array2[11] = 90;
			goto IL_1548;
		IL_15D3:
			array[24] = 158;
		IL_15E6:
			array[24] = 97;
		IL_15F6:
			num2 = 97;
			goto IL_24B;
		IL_16AC:
			array[1] = 156;
			goto IL_16B9;
		IL_16F3:
			array[9] = 244;
		IL_1706:
			array[9] = 187;
		IL_1719:
			num2 = 141;
		IL_1720:
			array[10] = (byte)num2;
		IL_1730:
			array[10] = 34;
		IL_173A:
			num2 = 150;
			goto IL_AA;
		IL_20:
			array2[7] = (byte)num3;
		IL_2E:
			num3 = 134;
		IL_34:
			array2[7] = (byte)num3;
		IL_42:
			array2[7] = 122;
		IL_51:
			array2[7] = 97;
		IL_60:
			num3 = 128;
		IL_6C:
			array2[7] = (byte)num3;
		IL_7A:
			num3 = 92;
		IL_83:
			array2[7] = (byte)num3;
		IL_8B:
			array2[8] = 50;
		IL_94:
			num3 = 131;
			if (true)
			{
				goto IL_1605;
			}
		IL_AA:
			array[10] = (byte)num2;
		IL_BA:
			num2 = 199;
		IL_C7:
			array[10] = (byte)num2;
		IL_D1:
			array[10] = 156;
		IL_E4:
			array[10] = 58;
		IL_EE:
			array[11] = 80;
		IL_FE:
			num2 = 107;
		IL_102:
			array[11] = (byte)num2;
		IL_112:
			num2 = 118;
		IL_11C:
			array[11] = (byte)num2;
		IL_126:
			array[12] = 15;
		IL_130:
			array[12] = 65;
		IL_140:
			num2 = 143;
		IL_14D:
			array[12] = (byte)num2;
		IL_15D:
			num2 = 108;
		IL_167:
			array[12] = (byte)num2;
			num = 208;
				goto IL_1789;
		IL_181:
			array[2] = (byte)num2;
		IL_191:
			array[2] = 132;
		IL_1A4:
			num2 = 149;
		IL_1AB:
			array[2] = (byte)num2;
		IL_1BB:
			array[3] = 84;
		IL_1C5:
			array[3] = 23;
		IL_1CF:
			array[3] = 102;
		IL_1D9:
			array[3] = 32;
		IL_1E3:
			num2 = 46;
		IL_1ED:
			array[3] = (byte)num2;
			num = 256;
				goto IL_1789;
		IL_207:
			array2[10] = 224;
		IL_213:
			array2[10] = 146;
		IL_22F:
			array2[10] = 167;
			num = 253;
				goto IL_1789;
		IL_24B:
			array[24] = (byte)num2;
		IL_255:
			num2 = 112;
		IL_259:
			array[24] = (byte)num2;
		IL_269:
			array[25] = 178;
			num = 354;
			goto IL_1789;
		IL_28B:
			num2 = 84;
			num = 150;
			goto IL_1789;
		IL_2A4:
			memoryStream = new MemoryStream();
		IL_2AB:
			cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
		IL_2BD:
			byte[] array3;
			cryptoStream.Write(array3, 0, array3.Length);
		IL_2CB:
			cryptoStream.FlushFinalBlock();
		IL_2D8:
			Class50.byte_3 = memoryStream.ToArray();
		IL_2EA:
			memoryStream.Close();
		IL_2F7:
			cryptoStream.Close();
		IL_304:
			array3 = Class50.byte_3;
		IL_30B:
			num4 = array3.Length % 4;
		IL_319:
			num5 = array3.Length / 4;
		IL_327:
			array4 = new byte[array3.Length];
		IL_338:
			//array5;
			num6 = array5.Length / 4;
		IL_340:
			num7 = 0U;
		IL_353:
			num8 = 0U;
		IL_35C:
			num9 = 0U;
		IL_365:
			if (num4 <= 0)
			{
				goto IL_370;
			}
		IL_36A:
			num5++;
		IL_370:
			num10 = 0U;
		IL_379:
			num11 = 0;
			goto IL_F08;
		IL_3A1:
			num2 = 155;
		IL_3A8:
			array[27] = (byte)num2;
		IL_3B8:
			array[27] = 230;
		IL_3C5:
			num2 = 145;
		IL_3CC:
			array[27] = (byte)num2;
		IL_3DC:
			array[27] = 206;
		IL_3E9:
			array[28] = 120;
		IL_3F9:
			array[28] = 118;
		IL_409:
			array[28] = 207;
			if (true)
			{
				goto IL_442;
			}
		IL_423:
			array[13] = 94;
		IL_42D:
			array[13] = 98;
			goto IL_697;
		IL_442:
			num2 = 151;
		IL_44F:
			array[29] = (byte)num2;
			goto IL_B5A;
		IL_464:
			num10 = (uint)(num12 * 4);
		IL_470:
			num8 = (uint)(((int)array5[(int)((UIntPtr)(num10 + 3U))] << 24) | ((int)array5[(int)((UIntPtr)(num10 + 2U))] << 16) | ((int)array5[(int)((UIntPtr)(num10 + 1U))] << 8) | (int)array5[(int)((UIntPtr)num10)]);
		IL_4A1:
			num13 = 255U;
		IL_4B8:
		IL_4BB:
			if (num11 != num5 - 1) {
				goto IL_C3C;
			}
		IL_4CB:
			if (num4 <= 0) {
				goto IL_C3C;
			}
		IL_4D3:
			num9 = 0U;
		IL_4DC:
			num7 += num8;
		IL_4E9:
			num15 = 0;
			goto IL_52E;
		IL_4FF:
			num9 <<= 8;
		IL_50B:
			num9 |= (uint)array3[array3.Length - (1 + num15)];
		IL_522:
			num15++;
		IL_52E:
			if (num15 >= num4) {
				goto IL_C84;
			}
			else {
				if (num15 > 0) {
					goto IL_4FF;
				}
				goto IL_50B;
			}
		IL_549:
			array2[6] = (byte)num3;
		IL_551:
			array2[6] = 189;
		IL_563:
			array2[6] = 182;
		IL_57F:
			array2[6] = 94;
			goto IL_174C;
		IL_59D:
			array[5] = (byte)num2;
		IL_5AD:
			array[5] = 66;
		IL_5B7:
			array[5] = 37;
		IL_5C7:
			num2 = 16;
		IL_5CB:
			array[6] = (byte)num2;
		IL_5DB:
			array[6] = 104;
		IL_5F5:
			array[6] = 157;
		IL_602:
			num2 = 21;
		IL_606:
			array[6] = (byte)num2;
		IL_616:
			num2 = 157;
		IL_623:
			array[7] = (byte)num2;
		IL_633:
			num2 = 148;
		IL_64A:
			array[7] = (byte)num2;
			goto IL_F4F;
		IL_669:
			assemblyPublicKeyToken = Class50.assembly_0.GetName().GetPublicKeyToken();
		IL_680:
			if (assemblyPublicKeyToken == null) {
				goto IL_C2E;
			}
			goto IL_BB3;
		IL_697:
			array[13] = 59;
		IL_6A1:
			num2 = 128;
		IL_6A8:
			array[14] = (byte)num2;
		IL_6B8:
			array[14] = 154;
			goto IL_7E3;
		IL_6D5:
			array5 = array;
		IL_6D9:
			array2 = new byte[16];
		IL_6E4:
			num3 = 98;
		IL_6F7:
			array2[0] = (byte)num3;
		IL_6FF:
			array2[0] = 128;
		IL_71B:
			num3 = 52;
		IL_724:
			array2[0] = (byte)num3;
			goto IL_802;
		IL_73C:
			num2 = 119;
		IL_740:
			array[4] = (byte)num2;
		IL_750:
			array[4] = 124;
		IL_75A:
			num2 = 168;
			goto IL_7AA;
		IL_76E:
			num3 = 48;
		IL_777:
			array2[15] = (byte)num3;
		IL_78F:
			array6 = array2;
		IL_798:
			Array.Reverse(array6);
			goto IL_669;
		IL_7AA:
			array[4] = (byte)num2;
		IL_7C4:
			array[4] = 50;
		IL_7D4:
			num2 = 85;
			goto IL_59D;
		IL_7E3:
			array[14] = 108;
			goto IL_A7A;
		IL_802:
			array2[0] = 241;
		IL_814:
			num3 = 94;
		IL_817:
			array2[1] = (byte)num3;
		IL_825:
			num3 = 130;
			goto IL_A05;
		IL_836:
			array2[1] = (byte)num3;
		IL_844:
			num3 = 230;
		IL_850:
			array2[1] = (byte)num3;
		IL_858:
			num3 = 126;
		IL_85B:
			array2[2] = (byte)num3;
			goto IL_8B6;
		IL_86B:
			array2[2] = (byte)num3;
		IL_879:
			num3 = 83;
		IL_87C:
			array2[2] = (byte)num3;
		IL_884:
			array2[2] = 140;
		IL_896:
			num3 = 0;
		IL_898:
			array2[3] = (byte)num3;
		IL_8A6:
			num3 = 125;
			goto IL_8C1;
		IL_8B6:
			num3 = 117;
			goto IL_86B;
		IL_8C1:
			array2[3] = (byte)num3;
		IL_8CF:
			num3 = 144;
		IL_8E5:
			array2[3] = (byte)num3;
		IL_8F3:
			num3 = 164;
		IL_8FF:
			array2[3] = (byte)num3;
		IL_90D:
			num3 = 98;
		IL_916:
			array2[3] = (byte)num3;
		IL_924:
			array2[3] = 205;
		IL_936:
			num3 = 101;
		IL_949:
			array2[4] = (byte)num3;
		IL_957:
			array2[4] = 83;
		IL_966:
			array2[4] = 206;
		IL_972:
			num3 = 69;
		IL_97B:
			array2[4] = (byte)num3;
		IL_989:
			num3 = 140;
		IL_995:
			array2[4] = (byte)num3;
		IL_9A3:
			array2[4] = 130;
		IL_9B5:
			num3 = 114;
		IL_9B8:
			array2[5] = (byte)num3;
		IL_9C6:
			num3 = 108;
		IL_9C9:
			array2[5] = (byte)num3;
		IL_9D1:
			array2[5] = 88;
		IL_9E0:
			array2[5] = 128;
		IL_9F2:
			num3 = 135;
			goto IL_A32;
		IL_A05:
			array2[1] = (byte)num3;
		IL_A0D:
			num3 = 111;
		IL_A16:
			array2[1] = (byte)num3;
		IL_A1E:
			array2[1] = 193;
		IL_A2A:
			num3 = 124;
			goto IL_836;
		IL_A32:
			array2[5] = (byte)num3;
		IL_A3A:
			array2[5] = 175;
		IL_A4C:
			num3 = 145;
			goto IL_549;
		IL_A5D:
			array2[11] = (byte)num3;
			num = 46;
			goto IL_1789;
		IL_A7A:
			array[14] = 178;
		IL_A97:
			array[15] = 128;
		IL_AA4:
			num2 = 165;
		IL_AB1:
			array[15] = (byte)num2;
		IL_AC1:
			array[15] = 14;
		IL_ACB:
			num2 = 199;
		IL_AD8:
			array[16] = (byte)num2;
		IL_AE8:
			num2 = 100;
		IL_AEC:
			array[16] = (byte)num2;
		IL_AF6:
			array[16] = 122;
		IL_B06:
			num2 = 44;
		IL_B0A:
			array[17] = (byte)num2;
		IL_B14:
			num2 = 204;
		IL_B21:
			array[17] = (byte)num2;
		IL_B31:
			array[17] = 166;
		IL_B44:
			num2 = 19;
			goto IL_1E9E;
		IL_B5A:
			array[29] = 98;
		IL_B6A:
			num2 = 177;
		IL_B71:
			array[29] = (byte)num2;
		IL_B81:
			array[30] = 111;
		IL_B91:
			array[30] = 142;
			num = 230;
			goto IL_1789;
		IL_BB3:
			if (assemblyPublicKeyToken.Length <= 0) {
				goto IL_C2E;
			}
		IL_BBA:
			array6[1] = assemblyPublicKeyToken[0];
		IL_BC8:
			array6[3] = assemblyPublicKeyToken[1];
		IL_BD6:
			array6[5] = assemblyPublicKeyToken[2];
		IL_BE4:
			array6[7] = assemblyPublicKeyToken[3];
		IL_BF2:
			array6[9] = assemblyPublicKeyToken[4];
		IL_C01:
			array6[11] = assemblyPublicKeyToken[5];
		IL_C10:
			array6[13] = assemblyPublicKeyToken[6];
		IL_C1F:
			array6[15] = assemblyPublicKeyToken[7];
		IL_C2E:
			num16 = 0;
			goto IL_D74;
		IL_C3C:
			num7 += num8;
		IL_C49:
			num10 = (uint)num17;
		IL_C53:
			num9 = (uint)(((int)array3[(int)((UIntPtr)(num10 + 3U))] << 24) | ((int)array3[(int)((UIntPtr)(num10 + 2U))] << 16) | ((int)array3[(int)((UIntPtr)(num10 + 1U))] << 8) | (int)array3[(int)((UIntPtr)num10)]);
		IL_C84:
			num18 = num7;
		IL_C88:
			num7 = 0U;
		IL_C91:
			uint num19 = num18;
			uint num20 = num18;
			num20 ^= num20 >> 13;
			num20 += 268849242U;
			num20 ^= num20 << 5;
			num20 += 2375360433U;
			num20 ^= num20 >> 19;
			num20 += 912001608U;
			num20 = 2127889350U - num20;
			num18 = num19 + (uint)num20;
		IL_CEA:
			num7 = num18;
		IL_CEE:
			if (num11 != num5 - 1)
			{
				goto IL_E9F;
			}

			goto IL_E21;
		IL_D08:
			array[21] = (byte)num2;
		IL_D18:
			array[21] = 87;
		IL_D28:
			array[21] = 253;
			goto IL_100F;
		IL_D5E:
			num16++;
		IL_D74:
			if (num16 < array6.Length) {
				array5[num16] ^= array6[num16];
				goto IL_D5E;
			}
		IL_D82:
			if (stringId != -1) {
				goto IL_30B;
			}
		IL_D89:
			symmetricAlgorithm = Class50.GetPreferredSymmetricAlgorithm();
		IL_D96:
			symmetricAlgorithm.Mode = CipherMode.CBC;
		IL_DA4:
			cryptoTransform = symmetricAlgorithm.CreateDecryptor(array5, array6);
			goto IL_2A4;
		IL_DC1:
			array[20] = 140;
		IL_DCE:
			array[20] = 156;
		IL_DE1:
			num2 = 101;
		IL_DF5:
			array[20] = (byte)num2;
		IL_E05:
			num2 = 181;
			goto IL_F78;
		IL_E21:
			if (num4 <= 0) {
				goto IL_E9F;
			}
		IL_E2C:
			num21 = num7 ^ num9;
		IL_E39:
			num22 = 0;
			goto IL_E91;
		IL_E59:
			num13 <<= 8;
		IL_E5F:
			num14 += 8;
		IL_E6B:
			array4[num17 + num22] = (byte)((num21 & num13) >> num14);
		IL_E85:
			num22++;
		IL_E91:
			if (num22 >= num4)
			{
				goto IL_EFE;
			}
			if (num22 <= 0)
			{
				goto IL_E6B;
			}
			goto IL_E59;
		IL_E9F:
			num23 = num7 ^ num9;
		IL_EA6:
			array4[num17] = (byte)(num23 & 255U);
		IL_EB4:
			array4[num17 + 1] = (byte)((num23 & 65280U) >> 8);
		IL_ECC:
			array4[num17 + 2] = (byte)((num23 & 16711680U) >> 16);
		IL_EE5:
			array4[num17 + 3] = (byte)((num23 & 4278190080U) >> 24);
		IL_EFE:
			num11++;
		IL_F08:
			if (num11 >= num5)
			{
				goto IL_1F9D;
			}
			num12 = num11 % num6;
		IL_F15:
			num17 = num11 * 4;
			goto IL_464;
		IL_F2C:
			array[27] = (byte)num2;
			goto IL_3A1;
		IL_F41:
			num3 = 160;
			goto IL_F8D;
		IL_F4F:
			array[7] = 206;
		IL_F5C:
			num2 = 151;
			num = 327;
			goto IL_1789;
		IL_F78:
			array[20] = (byte)num2;
			goto IL_28B;
		IL_F8D:
			array2[12] = (byte)num3;
		IL_FA5:
			array2[12] = 127;
		IL_FB4:
			num3 = 127;
		IL_FBD:
			array2[12] = (byte)num3;
		IL_FC5:
			array2[12] = 174;
		IL_FD7:
			array2[12] = 31;
		IL_FE6:
			num3 = 59;
		IL_FE9:
			array2[13] = (byte)num3;
		IL_FF7:
			num3 = 101;
			num = 201;
			goto IL_1789;
		IL_100F:
			array[22] = 185;
		IL_1022:
			array[22] = 86;
		IL_102C:
			array[22] = 152;
		IL_1039:
			num2 = 26;
		IL_1043:
			array[22] = (byte)num2;
		IL_1053:
			array[23] = 22;
		IL_1063:
			array[23] = 113;
		IL_1073:
			array[23] = 138;
		IL_1086:
			array[23] = 88;
		IL_1096:
			array[23] = 127;
		IL_10A6:
			array[23] = 124;
		IL_10B6:
			array[24] = 115;
			num = 123;
			goto IL_1789;
		IL_1605:
			array2[8] = (byte)num3;
		IL_1613:
			num3 = 112;
		IL_161C:
			array2[8] = (byte)num3;
		IL_162A:
			array2[8] = 42;
		IL_1639:
			num3 = 244;
		IL_1645:
			array2[8] = (byte)num3;
		IL_164D:
			num3 = 70;
		IL_1650:
			array2[9] = (byte)num3;
		IL_165E:
			array2[9] = 101;
		IL_166D:
			array2[9] = 159;
		IL_167F:
			num3 = 164;
		IL_1685:
			array2[10] = (byte)num3;
		IL_1693:
			num3 = 169;
		IL_169F:
			array2[10] = (byte)num3;
			goto IL_207;
		IL_16B9:
			array[1] = 95;
		IL_16C9:
			num2 = 106;
		IL_16CD:
			array[1] = (byte)num2;
		IL_16DD:
			array[2] = 111;
		IL_16E7:
			num2 = 163;
			goto IL_181;
		IL_174C:
			num3 = 148;
		IL_1758:
			array2[6] = (byte)num3;
		IL_1766:
			array2[6] = 237;
		IL_1778:
			num3 = 197;
			goto IL_20;
		IL_1E10:
			num2 = 62;
			num = 171;
			goto IL_1789;
		IL_1E29:
			array[19] = 138;
			goto IL_1E10;
		IL_1E38:
			array[19] = 176;
			goto IL_1E29;
		IL_1E47:
			array[19] = (byte)num2;
			goto IL_1E38;
		IL_1E53:
			num2 = 124;
			goto IL_1E47;
		IL_1E59:
			array[19] = 95;
			goto IL_1E53;
		IL_1E6B:
			array[19] = 142;
			goto IL_1E59;
		IL_1E80:
			array[18] = (byte)num2;
			goto IL_1E6B;
		IL_1E92:
			num2 = 113;
			goto IL_1E80;
		IL_1E9E:
			array[17] = (byte)num2;
		IL_1EAE:
			array[18] = 94;
		IL_1EBE:
			num2 = 132;
		IL_1ECB:
			array[18] = (byte)num2;
		IL_1ED5:
			num2 = 104;
		IL_1EDF:
			array[18] = (byte)num2;
			goto IL_1E92;
		IL_1EF1:
			array[0] = (byte)num2;
			num = 347;
			goto IL_1789;
		IL_1F0D:
			num2 = 99;
			goto IL_1EF1;
		IL_1F19:
			array = new byte[32];
			goto IL_1F0D;
		IL_1F27:
			BinaryReader binaryReader;
			binaryReader.Close();
			goto IL_1F19;
		IL_1F30:
			array3 = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			goto IL_1F27;
		IL_1F4E:
			binaryReader.BaseStream.Position = 0L;
			goto IL_1F30;
		IL_1F6B:
			Stream fromManifest = Class50.assembly_0.GetManifestResourceStream("fvGvniHlL5t89jCdxt.iXRCkP2b29rLWjHYun");
			binaryReader = new BinaryReader(fromManifest ?? new FileStream("fvGvniHlL5t89jCdxt.iXRCkP2b29rLWjHYun", FileMode.OpenOrCreate));
			goto IL_1F4E;
		IL_1F89:
			if (Class50.byte_3.Length == 0)
			{
				goto IL_1F6B;
			}
			goto IL_1FA4;
		IL_1F9D:
			Class50.byte_3 = array4;
		IL_1FA4:
			int num24 = BitConverter.ToInt32(Class50.byte_3, stringId);
			try {
				return Encoding.Unicode.GetString(Class50.byte_3, stringId + 4, num24);
			}
			catch {}

			return "";
		}

		internal static bool IsOnlyAllowingFIPS() {
			if (!Class50.InitialisedFIPSState) {
				Class50.GetFIPSFromConfig();
				Class50.InitialisedFIPSState = true;
			}

			return Class50.OnlyAllowingFIPS;
		}

		internal static void GetFIPSFromConfig() {
			try {
				Class50.OnlyAllowingFIPS = CryptoConfig.AllowOnlyFipsAlgorithms;
			}
			catch {}
		}

		internal static SymmetricAlgorithm GetPreferredSymmetricAlgorithm() {
			SymmetricAlgorithm symmetricAlgorithm = null;
			if (Class50.IsOnlyAllowingFIPS()) {
				symmetricAlgorithm = new AesCryptoServiceProvider();
			}
			else {
				try {
					symmetricAlgorithm = new RijndaelManaged();
				}
				catch {
					symmetricAlgorithm = (SymmetricAlgorithm)Activator.CreateInstance(
						"System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
						"System.Security.Cryptography.AesCryptoServiceProvider"
					).Unwrap();
				}
			}
			return symmetricAlgorithm;
		}

		private static Assembly assembly_0 = typeof(Class50).Assembly;
		public static byte[] byte_3 = new byte[0];
		private static bool InitialisedFIPSState = false;
		private static bool OnlyAllowingFIPS = false;
	}
}
