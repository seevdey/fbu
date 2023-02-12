use HospitalManagamentSystem

-----------------------ÝLAÇLAR---------------------
insert into Medicines(Medicine_Name,SGK, SGK_Disc, Price)
values('Hydrocodone',1,'%50',32),('Metformin',1,'%20',45),('Losartan',0,'%70',20),('Antibiotics',1,'%40',22),
('Albuterol',0,'%50',67),('Antihistamines',1,'%45',63),('Gabapentin',1,'%80',55),('Omeprazole',0,'%65',34)

select * from Medicines

------------------------DOKTORLAR-----------------
insert into Doctors (Doctor_Identification_Number, Doctor_Name, Doctor_Surname, Title, Branch_ID, Polyclinic_ID, Doctor_Phone, Doctor_Mail, Doctor_Address, Active) 
values('48258975974','Hasan','Kaldýrým','Prof. Dr.',1,1,'05452844166','hasan.kaldirim@GADS.com','ISTANBUL/Kartal',1),
('96975346666','Sinem','Öztürk','Prof. Dr.',2,2,'05322844786','sinem.ozturk@GADS.com','ISTANBUL/Pendik',1),
('87625846555','Berke','Bakan','Doç.Dr.',3,3,'05446846792','berke.bakan@GADS.com','ISTANBUL/Beyoðlu',1),
('65432146423','Furkan','Sakallý','Uzm.Dr.',4,4,'05422843128','furkan.sakalli@GADS.com','ISTANBUL/Kadýköy',1),
('43265646782','Eylül','Açelya','Dr.',5,5,'05382847946','eylul.acelya@GADS.com','ISTANBUL/Ataþehir',1)

select * from Doctors

-------------------Branþlar----------------------
insert into Branchs (Branch_Name)
values('Dahiliye'),('KBB'), ('Kardiyoloji'), ('Ortopedi'), ('Beyin Cerrahisi')


select * from Branchs
 
-------------------Polyclinics----------------------
insert into Polyclinics(Polyclinic_Name, Active)
values	('Dahiliye Polikliniði', 1),
	('KBB Polikliniði', 1),
	('Kardiyoloji Polikliniði', 1),
	('Ortopedi Polikliniði', 1),
	('Beyin Cerrahisi' , 1),
	('Genel Cerrahi Polikliniði', 0),
	('Kadýn Hastalýklarý ve Doðum Polikliniði', 0)

select * from Polyclinics

 
---------------------HASTA BÝLGÝLERÝ--------------
insert into Patient_Informations(Patient_Name, Patient_Surname,Gender, Birth_Date, Birth_Place, File_No )
values ('Gürsel','Terzioðlu','Erkek','05-05-1995','Konya',1568),
('Eda','Kobal','Kadýn','12-08-1975','Tokat',7896),
('Baþak','Çaðri','Kadýn','10-12-1999','Giresun',6497),
('Altay ','Erkoç','Erkek','08-11-1966','Ýstanbul',1599),
('Cemil ','Koca','Erkek','04-01-1988','Balýkesir',2347),
('Irmak','Öncü','Kadýn','01-05-1998','Diyarbakýr',3678),
('Burak','Parlak','Erkek','02-07-1976','Muþ',7985),
('Deniz','Kaçar','Erkek','11-06-1974','Ýzmir',2347),
('Sinem','Kýzýlkaya','Kadýn','09-05-1983','Aydýn',3678),
('Kuzey','Öz','Erkek','08-04-2000','Trabzon',7985)

select * from Patient_Informations

-------------------Randevu----------------------
insert into Appointments(Appointment_Date, Patient_ID, Polyclinics_ID, Doctor_ID, Appointment_Confirmation )
values ('2023-05-06', 9, 5, 5, 1),
		('2023-02-25', 7, 1, 1, 1),
		('2023-08-15', 10, 5, 5, 1),
		('2023-10-13', 6, 3, 3, 1),
		('2023-02-23', 5, 4, 4, 1),
		('2023-03-08', 1, 3, 3, 0)

