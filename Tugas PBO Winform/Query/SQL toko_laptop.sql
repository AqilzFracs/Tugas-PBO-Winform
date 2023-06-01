alter table transaksi
alter column tanggal_transaksi set default current_timestamp

select * from transaksi

CREATE TABLE IF NOT EXISTS laptop(
	id_laptop serial,
	nama_laptop varchar(128) not null,
	harga_laptop int not null,
	stok int not null,
	primary key (id_laptop)
);

CREATE TABLE IF NOT EXISTS transaksi(
	id_transaksi int not null,
	tanggal_transaksi timestamp without time zone default current_timestamp,
	status_transaksi varchar(16) not null,
	primary key (id_transaksi)
);

CREATE TABLE IF NOT EXISTS detail_transaksi(
	id_detail_transaksi serial,
	id_transaksi int not null,
	id_laptop int not null,
	stok_dibeli int not null,
	primary key (id_detail_transaksi),
	foreign key (id_transaksi) references transaksi (id_transaksi),
	foreign key (id_laptop) references laptop (id_laptop)
);