import React from "react"
import {BrowserRouter as Router, Switch, Route} from "react-router-dom";
import AdminDashboard from "./AdminDashboard";
import Login from "./Login";
import Registration from "./Registration";
import UserDashboard from "./UserDashboard";

export default function RouterPage()
{
    return(
        <Router>
            <Switch>
                <Route exact path='/' component={Login}/>
                <Route path='/registration' component={Registration}/>
                <Route path='/userdashboard' component={UserDashboard}/>
                <Route path='/admindashboard' component={AdminDashboard}/>
            </Switch>
        </Router>
    )
}