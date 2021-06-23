drop database if exists courseteachcook;
create database if not exists CourseTeachCook;
use CourseTeachCook;
create table admin(
adminID int auto_increment primary key,
adminName varchar(50) not null,
email varchar(100) unique not null,
password varchar(256) not null,
phoneNumber varchar(15) unique not null,
image varchar(200) not null
);
insert into admin(adminName, email, password, phoneNumber, image)
values('Duoc Le', 'adminDuocLe@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0333020842', 'anhDaiDien.png');


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
INSERT into staffs(staffName, jobPosition, email, password, phoneNumber, status, image)
values
('Ngo Huy', 'Quản Lí Khóa Học', 'ngoHuy3@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0333020844', 1, 'defaultImage.jpg'),
('Van Long', 'Quản Lí Tin Tức', 'vanLong3@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0123456782', 1, 'defaultImage.jpg'),
('Le Duoc', 'Quản Lí Khóa Học', 'leDuoc3@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0123456799', 1, 'defaultImage.jpg');

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
insert into customers(customerName, email, password, phoneNumber, address, timeRegister, image, numberOfPurchases, status, lastLoggedTime) values
('Lê Văn Được', 'duoclv@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0967381905', 'Hà Nội', current_timestamp(), 'defaultImage.jpg', 0, 1, current_timestamp()),
('Lê Văn Được1', 'duocclv01@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0967381904', 'Hà Nội', current_timestamp(),  'defaultImage.jpg', 1, 1, current_timestamp()),
('Lê Văn Được2', 'duoclv02@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0967381903', 'Hà Nội', current_timestamp(),  'defaultImage.jpg', 2, 1, current_timestamp()),
('Lê Văn Được3', 'duoclv03@gmail.com', '9DB982E6EB99F1704AADA61D50476874', '0967381902', 'Hà Nội', current_timestamp(),  'defaultImage.jpg', 3, 0, current_timestamp());


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

