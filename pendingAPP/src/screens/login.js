import React, { Component } from 'react';
import {
    StyleSheet,
    Text,
    TouchableOpacity,
    View,
    Image,
    ImageBackground,
    TextInput,
    SafeAreaView,
} from 'react-native';

import AsyncStorage from '@react-native-async-storage/async-storage';

import api from '../services/api';


export default class Login extends Component {

    constructor(props) {
        super(props);
        this.state = {
            emailUser: 'adm@pending.com',
            passwordUser: 'adm123',
        };
    }
    realizarLogin = async () => {
        console.warn(this.state.emailUser + ' ' + this.state.passwordUser);

        try {
            const resposta = await api.post('/login/login', {
                emailUser: this.state.emailUser, //ADM@ADM.COM
                passwordUser: this.state.passwordUser, //senha123
            });

            if (resposta.status == 200) {
                console.warn
                const token = resposta.data.token;
                console.warn(token);
                await AsyncStorage.setItem('userToken', token);
                this.props.navigation.navigate('clients');
            }
        } catch (error) {
            console.warn(error)
        }
    };
    render() {

        // Text Input - Don't change
        const loginTextInput = () => {
            const [number, onChangeNumber] = React.useState(null);
        }

        return (
            <View style={styles.main}>
                <View style={styles.container_header}>
                    <View style={styles.container_header_image}>
                        <TouchableOpacity
                            onPress={() => this.props.navigation.navigate('First')}>
                            <Image source={require('../assets/Back.png')} />
                        </TouchableOpacity>

                    </View>

                    <View style={styles.container_header_image}>
                        <Image source={require('../assets/pending.png')} />
                    </View>
                </View>

                <View style={styles.container_bottom}>
                    <View style={styles.container_bottom_image}>
                        <Image source={require('../assets/welcome.png')} />
                    </View>

                    <TextInput
                        style={styles.textinput}
                        placeholder="endereço de e-mail"
                        placeholderTextColor="rgba(200,200,200,0.5)"
                        keyboardType="default"
                        secureTextEntry={false}
                        onChangeText={emailUser => this.setState({ emailUser })}
                    />

                    <TextInput
                        style={styles.textinput}
                        placeholder="Senha"
                        placeholderTextColor="rgba(200,200,200,0.5)"
                        keyboardType="default"
                        secureTextEntry={true}
                        onChangeText={passwordUser => this.setState({ passwordUser })}
                    />

                    <TouchableOpacity
                        style={styles.btnLogin}
                        onPress={() => this.props.navigation.navigate('Main')}>
                        <Text style={styles.btnLogin_text}>Entrar</Text>
                    </TouchableOpacity>
                </View>
            </View>
        );
    }
}

const styles = StyleSheet.create({
    main: {
        flex: 1,
        backgroundColor: '#242526',
    },

    textinput: {
        height: 45,
        width: 345,
        borderColor: 'white',
        borderWidth: 3,
        borderRadius: 15,
        fontSize: 18,
        paddingLeft: 10,
        marginBottom: 20,
        color: 'white',
    },

    container_bottom: {
        width: '100%',
        height: 'auto',
        alignSelf: 'center',
        alignItems: 'center',
        flex: 1,
        justifyContent: 'flex-end',
        marginBottom: 35,
    },

    container_bottom_image: {
        alignSelf: 'flex-start',
        height: 40,
        marginBottom: 10,
        marginLeft: 33,
    },

    container_header: {
        width: '100%',
        height: 'auto',
        alignSelf: 'center',
        alignItems: 'center',
        flexDirection: 'row',
        justifyContent: 'space-between',
    },

    container_header_image: {
        marginLeft: 20,
        marginRight: 20,
        height: 40,
        marginTop: 25,
    },

    btnLogin: {
        height: 55,
        width: 345,
        backgroundColor: 'white',
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
    },

    btnLogin_text: {
        fontSize: 20,
        fontWeight: 'bold',
        color: '#222222',
    }
});