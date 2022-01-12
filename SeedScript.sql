USE InstagramClone
GO

INSERT INTO Users(Username, Email, Forename, Surname, Age, Rating)
VALUES ('mokeaveny', 'mokeav@test.co.uk', 'Michael', 'Keaveny', 21, 5.00)

INSERT INTO Users(Username, Email, Forename, Surname, Age, Rating)
VALUES ('testapi', 'testapi@gmail.co.uk', 'Magic', 'Amazing', 35, 3.82)

INSERT INTO Users(Username, Email, Forename, Surname, Age, Rating)
VALUES ('jhalpert', 'jhalpert00@dmifflin.com', 'Jim', 'Halpert', 28, 4.50)

INSERT INTO Posts(UserId, Image, Caption)
VALUES (1, 0xFFD8FFE000104A6494600001001, 'First Picture!')

INSERT INTO Posts(UserId, Image, Caption)
VALUES (2, 0xFFD8FFE000104A6494600001001, 'Placeholder For Now!')

INSERT INTO Posts(UserId, Image, Caption)
VALUES (3, 0xFFD8FFE000104A6494600001001, 'Remember To Insert Proper Values')

INSERT INTO Comments(PostId, AuthorId, Message)
VALUES(1, 3, 'Nice Post Mate!');

INSERT INTO Comments(PostId, AuthorId, Message)
VALUES(2, 1, 'Wow, I love this!');

INSERT INTO Comments(PostId, AuthorId, Message)
VALUES(3, 1, 'Amazing! Keep smashing it bro!');