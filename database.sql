create user 'GROUP6WD05'@'localhost' identified by 'Donation100$';
drop database if exists courseteachingcook;
create database CourseTeachingCook;
use courseteachingcook;

create database CourseTeachingCook;
drop table staffs;
create table staffs(
	staffID int auto_increment primary key,
    staffName varchar(50) not null,
    jobPosition varchar(100) not null,
    email varchar(100) unique not null,
    password varchar(256) not null,
    phoneNumber varchar(15) unique not null,
    status int default 1 not null,
    image varchar(200) not null
);

select * from staffs;
alter table courses 
add column numberOfSession int not null,
add column numberOfDishs int not null,
add column numberOfHours int not null;
INSERT into staffs(staffName, jobPosition, email, password, phoneNumber, status, image)
values
('Ngo Huy', 'Quản Lí Khóa Học', 'ngoHuy3@gmail.com', '123456', '0333020844', 1, 'defaultImage.jpg'),
('Van Long', 'Quản Lí Tin Tức', 'vanLong3@gmail.com', '123456', '0123456782', 1, 'defaultImage.jpg'),
('Le Duoc', 'Quản Lí Khóa Học', 'leDuoc3@gmail.com', '123456', '0123456799', 1, 'defaultImage.jpg');

create table admin(
adminID int auto_increment primary key,
adminName varchar(50) not null,
email varchar(100) unique not null,
password varchar(256) not null,
phoneNumber varchar(15) unique not null,
image varchar(200) not null
);

insert into admin(adminName, email, password, phoneNumber, image)
values('Duoc Le', 'adminDuocLe@gmail.com', 'BCE49C1FD7E0BE2BC178F17C57344E7A', '0333020842', 'defaultImage.jpg');
select * from admin;
select * from customers;
create table customers(
	customerID int auto_increment primary key,
    customerName varchar(50) not null,
	email varchar(100) unique not null,
    password varchar(256) not null,
    phoneNumber varchar(15) not null unique,
    address varchar(300) not null,
    timeRegister datetime not null,
	numberOfPurchases int not null check(numberOfPurChases > -1),
    image varchar(200) not null,
    status int not null,
    lastLoggedTime datetime not null
);

drop table customers;
insert into customers(customerName, email, password, phoneNumber, address, timeRegister, image, numberOfPurchases, status, lastLoggedTime) values
('Lê Văn Được', 'duoclv@gmail.com', 'BCE49C1FD7E0BE2BC178F17C57344E7A', '0967381905', 'Hà Nội', current_timestamp(), 'defaultImage.jpg', 0, 1, current_timestamp()),
('Lê Văn Được1', 'duocclv01@gmail.com', 'BCE49C1FD7E0BE2BC178F17C57344E7A', '0967381904', 'Hà Nội', current_timestamp(),  'defaultImage.jpg', 1, 1, current_timestamp()),
('Lê Văn Được2', 'duoclv02@gmail.com', 'BCE49C1FD7E0BE2BC178F17C57344E7A', '0967381903', 'Hà Nội', current_timestamp(),  'defaultImage.jpg', 2, 1, current_timestamp()),
('Lê Văn Được3', 'duoclv03@gmail.com', 'BCE49C1FD7E0BE2BC178F17C57344E7A', '0967381902', 'Hà Nội', current_timestamp(),  'defaultImage.jpg', 3, 0, current_timestamp());

select * from customers;

drop table orders;
drop table orderdetails;
drop table categories;

create table categories(
	categoryID int auto_increment primary key,
    categoryName varchar(100) not null
);

insert into categories (categoryName) values
('Đào tạo nghề bếp'),
('Bếp gia đình'),
('Trẻ vào bếp'),
('Bánh ngọt - kem chè'),
('Học pha chế'),
('Nghệ thuật tạo hình'),
('Ẩm thực thế giới');
insert into categories (categoryName) values
('Ẩm thực thế giới');
select * from categories;

drop table courses;
create table courses(
	courseID int auto_increment primary key,
    categoryID int,
    courseName varchar(100) not null,
    courseDescription varchar(1000) not null,
    courseRates int not null,
	check (courseRates > 0 and courseRates < 6),
    coursePrice int not null,
	check (coursePrice > 0),
    materialPrice int not null,
	check (materialPrice > 0),
    featureImage varchar(200) not null,
    numberOfStudent varchar(20) not null,
    addressLearn varchar(300) not null,
    dateOfOpening datetime not null,
    status int default 1 not null,
    views int not null,
    constraint foreign key(categoryID) references categories(categoryID)
);