select * from Appointments

------------------------------------NURSES-------------------------------
insert into Nurses --Poliklinik ID var
values ('87828710854','Sevde','Tokatlý', 'Baþ Hemþire', 1, '338-518-8520', 'sevdefenk@gmail.com', 'Sancaktepe, Ýstanbul', 1),
('75693907332','Dünya','Ertepýnar', 'Hemþire', 2, '537-057-1498', 'ertepýnar@gmail.com', 'Kadiköy, Ýstanbul', 1),
('72608190902','Vahide','Örge', 'Hemþire', 3, '535-947-0364', 'vahideorge@gmail.com', 'Bostancý, Ýstanbul', 1),
('36567519754','Emel','Numanoðlu', 'Hemþire', 4, '540-678-0024', 'numanoglu@hotmail.com', 'Ataþehir, Ýstanbul', 1),
('59380262140','Eser','Çörekçi', 'Hemþire', 5, '537-864-2878', 'corekcieser@gmail.com', 'Pendik, Ýstanbul', 1),
('30191336398','Mýsra','Akay', 'Hemþire', 6, '533-745-6417', 'misrakay7@hotmail.com', 'Kartal, Ýstanbul', 1),
('49910205594','Hazan','Demirbaþ', 'Hemþire', 7, '555-384-1785', 'hazandemirbas@hotmail.com', 'Tuzla, Ýstanbul', 1)

select * from Nurses

--------------------------INSURANCES-----------------------
insert into Insurances(Insurances_ID,Insurances_Name, Active)
values (1, 'Allianz Sigorta', 1),
(2, 'Ak Sigorta', 0),
(3, 'Acýbadem Sigorta', 1),
(4, 'Anadolu Sigorta', 1),
(5, 'Zurich Sigorta', 1),
(6, 'Türkiye Sigorta', 1),
(7, 'Ray Sigorta', 1),
(8, 'HDI Sigorta', 1),
(9, 'Quick  Sigorta', 0),
(10, 'Aveon Global', 1)

select * from Insurances


-------------------HASTA DETAY----------------------
insert into Patient_Information_Details(Patient_Information_ID, Identification_Number,Address1,Phone)
Values (1,'63376291984','Cumapazari,27, 61830, Of/ Trabzon, Turkey','+90 547 486 9908'),
       (2,'99011881210','Yukari,27, 60872, Sulusaray/ Tokat, Turkey','+90 545 583 6267'),
       (3,'37940268122','Kaya,30, 32700, Keçiborlu/ Isparta, Turkey','+90 541 588 2248'),
       (4,'25243338246','Aþaði,14, 17202, Biga/ Çanakkale, Turkey','+90 542 398 1911'),
       (5,'53096038082','Kizikli,15, 10702, Burhaniye/ Balikesir, Turkey','+90 532 502 1619'),
       (6,'38119574952','Geçitler Köyü,26, 14902, Gerede/ Bolu, Turkey','+90 531 000 2532'),
       (7,'38955683962','Görentepe,14, 21640, Silvan/ Diyarbakir, Turkey','+90 547 615 8722'),
       (8,'76092972440','Karþiyaka,30, 20170, Pamukkale/ Denizli, Turkey','+90 545 141 4830'),
       (9,'31694708996','Baðlar,33, 42500, Çumra/ Konya, Turkey','+90 541 161 8406'),
       (10,'48691937366','Kirklar,23, 13400, Ahlat/ Bitlis, Turkey','+90 532 148 6889')

select * from Patient_Information_Details

--------------------------------AMELÝYAT------------------------------------
insert into Surgeries 
Values (1,1,1, '2022-12-05'),
(2,2,2, '2023-01-10'),
(3,3,3, '2023-01-16'),
(1,4,1, '2023-02-15'),
(4,5,4, '2023-01-27')

