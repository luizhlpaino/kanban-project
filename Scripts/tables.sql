--ADMIN DB

create table databases (
	guid uuid primary key,
	name varchar(14),
	host varchar(500)
)

create table companies (
	guid uuid primary key,
	title varchar(100),
	created_at timestamp
)

insert into databases (guid, name, host) values 
('600b354e-3a08-47dd-8eb6-5c931c7cf4de', 'kanban_alpha', 'localhost'),
('e948cb8c-3479-47ed-b412-fe7ce487b652', 'kanban_beta', 'localhost'),
('457e7900-38b9-4262-8ba6-3cc5b112978f', 'kanban_charlie', 'localhost'),
('2482ef8f-b90a-4f73-8df6-2f59f170a048', 'kanban_delta', 'localhost'),
('1833f547-9dec-4a58-b77e-576c85b96f09', 'kanban_echo', 'localhost')

insert into companies (guid, title, created_at, databaseguid) values 
('e6db93a5-c466-4e8c-8423-758455892af4', 'alpha', now(), '600b354e-3a08-47dd-8eb6-5c931c7cf4de'),
('230f2e76-6241-4e8e-b72a-75a865e6fc26', 'beta', now(), 'e948cb8c-3479-47ed-b412-fe7ce487b652'),
('c62a5c77-0e5e-4c82-92df-e5fc027e427a', 'charlie', now(), '457e7900-38b9-4262-8ba6-3cc5b112978f'),
('41b9c8ad-21e2-4cea-8e3d-8ec0795d844e', 'delta', now(), '2482ef8f-b90a-4f73-8df6-2f59f170a048'),
('a3dcb370-c8b6-455b-8567-93fd33559a56', 'echo', now(), '1833f547-9dec-4a58-b77e-576c85b96f09')

--COMPANY DB
create table boards (
	guid uuid primary key,
	title varchar(250),
	created_at timestamp
)