select * from courses;
select * from categories;
select * from customers;
select * from orderdetails;
insert into courses (categoryID, courseName, courseDescription, courseRates, coursePrice, materialPrice, numberOfStudent, addressLearn, dateOfOpening, status, views, featureImage) values
(1, 'Bánh kinh doanh', 'Đây là khóa học của nhóm 6', 5, 3500000, 500000, '4-10', 'Tầng 5 - 142 Lê Duẩn', current_timestamp(), 1, 0, 'banhKinhDoanh.jpg'),
(1, 'Lớp bếp trưởng', 'Đây là khóa học của nhóm 6', 4, 3600000, 500000, '4-10', 'Tầng 5 - 142 Lê Duẩn', current_timestamp(), 1, 0, 'lopBepTruong.jpg'),
(1, 'Đào tạo làm bánh ngọt chuyên nghiệp', 'Đây là khóa học của nhóm 6', 5, 3700000, 500000, '4-11', 'Tầng 5 - 142 Lê Duẩn', current_timestamp(), 1, 0, 'daoTaoLamBanhNgotChuyenNghiep.jpg'),
(1, 'Cô dâu mới đi học nấu ăn trước khi về nhà chồng', 'Đây là khóa học của nhóm 6', 3, 4000000, 500000, '4-10', 'Tầng 5 - 142 Lê Duẩn', current_timestamp(), 1, 0, 'coDauMoiDiHocNauAnTruocKhiVeNhaChong.jpg'),
(1, 'Khóa học nghề đầu bếp trưởng', 'Đây là khóa học của nhóm 6', 5, 35010000, 500000, '6-10', 'Tầng 5 - 142 Lê Duẩn', current_timestamp(), 1, 0, 'khoaHocNgheDauBepTruong.jpg'),
(1, 'Khóa học đầu bếp chuyên nghiệp', 'Đây là khóa học của nhóm 6', 4, 35002000, 500000, '3-6', 'Tầng 5 - 142 Lê Duẩn', current_timestamp(), 1, 0, 'khoaHocDauBepChuyenNghiep.jpg');
select * from categories;
create table imagesCourse(
	imageID int auto_increment primary key,
    imageSource varchar(200) not null,
    courseID int not null,
    constraint foreign key(courseID) references courses(courseID)
);
drop table imagesCourse;
insert into imagesCourse(imageSource, courseID) values
('banhKinhDoanh.jpg', 1),
('banhKinhDoanh.jpg', 1);

create table orders(
orderID int auto_increment primary key,
orderDate datetime,
staffID int,
customerID int not null,
orderStatus int not null default 1,
reasonCancel varchar(200),
canceler int,
constraint foreign key(staffID) references staffs(staffID),
constraint foreign key(customerID) references customers(customerID)
);
alter table orders
add column requireInformation varchar(1000);
select * from orders;
select * from staffs;

select * from courses;
select * from customers;
drop table orders;
select * from staffs;
insert into orders(orderDate, staffID, customerID, orderStatus, reasonCancel) values
(current_timestamp(), 7, 1, -2, 'khách hàng đổi khóa học'),
(current_timestamp(), 8, 2, -2, 'khách hàng đổi khóa học khách hàng đổi khóa học'),
(current_timestamp(), 9, 3, -1, ''),
(current_timestamp(), 10, 4, -1, ''),
(current_timestamp(), 7, 1, 0, ''),
(current_timestamp(), 8, 2, 0, ''),
(current_timestamp(), 9, 3, 1, ''),
(current_timestamp(), 10, 4, 1, '');


insert into orders(orderDate, staffID, customerID, orderStatus, reasonCancel) values
(current_timestamp(), 7, 1, -2, 'khách hàng đổi khóa học');

insert into orders(orderDate, customerID, orderStatus, reasonCancel) values
(current_timestamp(), 4, -1, '');
drop table orderDetails;
create table orderDetails(
orderID int not null,
courseID int not null,
coursePrice int not null,
materialPrice int not null,
quantity int not null,
constraint foreign key(orderID) references orders(orderID),
constraint foreign key(courseID)  references courses(courseID)
);
drop table orderDetails;
select * from orderDetails;
select * from orders;
insert into orderDetails(orderID, courseID, coursePrice, materialPrice, quantity) values
(1, 1, 200000, 10000, 1),
(1, 2, 300000, 11000, 2),
(2, 1, 200000, 10000, 1),
(2, 2, 300000, 11000, 2),
(3, 1, 200000, 10000, 1),
(3, 2, 300000, 11000, 2),
(4, 1, 200000, 10000, 1),
(4, 2, 300000, 11000, 2),
(5, 1, 200000, 10000, 1),
(5, 2, 300000, 11000, 2),
(6, 1, 200000, 10000, 1),
(6, 2, 300000, 11000, 2),
(7, 1, 200000, 10000, 1),
(7, 2, 300000, 11000, 2),
(8, 1, 200000, 10000, 1),
(8, 2, 300000, 11000, 2),
(9, 1, 200000, 10000, 1),
(9, 2, 300000, 11000, 2),
(10, 1, 200000, 11000, 1),
(10, 2, 300000, 10000, 2);


