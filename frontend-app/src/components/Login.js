import React, { useState } from "react";
import axios from "axios";
import { useHistory, Link } from "react-router-dom";

function Login() {

    const [login, setlogin] = useState('')
    const [password, setPassword] = useState('')

    const [loginDirty, setloginDirty] = useState(false)
    const [passwordDirty, setpasswordDirty] = useState(false)

    const [loginError, setloginError] = useState("Login can't be empty")
    const [passwordError, setPasswordError] = useState("Password can't be empty")

    const url = 'http://localhost:42710/api/Authorization/Login'
    const data = {
        password: password,
        login: login
    }
    const history = useHistory();

    const blurHandler = (e) => {
        switch (e.target.name) {
            case 'login':
                setloginDirty(true)
                break
            case 'password':
                setpasswordDirty(true)
                break
        }
    }

    const loginHandler = (e) => {
        setlogin(e.target.value)
        setloginError('')
    }

    const passwordHandler = (e) => {
        setPassword(e.target.value)
        setPasswordError('')
    }

    const handleLogin = (e) => {
        e.preventDefault();
        axios.post(url, data)
            .then((result) => {
                const dt = result.data;
                if(dt.statusCode === 200){
                    if (login === "admin" && password === "admin"){
                        localStorage.setItem("login", login);
                        history.push("/admindashboard");
                    } else {
                        localStorage.setItem("login", login);
                        history.push("/userdashboard");
                    }
                }
                else{
                    alert(dt.statusMessage);
                }  
            })
            .catch((error) => {
                console.log(error);
            })
    }



    return (
        <section class="vh-100" style={{ backgroundColor: "#eee" }}>
            <div class="container h-100">
                <div class="row d-flex justify-content-center align-items-center h-100">
                    <div class="col-lg-12 col-xl-11">
                        <div class="card text-black" style={{ borderRadius: "25px" }}>
                            <div class="card-body p-md-5">
                                <div class="row justify-content-center">

                                    <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Login</p>
                                    <div class="container py-5 h-100">
                                        <div class="row d-flex align-items-center justify-content-center h-100">
                                            <div class="col-md-8 col-lg-7 col-xl-6">
                                                <img src={'https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg'}
                                                    class="img-fluid" alt="Phone" />
                                            </div>
                                            <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
                                                <form>
                                                    <div class="form-outline mb-4">
                                                        {(loginDirty && loginError) && <div style={{ color: 'red' }}>{loginError}</div>}
                                                        <input
                                                            type="text"
                                                            id="form1Example13"
                                                            class="form-control form-control-lg"
                                                            name="login"
                                                            onBlur={(e) => blurHandler(e)}
                                                            onChange={(e) => loginHandler(e)}
                                                            value={login}
                                                        />
                                                        <label class="form-label" for="form1Example13">Login</label>
                                                    </div>

                                                    <div class="form-outline mb-4">
                                                        {(passwordDirty && passwordError) && <div style={{ color: 'red' }}>{passwordError}</div>}
                                                        <input
                                                            type="password"
                                                            id="form1Example23"
                                                            class="form-control form-control-lg"
                                                            name="password"
                                                            onBlur={(e) => blurHandler(e)}
                                                            onChange={(e) => passwordHandler(e)}
                                                            value={password} />
                                                        <label class="form-label" for="form1Example23">Password</label>
                                                    </div>

                                                    <div class="d-flex justify-content-around align-items-center mb-4">
                                                        <a href="#!">Forgot password?</a>
                                                    </div>

                                                    <button type="submit"
                                                        class="btn btn-primary btn-lg btn-block"
                                                        onClick={(e) => handleLogin(e)}>
                                                        Sign in
                                                    </button>

                                                </form>
                                            </div>
                                        </div>
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

export default Login;