create table courses(
	courseID int auto_increment primary key,
    categoryID int,
    courseName varchar(100) not null,
    courseDescription varchar(2000) not null,
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
    numberOfSessions int not null,
    numberOfDishs int not null,
    numberOfHours int not null,
    status int default 1 not null,
    views int not null default 0,
    constraint foreign key(categoryID) references categories(categoryID)
);
insert into courses(categoryID,courseName,featureImage,courseRates,coursePrice,courseDescription,materialPrice,numberOfStudent,addressLearn,status,numberOfSessions,numberOfDishs,numberOfHours,dateOfOpening) values 
(1, "Bánh kinh doanh", "banhkinhdoanh.jpg", 5, 3500000,"Đảm bảo học viên học thành công, đặc biệt với khoá  học mang tính chất kinh doanh. Học viên được cấp chứng chỉ với điều kiện làm lại thành công món ăn và được sự đánh giá tốt từ phía giáo viên sẽ chia sẻ cách kiểm soát trong mua nguyên liệu, bảo quản nguyên liệu với số lượng lớn tránh hao hụt, sơ chế và cấp đông nguyên liệu an toàn cho những nhà hàng quy mô lớn…" , 500000, "Từ 7 - 10 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,1,2,3, current_timestamp()),
(1, "Lớp Bếp Trưởng", "lopbeptruong.jpg", 4, 6800000,"Học là cách duy nhất để rút ngắn thời gian nâng cao trình độ,là bếp trưởng bạn cần giỏi chuyển môn, cách quản lý, sắp sếp tổ chức chuyên nghiệp, cách lên menu thực đơn cho từng loại bếp nóng, bếp lạnh và biết cách tính giá cost cho bất kỳ món ăn nào, các kỹ năng tài chính, thống kê.. " , 5190000, "Từ 6 - 8 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,42,100,3,current_timestamp()),
(1, "Đào tạo làm bánh ngọt chuyên nghiệp", "banhngotchuyennghiep.jpg", 5, 4590000," Khóa học Đào tạo bánh ngọt chuyên nghiệp là một trong các khóa đào tạo về bánh tại EZcooking. Khóa học sẽ giúp những bạn yêu thích, đam mê và theo đuổi nghề bánh thực hiện ước mơ của mình.Hiện nay, nghề làm bánh thực sự là ngành kinh doanh đầy hấp dẫn, có thể đạt sự thành công và lợi nhuận cao. " , 1650000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,15,30,3,current_timestamp()),
(1, "Cô dâu mới đi học nấu ăn trước khi về nhà chồng", "hocnauan.jpg", 5, 2500000," Lấy chồng là một trong những sự kiện quan trọng nhất của đời người, đi cùng với niềm hân hoan hạnh phúc và chờ đợi ngày vui cận kề là nỗi lo khi phải một mình chăm sóc gia đình nhà chồng. " , 500000, "Từ 4 - 8 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,10,50,3,current_timestamp()),
(1, "Khóa học nghề đầu bếp trưởng", "daubeptruong.jpg", 5, 10600000," Chương trình đào tạo được thiết kế riêng, phù hợp với vị trí Bếp trưởng và cập nhật xu thế ẩm thực cùng với kỹ năng quản lý cần thiết của Bếp trưởng." , 7300000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,42,100,3,current_timestamp()),
(1, "Khóa học bếp chuyên nghiệp", "daubepchuyennghiep.jpg", 5, 6800000," Đào tạo nghề bếp tại EZcooking đáp ứng nhu cầu để thành bếp trưởng, nấu bếp trong những năm gần đây tăng nhanh, nghề bếp được nhiều bạn trẻ săn đón và lựa chọn thành nghề, thành nghiệp vì đam mê và xu hướng xã hội. Nhu cầu học của các bạn cũng khác nhau, có bạn mong muốn học nấu ăn để làm bếp cơ bản tại các nhà hàng nhỏ, có bạn mong muốn học để trở thành một đầu bếp, bếp trưởng giỏi... " , 5190000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,42,100,3,current_timestamp()),
(2, "Mâm cỗ ngày tết - Tết Trọn Yêu Thương", "mam-co-ngay-tet.png", 4, 2530000,"Trong đời sống tinh thần của người Việt, Tết Nguyên Đán là khởi đầu cho một năm mới, vận hội mới của gia đình, cộng đồng và cả dân tộc. Thế nên gia đình dù còn khó khăn, người ta vẫn gắng sắm sửa mâm cỗ Tết thịnh soạn để tưởng nhớ ông bà, Tổ tiên, mong Tổ tiên phù hộ cho con cháu sức khỏe, học hành tấn tới, làm ăn phát tài phát lộc. " , 1200000, "Từ 6 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,16,2,current_timestamp()),
(2, "Đảm Toàn Diện", "dam-toan-dien.jpg", 5, 3250000 , "Khóa học ĐẢM TOÀN DIỆN là lựa chọn hàng đầu cho các chị em phụ nữ những tuyệt chiêu, bí quyết nấu ăn NGON -  DINH DƯỠNG -  KHOA HỌC sẽ được đầu bếp EZcooking chia sẻ tại khóa học, ngoài ra học viên còn bổ sung thêm vào menu: làm bánh, pha chế và cắm hoa. " , 1150000, "Từ 6 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,12,26,3,current_timestamp()),
(2, "Khóa học nấu ăn gia đình thực hành", "1.jpg", 4, 2850000,"Nấu ăn sao cho ngon, tiết kiệm chi phí nhưng vẫn đảm bảo chế độ dinh dưỡng không phải là việc đơn giản. Làm sao để ngày nào gia đình cũng vui như có hội, bữa cơm nào cũng đầm ấp yêu thương như nhà có cỗ? Khóa học nấu ăn gia đình thực hành là giải pháp giúp chị em nâng cao tay nghề nấu ăn bản thân và quan trọng là gìn giữ mái ấm gia đình. " , 2200000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,10,30,3,current_timestamp()),
(2, "Lớp dạy nấu ăn gia đình", "1.jpg", 4, 2850000," Đàn ông xây nhà, đàn bà xây bếp .Nếp sống này vẫn được đặc biệt coi trọng trong các gia đình Việt Nam cho đến ngày nay. Trong gia đình, một người vợ tuyệt vời trong mắt các ông chồng là người nấu ăn giỏi, biết làm chủ căn bếp của mình." , 2200000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,10,30,3,current_timestamp()),
(3, "Khóa học Trẻ vui vào bếp", "trevuivaobep.jpg", 5, 190000,"Làm thế nào để ngoài những giờ học căng thẳng con vừa được vui chơi và vừa giúp con đáp ứng được những điều mà con đang tò mò trong bếp của mẹ? Con sẽ có vô vàn những thứ hay ho để kể cho bạn bè và con sẽ tự hào hơn bởi những điều con đã làm được.  Ba/mẹ không cần lo đâu EZcooking ở đây để cùng con tìm hiểu và rèn luyện những kỹ năng giúp con tự tin hơn với bạn bè rồi." , 10, "Từ 6 - 10 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,5,10,2,current_timestamp()),
(3, "Khóa học Dạy trẻ nấu ăn nâng cao – Start to cook 2", "trẻ-nấu-ăn-nâng-cao.JPG", 5, 2630000,"Nhiều năm qua, phụ huynh đã tin tưởng gửi gắm con em mình tham gia trong các khóa học Trẻ vào bếp tại EZcooking. Khóa học này được thiết kế menu riêng với mục tiêu nhiều thách thức hơn về kỹ năng làm bếp của trẻ. Chương trình đào tạo với 12 buổi và nhiều món yêu cầu cao: món ngon trong những bữa cơm gia đình, làm bánh pizza, học nấu chè…" , 920000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,10,20,3,current_timestamp()),
(3, "Khóa học MOON KIDS – Dạy trẻ làm bánh Trung thu", "moonkids.JPG", 5, 150000,"Để con vừa chơi, vừa học và hiểu thêm những giá trị văn hóa Trung thu truyền thống qua hoạt động làm bánh Trung thu cũng là một buổi sinh hoạt ngoại khóa lý tưởng mà các phụ huynh, nhà trường có thể tổ chức cho các con trong dịp Trung thu này.Khóa học Moon Kids – Dạy trẻ làm bánh Trung thu là hoạt động thú vị, ý nghĩa màEZcooking gửi tới các bậc cha mẹ mùa Trung thu năm nay." , 340000, "Từ 10 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,1,2,2,current_timestamp()),
(3, "Lớp Start To Cook Dạy Trẻ Nấu Ăn", "s2.JPG", 5, 2500000,"Mỗi dịp hè, những khóa học “Trẻ vào bếp” tại EZcooking luôn nhộn nhịp. Lớp học luôn nhận được sự quan tâm đặc biệt của phụ huynh và các em nhỏ. Đây thực sự là món quà ý nghĩa thiết thực của bố mẹ dành cho các con của mình." , 10, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,5,10,2,current_timestamp()),
(3, "Start to bake – Dạy trẻ làm bánh", "daytrelambanh-2.JPG", 2, 172500,"Khóa học dạy trẻ làm bánh sẽ giúp các bé thỏa mãn niềm yêu thích với bánh ngọt. Lớp học sẽ là môi trường tốt để phát hiện năng khiếu và rèn kỹ năng giao tiếp với cộng đồng thông qua hoạt động  tương tác trong lớp học, tính tỉ mỉ, kiên nhẫn cho trẻ từ học làm bánh cùng các bạn." , 875000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,5,9,2,current_timestamp()),
(4, "Lớp học nấu chè", "nấu-chè.jpg", 5, 6000000," Nấu chè ngon sẽ trở nên thật đơn giản khi có trong tay công thức nấu 15 món chè từ EZcooking đậm đà hương vị ẩm thực Việt Nam. Khóa học nấu chè không chỉ giúp bạn tự tin làm những món chè ngon đúng điệu mà còn tư vấn, hỗ trợ bạn mở quán kinh doanh chuyên nghiệp để làm thương hiệu." , 10, "Từ 3 - 6 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,15,2,current_timestamp()),
(4, "Khoá học làm kem", "kem.jpg", 1, 3000000," Khóa học làm kem đang là khóa học thu hút nhiều học viên tham dự. Với chương trình đào tạo kỹ năng làm kem ngon cũng như sáng tạo trong chế biến kem bằng nhiều công thức làm kem hấp dẫn. Lớp học làm kem tại EZcooking giúp bạn có được kỹ năng tốt nhất để chế biến kem ngon tuyệt hảo, mở quán kinh doanh với chất lượng sản phẩm tốt." , 500000, "Từ 5 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,5,10,2,current_timestamp()),
(4, "Khóa học chè và các món ăn vặt mùa đông", "che-mua-dong.jpg", 5, 2000000,"Mùa nào thức nấy, các món chè mùa đông rất được nhiều người quan tâm và tìm lớp đăng ký học vì chè mùa đông khá ngon nhưng đặc trưng và không hề dễ làm. Chè mùa đông và các món ăn vặt là cơ hội kinh doanh rất hay và thú vị mà các bạn có thể tham khảo. " , 400000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,18,2,current_timestamp()),
(4, "Dạy học làm bánh ngọt", "dayamthuc.jpg", 5,1840000,"Khóa học các loại bánh được sắp xếp theo chủ đề giúp học viên nắm vững kiến thức cách làm cụ thể từng dòng bánh cơ bản bắt đầu từ khâu chuẩn bị nguyên liệu trộn bột, đánh bột cho đến lúc làm ra một chiếc bánh ngọt hoàn hảo dành tặng những người thân yêu nhất " , 1450000, "Từ 6 - 15 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,12,2,current_timestamp()),
(4, "Khoá học làm bánh Việt Nam", "banh-viet-nam.jpg", 5, 2500000,"Khóa học dạy làm các món bánh đặc sản của Việt Nam, bánh đặc sản vùng miền. Đặc sản bánh Việt vô cùng đa dạng từ màu sắc, hình dạng cũng như cách chế biến phù hợp với đặc trưng của từng vùng miền. Ví như đặc sản bánh miền Bắc có bánh cuốn Thanh Trì, bánh giò, bánh đúc,… Miền Trung có bánh bèo, bánh khọt…, Miền Nam có bánh xèo, bánh bò… " ,300000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,12,2,current_timestamp()),
(4, "Khóa học làm bánh mì", "banh-mi.jpg", 5, 2700000,"Khóa học làm bánh mì tại EZcooking sẽ cung cấp cho bạn toàn bộ kiến thức để phân biệt đặc trưng của các loại bánh mì mà chỉ người sành mới biết được. Tham gia khóa học để nâng cao tay nghề nội trợ của mình. Đặc biệt tự tay làm cho gia đình những chiếc bánh mì không có chất bảo quản, hóa chất độc hại là món quà sức khỏe cho cả gia đình " , 300000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,4,11,2,current_timestamp()),
(5, "Khóa học pha chế căn bản", "pha-che-co-ban.JPG", 5, 1000000,"Khóa học pha chế căn bản giúp bạn có những kiến thức pha chế cơ bản phục vụ mục đích kinh doanh quán đồ uống hoặc pha chế gia đình với 5 chủ đề các loại đồ uống được quan tâm nhất trên thị trường hiện nay. Các loại đồ uống mới và hiện đại được giới trẻ ưa thích như dòng pha chế cà phê, trà, các loại đồ uống đá xay, sinh tố và Soda, sữa chua lắc…" , 10, "Từ 6 - 10 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,5,21,2,current_timestamp()),
(5, "Khóa học đào tạo pha chế chuyên nghiệp", "pha-chế-chuyên-nghiệp.JPG", 5, 4150000,"Dành cho đối tượng học nghề pha chế để làm việc chuyên nghiệp. Đảm bảo học viên có đủ các kỹ năng tiêu chuẩn để có mức thu nhập cao trong nghề. Đảm bảo việc làm cho học viên sau khi tốt nghiệp." , 2130000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,15,60,3,current_timestamp()),
(5, "Khóa dạy học pha chế gia đình", "pha-che-do-an.jpg", 5, 1460000,"Khóa học dạy pha chế căn bản giúp bạn có những kiến thức pha chế cơ bản phục vụ mục đích kinh doanh quán đồ uống hoặc pha chế gia đình với 5 chủ đề các loại đồ uống được quan tâm nhất trên thị trường hiện nay. Các loại đồ uống mới và hiện đại được giới trẻ ưa thích như dòng pha chế cà phê, trà, các loại đồ uống đá xay, sinh tố và Soda, sữa chua lắc…" , 1230000, "Từ 6 - 10 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,5,21,2,current_timestamp()),
(6, "Dạy nấu ăn cho cô dâu", "hoc-cam-hoa-voi-nghe-nhan.jpg", 2, 2130000,"Dạy nấu ăn cho cô dâu là lựa chọn hàng đầu cho những bạn gái. Những tuyệt chiêu, bí quyết nấu ăn NGON -  DINH DƯỠNG -  KHOA HỌC sẽ được những chuyên gia ẩm thực, đầu bếp EZcooking chia sẻ tại khóa học. EZcooking sẽ giúp bạn trở thành người phụ nữ lý tưởng của gia đình trong mắt người bạn đời. " , 980000, "Từ 6 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,10,30,2,current_timestamp()),
(6, "Khóa học cắm hóa", "nghethuattaohinh.jpg", 4, 1850000,"Thể hiện sự khéo léo của đôi bàn tay cùng với sự tinh tường trong cách bố trí, pha trộn màu sắc của các loài hoa sẽ khiến cho gian phòng khách, nơi làm việc hay góc thư giãn của bạn tràn ngập sức sống. Đến với khóa học cắm hoa tại EZcooking bạn sẽ được nghệ nhân cắm hoa chuyên nghiệp truyền đạt các kĩ năng cắm hoa sao cho hài hòa, tinh tế và mang ý nghĩa đặc trưng riêng của mỗi loại hoa cũng như phong cách riêng của người làm nên nó. " , 1000000, "Từ 5 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,8,24,3,current_timestamp()),
(6, "Khóa học cắt tỉa cơ bản", "cat-tia-rau-cu-qua.jpg", 2, 2500000,"Việc trang trí món ăn đẹp sẽ giúp mâm cơm đủ đầy, đẹp mắt có sự hấp dẫn hơn về thị giác, giúp mọi người ăn ngon miệng hơn. Nắm được những kỹ năng cắt tỉa cơ bản bạn hoàn toàn có thể biến tấu những thực phẩm sẵn có trong nhà bếp thành những bông hoa xinh xắn. Học nấu ăn gia đình và học cắt tỉa cơ bản là giúp các chị em nội trợ có được những tuyệt chiêu song kiếm hợp bích tự tin là người phụ nữ nhiều người mơ ước." , 300000, "Từ 6 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,12,3,current_timestamp()),
(7, "Ẩm thực Nhật Bản", "mon-nhat.jpg", 4, 3000000,"Khóa học ẩm thực Nhật Bản tại EZcooking sẽ hướng dẫn bạn không chỉ cách làm các món ăn ngon, đặc trưng của đất nước Nhật Bản như Sushi, Súp, Salad... Bạn sẽ được học từ kiến thức nền tảng và biến đó thành kiến thức, kỹ năng của riêng bạn. " , 2500000, "Từ 5 - 6 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,18,3,current_timestamp()),
(7, "Lớp yêu cầu kinh doanh đặc biệt", "nau-an-thuc-hanh.jpg", 5, 5000000,"Lớp dạy các món theo yêu cầu tại EZcooking đáp ứng những bạn muốn học nấu ăn để kinh doanh, chọn món để học, chọn giờ học và hơn hết học theo yêu cầu bạn sẽ học theo hình thức gia sư - tư vấn, bạn sẽ tương tác được với giáo viên nhiều hơn trong một buổi học để nắm bắt kiến thức một cách tốt nhất." , 300000, "Từ 1 - 2 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,1,1,3,current_timestamp()),
(7, "Khóa học nấu món Âu", "món-âu.jpg", 5, 2160000,"Những món ăn Âu ngon đòi hỏi phải được chế biến công phu, kỹ lưỡng. Món Âu được chú trọng nhất ở việc chế biến các vị nước sốt, hương liệu, sắp đặt món ăn trên bàn tiệc…Vì sao bạn là người hay nấu nướng, khéo tay nhưng chưa thể làm được những món Âu ngon, đúng vị? Khóa học làm các món Âu tại Ezcooking sẽ thực sự là khóa học giúp bạn bổ dung kỹ năng nội trợ của mình" , 1550000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,7,21,3,current_timestamp()),
(7, "Khóa học nấu món Hàn Quốc", "day-nau-mon-han-quoc.jpg", 5, 3050000,"Làm sao để có thể nấu món Hàn Quốc chuẩn vị như người Hàn vào bếp không phải là điều dễ dàng. Nhận biết hương vị trong các món ăn Hàn Quốc và am hiểu về ẩm thực Hàn đòi hỏi sự tinh tế và học bài bản. Khóa học nấu món Hàn nhằm mục đích giúp bạn trở thành một người nội trợ khéo léo và là một thực khách “sành” thưởng thức món ăn Hàn Quốc tại Việt Nam" , 1850000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,18,3,current_timestamp()),
(7, "Khoá học làm Pizza mỳ Ý Pasta", "món-ý.jpg", 2, 2400000,"Khóa học làm Pizza, mỳ Ý, Pasta là khóa học nấu ăn chuyên đề dành riêng cho các bạn học viên có niềm đam mê với các món ăn châu Âu nổi tiếng, muốn tìm hiểu về văn hóa đồ ăn nhanh của phương Tây." , 750000, "Từ 5 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,6,18,2,current_timestamp()),
(7, "Khóa học các món ăn chay", "chay.jpg", 4, 3090000," Cuộc sống hiện đại, nhu cầu ăn uống đa dạng nhưng kèm theo đó là sử dụng nhiều thực phẩm không rõ nguồn gốc, sử dụng nhiều chất bảo quản gây độc hại cho con người. Học làm món chay là phương pháp giảm bớt nguy cơ mắc bệnh từ thực phẩm trong những bữa ăn hằng ngày. Đặc biệt đối với những ngươi ăn kiêng, giảm cân mắc bệnh…" , 1060000, "Từ 8 - 12 " ," tầng 5 – 142 Lê Duẩn, Hà Nội ",1,10,20,3,current_timestamp());


create table imagesCourse(
	imageID int auto_increment primary key,
    imageSource varchar(200) not null,
    courseID int not null,
    constraint foreign key(courseID) references courses(courseID)
);

insert into imagesCourse(imageSource,courseID) values
("banhkinhdoanh1.jpg",1),
("lopbeptruong1.jpg",2),
("banhngotchuyennghiep1.jpg",3),
("hocnauan1.jpg",4),
("daubeptruong1.jpg",5),
("daubepchuyennghiep1.jpg",6),

("mam-co-ngay-tet1.png",7),
("dam-toan-dien1.jpg",8),
("1.1.jpg",9),
("nauangiadinh1.jpg",10),

("trevuivaobep1.jpg",11),
("trẻ-nấu-ăn-nâng-cao1.jpg",12),
("moonkids1.jpg",13),
("s21.jpg",14),
("daytrelambanh-21.jpg",15),

("nấu-chè1.jpg",16),
("kem1.jpg",17),
("che-mua-dong1.jpg",18),
("dayamthuc1.jpg",19),
("banh-viet-nam1.jpg",20),
("banh-mi1.jpg",21),

("pha-che-co-ban1.jpg",22),
("pha-chế-chuyên-nghiệp1.jpg",23),
("pha-che-do-an1.jpg",24),

("hoc-cam-hoa-voi-nghe-nhan.jpg1.jpg",25),
("nghethuattaohinh.jpg",26),
("cat-tia-rau-cu-qua1.jpg",27),

("mon-nhat1.jpg",28),
("nau-an-thuc-hanh1.jpg",29),
("món-âu1.jpg",30),
("day-nau-mon-han-quoc1.jpg",31),
("món-ý1.jpg",32),
("chay1.jpg",33);

create table orders(
orderID int auto_increment primary key,
orderDate datetime,
staffID int,
customerID int not null,
orderStatus int not null default 1,
requireInformation varchar(500),
reasonCancel varchar(200),
canceler int,
constraint foreign key(staffID) references staffs(staffID),
constraint foreign key(customerID) references customers(customerID)
);

insert into orders(orderDate, staffID, customerID, orderStatus, reasonCancel) values
(current_timestamp(), 1, 1, -2, 'khách hàng đổi khóa học'),
(current_timestamp(), 2, 2, -2, 'khách hàng đổi khóa học'),
(current_timestamp(), 1, 3, -1, ''),
(current_timestamp(), 2, 4, -1, ''),
(current_timestamp(), 1, 1, 0, ''),
(current_timestamp(), 2, 2, 0, ''),
(current_timestamp(), 1, 3, 1, ''),
(current_timestamp(), 2, 4, 1, ''),
(current_timestamp(), 1, 2, 1, 'khách hàng đổi khóa học'),
(current_timestamp(), 1, 2, 1, 'khách hàng đổi khóa học');

create table orderDetails(
id int auto_increment primary key,
orderID int not null,
courseID int not null,
coursePrice int not null,
materialPrice int not null,
quantity int not null,
constraint foreign key(orderID) references orders(orderID),
constraint foreign key(courseID)  references courses(courseID)
);

insert into orderDetails(orderID, courseID, coursePrice, materialPrice, quantity) values
(1, 10, 350000, 500000, 1),
(2, 12, 1200000, 600000, 1),
(3, 12, 1200000, 600000, 1),
(4, 13, 3600000, 500000, 1),
(5, 13, 3600000, 500000, 1),
(6, 14, 4000000, 500000, 1),
(7, 14, 4000000, 500000, 1),
(8, 15, 6000000, 500000, 1),
(9, 15, 6000000, 500000, 1),
(10, 16, 3500000, 500000, 1);


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
('Giáo vụ', 'giaovu1@ezcooking.vn', 'giaovu1.png', '0963.938.523', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Kế toán', 'ketoan1@ezcooking.vn', 'ketoan.png', '024.3773.9943', 'Quan hệ giao thương', 'Lên thực phẩm', 'Theo dõi công nợ về học phí của học viên'),
('Marketing', 'marketing@ezcooking.vn', 'marketing.png', '0963.938.524', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Tuyển sinh', 'tuyensinh@ezcooking.vn', 'tuyensinh.png', '0963.938.525', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Hành chính - Nhân sự', 'hanhchinhnhansu@ezcooking.vn', 'hanhchinh.png', '0963.938.526', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học'),
('Tuyển dụng nghề bếp', 'tuyendungnghebep@ezcooking.vn', 'tuyendung.png', '0963.938.527', 'Quản lí thông tin học viên', 'Tổ chức, sắp xếp lịch học', 'Chuẩn bị các tài liệu cho lớp học');