create table banks(
	bankID int auto_increment primary key,
    bankName varchar(100) not null,
    accountNumber varchar(30) not null unique,
    nameOwner varchar(50) not null
);

insert into banks(bankName, accountNumber, nameOwner) values
('Vietcombank', '0931004219170', 'Le van Duoc'),
('Agribank', '012345678910', 'Vu Van Long');

create table teachers(
	teacherID int auto_increment primary key,
    teacherName varchar(50) not null,
    teacherDescription varchar(1000) not null,
    teacherImage varchar(200) not null
);
insert into teachers(teacherName, teacherDescription, teacherImage) values
('Thầy Ninh Văn Hưởng', 'Bếp phó K.S Flower Garden', 'ThayNinhVanHuong.jpg'),
('Thầy Chu Anh Tiệp', 'Bếp trưởng K.S Flower Garden', 'ThayChuAnhTiep.jpg'),
('Thầy Hoàng Công Đam', 'K.S Sunway', 'ThayHoangCongDam.jpg'),
('Cô Nguyễn Thị Kim Liên', 'Khách sạn Melia Hanoi', 'CoNguyenThiKimLien.png'),
('Thầy Nguyễn Mạnh Cường', 'Trường trung cấp nấu ăn Hà Nội', 'ThayNguyenManhCuong.jpg'),
('Thầy Nguyễn Mạnh Tuấn', 'Khách sạn Hanoi Sky Hotel', 'ThayNguyenManhTuan.jpg'),
('Thầy Ngô Quốc Hưng', 'Bếp trưởng bếp Nhật K.S Melia', 'ThayNgoQuocHung.jpg'),
('Thầy Lê Mộng Long', 'Bếp trưởng K.S Kim Liên Hà Nội', 'ThayLeMongLong.jpg'),
('Thầy Nguyễn Năng Vinh', 'Nhà Hàng Neva', 'ThayNguyenNangVinh.jpg'),
('Thầy Vũ Văn Bốn', 'Nghệ nhân cắt tỉa', 'ThayVuVanBon.jpg'),
('Cô Trương Thúy Thưởng', 'Bếp trưởng bếp Arirang Hàn Quốc K.S Grand Plaza', 'CoTruongThuyThuong.jpg'),
('Cô Nguyễn Thị Thanh', 'Giảng viên - Trường TCDL Hoa Sữa', 'CoNguyenThiThanh.jpg');
select * from orders;
create table imageLogo(
	imageID int auto_increment primary key,
    imageSource varchar(200) not null
);
insert into imageLogo(imageSource) value
('Logo.png');
create table contactsInformation(
	contactID int auto_increment primary key,
    jobPosition varchar(50) not null,
    email varchar(100) not null unique,
    image varchar(200) not null,
    phoneNumber varchar(15) not null unique,
    description1 varchar(150),
    description2 varchar(150),
    description3 varchar(150)
);

insert into contactsInformation(jobPosition, email, image, phoneNumber, description1, description2, description3) values
('Giáo vụ', 'giaovu1@ezcooking.vn', 'ic_contact.png', '0963.938.523', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Kế toán', 'ketoan1@ezcooking.vn', 'ic_contact1.png', '024.3773.9943', 'Quan hệ giao thương', 'Lên thực phẩm', 'Theo dõi công nợ về học phí của học viên'),
('Marketing', 'marketing@ezcooking.vn', 'ic_contact2.png', '0963.938.524', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Tuyển sinh', 'tuyensinh@ezcooking.vn', '1450835234ic_contact3.png', '0963.938.525', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Hành chính - Nhân sự', 'hanhchinhnhansu@ezcooking.vn', '1450834578ic_contact5.png', '0963.938.526', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Tuyển dụng nghề bếp', 'tuyendungnghebep@ezcooking.vn', '1450834541ic_contact4.png', '0963.938.527', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học');
select * from contactsInformation;


select * from orders;





create table news(
	newsID int auto_increment primary key,
    newsTitle varchar(200) not null,
    newsDate datetime not null,
    featureImage varchar(200) not null,
    newsDescription varchar(1000) not null,
    status int default 1
);
drop table news;
create table newsDetails(
	newsID int not null,
    newsTitle varchar(200),
    newsDescription varchar(1000),
    newsImage varchar(200)
)