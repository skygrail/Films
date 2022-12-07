import React, { useState } from "react";
import axios from "axios";
import lodash from "lodash";

function Registration() {

  const [name, setName] = useState('')
  const [login, setlogin] = useState('')
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [passwordRepeat, setPasswordRepeat] = useState('')

  const [nameDirty, setnameDirty] = useState(false)
  const [loginDirty, setloginDirty] = useState(false)
  const [emailDirty, setemailDirty] = useState(false)
  const [passwordDirty, setpasswordDirty] = useState(false)
  const [passwordRepeatDirty, setpasswordRepeatDirty] = useState(false)

  const [nameError, setNameError] = useState("Name can't be empty")
  const [loginError, setloginError] = useState("Login can't be empty")
  const [emailError, setEmailError] = useState("Email can't be empty")
  const [passwordError, setPasswordError] = useState("Password can't be empty")
  const [passwordRepeatError, setPasswordRepeatError] = useState("Password can't be empty")

  const url = 'http://localhost:42710/api/Authorization/Registration'
  const data =
  {
    userName: name,
    login: login,
    email: email,
    password: password
  }

  const handleSave = (e) => {
    e.preventDefault();
    console.log(name, login, email, password, passwordRepeat)

    axios.post(url, data)
      .then((result) => {
        clear();
        const dt = result.data;
        alert(dt.statusMessage);
      })
      .catch((error) => {
        console.log(error);
      })
  }

  const handleLogin = () => {
    window.location.url = "/login"
  }

  const blurHandler = (e) => {
    switch (e.target.name) {
      case 'name':
        setnameDirty(true)
        break
      case 'login':
        setloginDirty(true)
        break
      case 'email':
        setemailDirty(true)
        break
      case 'password':
        setpasswordDirty(true)
        break
      case 'passwordRep':
        setpasswordRepeatDirty(true)
        break

    }
  }

  const nameHandler = (e) => {
    setName(e.target.value)
    setNameError('')
  }

  const loginHandler = (e) => {
    setlogin(e.target.value)
    setloginError('')
  }

  const emailHandler = (e) => {
    setEmail(e.target.value)
    const re = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i;
    if (!re.test(String(e.target.value).toLowerCase())) {
      setEmailError('Invalid email!')
    }
    else {
      setEmailError('')
    }

  }

  const passwordHandler = (e) => {
    setPassword(e.target.value)
    setPasswordError('')
  }

  const passwordRepHandler = (e) => {
    setPasswordRepeat(e.target.value)

    if (lodash.isEqual(password, e.target.value)) {
      setPasswordRepeatError('')
    }
    else {
      setPasswordRepeatError('Passwords should be equals!')
    }
  }

  const clear = () => {
    setName('')
    setlogin('')
    setEmail('')
    setPassword('')
    setPasswordRepeat('')
  }

  return (
    <section class="vh-100" style={{ backgroundColor: "#eee" }}>
      <div class="container h-100">
        <div class="row d-flex justify-content-center align-items-center h-100">
          <div class="col-lg-12 col-xl-11">
            <div class="card text-black" style={{ borderRadius: "25px" }}>
              <div class="card-body p-md-5">
                <div class="row justify-content-center">

                  <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                    <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Sign up</p>

                    <form class="mx-1 mx-md-4">

                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          {(nameDirty && nameError) && <div style={{ color: 'red' }}>{nameError}</div>}
                          <input
                            type="text"
                            name="name"
                            id="form3Example1c"
                            class="form-control"
                            value={name}
                            onBlur={(e) => blurHandler(e)}
                            onChange={(e) => nameHandler(e)} required
                          />
                          <label class="form-label" for="form3Example1c">Your Name</label>
                        </div>
                      </div>

                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-login fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          {(loginDirty && loginError) && <div style={{ color: 'red' }}>{loginError}</div>}
                          <input
                            type="text"
                            name="login"
                            id="form3Example2c"
                            class="form-control"
                            onBlur={(e) => blurHandler(e)}
                            onChange={(e) => loginHandler(e)}
                            value={login}
                          />
                          <label class="form-label" for="form3Example2c">Your Login</label>
                        </div>
                      </div>

                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          {(emailDirty && emailError) && <div style={{ color: 'red' }}>{emailError}</div>}
                          <input
                            type="email"
                            name="email"
                            id="form3Example3c"
                            class="form-control"
                            onBlur={(e) => blurHandler(e)}
                            onChange={(e) => emailHandler(e)}
                            value={email}
                          />
                          <label class="form-label" for="form3Example3c">Your Email</label>
                        </div>
                      </div>

                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          {(passwordDirty && passwordError) && <div style={{ color: 'red' }}>{passwordError}</div>}
                          <input
                            type="password"
                            name="password"
                            id="form3Example4c"
                            class="form-control"
                            onBlur={(e) => blurHandler(e)}
                            onChange={(e) => passwordHandler(e)}
                            value={password}
                          />
                          <label class="form-label" for="form3Example4c">Password</label>
                        </div>
                      </div>

                      <div class="d-flex flex-row align-items-center mb-4">
                        <i class="fas fa-key fa-lg me-3 fa-fw"></i>
                        <div class="form-outline flex-fill mb-0">
                          {(passwordRepeatDirty && passwordRepeatError) && <div style={{ color: 'red' }}>{passwordRepeatError}</div>}
                          <input
                            type="password"
                            name="passwordRep"
                            id="form3Example4cd"
                            class="form-control"
                            onBlur={(e) => blurHandler(e)}
                            onChange={(e) => passwordRepHandler(e)}
                            value={passwordRepeat}
                          />
                          <label class="form-label" for="form3Example4cd">Repeat your password</label>
                        </div>
                      </div>


                      <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                        <button
                          type="button"
                          class="btn btn-primary btn-lg"
                          onClick={(e) => handleSave(e)}>Register</button>
                      </div>

                      <p class="text-center text-muted mt-5 mb-0">Have already an account? 
                      <a onClick={(e) => handleLogin(e)} href="/"
                         class="fw-bold text-body"><u>Login here</u></a></p>


                    </form>

                  </div>
                  <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

                    <img src={'https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/draw1.webp'}
                      class="img-fluid" alt="Sample" />

                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  )
}

export default Registration;