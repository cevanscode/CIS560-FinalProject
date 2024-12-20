INSERT TalentCategory(TalentCategoryID)
VALUES (1), (2);
GO

---More implementation - temp table here


DROP TABLE IF EXISTS TempAccountData;
GO

CREATE TABLE TempAccountData(
	UserName NVARCHAR(50) PRIMARY KEY,
	AccountPassword NVARCHAR(100),
	Email NVARCHAR(50),
	FullName NVARCHAR(32),
	Birthday DATETIME2,
	CharacterName NVARCHAR(32),
	CharacterAge INT,
	Health INT,
	XP INT,
	Copper INT
	)

INSERT TempAccountData(UserName,AccountPassword,Email,FullName,Birthday,CharacterName,CharacterAge,Health,XP,Copper)
VALUES
	 (N'esowthcote0', N'lC6*oMFhAIOY', N'esowthcote0@freewebs.com',N'Dru Jacquest',N'1983-12-22',N'Estrellita Sowthcote',N'45',N'6',N'116',N'23'),
 (N'plampl1', N'tF3/*Kr6Ak0RF', N'plampl1@dropbox.com',N'Mordecai Ellor',N'2010-01-01',N'Port Lampl',N'82',N'7',N'170',N'55'),
 (N'aposen2', N'hC5?/0w%hT%', N'aposen2@sciencedirect.com',N'Auria Penwright',N'1991-03-01',N'Alexina Posen',N'70',N'3',N'55',N'74'),
 (N'kberinger3', N'dN3|L/ER41gf@', N'kberinger3@berkeley.edu',N'Benedicta Olivelli',N'2006-09-22',N'Kit Beringer',N'8',N'7',N'61',N'45'),
 (N'pandriolli4', N'rC1_oG\LJ8', N'pandriolli4@t-online.de',N'Erin Giorgiutti',N'1980-03-08',N'Purcell Andriolli',N'64',N'5',N'100',N'54'),
 (N'pwordesworth5', N'aA5+RaaR+T', N'pwordesworth5@howstuffworks.com',N'Stafford Goldstone',N'1999-07-17',N'Pip Wordesworth',N'4',N'3',N'118',N'87'),
 (N'btrask6', N'zN2)87Ye', N'btrask6@ed.gov',N'Remy Chasle',N'1986-01-07',N'Broderic Trask',N'60',N'8',N'128',N'78'),
 (N'ebelchamp7', N'sW3VolU', N'ebelchamp7@cmu.edu',N'Dorian Greenhalgh',N'1996-01-16',N'Estelle Belchamp',N'45',N'8',N'94',N'3'),
 (N'adiamant8', N'yQ5s&r,+', N'adiamant8@wikipedia.org',N'Brook Androletti',N'2006-12-21',N'Alister Diamant',N'83',N'5',N'22',N'62'),
 (N'mtym9', N'bL0BQb9REJg7*', N'mtym9@addthis.com',N'Bendix Shankle',N'2017-01-27',N'Marleah Tym',N'84',N'5',N'37',N'44'),
 (N'tnatona', N'gH6dCcLpgsf', N'tnatona@vistaprint.com',N'Matthieu Buick',N'2006-02-12',N'Torrey Naton',N'69',N'5',N'164',N'94'),
 (N'tkhadirb', N'pI7`GK#7', N'tkhadirb@google.ca',N'Ryun Mityashev',N'1982-03-02',N'Temple Khadir',N'91',N'5',N'151',N'91'),
 (N'rwhitwhamc', N'jU3$gFG>iL)V', N'rwhitwhamc@domainmarket.com',N'Joycelin Spat',N'2018-04-07',N'Rube Whitwham',N'94',N'3',N'127',N'94'),
 (N'jleftridged', N'vK9!Mdhz7#Yfj*s', N'jleftridged@skype.com',N'Thorpe Birtwistle',N'2003-01-14',N'Jess Leftridge',N'86',N'3',N'48',N'95'),
 (N'pschneidare', N'fL1.R#|7Q\', N'pschneidare@usda.gov',N'Bayard Eastam',N'2012-11-14',N'Prisca Schneidar',N'16',N'4',N'166',N'90'),
 (N'dnowellf', N'zN7=s93!', N'dnowellf@elpais.com',N'Nicoli Bamborough',N'2009-03-26',N'Devlin Nowell',N'96',N'3',N'120',N'67'),
 (N'ldalgleishg', N'jO1!YjmBxK!JGZR!', N'ldalgleishg@japanpost.jp',N'Van Joddens',N'2009-08-13',N'Linette Dalgleish',N'15',N'7',N'38',N'99'),
 (N'syakovichh', N'tJ2?Az9m5"2j##s', N'syakovichh@utexas.edu',N'Starr Pugsley',N'2004-03-02',N'Sigismond Yakovich',N'70',N'6',N'65',N'34'),
 (N'jphetheani', N'mA6<Wk,~&N=TX!3', N'jphetheani@people.com.cn',N'Legra Mudle',N'2003-01-08',N'Jareb Phethean',N'69',N'7',N'168',N'67'),
 (N'nkiddyej', N'vP9}>PB%~', N'nkiddyej@cpanel.net',N'Corenda Oluwatoyin',N'2011-02-21',N'Nyssa Kiddye',N'39',N'7',N'72',N'53'),
 (N'ncowdreyk', N'yO1((d{FYJ<AIg', N'ncowdreyk@t.co',N'Ladonna Merrigan',N'2001-10-26',N'Nani Cowdrey',N'64',N'6',N'53',N'4'),
 (N'sbrissendenl', N'hR8{pH%pSlr@G+8', N'sbrissendenl@globo.com',N'Lottie Wasson',N'1996-04-29',N'Sheppard Brissenden',N'81',N'6',N'96',N'33'),
 (N'slewsym', N'hH5<\4!2UF#', N'slewsym@etsy.com',N'Darcy Earsman',N'1981-08-07',N'Skippie Lewsy',N'98',N'3',N'127',N'39'),
 (N'ptannn', N'fR7*.qPd#I|P/', N'ptannn@telegraph.co.uk',N'Nari Larter',N'1990-04-23',N'Phillipe Tann',N'95',N'7',N'95',N'22'),
 (N'bmartinollio', N'hV5.`I{D%t>', N'bmartinollio@nationalgeographic.com',N'Karrie Fitch',N'2000-01-10',N'Barclay Martinolli',N'82',N'7',N'166',N'98'),
 (N'egillicep', N'hJ5?KYVOIGvD,y', N'egillicep@gizmodo.com',N'Tobye Gavan',N'1985-10-16',N'Ethan Gillice',N'79',N'6',N'158',N'88'),
 (N'ekestleq', N'kB1{/M{1e+pJU$V>', N'ekestleq@ovh.net',N'Dominica Volante',N'1994-10-24',N'Early Kestle',N'42',N'4',N'77',N'32'),
 (N'dwardenr', N'qH5@ouh`wW', N'dwardenr@bandcamp.com',N'Hermie Kubek',N'2004-09-18',N'Donnie Warden',N'23',N'6',N'139',N'88'),
 (N'sternes', N'eV4?tYB#', N'sternes@npr.org',N'Giavani Sysland',N'2012-10-27',N'Silvano Terne',N'83',N'7',N'184',N'77'),
 (N'chalwellt', N'iY9?e3GG/K9bN$', N'chalwellt@techcrunch.com',N'Philippa Echallier',N'1984-11-01',N'Carter Halwell',N'4',N'8',N'184',N'5'),
 (N'atrippacku', N'yR6>Uvz\J`sM', N'atrippacku@hc360.com',N'Alfreda Borrie',N'1987-02-18',N'Anthe Trippack',N'95',N'3',N'163',N'6'),
 (N'hdriversv', N'vY8|T1HO|WKt', N'hdriversv@umn.edu',N'Wilek Cashin',N'1994-03-22',N'Heidie Drivers',N'89',N'6',N'52',N'49'),
 (N'sbremmellw', N'uM80M<&8|`<HK', N'sbremmellw@i2i.jp',N'Leah Twohig',N'2017-02-10',N'Sofia Bremmell',N'61',N'3',N'69',N'72'),
 (N'dbantonx', N'lA0_<L9faqZ', N'dbantonx@yellowpages.com',N'Ardis Mannock',N'2004-08-08',N'Deni Banton',N'23',N'8',N'131',N'80'),
 (N'bharrismithy', N'eZ8}|=M$I*x6', N'bharrismithy@opensource.org',N'Kiah Weond',N'1994-06-13',N'Bessy Harrismith',N'78',N'4',N'176',N'45'),
 (N'acicceralez', N'sH3sV83jU8s', N'acicceralez@auda.org.au',N'Bailey Houlworth',N'2017-12-14',N'Alleen Ciccerale',N'99',N'7',N'47',N'97'),
 (N'grawlcliffe10', N'dD9_UVKp4f8T', N'grawlcliffe10@shinystat.com',N'Mareah Denial',N'2005-07-12',N'Galvin Rawlcliffe',N'81',N'5',N'68',N'40'),
 (N'dcarlow11', N'eK39?_N4"9@%', N'dcarlow11@a8.net',N'Early Dowdell',N'1987-02-19',N'Doro Carlow',N'30',N'7',N'149',N'77'),
 (N'eskeffington12', N'mM4"M8Ve<n`_', N'eskeffington12@yandex.ru',N'Sherry Picopp',N'2002-02-13',N'Emmanuel Skeffington',N'72',N'4',N'69',N'2'),
 (N'btuley13', N'yX7.goH+XnY', N'btuley13@twitpic.com',N'Benny Dobney',N'2016-04-08',N'Byram Tuley',N'53',N'8',N'70',N'54'),
 (N'gebden14', N'eH5!!xDOj', N'gebden14@google.de',N'Sean Osgood',N'1996-02-28',N'Gilligan Ebden',N'58',N'5',N'22',N'34'),
 (N'phemshall15', N'iB7,C#vQ4VGVK2tE', N'phemshall15@i2i.jp',N'Tedman Blaine',N'1991-10-15',N'Pier Hemshall',N'97',N'8',N'139',N'81'),
 (N'thunnam16', N'iS2~D{(n3I', N'thunnam16@google.fr',N'Gregory Twopenny',N'1983-12-28',N'Thedric Hunnam',N'46',N'8',N'195',N'73'),
 (N'jaddionisio17', N'jX7.lFKo', N'jaddionisio17@a8.net',N'Kendell Huntress',N'1984-01-02',N'Johny Addionisio',N'25',N'6',N'71',N'68'),
 (N'lshenton18', N'yL5#zU1*U(Z`axY0', N'lshenton18@bloglines.com',N'Malvin Brydone',N'2012-08-18',N'Lyndy Shenton',N'51',N'5',N'147',N'4'),
 (N'sashe19', N'cW8@yG0"l0M', N'sashe19@parallels.com',N'Mara Eliff',N'2004-05-20',N'Salim Ashe',N'27',N'8',N'141',N'29'),
 (N'tchurchman1a', N'mK9>Ab(p', N'tchurchman1a@berkeley.edu',N'Carin Grimsdyke',N'2005-06-24',N'Terri Churchman',N'35',N'3',N'61',N'60'),
 (N'hgurg1b', N'dL4$arUtaqk$W2JR', N'hgurg1b@nature.com',N'Buckie ORourke',N'2009-10-24',N'Harwell Gurg',N'33',N'4',N'67',N'28'),
 (N'astollenwerck1c', N'xT6+_$~6Z', N'astollenwerck1c@aboutads.info',N'Bail Boodle',N'2008-10-06',N'Akim Stollenwerck',N'29',N'3',N'114',N'99'),
 (N'rcarlisso1d', N'nR9f1``oAQy8v|', N'rcarlisso1d@globo.com',N'Gwendolyn Ballinghall',N'1983-01-27',N'Rayshell Carlisso',N'26',N'6',N'90',N'74'),
 (N'cdroghan1e', N'lU3A|>sQkW8', N'cdroghan1e@wunderground.com',N'Roana Defont',N'2008-12-26',N'Cristen Droghan',N'1',N'4',N'89',N'45'),
 (N'yfavill1f', N'pI0~|x)u', N'yfavill1f@webs.com',N'Becki Cavan',N'1983-10-17',N'Ysabel Favill',N'43',N'8',N'113',N'98'),
 (N'nbransom1g', N'oR9|{UjU,u"&', N'nbransom1g@tinyurl.com',N'Sisely Tew',N'1983-07-24',N'Nisse Bransom',N'44',N'6',N'62',N'77'),
 (N'rmcgrae1h', N'mU7|qjgO<', N'rmcgrae1h@hp.com',N'Pete Bengtsen',N'1992-06-16',N'Rick McGrae',N'20',N'4',N'37',N'29'),
 (N'bdrayson1i', N'uE7)fb#sI<gcmf<', N'bdrayson1i@ovh.net',N'Burke Terbruggen',N'2017-08-22',N'Bartolomeo Drayson',N'15',N'6',N'101',N'57'),
 (N'lkingsman1j', N'hK1"~uFr', N'lkingsman1j@taobao.com',N'Robby Cranton',N'1998-06-01',N'Lavena Kingsman',N'67',N'3',N'151',N'22'),
 (N'hceaser1k', N'zF1|C+6bG', N'hceaser1k@creativecommons.org',N'Waly Platts',N'1998-05-12',N'Hunfredo Ceaser',N'83',N'5',N'149',N'97'),
 (N'hsizeland1l', N'gP8},&K#', N'hsizeland1l@bloglines.com',N'Pasquale Grumley',N'2014-08-08',N'Hobard Sizeland',N'16',N'7',N'132',N'37'),
 (N'nmanilo1m', N'yO1*L2>_/0Ef', N'nmanilo1m@yellowpages.com',N'Michelle Frosch',N'1996-10-27',N'Nefen Manilo',N'46',N'3',N'17',N'98'),
 (N'mpeete1n', N'uI2$AlYwQSI\~tk', N'mpeete1n@cnet.com',N'Burty Abden',N'2007-07-24',N'Marylinda Peete',N'76',N'7',N'19',N'1'),
 (N'tatty1o', N'yS6(1*gjGJ', N'tatty1o@geocities.jp',N'Vinita Pepon',N'2017-10-17',N'Tonie Atty',N'57',N'7',N'159',N'64'),
 (N'bboustred1p', N'fT2%B5"?Jn', N'bboustred1p@hp.com',N'Fransisco Jencey',N'2012-05-16',N'Brinna Boustred',N'77',N'8',N'68',N'19'),
 (N'ltonbye1q', N'gT9$1x2kmBt@S(3', N'ltonbye1q@yahoo.co.jp',N'Dominic Tytcomb',N'2003-06-10',N'Lilith Tonbye',N'5',N'6',N'41',N'61'),
 (N'bpavlenkov1r', N'nZ0"AA@,vR8<', N'bpavlenkov1r@uol.com.br',N'Roley Grotty',N'2010-12-20',N'Bertie Pavlenkov',N'5',N'4',N'80',N'31'),
 (N'hshaughnessy1s', N'zQ1`d3T_|}Ig', N'hshaughnessy1s@imgur.com',N'Dodie Cappel',N'2012-11-07',N'Hetty Shaughnessy',N'45',N'7',N'76',N'42'),
 (N'kjiranek1t', N'bH6{m(!F#w8lC', N'kjiranek1t@github.com',N'Kacy OKynsillaghe',N'2010-08-28',N'Karel Jiranek',N'26',N'7',N'74',N'5'),
 (N'mguillotin1u', N'lL63dC7XsMK', N'mguillotin1u@symantec.com',N'Chryste Gosker',N'1991-12-29',N'Minerva Guillotin',N'59',N'4',N'178',N'82'),
 (N'ovasilkov1v', N'lU41eKRPhb5z%Bw', N'ovasilkov1v@jiathis.com',N'Milty Cousen',N'1998-02-04',N'Oliviero Vasilkov',N'36',N'8',N'73',N'6'),
 (N'sraeside1w', N'mE2AnB9,#}7|e', N'sraeside1w@geocities.jp',N'Izaak Ahren',N'1996-05-28',N'Sayers Raeside',N'99',N'6',N'165',N'99'),
 (N'moduggan1x', N'uD3`CFp*u', N'moduggan1x@prnewswire.com',N'Kaleena Aleksandrov',N'1986-04-20',N'Marilee ODuggan',N'69',N'3',N'155',N'59'),
 (N'klouthe1y', N'iY0,j~Za)hZQm', N'klouthe1y@prweb.com',N'Rafaelita Ottley',N'2001-12-06',N'Kassandra Louthe',N'2',N'6',N'133',N'2'),
 (N'jdemeza1z', N'wS5.6l$J', N'jdemeza1z@wordpress.org',N'Karoly Deeble',N'2011-06-25',N'Jannel Demeza',N'40',N'5',N'109',N'38'),
 (N'fknewstub20', N'fK7#jaDM>svnua`f', N'fknewstub20@live.com',N'Dari Bysshe',N'2007-11-26',N'Field Knewstub',N'44',N'3',N'69',N'9'),
 (N'njoliffe21', N'dH7{HUs"', N'njoliffe21@lulu.com',N'Maggi Bolingbroke',N'1999-02-03',N'Norton Joliffe',N'35',N'3',N'30',N'53'),
 (N'mskillicorn22', N'vP1@m}2t%uG', N'mskillicorn22@unblog.fr',N'Maribeth Crimin',N'1981-08-26',N'Marshall Skillicorn',N'76',N'4',N'42',N'23'),
 (N'mbrentnall23', N'zU3,>U>nmm', N'mbrentnall23@cbsnews.com',N'Mort Bexon',N'2001-06-17',N'Maribeth Brentnall',N'63',N'3',N'138',N'73'),
 (N'dhendrich24', N'eM1$W8l7eO@9z8', N'dhendrich24@rakuten.co.jp',N'Sharyl Somerfield',N'1985-01-18',N'Dolores Hendrich',N'2',N'5',N'68',N'88'),
 (N'fmerkel25', N'iR9.a.O7|.', N'fmerkel25@chronoengine.com',N'Viviyan Hawton',N'2012-09-07',N'Flor Merkel',N'4',N'7',N'115',N'85'),
 (N'pde26', N'jX3*6cA4bum=,M', N'pde26@ezinearticles.com',N'Conan Mitie',N'1997-01-25',N'Padraic De Cristoforo',N'58',N'7',N'125',N'86'),
 (N'afrise27', N'vG0~32EW', N'afrise27@youku.com',N'Scarface Crosgrove',N'1996-11-09',N'Aloise Frise',N'41',N'4',N'197',N'95'),
 (N'fnoor28', N'dB5%.{72N', N'fnoor28@techcrunch.com',N'Morgen Drew',N'2004-09-11',N'Fancy Noor',N'19',N'8',N'65',N'82'),
 (N'gfelmingham29', N'wS7+Qi#kkmG', N'gfelmingham29@123-reg.co.uk',N'Rudyard Segge',N'1980-04-11',N'Garik Felmingham',N'82',N'6',N'71',N'76'),
 (N'selmhurst2a', N'rB5$7k8+RT', N'selmhurst2a@theguardian.com',N'Arabella Ainley',N'1987-07-31',N'Salvatore Elmhurst',N'28',N'3',N'135',N'93'),
 (N'bcassie2b', N'kE3*OK,G', N'bcassie2b@chicagotribune.com',N'Kile Gauntley',N'2001-01-30',N'Barbaraanne Cassie',N'93',N'5',N'156',N'86'),
 (N'mlaux2c', N'zW7}Y`EdBwO3', N'mlaux2c@qq.com',N'Mia Methingam',N'1987-04-25',N'Mignon Laux',N'24',N'3',N'116',N'81'),
 (N'jblaber2d', N'pL3@z%!YL#', N'jblaber2d@indiatimes.com',N'Natalya Westhead',N'2006-04-17',N'Jamie Blaber',N'56',N'3',N'160',N'3'),
 (N'landresser2e', N'oN0!k|"=tY\', N'landresser2e@friendfeed.com',N'Chrissy Attarge',N'1994-12-21',N'Lennard Andresser',N'3',N'5',N'106',N'27'),
 (N'ugodsell2f', N'cI4.Fk<,', N'ugodsell2f@multiply.com',N'Bud Langstrath',N'1984-09-21',N'Ulrich Godsell',N'96',N'4',N'74',N'50'),
 (N'fbrisco2g', N'cX7#QJjd', N'fbrisco2g@boston.com',N'Abbott Musico',N'1993-09-15',N'Francklyn Brisco',N'32',N'3',N'129',N'92'),
 (N'lelby2h', N'wD1&$B2<@APCbg|,', N'lelby2h@dell.com',N'Josias Graysmark',N'2013-12-12',N'Laetitia Elby',N'84',N'3',N'106',N'61'),
 (N'nsoeiro2i', N'xF1||$U8', N'nsoeiro2i@wunderground.com',N'Kala Legen',N'1988-09-19',N'Nertie Soeiro',N'75',N'4',N'34',N'43'),
 (N'cchrstine2j', N'gH5=J_O#s', N'cchrstine2j@hp.com',N'Juanita Dearth',N'2007-12-15',N'Corabella Chrstine',N'85',N'5',N'98',N'3'),
 (N'ikitchingman2k', N'aZ3"l{2', N'ikitchingman2k@epa.gov',N'Celka Piser',N'2012-09-13',N'Ingrid Kitchingman',N'27',N'8',N'108',N'79'),
 (N'rtrayte2l', N'lB8_McgZU', N'rtrayte2l@symantec.com',N'Bidget Buttery',N'1992-12-27',N'Randee Trayte',N'87',N'3',N'147',N'97'),
 (N'gelverston2m', N'xD0!uI{+nI2', N'gelverston2m@flickr.com',N'Opaline Fenne',N'1986-03-05',N'Gabe Elverston',N'25',N'7',N'104',N'31'),
 (N'cmushawe2n', N'cX5*ZON.', N'cmushawe2n@flavors.me',N'Cortney Eddleston',N'2015-08-11',N'Caro Mushawe',N'30',N'8',N'169',N'97'),
 (N'lgronow2o', N'bX4_dm,uXZYH2Am', N'lgronow2o@upenn.edu',N'Lotte Haythorne',N'1981-07-24',N'Lyssa Gronow',N'82',N'4',N'193',N'1'),
 (N'zbitterton2p', N'mL3\UgMd', N'zbitterton2p@dropbox.com',N'Angelita Dowsey',N'1990-11-15',N'Zahara Bitterton',N'21',N'4',N'86',N'1'),
 (N'ecuningham2q', N'uV2$PE$,c', N'ecuningham2q@weebly.com',N'Putnem Locock',N'1990-12-02',N'Elli Cuningham',N'71',N'4',N'170',N'66'),
 (N'dmattusov2r', N'rW5*r(rPm', N'dmattusov2r@adobe.com',N'Barbabra Chell',N'2005-06-05',N'Dur Mattusov',N'36',N'5',N'157',N'46'),
 (N'rpreedy2s', N'iL4&trCbg@21', N'rpreedy2s@squarespace.com',N'Jodee Brosini',N'1998-04-14',N'Richardo Preedy',N'54',N'8',N'139',N'12'),
 (N'rbooi2t', N'wH7$97J_?|', N'rbooi2t@rambler.ru',N'Meridel Linthead',N'2017-10-03',N'Rodie Booi',N'90',N'6',N'158',N'58'),
 (N'mcohalan2u', N'gN4No8EI`h', N'mcohalan2u@people.com.cn',N'Lucky Delacourt',N'1983-02-16',N'Mandie Cohalan',N'19',N'6',N'195',N'99'),
 (N'rmaddern2v', N'tR9|)hE=8pS', N'rmaddern2v@msu.edu',N'Caryn Frail',N'1981-02-08',N'Rudolf Maddern',N'28',N'5',N'82',N'29'),
 (N'slynd2w', N'eQ8~i"sl7rg9M', N'slynd2w@soundcloud.com',N'Zsazsa Hanniger',N'1988-04-15',N'Shaughn Lynd',N'20',N'3',N'169',N'30'),
 (N'aroyce2x', N'uK8{(GKL', N'aroyce2x@sakura.ne.jp',N'Daveen Kemm',N'1987-10-28',N'Ashil Royce',N'81',N'6',N'163',N'72'),
 (N'dlanigan2y', N'sG3!UKx8Kh`c$cR', N'dlanigan2y@topsy.com',N'Anton Seebright',N'2009-08-09',N'Drusilla Lanigan',N'23',N'7',N'145',N'16'),
 (N'jaxelby2z', N'xQ3|6=Pln)U', N'jaxelby2z@simplemachines.org',N'Adrienne July',N'1995-04-17',N'Janot Axelby',N'12',N'4',N'44',N'87'),
 (N'afreeth30', N'lW2+%ymA9', N'afreeth30@pinterest.com',N'Braden Rochell',N'2007-01-07',N'Agnese Freeth',N'58',N'7',N'161',N'70'),
 (N'wlinzee31', N'kR1}Zcv00G', N'wlinzee31@irs.gov',N'Bevon Flobert',N'1997-05-02',N'Wallace Linzee',N'74',N'7',N'21',N'53'),
 (N'llarmouth32', N'tZ1}KDDMOAJ', N'llarmouth32@blogger.com',N'Oby Beston',N'2003-06-29',N'Lanna Larmouth',N'71',N'5',N'124',N'92'),
 (N'dmurkus33', N'qF4!gWz|3kNn6TA', N'dmurkus33@sciencedaily.com',N'Rois Cornfield',N'1994-07-27',N'Darnell Murkus',N'27',N'5',N'197',N'48'),
 (N'lculp34', N'zO2&gdidRf99', N'lculp34@msn.com',N'Gordon Garrould',N'1983-03-15',N'Lauren Culp',N'12',N'7',N'90',N'50'),
 (N'amuffitt35', N'hD5~0MZasF', N'amuffitt35@mac.com',N'Carmine Fulker',N'2001-05-24',N'Art Muffitt',N'56',N'8',N'93',N'2'),
 (N'ladamski36', N'hJ0@ORg4oD_~gVlt', N'ladamski36@businessweek.com',N'Quintus Rawet',N'2013-03-03',N'Lou Adamski',N'32',N'7',N'110',N'1'),
 (N'aceeley37', N'gI6.V\9VGqmuAb_', N'aceeley37@acquirethisname.com',N'Celesta Venditti',N'1983-03-21',N'Alric Ceeley',N'34',N'5',N'29',N'36'),
 (N'negdell38', N'uT0_y?E/rb*M', N'negdell38@gov.uk',N'Tracie Cord',N'1985-10-18',N'Nanci Egdell',N'24',N'4',N'73',N'52'),
 (N'srooms39', N'sV7|/=W_F@b{', N'srooms39@studiopress.com',N'Townsend Howitt',N'2002-08-26',N'Seline Rooms',N'40',N'6',N'87',N'96'),
 (N'abecraft3a', N'zQ7@n|zm`t+i*', N'abecraft3a@php.net',N'Justinn Kleuer',N'2017-01-16',N'Adrea Becraft',N'21',N'7',N'84',N'49'),
 (N'akruse3b', N'fH7=Bn5Y!18I', N'akruse3b@rediff.com',N'Bobby Ewbach',N'2001-10-10',N'Alexi Kruse',N'69',N'5',N'85',N'28'),
 (N'chardaker3c', N'sR5&k#p=p8f', N'chardaker3c@harvard.edu',N'Teddy Hanselmann',N'1982-06-27',N'Catrina Hardaker',N'82',N'4',N'106',N'90'),
 (N'ytetla3d', N'tS6~bpg<HYD', N'ytetla3d@dailymotion.com',N'Knox Chesser',N'1992-12-12',N'Yehudi Tetla',N'49',N'7',N'83',N'2'),
 (N'jhartright3e', N'iR2$6stn', N'jhartright3e@webnode.com',N'Eleonore Govan',N'1980-10-06',N'Jeanette Hartright',N'23',N'8',N'53',N'26'),
 (N'jshurrocks3f', N'yJ3+{ZnC', N'jshurrocks3f@stumbleupon.com',N'Joli Mc Faul',N'1985-11-17',N'Josey Shurrocks',N'17',N'6',N'158',N'55'),
 (N'mmatteoli3g', N'sW0%pxgz#CDhG.', N'mmatteoli3g@psu.edu',N'Ermina Vondra',N'2000-03-28',N'Maryanna Matteoli',N'77',N'4',N'22',N'4'),
 (N'bfitzroy3h', N'jD9+y!b+P', N'bfitzroy3h@barnesandnoble.com',N'Balduin Byrde',N'2011-06-27',N'Bell Fitzroy',N'6',N'7',N'76',N'85'),
 (N'abrandenburg3i', N'fG5?4"RrC', N'abrandenburg3i@usda.gov',N'Ban Gates',N'1980-11-29',N'Adella Brandenburg',N'18',N'6',N'106',N'97'),
 (N'bheritege3j', N'pE8}Nva9B5n|}Rpg', N'bheritege3j@boston.com',N'Allayne Forestall',N'2017-11-05',N'Burk Heritege',N'12',N'3',N'186',N'36'),
 (N'dgianolo3k', N'aS9@wO$5~I', N'dgianolo3k@ucsd.edu',N'Kaleena Gelderd',N'1993-05-26',N'Dermot Gianolo',N'30',N'4',N'187',N'91'),
 (N'pbaptie3l', N'yF2{hH/erEE', N'pbaptie3l@naver.com',N'Calida Heersma',N'1984-04-25',N'Paddie Baptie',N'17',N'8',N'168',N'55'),
 (N'tbromley3m', N'fU3\voQG{{=4v', N'tbromley3m@com.com',N'Fergus Cesconi',N'1992-03-18',N'Trisha Bromley',N'94',N'4',N'94',N'31'),
 (N'dsycamore3n', N'dM2"spD3>ET', N'dsycamore3n@washington.edu',N'Ty Budcock',N'1998-11-26',N'Dione Sycamore',N'83',N'8',N'128',N'79'),
 (N'hmimmack3o', N'fK3\#23l1iZ', N'hmimmack3o@uol.com.br',N'Melisandra Giddy',N'2012-05-10',N'Henderson Mimmack',N'95',N'7',N'132',N'74'),
 (N'lmcian3p', N'aB9"+<nJ', N'lmcian3p@surveymonkey.com',N'Carlin Everil',N'1995-03-27',N'Lazar McIan',N'78',N'8',N'41',N'71'),
 (N'eokennedy3q', N'fK1`,x`y', N'eokennedy3q@rambler.ru',N'Rita Simek',N'1989-04-03',N'Eal OKennedy',N'35',N'8',N'140',N'32'),
 (N'cstarr3r', N'tL7Xr"KVE&6d', N'cstarr3r@nsw.gov.au',N'Jaquenette Conring',N'2003-10-25',N'Caro Starr',N'30',N'5',N'70',N'48'),
 (N'eewen3s', N'xY4c%ZcJn8`1N', N'eewen3s@lycos.com',N'Steve Domenichelli',N'2002-10-06',N'Ertha Ewen',N'38',N'4',N'101',N'28'),
 (N'kpardey3t', N'wL2Kt=!j&.y', N'kpardey3t@lycos.com',N'Shane Tinmouth',N'1990-03-11',N'Kristin Pardey',N'15',N'5',N'78',N'62'),
 (N'chilldrop3u', N'yK2"LR)ZJ?!&+m', N'chilldrop3u@1und1.de',N'Whittaker Kelleway',N'2008-02-24',N'Casey Hilldrop',N'50',N'3',N'47',N'27'),
 (N'sjammet3v', N'hX7?TM$R8&KzAuRX', N'sjammet3v@blogger.com',N'Samuele Maleck',N'1982-02-15',N'Shantee Jammet',N'66',N'4',N'41',N'4'),
 (N'trollins3w', N'uP3+h2%JZ{gB', N'trollins3w@ft.com',N'Wynne Karchowski',N'1999-07-23',N'Tami Rollins',N'42',N'6',N'57',N'43'),
 (N'dantushev3x', N'sI3$Y)kR{z7Y{I', N'dantushev3x@purevolume.com',N'Lemmie Allwell',N'2018-07-06',N'Dame Antushev',N'59',N'5',N'175',N'96'),
 (N'jcann3y', N'cU8+{x\0', N'jcann3y@wunderground.com',N'Heddi Gowry',N'1994-04-22',N'Jorge Cann',N'33',N'5',N'178',N'75'),
 (N'ggalero3z', N'gA1{#4g5sNi', N'ggalero3z@shinystat.com',N'Rafferty Issard',N'2006-01-11',N'Gaye Galero',N'42',N'6',N'182',N'98'),
 (N'cbremner40', N'dI5`L<=5|~J"#r%', N'cbremner40@google.cn',N'Jenda Inman',N'1988-12-30',N'Chadwick Bremner',N'28',N'7',N'79',N'14'),
 (N'asellack41', N'oG6_l"YJEHVu*', N'asellack41@biglobe.ne.jp',N'Jimmy Druitt',N'1985-08-11',N'Aimee Sellack',N'60',N'3',N'188',N'92'),
 (N'blafay42', N'gF2)\}_%Yq', N'blafay42@scientificamerican.com',N'Niki Junifer',N'1986-06-07',N'Barr Lafay',N'34',N'6',N'161',N'30'),
 (N'afinlan43', N'bM4(E>3CiA6', N'afinlan43@webnode.com',N'Theda Comar',N'1994-10-21',N'Andriana Finlan',N'95',N'7',N'157',N'45'),
 (N'staig44', N'mX6.0E}6i?U$jS)1', N'staig44@msu.edu',N'Jammie Doog',N'1999-12-11',N'Stephan Taig',N'67',N'6',N'63',N'51'),
 (N'srabat45', N'aU4|s..Y?HP', N'srabat45@salon.com',N'Roberta Van der Linde',N'1993-08-21',N'Shana Rabat',N'31',N'4',N'160',N'44'),
 (N'inelson46', N'kE0(E#zhJ', N'inelson46@csmonitor.com',N'Frants Dicken',N'1999-12-10',N'Ingaberg Nelson',N'7',N'6',N'25',N'15'),
 (N'mshutler47', N'xT4|*Oz?', N'mshutler47@nps.gov',N'Arturo MacParland',N'1988-03-16',N'Marlena Shutler',N'8',N'6',N'97',N'87'),
 (N'dlemasney48', N'mK4>%g.+`jo/', N'dlemasney48@storify.com',N'Ertha Sidgwick',N'2016-05-24',N'Davon Lemasney',N'86',N'4',N'179',N'21'),
 (N'jbeardon49', N'cM5)7wF,', N'jbeardon49@people.com.cn',N'Webster Sinden',N'1999-03-22',N'Jennica Beardon',N'6',N'7',N'150',N'73'),
 (N'ndines4a', N'gH4`#/aL`lV', N'ndines4a@google.it',N'Eberto Mallalieu',N'1984-10-27',N'Ninette Dines',N'77',N'5',N'166',N'35'),
 (N'mcompson4b', N'rT8"{~vmnkx', N'mcompson4b@tonline.de',N'Kaila Bettenson',N'1991-02-10',N'Marianne Compson',N'56',N'5',N'192',N'10'),
 (N'arosbrough4c', N'vM2$Hb"+"px,', N'arosbrough4c@hexun.com',N'Kitti Rathke',N'2016-10-06',N'Adolphe Rosbrough',N'85',N'7',N'64',N'7'),
 (N'jlidgertwood4d', N'aJ6?e$4Ev1', N'jlidgertwood4d@amazonaws.com',N'Winny Southern',N'1989-10-17',N'Jess Lidgertwood',N'82',N'5',N'112',N'12'),
 (N'cbulfield4e', N'pW3~sjA}NUJ', N'cbulfield4e@phpbb.com',N'Merell Board',N'2010-07-16',N'Cris Bulfield',N'79',N'6',N'73',N'99'),
 (N'yiacopo4f', N'vO8@3X}d1*u(v|eO', N'yiacopo4f@slate.com',N'Halie Brimacombe',N'2017-04-16',N'Yulma Iacopo',N'37',N'3',N'138',N'14'),
 (N'nbuchett4g', N'tU7{*HnD7nU', N'nbuchett4g@columbia.edu',N'Maurise Izsak',N'2004-12-20',N'Nataniel Buchett',N'99',N'6',N'172',N'98'),
 (N'plampe4h', N'oU0$COVp_mZSQre', N'plampe4h@cam.ac.uk',N'Aleece Ebbing',N'1982-02-03',N'Philomena Lampe',N'72',N'3',N'94',N'58'),
 (N'dsacco4i', N'zT1*RdMO>ZR,p,', N'dsacco4i@yolasite.com',N'Dodie Sykora',N'2014-01-21',N'Deidre Sacco',N'31',N'7',N'78',N'49'),
 (N'lscarlett4j', N'qO5_&UY<!_d<(v/g', N'lscarlett4j@bloglines.com',N'Annecorinne Selway',N'2015-09-07',N'Lenard Scarlett',N'71',N'8',N'55',N'95'),
 (N'ekenset4k', N'bR9<~/q8F(', N'ekenset4k@shinystat.com',N'Brockie Challinor',N'2013-01-23',N'Elena Kenset',N'64',N'7',N'48',N'24'),
 (N'varundel4l', N'jA0>xkYB/V5L', N'varundel4l@japanpost.jp',N'Sutherland Backler',N'1986-04-15',N'Vin Arundel',N'20',N'8',N'21',N'85'),
 (N'afaichnie4m', N'eD7.J>PU', N'afaichnie4m@tripadvisor.com',N'Alexine Riceards',N'1981-03-22',N'Aymer Faichnie',N'19',N'6',N'196',N'76'),
 (N'ahoyer4n', N'nA5@,4}2', N'ahoyer4n@nsw.gov.au',N'Felicdad Gallichan',N'1984-04-23',N'Alana Hoyer',N'19',N'7',N'188',N'98'),
 (N'larrundale4o', N'aS6/ioQYgKPcH', N'larrundale4o@china.com.cn',N'Jacinta Dimitrijevic',N'2013-06-08',N'Lizette Arrundale',N'100',N'3',N'47',N'82'),
 (N'gdalrymple4p', N'kI1/s_stN', N'gdalrymple4p@ucla.edu',N'Adelaide Allbones',N'2016-10-09',N'Georas Dalrymple',N'7',N'5',N'70',N'31'),
 (N'mbusch4q', N'aL9.,@Nv?ZMc\', N'mbusch4q@seattletimes.com',N'Sheelah Carruthers',N'1982-02-17',N'Morlee Busch',N'17',N'3',N'169',N'58'),
 (N'achurchard4r', N'xE9`P"YB6', N'achurchard4r@prlog.org',N'Conchita Snarr',N'2004-02-07',N'Antonella Churchard',N'12',N'4',N'45',N'80'),
 (N'msiemon4s', N'bB6$8"UhzW', N'msiemon4s@amazon.co.jp',N'Valentin Maseyk',N'1998-02-08',N'Morly Siemon',N'14',N'7',N'89',N'33'),
 (N'xleyre4t', N'iO479Mbe', N'xleyre4t@wikia.com',N'Sherri Divill',N'1991-03-18',N'Xever Leyre',N'95',N'6',N'137',N'66'),
 (N'djennions4u', N'yL2#}wS<', N'djennions4u@dailymail.co.uk',N'Christiane Coda',N'1998-10-22',N'Domingo Jennions',N'22',N'6',N'21',N'88'),
 (N'pdubber4v', N'vS9%9l7l', N'pdubber4v@google.ca',N'Jaquelin Kleiser',N'2002-09-19',N'Phebe Dubber',N'18',N'4',N'15',N'85'),
 (N'jyounglove4w', N'uV0)uWy1dEgrX', N'jyounglove4w@intel.com',N'Welch Munsey',N'1981-08-01',N'Janelle Younglove',N'91',N'6',N'193',N'78'),
 (N'ebalmforth4x', N'sQ5$~@>PA.Oq8!K', N'ebalmforth4x@odnoklassniki.ru',N'Gerardo Davidek',N'2006-12-30',N'Ellswerth Balmforth',N'33',N'5',N'143',N'60'),
 (N'sboston4y', N'vJ3+$k_aYccD?jt', N'sboston4y@noaa.gov',N'Guinevere Cuardall',N'1984-01-06',N'Skye Boston',N'2',N'3',N'127',N'23'),
 (N'wmcconnulty4z', N'xN5?u"lXw<', N'wmcconnulty4z@yolasite.com',N'Darci Rodolico',N'1988-03-13',N'Westley McConnulty',N'33',N'8',N'76',N'22'),
 (N'nleaver50', N'vB3@Y+."lDo', N'nleaver50@timesonline.co.uk',N'Whitaker Hackney',N'1984-09-24',N'Nolly Leaver',N'11',N'6',N'56',N'81'),
 (N'dtailour51', N'mI7&W0GSn', N'dtailour51@lulu.com',N'Ogdon Fontin',N'2007-01-06',N'Devy Tailour',N'8',N'5',N'139',N'54'),
 (N'kobey52', N'uO6$9tOWIB0S}', N'kobey52@sina.com.cn',N'Willabella Dominique',N'2000-01-22',N'Kamila Obey',N'6',N'8',N'70',N'7'),
 (N'bchurching53', N'bY6!XD8ooGLu', N'bchurching53@europa.eu',N'Marielle Schirak',N'1994-03-18',N'Brockie Churching',N'96',N'3',N'109',N'56'),
 (N'tcollins54', N'gI1+U=d&<x/owui', N'tcollins54@technorati.com',N'Dame Klimke',N'1989-06-07',N'Therine Collins',N'4',N'4',N'127',N'38'),
 (N'lcockerell55', N'rQ7{6O3s,', N'lcockerell55@tripadvisor.com',N'Larina Dunseith',N'2007-08-05',N'Lark Cockerell',N'84',N'8',N'163',N'86'),
 (N'lfalco56', N'vA2+q{.Y7UT', N'lfalco56@wikia.com',N'Fleming James',N'1988-03-15',N'Lorne Falco',N'44',N'6',N'174',N'46'),
 (N'kmohammad57', N'jL6"S%WiU', N'kmohammad57@yandex.ru',N'Leontine Orniz',N'1990-01-18',N'Kalila Mohammad',N'7',N'3',N'62',N'50'),
 (N'sallner58', N'eN7@SO2Zf?s<Oa', N'sallner58@usgs.gov',N'Adrienne Ovize',N'1994-03-18',N'Saunder Allner',N'81',N'6',N'90',N'45'),
 (N'ecobbing59', N'zQ8/\LM44ff{UI', N'ecobbing59@nymag.com',N'Lelah Andrieux',N'1996-06-06',N'Evangelin Cobbing',N'45',N'7',N'170',N'13'),
 (N'aedmeades5a', N'hV0.7NaUWphy7k', N'aedmeades5a@nbcnews.com',N'Bar Northwood',N'2010-06-10',N'Anthony Edmeades',N'41',N'4',N'146',N'67'),
 (N'ccleyburn5b', N'rJ5>!>6)2h8p\7', N'ccleyburn5b@china.com.cn',N'Cecilius Chong',N'1994-01-26',N'Cody Cleyburn',N'23',N'3',N'100',N'64'),
 (N'fjobb5c', N'bC0~?v7hh0NXb9', N'fjobb5c@unesco.org',N'Lilllie Eland',N'2012-12-04',N'Fabien Jobb',N'79',N'8',N'30',N'32'),
 (N'amatteuzzi5d', N'rF1_Rpo+Q', N'amatteuzzi5d@discuz.net',N'Kate Rushbrook',N'2007-09-25',N'Alanna Matteuzzi',N'81',N'6',N'95',N'68'),
 (N'ptipple5e', N'jY9/&+*=9S%se', N'ptipple5e@sohu.com',N'Karly Ardron',N'1984-03-27',N'Paxon Tipple',N'8',N'6',N'131',N'27'),
 (N'jla5f', N'zF1`+e4C4_I~4XB', N'jla5f@sun.com',N'Claudius McCunn',N'1989-03-08',N'Joete La Torre',N'62',N'8',N'190',N'66'),
 (N'sisley5g', N'bS1#Mj}RMJ@$6', N'sisley5g@soundcloud.com',N'Livvyy Froude',N'2015-10-23',N'Shandy Isley',N'68',N'5',N'104',N'3'),
 (N'omears5h', N'bQ0/6q0Uv(4A<', N'omears5h@vinaora.com',N'Nevsa Duinkerk',N'2013-08-06',N'Olenka Mears',N'64',N'4',N'197',N'82'),
 (N'sbristow5i', N'uV9/?Tev\5', N'sbristow5i@barnesandnoble.com',N'Jemimah Lecointe',N'2002-11-29',N'Sergeant Bristow',N'47',N'8',N'58',N'50'),
 (N'emckeefry5j', N'lY9{o6?\Y', N'emckeefry5j@angelfire.com',N'Carie Burling',N'2006-09-22',N'Eleonora McKeefry',N'75',N'3',N'138',N'82');
 GO

 INSERT Accounts(UserName,AccountPassword,Email,FullName,Birthday)
 VALUES (N'Admin', N'generalAdminPassword',N'admin@ksu.edu',N'Sisyphus Administrator', N'1999-01-10');
 GO



 INSERT Accounts(UserName,AccountPassword,Email,FullName,Birthday)
 SELECT T.UserName,T.AccountPassword,T.Email,T.FullName,T.Birthday
 FROM TempAccountData T;
 GO



 INSERT [Character](CharacterName,CharacterAge,AccountID,Health,XP,Copper)
 SELECT T.CharacterName,T.CharacterAge,A.AccountID,T.Health,T.XP,T.Copper
 FROM TempAccountData T INNER JOIN Accounts A ON A.UserName = T.UserName;
 GO

SELECT * FROM Accounts A INNER JOIN [Character] C ON A.AccountID = C.AccountID; 
GO


DROP TABLE IF EXISTS TempClassData;
GO


CREATE TABLE TempClassData(
	SubclassName NVARCHAR(30), 
	SubclassDescription NVARCHAR(1000),
	ClassName NVARCHAR(30), 
	ClassDescription NVARCHAR(1000),
)

INSERT TempClassData(SubclassName, SubclassDescription, ClassName, ClassDescription)
VALUES
	 (N'BaseClassless', N'Accessible for anyone', N'Classless', N'Accessible for anyone'),
 	(N'BaseCleric', N'Clerics have control of Interplanary powers, which they use to heal and protect themselves and others. They can further support their team by crafting elixirs to aid them in various situations. As interplanary powers are a form of magic, Clerics can also enchant gems and scrolls. A clerics role on the battlefield is to heal, revive, or protect their allies. Clerics have the ability to become tanky Paladins or supportive Soothsayers.', N'Cleric', N'Clerics have control of Interplanary powers, which they use to heal and protect themselves and others. They can further support their team by crafting elixirs to aid them in various situations. As interplanary powers are a form of magic, Clerics can also enchant gems and scrolls. A clerics role on the battlefield is to heal, revive, or protect their allies. Clerics have the ability to become tanky Paladins or supportive Soothsayers.'),
 	(N'SoothSayer', N'Ultimate Healer Guy', N'Cleric', N'Clerics have control of Interplanary powers, which they use to heal and protect themselves and others. They can further support their team by crafting elixirs to aid them in various situations. As interplanary powers are a form of magic, Clerics can also enchant gems and scrolls. A clerics role on the battlefield is to heal, revive, or protect their allies. Clerics have the ability to become tanky Paladins or supportive Soothsayers.'),
 	(N'Paladin', N'Ultimate Tanky Guy', N' Cleric', N'Clerics have control of Interplanary powers, which they use to heal and protect themselves and others. They can further support their team by crafting elixirs to aid them in various situations. As interplanary powers are a form of magic, Clerics can also enchant gems and scrolls. A clerics role on the battlefield is to heal, revive, or protect their allies. Clerics have the ability to become tanky Paladins or supportive Soothsayers.'),
 	(N'BaseNoble', N'Nobles are negotiators, leaders, and tacticians. Far from the lofty, arrogant, braggart stereotype, these Nobles usually have pockets and minds that are deeper than they let on. In-game, Nobles have a small town to manage that gives them a variety of resources to utilize. While useful in a battle, much of a Nobles power comes from their connections with powerful people. During combat, they control the flow of battle, supporting their allies with their tactical awareness. This is accomplished either on the front lines as a Knight or by directing the fight as a Lord.', N'Noble', N'Nobles are negotiators, leaders, and tacticians. Far from the lofty, arrogant, braggart stereotype, these Nobles usually have pockets and minds that are deeper than they let on. In-game, Nobles have a small town to manage that gives them a variety of resources to utilize. While useful in a battle, much of a Nobles power comes from their connections with powerful people. During combat, they control the flow of battle, supporting their allies with their tactical awareness. This is accomplished either on the front lines as a Knight or by directing the fight as a Lord.'),
 	(N'Knight', N'The Heck is a Knight Team?!', N'Noble', N'Nobles are negotiators, leaders, and tacticians. Far from the lofty, arrogant, braggart stereotype, these Nobles usually have pockets and minds that are deeper than they let on. In-game, Nobles have a small town to manage that gives them a variety of resources to utilize. While useful in a battle, much of a Nobles power comes from their connections with powerful people. During combat, they control the flow of battle, supporting their allies with their tactical awareness. This is accomplished either on the front lines as a Knight or by directing the fight as a Lord.'),
 	(N'Lord', N'Like to talk a lot.', N'Noble', N'Nobles are negotiators, leaders, and tacticians. Far from the lofty, arrogant, braggart stereotype, these Nobles usually have pockets and minds that are deeper than they let on. In-game, Nobles have a small town to manage that gives them a variety of resources to utilize. While useful in a battle, much of a Nobles power comes from their connections with powerful people. During combat, they control the flow of battle, supporting their allies with their tactical awareness. This is accomplished either on the front lines as a Knight or by directing the fight as a Lord.'),
 	(N'BaseRanger', N'Rangers excel at everything from guarding nobles to stopping hostile warbands in their tracks. These versatile survivors tend to specialize in the field of archery, and all Rangers use a bow or some other type of ranged weapon. Skilled in hunting, tracking, and securing objectives, these adventurers either become master Marksmen or Stalkers.', N'Ranger', N'Rangers excel at everything from guarding nobles to stopping hostile warbands in their tracks. These versatile survivors tend to specialize in the field of archery, and all Rangers use a bow or some other type of ranged weapon. Skilled in hunting, tracking, and securing objectives, these adventurers either become master Marksmen or Stalkers.'),
 	(N'Marksman', N'SNIPER!', N'Ranger', N'Rangers excel at everything from guarding nobles to stopping hostile warbands in their tracks. These versatile survivors tend to specialize in the field of archery, and all Rangers use a bow or some other type of ranged weapon. Skilled in hunting, tracking, and securing objectives, these adventurers either become master Marksmen or Stalkers.'),
 	(N'Stalker', N'They will track you down', N'Ranger', N'Rangers excel at everything from guarding nobles to stopping hostile warbands in their tracks. These versatile survivors tend to specialize in the field of archery, and all Rangers use a bow or some other type of ranged weapon. Skilled in hunting, tracking, and securing objectives, these adventurers either become master Marksmen or Stalkers.'),
 	(N'BaseRogue', N'A surprisingly wide variety of people train in this mysterious, stealthy discipline. The less honorable among them have the ability to master the darker side of combat, employing poisons and stealthy armor-piercing stabs. Some Rogues with a different sense of nobility and honor may find the arts of obtaining things without murder more to their tastes; with inexplicably deft movements, they can quietly take things from their enemies, or devise silver-tongued trickeries that can be useful in a variety of situations. Experienced Rogues become Assassins or Thieves.', N'Rogue', N'A surprisingly wide variety of people train in this mysterious, stealthy discipline. The less honorable among them have the ability to master the darker side of combat, employing poisons and stealthy armor-piercing stabs. Some Rogues with a different sense of nobility and honor may find the arts of obtaining things without murder more to their tastes; with inexplicably deft movements, they can quietly take things from their enemies, or devise silver-tongued trickeries that can be useful in a variety of situations. Experienced Rogues become Assassins or Thieves.'),
 	(N'Assassin', N'Murder! Violence! Yippee!', N'Rogue', N'A surprisingly wide variety of people train in this mysterious, stealthy discipline. The less honorable among them have the ability to master the darker side of combat, employing poisons and stealthy armor-piercing stabs. Some Rogues with a different sense of nobility and honor may find the arts of obtaining things without murder more to their tastes; with inexplicably deft movements, they can quietly take things from their enemies, or devise silver-tongued trickeries that can be useful in a variety of situations. Experienced Rogues become Assassins or Thieves.'),
 	(N'Thief', N'Stealing, but they actually like never do that.', N'Rogue', N'A surprisingly wide variety of people train in this mysterious, stealthy discipline. The less honorable among them have the ability to master the darker side of combat, employing poisons and stealthy armor-piercing stabs. Some Rogues with a different sense of nobility and honor may find the arts of obtaining things without murder more to their tastes; with inexplicably deft movements, they can quietly take things from their enemies, or devise silver-tongued trickeries that can be useful in a variety of situations. Experienced Rogues become Assassins or Thieves.');
GO

SELECT * FROM TempClassData;
GO


INSERT Class(ClassName, ClassDescription)
SELECT T.ClassName, T.ClassDescription
FROM TempClassData T
GROUP BY T.ClassName, T.ClassDescription;
GO


INSERT Subclass(SubclassName, SubclassDescription, ClassID)
SELECT T.SubclassName, T.SubclassDescription, C.ClassID
FROM TempClassData T
	INNER JOIN Class C ON T.Classname = C.Classname;
GO

SELECT * FROM Subclass S INNER JOIN Class C ON S.ClassID = C.ClassID;
GO









DROP TABLE IF EXISTS TempTalentData;
GO

CREATE TABLE TempTalentData(
	TalentName NVARCHAR(30),
	TalentDescription NVARCHAR(500),
	TalentRank INT,
	TalentCategory NVARCHAR(30),
	ClassName NVARCHAR(30),
	SubclassName NVARCHAR(30)
)

INSERT TempTalentData(TalentName, TalentDescription, TalentRank, TalentCategory, ClassName, SubclassName)
VALUES 
	 (N'Organic Crafting', N'The player can extract 3 basic materials from a creature and can make and repair basic organic weapons and armor. The player may learn to craft 2 one-slot modifications and 1 two-slot modification.', 1, N'Skill', N'Classless', N'BaseClassless'),
 (N'Organic Crafting', N'The player can extract up to 5 items from a creature and can make and repair non-mythic organic weapons and armor. The player may learn to craft 2 additional one-slot modifications and 1 two-slot modification.', 2, N'Skill', N'Classless', N'BaseClassless'),
 (N'Organic Crafting', N'The player can extract all materials from any creature and can make and repair all organic weapons and armor if they have the materials. The player may learn to craft 4 additional one-slot modifications and 2 two-slot modifications. The player can create their own modification, subject to GM approval.', 3, N'Skill', N'Classless', N'BaseClassless'),
 (N'Smithing', N'Allows the mining, smelting, smithing, and repair of bronze, iron, and steel weapons and armor. The player may choose two one-slot modifications and one two-slot modification.', 1, N'Skill', N'Classless', N'BaseClassless'),
 (N'Smithing', N'Allows the mining, smelting, and smithing, of all non-mythic weapons and armor. The player may choose two additional one-slot modifications and one two-slot modification.', 2, N'Skill', N'Classless', N'BaseClassless'),
 (N'Smithing', N'Allows the mining, smelting, and smithing, of all weapons and armor. The player may choose four additional one-slot modifications and two two-slot modifications. The player can make their own modification, subject to GM approval.', 3, N'Skill', N'Classless', N'BaseClassless'),
 (N'Constitution"""', N'The player gains 1 additional max carrying capacity (1 weight addition costs 2 XP).', 0, N'Skill', N'Classless', N'BaseClassless'),
 (N'Sense', N'Gain Sense for a chosen sense', 0, N'Skill', N'Classless', N'BaseClassless'),
 (N'Weapon Dexterity', N'Gain a chosen Weapon Dexterity', 0, N'Skill', N'Classless', N'BaseClassless'),
 (N'Magical Crafting', N'Gain 2 magical Crafting Points per out-of-game day. Magical Crafting Enchantment Max Cost: 4.', 1, N'Ability', N'Classless', N'BaseClassless'),
 (N'Magical Crafting', N'Gain 3 magical Crafting Points per out-of-game day. Magical Crafting Enchantment Max Cost: 12.', 2, N'Ability', N'Classless', N'BaseClassless'),
 (N'Magical Crafting', N'Gain 6 magical Crafting Points per out-of-game day. Magical Crafting Enchantment Max Cost: Null.', 3, N'Ability', N'Classless', N'BaseClassless'),
 (N'Elixirs', N'The player can make Rank I elixirs if they have the materials. The player receives 2 random herbs or flowers OPOOGD.', 1, N'Skill', N'Cleric', N'BaseCleric'),
 (N'Elixirs', N'The player can make Rank II elixirs if they have the materials. The player receives 4 random or 2 specific herbs or flowers OPOOGD.', 2, N'Skill', N'Cleric', N'BaseCleric'),
 (N'Elixirs', N'The player can make Rank III elixirs if they have the materials. The player receives 8 random or 4 specific herbs or flowers OPOOGD.', 3, N'Skill', N'Cleric', N'BaseCleric'),
 (N'Renewing Ground', N'Heals or Mends for 2.', 1, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Renewing Ground', N'Heals or Mends for 4.', 2, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Renewing Ground', N'Heals or Mends for 6 to the entire party. No cast time is needed.', 3, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Mend', N'The player gains 4 Mending points.', 1, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Mend', N'The player gains 8 Mending points.', 2, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Mend', N'The player gains 20 Mending points.', 3, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Shell', N'Protects for 5.', 1, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Shell', N'Protects for 10.', 2, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Shell', N'Protects for 20.', 3, N'Ability', N'Cleric', N'BaseCleric'),
 (N'Born Anew', N'Brings back an adventurer to 1 HP.', 1, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Born Anew', N'Brings back anyone to 3 HP', 2, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Born Anew', N'Brings back anything to 10 HP. Can overheal max HP to 10 for the rest of the encounter.', 3, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Invulnerability', N'The player counts down from 5', 1, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Invulnerability', N'The player counts down from 10', 2, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Invulnerability', N'The player counts down from 20', 3, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Metamorph', N'Allows the player to transfer their mass into an inanimate organic object the size of the player or larger, as long as theyd like. While in this state they cannot take damage but are still susceptible to non-damaging effects.', 1, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Metamorph', N'Allows the player to transfer their mass into an approximately 2 diameter, inanimate organic object for as long as theyd like, making them invulnerable to damage and effects.', 2, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Metamorph', N'Allows a player to transfer their mass into any object for as long as theyd like, making them invulnerable to damage and effects. The player can use talents while metamorphosed', 3, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Restore', N'The player can restore 1 Rank 1 or 1 rankless talent of the target.', 1, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Restore', N'The player can restore 1 Rank 2, 2 Rank 1s, or 2 rankless talents of the target.', 2, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Restore', N'The player can restore 1 Rank 3, 2 Rank 2s, 3 Rank 1s, or 3 rankless talents of the target.', 3, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Safeguard', N'The player calls “safeguard” on a target. The target can then activate safeguard to return to the player while invulnerable. If the target dies the talent activates automatically.', 0, N'Ability', N'Cleric', N'Soothsayer'),
 (N'Protective Ward', N'Allows the player to make 2 wards. All wards have a cornerstone effect of the players choosing.', 1, N'Skill', N'Cleric', N'Paladin'),
 (N'Protective Ward', N'Allows the player to make a total of 3 wards. All wards gain a secondary effect that can be any from the list they can swap out before going on a quest.', 2, N'Skill', N'Cleric', N'Paladin'),
 (N'Protective Ward', N'Allows the player to make a total of 4 wards. All wards gain a masterwork effect made by the player.', 3, N'Skill', N'Cleric', N'Paladin'),
 (N'Unbreakable', N'Gives a DR1 and lowers the targets swing by 1.', 1, N'Skill', N'Cleric', N'Paladin'),
 (N'Unbreakable', N'Gives a DR2 and lowers the targets swing by 1.', 2, N'Skill', N'Cleric', N'Paladin'),
 (N'Unbreakable', N'Gives a DR10 and lowers the targets swing by 4.', 3, N'Skill', N'Cleric', N'Paladin'),
 (N'Challenge', N'The player forces a target to only attack the player until the target or player dies or until the target is attacked by another ally.', 1, N'Ability', N'Cleric', N'Paladin'),
 (N'Challenge', N'The player forces all targets within a 5 radius to only attack the player until the target or player dies or until the target(s) is attacked by another ally.', 2, N'Ability', N'Cleric', N'Paladin'),
 (N'Challenge', N'The player forces all targets to only attack the player until the target or player dies or until the target(s) is attacked by another ally.', 3, N'Ability', N'Cleric', N'Paladin'),
 (N'Charisma', N'Makes a target inclined to believe or approve.', 1, N'Ability', N'Noble', N'BaseNoble'),
 (N'Charisma', N'Makes a target strongly inclined to believe or approve.', 2, N'Ability', N'Noble', N'BaseNoble'),
 (N'Charisma', N'Makes a target strongly compelled to believe or approve.', 3, N'Ability', N'Noble', N'BaseNoble'),
 (N'Decorum', N'The player can take back spoken words or grab the attention of a target.', 1, N'Ability', N'Noble', N'BaseNoble'),
 (N'Decorum', N'The player can force two targets to stop fighting or grab the attention of a small group of people.', 2, N'Ability', N'Noble', N'BaseNoble'),
 (N'Decorum', N'The player can take back any non-heinous action or make any-sized group of people stop and listen to you.', 3, N'Ability', N'Noble', N'BaseNoble'),
 (N'Income', N'The players Ludus income is increased by 125 copper.', 0, N'Ability', N'Noble', N'BaseNoble'),
 (N'Tactician', N'The player can tell a party member to use one of their rank 1 abilities free of cost. The called ability must be the next talent used for the free cost to take effect.', 1, N'Ability', N'Noble', N'BaseNoble'),
 (N'Tactician', N'The player can tell a party member to use one of their rank 2 abilities free of cost. The called ability must be the next talent used for the free cost to take effect.', 2, N'Ability', N'Noble', N'BaseNoble'),
 (N'Tactician', N'The player can tell a party member to use one of their rank 3 abilities free of cost. The called ability must be the next talent used for the free cost to take effect.', 3, N'Ability', N'Noble', N'BaseNoble'),
 (N'Training', N'Allows the player to learn 1 rankless Warrior ability.', 0, N'Skill', N'Noble', N'BaseNoble'),
 (N'Advanced Training', N'Lets the player purchase one of the following Warrior Title at the cost of a skill: Armor Category Titles, Support Category Titles, Shield Fighter', 0, N'Skill', N'Noble', N'Knight'),
 (N'Squire', N'Can carry up to 2 weight or 1 suit of armor and can change to that armor in 5 seconds.', 1, N'Skill', N'Noble', N'Knight'),
 (N'Squire', N'Can carry up to 4 weight or 2 suits of armor and can change to that armor in 5 seconds.', 2, N'Skill', N'Noble', N'Knight'),
 (N'Squire', N'Can carry up to 6 weight or 3 suits of armor and can change to that armor instantly.', 3, N'Skill', N'Noble', N'Knight'),
 (N'Hardened', N'Adds DR 1 to a target.', 1, N'Ability', N'Noble', N'Knight'),
 (N'Hardened', N'Adds DR 2 to a target.', 2, N'Ability', N'Noble', N'Knight'),
 (N'Hardened', N'Adds DR 2 to the Knights Team.', 3, N'Ability', N'Noble', N'Knight'),
 (N'Morale', N'Adds 5 HP to a targets max health.', 1, N'Ability', N'Noble', N'Knight'),
 (N'Morale', N'Add 10 HP to a targets max health.', 2, N'Ability', N'Noble', N'Knight'),
 (N'Morale', N'Adds 10 HP to the Knights Teams max health.', 3, N'Ability', N'Noble', N'Knight'),
 (N'War Cry', N'Adds 2 damage to the Knights Teams next weapon attack.', 1, N'Ability', N'Noble', N'Knight'),
 (N'War Cry', N'Adds 3 damage to the Knights Teams next weapon attack.', 2, N'Ability', N'Noble', N'Knight'),
 (N'War Cry', N'Adds 4 damage to the Knights Teams next weapon attack.', 3, N'Ability', N'Noble', N'Knight'),
 (N'Erudite', N'The player can pick 4 additional backgrounds.', 1, N'Skill', N'Noble', N'Lord'),
 (N'Erudite', N'The player can pick 6 additional backgrounds.', 2, N'Skill', N'Noble', N'Lord'),
 (N'Erudite', N'The player can call upon their scribe once per event to compile a wealth of information quickly (after one quest). Also allows the player 1 additional research topic between events.', 3, N'Skill', N'Noble', N'Lord'),
 (N'Languages', N'Understand all common spoken languages.', 1, N'Skill', N'Noble', N'Lord'),
 (N'Languages', N'Speak all common spoken languages, as well as read and write in them.', 2, N'Skill', N'Noble', N'Lord'),
 (N'Languages', N'Can understand and convey hidden intent and cultural nuance, can resist mental manipulation, and can read expressions.', 3, N'Skill', N'Noble', N'Lord'),
 (N'Guidance', N'The player can give a target a use of a rankless or rank 1 ability that has already been used during the encounter. The targets next talent used must be the talent received by Guidance.', 1, N'Ability', N'Noble', N'Lord'),
 (N'Guidance', N'The player can give 2 targets a use of a rankless or rank 1, or give 1 target a use of a rank 2 ability that has already been used during the encounter.', 2, N'Ability', N'Noble', N'Lord'),
 (N'Guidance', N'The player can give up to 3 targets a use of a rankless or rank 1, 2 targets a use of a rank 2, or give 1 target a use of a rank 3 ability that has already been used during the encounter.', 3, N'Ability', N'Noble', N'Lord'),
 (N'Rally', N'Can give +1 base damage towards a specified unit. When the specified unit dies, the effect is removed.', 1, N'Ability', N'Noble', N'Lord'),
 (N'Rally', N'The player can give up to 3 targets +1 base damage towards a specified unit. When the specified unit dies, the effect is removed.', 2, N'Ability', N'Noble', N'Lord'),
 (N'Rally', N'The player can give up to 3 targets +1 base damage for the encounter.', 3, N'Ability', N'Noble', N'Lord'),
 (N'Steward', N'The player can pick 1 use of any stewards to add to their retinue: Combat Steward - The player can administer a non-equipment item to friendly targets during combat via point cast twice per steward. Armor Steward - The player can register a weapon or armor to the steward. The player can swap a targets party members equipment with the registered equipment after a 5-second focus. Mercantile Steward - Can purchase a copy of an item the player already has once per out-of-game day.', 0, N'Ability', N'Noble', N'Lord'),
 (N'Fletching', N'The player may choose 1 specialty ammunition to take with them. The player may choose 1 1-slot modification to learn. The player can make basic ranged weapons given the appropriate materials. The player can apply poisons to ammunition after a roleplay action.', 1, N'Skill', N'Ranger', N'BaseRanger'),
 (N'Fletching', N'The player may choose 3 specialty ammunition to take with them. The player may choose 1 1-slot and 1 2-slot modification to learn. The player can make advanced ranged weapons given the appropriate materials. The player can attach gems to ammunition after a roleplay action.', 2, N'Skill', N'Ranger', N'BaseRanger'),
 (N'Fletching', N'The player may choose 6 specialty ammunition to take with them. The player may choose 2 1-slot and 1 2-slot modification to learn. The player can make mythic ranged weapons given the appropriate materials.', 3, N'Skill', N'Ranger', N'BaseRanger'),
 (N'Point Blank', N'The target stumbles and is shaken for 5 seconds.', 1, N'Ability', N'Ranger', N'BaseRanger'),
 (N'Point Blank', N'The target stumbles and is shaken for 10 seconds.', 2, N'Ability', N'Ranger', N'BaseRanger'),
 (N'Point Blank', N'The target stumbles and is shaken for 20 seconds.', 3, N'Ability', N'Ranger', N'BaseRanger'),
 (N'Reveal', N'Can reveal an unseen, hidden, or disguised target, removing the effect that was obscuring them.', 0, N'Ability', N'Ranger', N'BaseRanger'),
 (N'Stagger', N'The target is pinned for 5 seconds.', 1, N'Ability', N'Ranger', N'BaseRanger'),
 (N'Stagger', N'The target is pinned for 10 seconds.', 2, N'Ability', N'Ranger', N'BaseRanger'),
 (N'Stagger', N'The target is pinned for 20 seconds.', 3, N'Ability', N'Ranger', N'BaseRanger'),
 (N'Artillerist', N'Adds 1 base damage to the players ranged attacks.', 1, N'Skill', N'Ranger', N'Marksman'),
 (N'Artillerist', N'Adds 2 base damage to the players ranged attacks.', 2, N'Skill', N'Ranger', N'Marksman'),
 (N'Artillerist', N'Adds 4 base damage to the players ranged attacks.', 3, N'Skill', N'Ranger', N'Marksman'),
 (N'Sniper', N'After focusing for 15 uninterrupted seconds, the player can point cast an attack and cannot miss their target. Cannot be stacked with other talents.', 1, N'Ability', N'Ranger', N'Marksman'),
 (N'Sniper', N'After focusing for 10 uninterrupted seconds, the player can point cast an attack and cannot miss their target. Cannot be stacked with other talents.', 2, N'Ability', N'Ranger', N'Marksman'),
 (N'Sniper', N'After focusing for 5 uninterrupted seconds, the player can point cast an attack or ability and cannot miss as long as they are aware of the target.', 3, N'Ability', N'Ranger', N'Marksman'),
 (N'Deadeye', N'The players next attack is piercing.', 1, N'Ability', N'Ranger', N'Marksman'),
 (N'Deadeye', N'The players next two attacks are piercing.', 2, N'Ability', N'Ranger', N'Marksman'),
 (N'Deadeye', N'The players next three attacks or until the player moves, are piercing.', 3, N'Ability', N'Ranger', N'Marksman'),
 (N'Adaptable', N'4 damage in a 5 AoE or 8 damage to a single target', 1, N'Skill', N'Ranger', N'Stalker'),
 (N'Adaptable', N'8 damage in a 5 AoE or 12 damage to a single target', 2, N'Skill', N'Ranger', N'Stalker'),
 (N'Adaptable', N'12 damage in a 5 AoE or 16 damage to single target', 3, N'Skill', N'Ranger', N'Stalker'),
 (N'Agile', N'Adds 1 base damage to the players ranged attacks.', 1, N'Skill', N'Ranger', N'Stalker'),
 (N'Agile', N'Adds 2 base damage to the players ranged attacks.', 2, N'Skill', N'Ranger', N'Stalker'),
 (N'Agile', N'Adds 4 base damage to the players ranged attacks.', 3, N'Skill', N'Ranger', N'Stalker'),
 (N'Vigilant', N'The player will know if any Rank I Rogue talent is used near them. The player is aware if there is anything unseen nearby.', 1, N'Skill', N'Ranger', N'Stalker'),
 (N'Vigilant', N'The player will know if any Rank 2 Rogue talent is used near them. The player can identify nearby danger. Gain +2 base damage on first hit against a detected target.', 2, N'Skill', N'Ranger', N'Stalker'),
 (N'Vigilant', N'The player will know if any Rogue talents are used near them or if any talents are used for stealth or espionage within 10 of them. The player can continue attacking a target that is vanishing/dashing, but the player must hold still while the target is moving', 3, N'Skill', N'Ranger', N'Stalker'),
 (N'Hide', N'Allows the player to hide, preventing them from being seen. Moving breaks the Hide.', 1, N'Ability', N'Ranger', N'Stalker'),
 (N'Hide', N'Allows the player to hide themselves and one other target as long as they are within touch-cast distance of the player, preventing them from being seen. The target will become visible if they are separated from the player. Moving while hidden hides the players tracks.', 2, N'Ability', N'Ranger', N'Stalker'),
 (N'Hide', N'Allows the player to hide up to 5 targets in a 5 radius, preventing them from being seen. The player may move with one hidden target at a time, anyone that moves without the player, will break their hide. The player may use lower ranks of Hide for a Rank I Hide effect on a target. Moving while hidden hides the players tracks.', 3, N'Ability', N'Ranger', N'Stalker'),
 (N'Multi-Shot', N'The player calls “multi-shot,” holding gameplay for the two closest targets in a 10 cone. The player makes a single ranged attack against one target and deals the same damage to both targets if landed.', 1, N'Ability', N'Ranger', N'Stalker'),
 (N'Multi-Shot', N'The player calls “multi-shot,” holding gameplay for the three closest targets in a 10 cone. The player makes a single ranged attack against one target and deals the same damage to all three targets if landed.', 2, N'Ability', N'Ranger', N'Stalker'),
 (N'Multi-Shot', N'The player calls “multi-shot,” holding gameplay for all targets in a 10 cone. The player makes a single ranged attack against one target, dealing the same damage to all targets if landed.', 3, N'Ability', N'Ranger', N'Stalker'),
 (N'Poisons', N'Allows the player to make rank I poisons. Also gives 4 random herbs or fungi per event.', 1, N'Skill', N'Rogue', N'BaseRogue'),
 (N'Poisons', N'Allows the player to make rank II poisons. Also gives 8 random or 4 specific herbs or fungi per event.', 2, N'Skill', N'Rogue', N'BaseRogue'),
 (N'Poisons', N'Allows the player to make rank III poisons. Also gives 16 random or 8 specific herbs or fungi per event.', 3, N'Skill', N'Rogue', N'BaseRogue'),
 (N'Blind', N'Blinds the target for 5 seconds.', 1, N'Ability', N'Rogue', N'BaseRogue'),
 (N'Blind', N'Blinds the target for 10 seconds.', 2, N'Ability', N'Rogue', N'BaseRogue'),
 (N'Blind', N'Blinds the target for 20 seconds.', 3, N'Ability', N'Rogue', N'BaseRogue'),
 (N'Disguise', N'After 10 seconds, the player can make themselves look like a random person with no affiliation to any group.', 1, N'Ability', N'Rogue', N'BaseRogue'),
 (N'Disguise', N'After 10 seconds, the player can make themselves look like a random person with an affiliation to a group via symbol, uniform, etc.', 2, N'Ability', N'Rogue', N'BaseRogue'),
 (N'Disguise', N'The player can use previous ranks on team members. The player can disguise themself instantly and can perfectly resemble in all ways a specific person. Hostile action does not break this disguise.', 3, N'Ability', N'Rogue', N'BaseRogue'),
 (N'Assassinate', N'The player can instantly reduce a targets HP to 0 provided the target is not aware of the players presence. This is audible to anyone within 10.', 1, N'Skill', N'Rogue', N'Assassin'),
 (N'Assassinate', N'Any time the player uses assassinate, it is completely silent. The player can hide unconscious targets instantly.', 2, N'Skill', N'Rogue', N'Assassin'),
 (N'Assassinate', N'The player can assassinate multiple targets simultaneously. The player can use ranged weapons to perform assassinations as well. The player can regain the use of assassinate for an encounter if all parties that were aware of them have been killed.', 3, N'Skill', N'Rogue', N'Assassin'),
 (N'Precision', N'Adds 1 base damage until the player is hit for the first time during an encounter. The effect resets after the encounter.', 1, N'Skill', N'Rogue', N'Assassin'),
 (N'Precision', N'Adds 1 base damage until the player is hit for the first time during an encounter. The effect resets after the encounter. On the third successful hit the third hit deals +1 base damage.', 2, N'Skill', N'Rogue', N'Assassin'),
 (N'Precision', N'Adds 2 base damage until the player is hit for the first time during an encounter. The effect resets after the encounter. On the third successful hit the third hit deals +2 base damage.', 3, N'Skill', N'Rogue', N'Assassin'),
 (N'Expose', N'Make the players or an allys next instance of damage piercing.', 1, N'Ability', N'Rogue', N'Assassin'),
 (N'Expose', N'Make the players or an allys successful attack piercing.', 2, N'Ability', N'Rogue', N'Assassin'),
 (N'Expose', N'The player selects a target. Either the players or an allys damage against the target is piercing for the encounter.', 3, N'Ability', N'Rogue', N'Assassin'),
 (N'Ghost Blade', N'Doubles the marks damage.', 1, N'Ability', N'Rogue', N'Assassin'),
 (N'Ghost Blade', N'Triple the marks damage.', 2, N'Ability', N'Rogue', N'Assassin'),
 (N'Ghost Blade', N'Triples the marks damage plus 10 or quadruple the marks damage and automatically redirects hits to the torso, excluding weapons and shields.', 3, N'Ability', N'Rogue', N'Assassin'),
 (N'Invisibility', N'Allows the player to be invisible for 15 seconds.', 1, N'Ability', N'Rogue', N'Assassin'),
 (N'Invisibility', N'Allows the player to be invisible for 30 seconds.', 2, N'Ability', N'Rogue', N'Assassin'),
 (N'Invisibility', N'Allows the player to be invisible and completely silent for an encounter. Can use previous ranks of invisibility on ally targets. Ally targets cannot use Shadow.', 3, N'Ability', N'Rogue', N'Assassin'),
 (N'Skirmisher', N'Adds 1 to damage and 1 to DR for 1 hit. Resets on hitting a different enemy.', 1, N'Skill', N'Rogue', N'Thief'),
 (N'Skirmisher', N'Adds 1 to damage and 1 to DR for 2 hits. Resets on hitting a different enemy.', 2, N'Skill', N'Rogue', N'Thief'),
 (N'Skirmisher', N'Adds 2 to damage and 2 to DR for 2 hits. Resets on hitting a different enemy.', 3, N'Skill', N'Rogue', N'Thief'),
 (N'Sleight of Hand', N'Can pick 3 objects to pickpocket. Must guess all 3 objects correctly to succeed. Can only pickpocket coins. Allows the player to conceal up to 1 weight or up to 100 copper. Can pick locks in 30 seconds.', 1, N'Skill', N'Rogue', N'Thief'),
 (N'Sleight of Hand', N'Can pick 3 objects to pickpocket. Must guess at least 2 correctly to succeed. Can pickpocket coins and any item that would fit in a purse or bag. Allows the player to conceal up to 2 weight, or up to 500 copper. Can pick locks in 15 seconds.', 2, N'Skill', N'Rogue', N'Thief'),
 (N'Sleight of Hand', N'Can pick 3 objects to pickpocket. Must guess at least 1 correctly to succeed. Can pickpocket any item that is not equipped. Allows the player to conceal 3 weight, as well as any amount of copper. They can also conceal any parietal weight item on another target. Can pick locks in 5 seconds.', 3, N'Skill', N'Rogue', N'Thief'),
 (N'Acrobatics', N'The player can move for 5 seconds.', 1, N'Ability', N'Rogue', N'Thief'),
 (N'Acrobatics', N'The player can move 2 times in a row, 5 seconds each time.', 2, N'Ability', N'Rogue', N'Thief'),
 (N'Acrobatics', N'The player can move 3 times in a row, 5 seconds each time.', 3, N'Ability', N'Rogue', N'Thief'),
 (N'Daze', N'The target is shaken for 5 seconds', 1, N'Ability', N'Rogue', N'Thief'),
 (N'Daze', N'The target is shaken for 10 seconds', 2, N'Ability', N'Rogue', N'Thief'),
 (N'Daze', N'The target is shaken for 20 seconds', 3, N'Ability', N'Rogue', N'Thief'),
 (N'Façade', N'Allows the player to remove suspicion from themselves or to throw their voice to distract a target for 30 seconds.', 1, N'Ability', N'Rogue', N'Thief'),
 (N'Façade', N'Allows the player to completely remove suspicion from themselves, allowing them to re-attempt the failed action, or to throw their voice to distract two targets for 30 seconds.', 2, N'Ability', N'Rogue', N'Thief'),
 (N'Façade', N'Allows the player to remove suspicion from themselves and move a targets current suspicion elsewhere, or to throw their voice to distract six targets for 30 seconds.', 3, N'Ability', N'Rogue', N'Thief');
GO

SELECT * FROM TempTalentData;
GO

INSERT Talent(TalentName, TalentDescription, ClassID, SubclassID, TalentRank, TalentCategoryID)
SELECT T.TalentName, T.TalentDescription, C.ClassID, S.SubclassID, T.TalentRank, IIF(T.TalentCategory = N'Skill', 1, 2)
FROM TempTalentData T
	INNER JOIN Subclass S ON T.SubclassName = S.SubclassName
	INNER JOIN Class C ON S.ClassID = C.ClassID
GO

SELECT * FROM Talent;
GO