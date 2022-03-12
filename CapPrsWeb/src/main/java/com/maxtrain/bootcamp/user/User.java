package com.maxtrain.bootcamp.user;

import javax.persistence.*;

@Entity
//unique
@Table(uniqueConstraints=@UniqueConstraint(name="UIDX_code", columnNames={"userName"}))
public class User {
	
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(columnDefinition="int")
	private int Id;
	@Column(length=30, nullable=false)
	private String UserName;
	@Column(length=30, nullable=false)
	private String Password;
	@Column(length=30, nullable=false)
	private String FirstName;
	@Column(length=30, nullable=false)
	private String LastName;
	@Column(length=12, nullable=true)
	private String Phone;
	@Column(length=225, nullable=true)
	private String Email;
	private boolean IsReview;
	private boolean IsAdmin;
	
	public User () {}

	public int getId() {
		return Id;
	}

	public void setId(int id) {
		Id = id;
	}

	public String getUserName() {
		return UserName;
	}

	public void setUserName(String userName) {
		UserName = userName;
	}

	public String getPassword() {
		return Password;
	}

	public void setPassword(String password) {
		Password = password;
	}

	public String getFirstName() {
		return FirstName;
	}

	public void setFirstName(String firstName) {
		FirstName = firstName;
	}

	public String getLastName() {
		return LastName;
	}

	public void setLastName(String lastName) {
		LastName = lastName;
	}

	public String getPhone() {
		return Phone;
	}

	public void setPhone(String phone) {
		Phone = phone;
	}

	public String getEmail() {
		return Email;
	}

	public void setEmail(String email) {
		Email = email;
	}

	public boolean isIsReview() {
		return IsReview;
	}

	public void setIsReview(boolean isReview) {
		IsReview = isReview;
	}

	public boolean isIsAdmin() {
		return IsAdmin;
	}

	public void setIsAdmin(boolean isAdmin) {
		IsAdmin = isAdmin;
	}
	
	
}
