use Team42DB
-- User insert
INSERT INTO [Users] ([name])
VALUES ('Alice'), ('Bob'), ('Charlie'), ('John'), ('Mary');

-- Categories insert
INSERT INTO [Categories] ([name])
VALUES ('Technology'), ('Science'), ('Art'), ('Sports'), ('VideoGames');

-- Moderates insert
INSERT INTO [Moderates] ([userId], [categoryId])
VALUES (1, 1), (2, 2), (1, 2), (1, 3), (4, 1);

-- Badges insert
INSERT INTO [Badges] ([name], [description], [image])
VALUES ('Bronze', 'Achieved after 10 posts', 0xc9b6d5), -- Insert image binary data
       ('Silver', 'Achieved after 50 posts', 0xc346d5),
       ('Gold', 'Achieved after 100 posts', 0xabb6d5);

-- Owns insert
INSERT INTO [Owns] ([userId], [badgeId])
VALUES (1, 1), (2, 2), (1, 2), (1, 3), (3, 1), (3, 2);

-- Posts insert
INSERT INTO [Posts] ([userId], [content], [datePosted], [type], [title], [categoryId])
VALUES (1, 'How does quantum computing work?', GETDATE(), 'question', 'Quantum Computing', 1);

INSERT INTO [Posts] ([userId], [content], [datePosted], [type], [title])
VALUES (2, 'Quantum computing leverages quantum bits (qubits) to perform complex calculations.', GETDATE(), 'answer', NULL);

INSERT INTO [Posts] ([userId], [content], [datePosted], [type])
VALUES (3, 'Interesting topic!', GETDATE(), 'comment');

INSERT INTO [Posts] ([userId], [content], [datePosted], [type], [title], [categoryId])
VALUES (1, 'How can I improve my coding skills? Any tips or resources?', GETDATE(), 'question', 'Improving Coding Skills', 1);

INSERT INTO [Posts] ([userId], [content], [datePosted], [type], [title])
VALUES (2, 'Improving your coding skills involves consistent practice, learning from others, and exploring new technologies.', GETDATE(), 'answer', NULL);

INSERT INTO [Posts] ([userId], [content], [datePosted], [type])
VALUES (3, 'Great advice! I''ve found that collaborating on GitHub projects also helps.', GETDATE(), 'comment');

-- Replies insert
INSERT INTO [Replies] ([idOfPostRepliedOn], [idOfReply])
VALUES (1, 2), (3, 2), (4, 5), (4, 6);

-- Votes insert
INSERT INTO [Votes] ([postId], [userId], [value])
VALUES (2, 1, 1), (1, 3, 1), (2, 2, -1), (3, 1, 1);

-- Tags insert
insert into [Tags] ([name])
values ('Trees'), ('C#'), ('Quantum'), ('Python'), ('DataScience'), ('FunctionalProgramming'), ('Lisp');

-- Has insert
insert into [Has] ([questionId], [tagId]) 
values (1, 3)

-- Notifications insert
INSERT INTO [Notifications] ([userId], [postId], [badgeId])
VALUES (1, 1, NULL), (1, 4, NULL), (3, 3, NULL), (1, 4, NULL), (1, NULL, 1), (1, NULL, 2), (1, NULL, 3), (2, NULL, 2), (3, NULL, 1), (3, NULL, 2);

select * from [Users]
select * from [Posts]
select * from [Badges]
select * from [Has]
select * from [Owns]
select * from [Tags]
select * from [Categories]
select * from [Moderates]
select * from [Notifications]
select * from [Replies]
select * from [Votes]