select * from Surgeries


----------------SERVÝCES-------------------
insert into Services(Gender,Service_Name)
values('Kadýn','Dahiliye - 1'),
('Kadýn','Dahiliye - 2'),
('Kadýn','KBB - 1'),
('Erkek','KBB - 2'),
('Kadýn','Kardiyoloji - 1'),
('Erkek','Kardiyoloji - 2'),
('Kadýn','Ortopedi - 1'),
('Erkek','Ortopedi - 2'),
('Kadýn','Beyin Cerrahisi - 1'),
('Erkek','Beyin Cerrahisi - 2')

select * from Services

--------------ROOMS-----------------

insert into Rooms(Room_Number,Service_ID)
values(101,1),
(102,2),
(111,3),
(112,4),
(201,5),
(202,6),
(211,7),
(212,8),
(301,9),
(302,10)


--------------BEDS--------------

insert into Beds(Room_ID,Active)
values(1,1),
(1,1),
(1,0),
(2,1),
(2,0),
(2,0),
(3,1),
(3,0),
(3,1),
(4,1),
(4,1),
(4,1),
(5,0),
(5,0),
(5,1),
(6,0),
(6,1),
(6,1),
(7,1),
(7,0),
(7,1),
(8,0),
(8,1),
(8,0),
(9,0),
(9,0),
(9,1),
(10,0),
(10,0),
(10,1)

select * from Beds

-------------------Muayene----------------------
insert into Examination(Doctor_ID, Examination_Date)
values  (3, '2023-01-25'),
		(4, '2023-01-28'),
		(1, '2023-02-06'),
		(5, '2023-02-15'),
		(2, '2023-02-13')

select * from Examination


-------------------Reçete----------------------
insert into Prescriptions(Prescription_ID, Medicine_Piece)
values  (1, 4),
		(2, 6),
		(3, 5),
		(4, 4),
		(5, 2)

select * from Prescriptions

----------------------------Prescription Medicine-----------------------------

insert into Prescription_Medicine
values (1, 8),
		(2, 6),
		(3, 1),
		(4, 4),
		(5, 3)

select * from Prescription_Medicine


----------------------Hasta Refakatçi-------------------------------

insert into Patient_Accompaniment(Identification_Number, Acc_Name, Acc_Surname, Start_Date, End_Date, Acc_Address, Acc_Phone, Degree_Proximity)
values('78172594474', 'Sevinç', 'Tütüncü', '2023-02-05', '2023-02-06', 'Kartal, Ýstanbul', '534-894-5623', 'Annesi'),
('12510646050', 'Ümran', 'Çörekçi', '2023-01-10', '2023-01-28', 'Baðcýlar, Ýstanbul', '533-697-0456', 'Teyzei'),
('45063843676', 'Selda', 'Aybar', '2022-12-15', '2022-12-05', 'Üsküdar, Ýstanbul', '545-165-7842', 'Kardeþi'),
('39952628598', 'Muzaffer', 'Tekelioðlu', '2022-11-10', '2022-11-20', 'Göztepe, Ýstanbul', '536-487-3458', 'Babasý'),
('57051382630', 'Evran', 'Erberk', '2022-10-24', '2022-10-26', 'Bostancý, Ýstanbul', '542-434-1367', 'Abisi')

select * from  Patient_Accompaniment


-----------------------------------Lab Sonuçlarý-----------------------------------
insert into LabReports
values (1, 3, 'Covid+'),
(2, 9, '')








---------------------------
insert into Patient_Discharge (Patient_Discharge_ID, Discharge_Date, Explanation) 
values 
(1, '2023-05-07','Monthly check-up'),
(2, '2023-02-25','Routine'),
(3, '2023-08-18','Weekly check-up'),
(4, '2023-10-15','Check-up per 2 month'),
(5, '2023-02-23','Plaster')